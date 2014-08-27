namespace classHuman
{
	using System;
	
	public class Worker: Human
	{
		//fields
        private uint weekSalary;
		private uint workHourPerDay;
		//properties
		public uint WeekSalary
		{
			get {return this.weekSalary;}
			set 
			{
                if (value == 0)
			{
				throw new ArgumentException("You must enter number!!!");
			}
			this.weekSalary = value;
			}
		}		
		
		public uint WorkHourPerDay
		{
            get { return this.workHourPerDay; }
			set 
			{
                if (value == 0)
			{
				throw new ArgumentException("You must enter number!!!");
			}
			this.workHourPerDay = value;
			}
		}	
		//construktor
		public Worker (string firstName, string lastName, uint weekSalary, uint workHourPerDay)
		:base(firstName,lastName)
		{
			this.FirstName = firstName;	
			this.LastName = lastName;	
			this.WeekSalary = weekSalary;
			this.WorkHourPerDay = workHourPerDay;
		}	
		//methods
		public uint MoneyPerHour()
		{
			return WeekSalary/WorkHourPerDay*5;
		}
		
		public override string ToString() 
		{
            return String.Format("{0} {1} - {2} - {3}", this.FirstName, this.LastName, this.WeekSalary, this.WorkHourPerDay);  
		}		
	}
}