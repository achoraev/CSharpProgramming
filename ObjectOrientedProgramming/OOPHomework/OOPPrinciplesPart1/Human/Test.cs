namespace classHuman
{
	using System;
    using System.Collections.Generic;
    using System.Linq;
	//Define abstract class Human with first name and last name. Define new class Student 
	//which is derived from Human and has new field – grade. Define class Worker derived from Human 
	//with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns 
	//money earned by hour by the worker. Define the proper constructors and properties for
	//this hierarchy. Initialize a list of 10 students and sort them by grade in ascending order 
	//(use LINQ or OrderBy() extension method). 
	//Initialize a list of 10 workers and sort them by money per hour in descending order. 
	//Merge the lists and sort them by first name and last name.

	public class Test
	{
		static void Main()
		{
            IList<Student> students = new List<Student>();
			students.Add(new Student("Zakero", "Tabayashi", 5));
			students.Add(new Student("Atanas", "Atanasov", 2));
			students.Add(new Student("Viktor", "Georgiev", 2));
			students.Add(new Student("Krustio", "Piskov", 4));
			students.Add(new Student("Svetlin", "Stanchev", 2));
			students.Add(new Student("Boyan", "Krastev", 5));
			students.Add(new Student("Yurii", "Seizmov", 4));
			students.Add(new Student("Nikolay", "Georgiev", 3));
			students.Add(new Student("Joro", "Ivanov", 5));
			students.Add(new Student("Cvetan", "Asenov", 3));

            IList<Worker> workers = new List<Worker>();
			workers.Add(new Worker("John", "Stanford", 354, 16));
			workers.Add(new Worker("Stann", "Lee", 834, 24));
			workers.Add(new Worker("George", "Martin", 568, 6));
			workers.Add(new Worker("Charles", "Dickens", 355, 12));
			workers.Add(new Worker("Athanas", "Menethil", 324, 12));
			workers.Add(new Worker("Math", "LeBlanc", 123, 2));
			workers.Add(new Worker("Al", "Capone", 548, 5));
			workers.Add(new Worker("Al", "Pacino", 436, 10));
			workers.Add(new Worker("Malfurion", "StormRage", 565, 10));
			workers.Add(new Worker("Illidan", "StormRage", 670, 9));

				// todo test and sort
            var sortedStudents = students.OrderBy(st => st.Grade);
            Console.WriteLine("Students sorted by grade: ");
            Console.WriteLine();
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine(new String('-', 25));
            Console.WriteLine("Workers sorted by moneyPerHour: ");
            Console.WriteLine();
            var sortedWorkers = workers.OrderByDescending(w => w.MoneyPerHour());
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine(new String('-', 25));
            List<Human> merged = new List<Human>();
            merged.AddRange(students);
            merged.AddRange(workers);
            var finalList = merged.OrderBy(n => n.FirstName).ThenBy(l => l.LastName);
            Console.WriteLine("Final sort by first name:");
            Console.WriteLine();
            foreach (var item in finalList)
            {
                Console.WriteLine(item);
            }
		
		
		}
	}
}