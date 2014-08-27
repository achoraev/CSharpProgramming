namespace classHuman
{
	using System;
	
	public class Student: Human
	{
		//field
        private int grade;						
		//property
		public int Grade
		{
			get {return this.grade;}
			set 
			{
                if (value == 0)
			{
				throw new ArgumentException("You must enter something!!!");
			}
			this.grade = value;
			}
		}		
		//construktor
		public Student (string firstName, string lastName, int grade)
		:base(firstName, lastName)
		{
			this.FirstName = firstName;	
			this.LastName = lastName;	
			this.Grade = grade;
		}
        //methods
		public override string ToString() 
		{    
		return String.Format("{0} {1} - {2}", this.FirstName, this.LastName, this.Grade);  
		}		
	}
}