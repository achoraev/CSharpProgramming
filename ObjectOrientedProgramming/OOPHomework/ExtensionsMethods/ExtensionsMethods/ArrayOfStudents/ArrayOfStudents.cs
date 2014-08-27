namespace ArrayOfStudents
{
    using System;
    using System.Text;

    public class ArrayOfStudents
    {
        //field
        private string firstName;
        private string lastName;        
        
        //properties
        public string FirstName
        {
            get {return this.firstName;}
            set
            {
                if (firstName == null)
                {
                    throw new NullReferenceException("The field must have a value.");
                }
                this.firstName = value; 
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (lastName == null)
                {
                    throw new NullReferenceException("The field must have a value.");
                }
                this.lastName = value;
            }
        }
        // construktor
        public ArrayOfStudents(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string.Format("{0}-{1}", this.FirstName, this.LastName));
            return builder.ToString();
        }
    }
}
