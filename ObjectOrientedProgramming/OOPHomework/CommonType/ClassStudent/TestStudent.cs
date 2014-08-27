namespace CommonType
{
    using System;
    using System.Collections.Generic;

    public class TestStudent
    {
        public static void Main()
        {
            Student Unufri = new Student("Unufri ", "Nikolov ", "Ivanov ", 14155687, "Sofia Mladost 5", "08888756555", "asddd@abv.bg", "0088795", Specialty.ComputerSystems, University.FMI, Faculty.IT);
            Student Pesho = new Student("Petar ", "Nikolov ", "Ivanov ", 15587952, "Vraca 234", "0877888888", "hjfjf@gmail.com", "35687", Specialty.ComputerSystems,
            University.FMI, Faculty.IT);
            Console.WriteLine(Pesho);
            Student Stamat = new Student("Stamat", "Todorov", "Spiridonov", 87556555, "Varna 54", "0878555666", "stamat@abv.bg", "04897487", Specialty.ComputerSystems,
                University.FMI, Faculty.IT);

            Console.WriteLine("Student Comparison");
            Console.WriteLine(Unufri != Pesho);
            Console.WriteLine(Unufri == Pesho);
            Console.WriteLine(Unufri.Equals(Pesho));

            var peshoClone = Unufri.Clone();
            Console.WriteLine("\nPrinting Pesho Clone:");
            Console.WriteLine(peshoClone);


            // We are able to sort the student list because of the implementation of IComparable Interface!
            Console.WriteLine("\n\nSorting and Foreaching student List");
            List<Student> students = new List<Student>();

            students.Add(Pesho);
            students.Add(Unufri);
            students.Add(Stamat);

            students.Sort();
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}