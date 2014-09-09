namespace StudentClass
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    //9. Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>), GroupNumber. 
    //Create a List<Student> with sample students. Select only the students that are from group number 2. Use LINQ query.
    //Order the students by FirstName.

    public class StudentClass
    {
        //field
        private string firstName;
        private string lastName;
        private string facultyN;
        private string telephone;
        private string eMail;
        private List<int> marks;
        private int groupNumber;

        //properties
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value == null)
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
                if (value == null)
                {
                    throw new NullReferenceException("The field must have a value.");
                }
                this.lastName = value;
            }
        }

        public string EMail
        {
            get { return this.eMail; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("The field must have a value.");
                }
                this.eMail = value;
            }
        }

        public string FacultyN
        {
            get { return this.facultyN; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("The field must have a value.");
                }
                this.facultyN = value;
            }
        }

        public string Telephone
        {
            get { return this.telephone; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("The field must have a value.");
                }
                this.telephone = value;
            }
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new NullReferenceException("The field must have a positive value.");
                }
                this.groupNumber = value;
            }
        }

        public List<int> Marks
        {
            get { return this.marks; }
            set
            {
                if (marks.Count == 0)
                {
                    throw new NullReferenceException("Marks is Empty!!!");
                }
                this.marks = value;
            }
        }
        // construktors
        public StudentClass()
        { 
        }
        
        public StudentClass(string firstName, string lastName, string facultyN, string telephone, string eMail, List<int> marks, int groupNumber)
            : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyN = facultyN;
            this.Telephone = telephone;
            this.EMail = eMail;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Name: {0} {1}", this.FirstName, this.LastName);
            result.AppendLine();
            result.AppendLine("FN: " + this.FacultyN);
            result.AppendLine("Tel: " + this.Telephone);
            result.AppendLine("Email: " + this.EMail);
            result.AppendLine("Marks: " + string.Join(", ", this.marks));
            result.Append("Group number: " + this.GroupNumber);

            return result.ToString();
        }
    }
}
