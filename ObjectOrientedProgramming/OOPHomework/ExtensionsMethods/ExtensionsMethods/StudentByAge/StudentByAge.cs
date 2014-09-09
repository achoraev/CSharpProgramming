namespace StudentByAge
{
    using System;
    using ArrayOfStudents;
    using System.Text;
    //4.Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

    public class StudentByAge : ArrayOfStudents // inheritance ArrayOfStudent
    {
        private int age;

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public StudentByAge(string FirstName, string lastName, int age)
            :base (FirstName, lastName)
        {  
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string.Format("{0} {1} {2} years old", this.FirstName, this.LastName, this.Age));
            return builder.ToString();
        }
    }
}
