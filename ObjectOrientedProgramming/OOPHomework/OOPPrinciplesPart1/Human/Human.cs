namespace classHuman
{
	using System;
    using System.Linq;
	
	public abstract class Human
	{
		//fields
        private string firstName;
		private string lastName;		
		//properties
		public string FirstName
		{
			get {return this.firstName;}
			set 
			{
			if (String.IsNullOrWhiteSpace(value))
			{
				throw new ArgumentException("You must enter something!!!");
			}
			this.firstName = value;
			}
		}		
		
		public string LastName
		{
			get {return this.lastName;}
			set 
			{
                if (String.IsNullOrWhiteSpace(value))
			{
				throw new ArgumentException("You must enter something!!!");
			}
			this.lastName = value;
			}
		}		
		//construktor
		public Human (string firstName, string lastName)
		{
			this.FirstName = firstName;	
			this.LastName = lastName;		
		}	
	}
}