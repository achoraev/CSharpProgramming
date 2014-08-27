namespace StudentByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    //5.Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students 
    //by first name and last name in descending order. Rewrite the same with LINQ.

    public class StudentTest
    {
        public static IEnumerable<StudentByAge> FindByAge(StudentByAge[] students)
        {
            var result = from student in students
                         where student.Age >= 18 && student.Age <= 24
                         select student;
            return result;
        }

        static void Main()
        {
            StudentByAge[] students = new StudentByAge[5];
            students[0] = new StudentByAge("Svetlin", "Nakov", 34);
            students[1] = new StudentByAge("Ivailo", "Kenov", 24);
            students[2] = new StudentByAge("Nikolay", "Kostov", 26);
            students[3] = new StudentByAge("Jivko", "Petrov", 18);
            students[4] = new StudentByAge("Georgi", "Georgiev", 23);

            var searchedStudents = FindByAge(students);
            foreach (var item in searchedStudents)
            {
                Console.WriteLine(item);
            }
            // sort descending with OrderBy and ThenBy
            Console.WriteLine("\nPrinting sorted students by name:");
            var sortedStudents = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
            // sort ascending with LINQ
            Console.WriteLine("\nPrinting sorted students with LINQ:");
            var sortedWithLINQ = from student in students
                                 orderby student.FirstName ascending, student.LastName ascending
                                 select student;
            foreach (var student in sortedWithLINQ)
            {
                Console.WriteLine(student);
            }
        }
    }
}
