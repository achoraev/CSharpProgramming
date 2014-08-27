namespace PhonebookApplication
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Odbc;
    using System.Data.Sql;
    using System.Data.SqlTypes;
    using System.Linq;
    using System.Net.Mail;
    using System.Net.Mime;
    using System.Net.Sockets;
    using System.Text;
    using Wintellect.PowerCollections;

    public class CompareNames : IComparable<CompareNames>
    {
        private string name;

        private string nameToLower;

        private SortedSet<string> setOfStrings;

        public SortedSet<string> SetOfStrings
        {
            get
            {
                return this.setOfStrings;
            }
            set
            {
                this.setOfStrings = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
                this.nameToLower = value.ToLowerInvariant();
            }
        }

        public override string ToString()
        {
            StringBuilder numbers = new StringBuilder();
            numbers.Append('[');
            numbers.Append(this.Name);
            numbers.Append(": ");
            //bool flag = true;
            foreach (var phone in this.setOfStrings)
            {
                numbers.Append(", ");
                numbers.Append(phone);
            }

            numbers.Append(']');
            return numbers.ToString();
        }

        public int CompareTo(CompareNames other)
        {
            return this.nameToLower.CompareTo(other.nameToLower);
        }
    }
}