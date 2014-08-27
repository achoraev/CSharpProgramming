namespace GroupByGroupName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;    
    using ArrayOfStudents;
    // 18. Create a program that extracts all students grouped by GroupName and then prints them to the console. Use LINQ.

    public class GroupByGroupName
    {
        public class StudentWithGroup : ArrayOfStudents
        { 
            public string Group {get; set;}

            public StudentWithGroup(string FirstName, string LastName, string Group)
                : base(FirstName, LastName)
            {
                this.Group = Group;
            }        
        }

        static void GroupWithLinq()
        {
            var studentsWithLinq =
                from student in students
                group student by student.Group into newGroup
                orderby newGroup.Key
                select newGroup;

            foreach (var currentGroup in studentsWithLinq)
            {
                Console.WriteLine(currentGroup.Key);
                foreach (var student in currentGroup)
                {
                    Console.WriteLine(student.FirstName);
                }
                Console.WriteLine();
            }
        }
        // 19. Rewrite the previous using extension methods.

        static void GroupLambda()
        {
            var studentsWithLambda = students.GroupBy(x => x.Group).OrderBy(x => x.Key);
            foreach (var student in studentsWithLambda)
            {
                Console.WriteLine(student.Key);
                foreach (var item in student)
                {
                    Console.WriteLine(item.FirstName);
                }
                Console.WriteLine();
            }
        }

        static StudentWithGroup[] students;
        static void Main()
        {
            students = new StudentWithGroup[6];
            students[0] = new StudentWithGroup("Grigor", "Petrov", "C#");
            students[1] = new StudentWithGroup("Petar", "Marinov", "JavaScript");
            students[2] = new StudentWithGroup("Dobri", "Gospodinov", "JavaScript");
            students[3] = new StudentWithGroup("Anna", "Dimova", "Java");
            students[4] = new StudentWithGroup("Penka", "Stoicheva", "Java");
            students[5] = new StudentWithGroup("Anna", "Dimova", "C#");

            GroupWithLinq();
            GroupLambda();
        }
    }
}
