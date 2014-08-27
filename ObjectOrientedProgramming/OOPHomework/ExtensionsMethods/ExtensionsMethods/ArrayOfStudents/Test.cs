namespace ArrayOfStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Test
    {
        public static IEnumerable<ArrayOfStudents> FindByName(ArrayOfStudents[] students)
        {
            var result = from student in students
                         where student.FirstName.CompareTo(student.LastName) < 0
                         select student;
            return result;
        }

        static void Main()
        {
            ArrayOfStudents[] students = new ArrayOfStudents[5];
            students[0] = new ArrayOfStudents("Svetlin", "Nakov");
            students[1] = new ArrayOfStudents("Ivailo", "Kenov");
            students[2] = new ArrayOfStudents("Nikolay", "Kostov");
            students[3] = new ArrayOfStudents("Jivko", "Petrov");
            students[4] = new ArrayOfStudents("Georgi", "Georgiev");
            
            var searchedStudents = FindByName(students);
            foreach (var item in searchedStudents)
            {
                Console.WriteLine(item);     
            }                              
        }
    }
}
