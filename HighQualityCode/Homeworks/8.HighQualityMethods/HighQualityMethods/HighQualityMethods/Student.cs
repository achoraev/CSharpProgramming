namespace Methods
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string birthDate;
        private string otherInfo;

        public Student()
        {
        }

        public Student(string first, string last)
        {
            this.FirstName = first;
            this.LastName = last;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }

        public string OtherInfo
        {
            get { return this.otherInfo; }
            set { this.otherInfo = value; }
        }

        public static bool IsOlderThan(string birthDateOfFirst, string birthDateOfSecond)
        {
            DateTime firstDate = DateTime.Parse(birthDateOfFirst);
            DateTime secondDate = DateTime.Parse(birthDateOfSecond);
            int isOlder = firstDate.CompareTo(secondDate);            
            if (isOlder > 0)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
    }
}
