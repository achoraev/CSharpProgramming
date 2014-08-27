namespace classAnimals
{
	using System;
	
	public class Frog:Animals, ISound
	{		
		//construktor
		public Frog (string name, int age, Sex sex)
		: base(name, age, sex)
		{
			this.Name = name;	
			this.Age = age;		
			this.Sex = sex;
		}	
		//method
		public override void MakeSound()
		{
			Console.WriteLine("Kvak, Kvak!!!");
		}
	}
}