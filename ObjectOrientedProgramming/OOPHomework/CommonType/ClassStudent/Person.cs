namespace classStudent
{
	using System;
    using System.Text;
    //4. Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() 
    //to display the information of a person and if age is not specified – to say so. Write a program to test this functionality.

	public class Person	
	{
		//fields
		private string name;
		private int age;

        //properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
       
        public int Age
		{
			get {return this.age;}
			set 
			{
				if(value <= 0)
				{
					throw new NullReferenceException("Age not specified!!!");
				}
				this.age = value;
			}
		}
		
		//construktor
		public Person (string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}
		// override ToString
		public override string ToString()  
		{    
        StringBuilder info = new StringBuilder(); 
		info.AppendFormat("Name: {0}", this.Name);  
		info.AppendLine();   		
		if (this.Age != 0)    
        {           
			info.AppendFormat("Age: {0}", this.Age);   
		}  
		else 
		{
            info.AppendFormat("Age not specified!!!");
		}
		return info.ToString();   
		}
	}	
}