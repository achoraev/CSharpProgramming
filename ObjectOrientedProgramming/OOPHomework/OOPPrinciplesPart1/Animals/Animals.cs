namespace classAnimals
{
	using System;
	using System.Collections.Generic;

    public enum Sex
    {
        Male,
        Female
    }
	public class Animals
	{
		
		// fields
		private string name;
		private int age;
		private Sex sex;		
		// properties
		public string Name
		{
			get {return this.name;}
			set 
			{
			if (value.Length <= 0)
			{
				throw new ArgumentException("Name is too short!!!");
			}
			this.name = value;
			}
		}		
		
		public int Age
		{
			get {return this.age;}
			set 
			{
			if (value <= 0)
			{
				throw new ArgumentException("Age must be not negative or zero!!!");
			}
			this.age = value;
			}
		}

        public Sex Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }				
		//construktor
        public Animals(string name, int age)
        {
            this.Name = name;
            this.Age = age;            
        }	

        public Animals (string name, int age, Sex sex)
		{
			this.Name = name;	
			this.Age = age;
            this.Sex = sex;
		}	
		//methods
		public virtual void MakeSound()
		{
			Console.WriteLine("I am an animal!!!");
		}
		
		public override string ToString()    
		{       
		return String.Format("{0} - {1} {2} {3}", this.GetType().Name, this.Name, this.Age, this.Sex);   
		}
		
		public static int AverageAge(IList<Animals> listOfAnimal)
		{
			int averageSum = 0;  
			for (int i = 0; i < listOfAnimal.Count; i++)  
			{      
			averageSum += listOfAnimal[i].Age;    
			}         
			return averageSum / listOfAnimal.Count;
		}
	}
}