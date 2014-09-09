namespace classAnimals
{
	using System;
	
	public class Cat:Animals, ISound
	{		
		//construktor
        public Cat(string name, int age)
            : base(name, age)
        {
            this.Name = name;
            this.Age = age;            
        }	

        public Cat (string name, int age, Sex sex)
		: base(name, age, sex)
		{
			this.Name = name;	
			this.Age = age;		
			this.Sex = sex;
		}	
		//method
		public override void MakeSound()
		{
			Console.WriteLine("Miau, Miau!!!");
		}
	}
}