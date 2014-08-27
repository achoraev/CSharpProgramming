namespace classAnimals
{
	using System;
	
	public class Kitten:Cat, ISound
	{		
		//construktor
		public Kitten (string name, int age)
		: base(name, age)
		{
			this.Name = name;	
			this.Age = age;
            this.Sex = Sex.Female;
		}			
	}
}