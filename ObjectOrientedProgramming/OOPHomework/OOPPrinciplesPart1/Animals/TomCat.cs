namespace classAnimals
{
	using System;
	
	public class TomCat:Cat, ISound
	{		
		//construktor
		public TomCat (string name, int age)
		: base(name, age)
		{
			this.Name = name;	
			this.Age = age;		
			this.Sex = Sex.Male;
		}			
	}
}