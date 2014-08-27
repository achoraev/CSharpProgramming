namespace CommonType
{
	using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
		//fields
		private string firstName;		
		private string middleName;
		private string lastName;
		private int ssNumber;
		private string address;
		private string mobile;
		private string mail;
		private string course;
        public Specialty Specialty { get ; set;}
        public University University { get ; set;}
        public Faculty Faculty { get ; set;}
		//properties
        
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                this.middleName = value;
            }
        }

        public string Course
        {
            get
            {
                return this.course;
            }
            set
            {
                this.course = value;
            }
        }

        public string Mail
        {
            get
            {
                return this.mail;
            }
            set
            {
                this.mail = value;
            }
        }

        public string Mobile
        {
            get
            {
                return this.mobile;
            }
            set
            {
                this.mobile = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        public int SsNumber
        {
            get
            {
                return this.ssNumber;
            }
            set
            {
                this.ssNumber = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

		//construktor
		public Student(
		string firstName, string middleName, string lastName, int ssNumber, 
		string address, string mobile, string mail, string course, Specialty specialty, University university,
		Faculty faculty
		)
		{
			this.FirstName = firstName;
			this.MiddleName = middleName;
			this.LastName = lastName;
			this.SsNumber = ssNumber;
			this.Address = address;
			this.Mobile = mobile;
			this.Mail = mail;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;            
		}
		
        public override string ToString()
		{
			StringBuilder info = new StringBuilder();
			info.AppendLine("StudentInfo: ");  
			info.AppendLine(new String('-', 30));  
			info.AppendLine(base.ToString());
			info.AppendLine(String.Format("First Name: {0}", this.FirstName));
			info.AppendLine(String.Format("Middle Name: {0}", this.MiddleName));
			info.AppendLine(String.Format("Last Name: {0}", this.LastName));
			info.AppendLine(String.Format("Social Security Number(EGN): {0}", this.SsNumber));
			info.AppendLine(String.Format("Address: {0}", this.Address));
			info.AppendLine(String.Format("Mobile: {0}",this.Mobile));
			info.AppendLine(String.Format("E-mail: {0}",this.Mail));
			info.AppendLine(String.Format("Course: {0}",this.Course));
			info.AppendLine(String.Format("Specialty: {0}",Specialty.ComputerSystems));
			info.AppendLine(String.Format("University: {0}",University.Technical));
			info.AppendLine(String.Format("Faculty: {0}",Faculty.IT));
			info.AppendLine(new String('-', 30));  
			return info.ToString();
		}
		
		public override bool Equals(object param)
		{
			Student student = param as Student;            
			if (! Object.Equals(this.FirstName, student.FirstName))
			return false;
			if (this.SsNumber != student.SsNumber)
			return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			return this.FirstName.GetHashCode() ^ this.SsNumber.GetHashCode();
		}
		
		public static bool operator ==(Student student1, Student student2)
		{
			return student1.SsNumber == student2.SsNumber;//if not work try only SSN
		}
		
		public static bool operator !=(Student student1, Student student2)
		{
			return !(student1.FirstName == student2.FirstName && student1.SsNumber == student2.SsNumber);
		}
		//2. Add implementations of the ICloneable interface. The Clone() method should deeply 
		//copy all object's fields into a new object of type Student.
		public object Clone()
		{
            return new Student(
                this.FirstName, this.MiddleName, this.LastName, this.SsNumber, this.Address, this.Mobile, 
                this.Mail, this.Course, Specialty.ComputerSystems, University.Technical, Faculty.IT);           
		}
        //3.Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
        //and by social security number (as second criteria, in increasing order).
		public int CompareTo(Student otherStudent)
		{
            if (this.FirstName.CompareTo(otherStudent.FirstName) != 0)
			{
                return this.FirstName.CompareTo(otherStudent.FirstName);
			}
			else if (this.MiddleName.CompareTo(otherStudent.MiddleName) != 0 )
			{
				return this.MiddleName.CompareTo(otherStudent.MiddleName);
			}
			else if (this.SsNumber.CompareTo(otherStudent.SsNumber) != 0 )
			{
                return this.SsNumber.CompareTo(otherStudent.SsNumber);
			}
			return 0;
		}
    }
}