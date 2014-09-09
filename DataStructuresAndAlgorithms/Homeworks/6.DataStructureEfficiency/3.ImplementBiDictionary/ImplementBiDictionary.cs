// 3.Implement a class BiDictionary<K1,K2,T> that allows adding triples {key1, key2, value} and fast search by key1, key2 or by both key1 and key2.
// Note: multiple values can be stored for given key.
namespace ImplementBiDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ImplementBiDictionary
    {
        public static void Main()
        {
            var bdict = new BiDictionary<string, int, Person>();

            var people = new[]
        {
            new Person() { Name = "Peter", Age = 20, Town = "Sofia" },
            new Person() { Name = "Peter", Age = 20, Town = "Varna" },
            new Person() { Name = "Peter", Age = 25, Town = "Varna" },
            new Person() { Name = "Billy", Age = 20, Town = "Sofia" },
        };

            AddToDictionary(bdict, people);

            PrintDictionary(bdict);

            Console.WriteLine("All people named Peter: {0}", string.Join(", ", bdict.GetByK1("Peter")));
            Console.WriteLine("All people at age 20: {0}", string.Join(", ", bdict.GetByK2(20)));
            Console.WriteLine("All people at age 20, named Peter: {0}", string.Join(", ", bdict.GetByBoth("Peter", 20)));
        }

        private static void PrintDictionary(BiDictionary<string, int, Person> bdict)
        {
            Console.WriteLine("All people in the BiDictionary:");
            foreach (var triple in bdict)
            {
                Console.WriteLine(string.Join(Environment.NewLine, triple.Item3));
            }
        }

        private static void AddToDictionary(BiDictionary<string, int, Person> bdict, Person[] people)
        {
            foreach (var person in people)
            {
                bdict.Add(person.Name, person.Age, person);
            }
        }

        private struct Person
        {
            public string Name;
            public int Age;
            public string Town;

            public override string ToString()
            {
                return string.Format("{{{0,-5}, {1}, {2}}}", this.Name, this.Age, this.Town);
            }
        }
    }
}