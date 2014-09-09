namespace School
{
    using System;

    public class Test
    {
        static void Main()
        {
            Teacher firstTeacher = new Teacher("Ivailo Kenov");
            Teacher secondTeacher = new Teacher("Georgi Georgiev");
            Student newStudent = new Student("Nikolay Kostov", 578855);
            ClassesOfStudents JavaClass = new ClassesOfStudents();
            JavaClass.AddTeacher(firstTeacher);            
            JavaClass.AddTeacher(secondTeacher);
            JavaClass.AddStudent(newStudent);

            Console.WriteLine("List of teachers: ");
            foreach (People teacher in JavaClass.Teachers)
            {
                Console.WriteLine(teacher);
            }

            Console.WriteLine("\nList all Students: ");
            foreach (People student in JavaClass.Students)
            {
                Console.WriteLine(student);
            }
        }
    }
}