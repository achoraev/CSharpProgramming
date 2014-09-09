namespace PhonebookApplication
{
    using System;
    using System.Data;
    using System.Data.Odbc;
    using System.Data.Sql;
    using System.Data.SqlTypes;
    using System.Collections.Generic;
    using System.Net.Mail;
    using System.Net.Sockets;
    using System.Net.Mime;
    using System.Linq;
    using System.Text;
    using Wintellect.PowerCollections;

    public class PhonebookRepository : IPhonebookRepository
    {
        private OrderedSet<CompareNames> sortedNumbers = new OrderedSet<CompareNames>();
        private Dictionary<string, CompareNames> dict = new Dictionary<string, CompareNames>();
        private MultiDictionary<string, CompareNames> multidict = new MultiDictionary<string, CompareNames>(false);

        public bool AddPhone(string name, IEnumerable<string> numbers)
        {
            string nameAsLower = name.ToLowerInvariant();
            CompareNames entry;
            bool flag = !this.dict.TryGetValue(nameAsLower, out entry);
            if (flag)
            {
                entry = new CompareNames();
                entry.Name = name;
                entry.SetOfStrings = new SortedSet<string>();
                this.dict.Add(nameAsLower, entry);
                this.sortedNumbers.Add(entry);
            }
            foreach (var num in numbers)
            {
                this.multidict.Add(num, entry);
            }
            entry.SetOfStrings.UnionWith(numbers);
            return flag;
        }

        public int ChangePhone(string oldNumber, string newNumber)
        {
            var numbers = this.multidict[oldNumber].ToList();
            foreach (var entry in numbers)
            {
                entry.SetOfStrings.Remove(oldNumber);
                this.multidict.Remove(oldNumber, entry);
                entry.SetOfStrings.Add(newNumber);
                this.multidict.Add(newNumber, entry);
            }
            return numbers.Count;
        }
        public CompareNames[] ListEntries(int first, int num)
        {
            if (first < 0 || first + num > this.dict.Count)
            {
                throw new ArgumentException("Invalid range");
            }
            CompareNames[] list = new CompareNames[num];

            for (int i = first; i <= first + num - 1; i++)
            {
                CompareNames entry = this.sortedNumbers[i];
                list[i - first] = entry;
            }
            return list;
        }
    }
}