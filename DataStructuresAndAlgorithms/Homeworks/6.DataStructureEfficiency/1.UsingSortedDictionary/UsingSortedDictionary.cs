// 1.A text file students.txt holds information about students and their courses in the following format:
// Kiril  | Ivanov   | C#
// Stefka | Nikolova | SQL
// Stela  | Mineva   | Java
// Milena | Petrova  | C#
// Ivan   | Grigorov | C#
// Ivan   | Kolev    | SQL
// Using SortedDictionary<K,T> print the courses in alphabetical order and for each of them prints the students ordered by family and then by name:
// C#: Ivan Grigorov, Kiril Ivanov, Milena Petrova
// Java: Stela Mineva
// SQL: Ivan Kolev, Stefka Nikolova
namespace UsingSortedDictionary
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class UsingSortedDictionary
    {
        public static void Main()
        {
            var studentsCourses = new SortedDictionary<string, List<Student>>();

            foreach (string line in File.ReadLines("../.../students.txt"))
            {                
                var inputData = line.Split('|').Select(s => s.Trim()).ToArray();
                var firtsName = inputData[0];
                var lastName = inputData[1];
                var course = inputData[2];

                List<Student> students;
                if (!studentsCourses.TryGetValue(course, out students))
                {                    
                    students = new List<Student>();
                    studentsCourses.Add(course, students);
                }

                var student = new Student() { FirstName = firtsName, LastName = lastName };
                students.Add(student);
            }

            foreach (var course in studentsCourses)
            {
                Console.WriteLine(
                    "{0}: {1}",
                    course.Key,                    
                    string.Join(", ", course.Value.OrderBy(s => s.LastName).ThenBy(s => s.FirstName)));
            }
        }

        private struct Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            
            public override string ToString()
            {
                return this.FirstName + " " + this.LastName;
            }
        }
    }
}