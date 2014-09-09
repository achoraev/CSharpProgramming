namespace StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestStudent
    {
        static void Main()
        {
            StudentClass[] students = new StudentClass[6];
            students[0] = new StudentClass("Grigor", "Petrov", "316106", "02876455", "grigor@abv.bg", new List<int> { 3, 4 }, 2);
            students[1] = new StudentClass("Petar", "Marinov", "316206", "02899123", "petar@gmail.com", new List<int> { 6, 5, 6, 6 }, 2);
            students[2] = new StudentClass("Dobri", "Gospodinov", "324806", "73654789", "dobri@abv.bg", new List<int> { 6, 5, 6 }, 4);
            students[3] = new StudentClass("Anna", "Dimova", "395103", "52999999", "anna@gmail.com", new List<int> { 6, 6 }, 2);
            students[4] = new StudentClass("Penka", "Stoicheva", "318206", "0899111111", "penka@abv.bg", new List<int> { 2, 2, 3, 3 }, 5);
            students[5] = new StudentClass("Anna", "Dimova", "395103", "52999999", "anna@gmail.com", new List<int> { 2, 2, 3, 3, 4 }, 1);
            var selectedLINQ = from student in students
                               where student.GroupNumber == 2
                               orderby student.FirstName
                               select student;
            PrintGroups(selectedLINQ);
            // 10. Implement the previous using the same query expressed with extension methods.
            var selectedLambda = students.Where(group => group.GroupNumber == 2).OrderBy(name => name.FirstName);
            PrintGroups(selectedLambda);
            // 11. Extract all students that have email in abv.bg. Use string methods and LINQ.
            var selectEmails = from student in students
                               where student.EMail.EndsWith("abv.bg")
                               select student;
            PrintGroups(selectEmails);
            // 12. Extract all students with phones in Sofia. Use LINQ.
            var selectedPhonesInSofia = from student in students
                                        where student.Telephone.StartsWith("02")
                                        select student;
            PrintGroups(selectedPhonesInSofia);
            // 13. Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – 
            //FullName and Marks. Use LINQ.
            var selectExcellentMark = from student in students
                                      where student.Marks.Contains(6)
                                      select new { FullName = student.FirstName + " " + student.LastName, Marks = (string.Join(", ",student.Marks)) };
            foreach (var student in selectExcellentMark)
            {
                Console.WriteLine("{0} {1}", student.FullName, student.Marks);
            }            
            // 14. Write down a similar program that extracts the students with exactly  two marks "2". Use extension methods.
            var studentWithTwoMarksTwo = from student in students
                                         where student.Marks.Count(m => m == 2) == 2
                                         select new { FullName = student.FirstName + " " + student.LastName, Marks = (string.Join(", ", student.Marks)) };
            Console.WriteLine();
            Console.WriteLine("Students with mark 2");            
            foreach (var student in studentWithTwoMarksTwo)
            {
                Console.WriteLine("{0} {1}", student.FullName, student.Marks);
            }
            //15. Extract all Marks of the students that enrolled in 2006. 
            //(The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            Console.WriteLine();
            var studentFrom2006 = students.Where(st => st.FacultyN.EndsWith("06"));
            PrintGroups(studentFrom2006);            
        }        

        private static void PrintGroups(IEnumerable<StudentClass> selectedLINQ)
        {
            foreach (var item in selectedLINQ)
            {
                Console.WriteLine(item);
                Console.WriteLine("---------------------------------------------");
            }
        }
    }
}
