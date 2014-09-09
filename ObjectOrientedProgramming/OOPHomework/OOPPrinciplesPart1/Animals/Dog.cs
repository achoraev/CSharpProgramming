namespace classAnimals
{
	using System;
	
	public class Dog:Animals, ISound
	{		
		//construktor
		public Dog (string name, int age, Sex sex)
		: base(name, age, sex)
		{
			this.Name = name;	
			this.Age = age;		
			this.Sex = sex;
		}	
		//method
		public override void MakeSound()
		{
			Console.WriteLine("Bau, Bau!!!");
		}
	}
}