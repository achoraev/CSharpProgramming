namespace classAnimals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;    
	// 3.Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
	//Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
	//Kittens and tomcats are cats. All animals are described by age, name and sex. 
	//Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. 
	//Create arrays of different kinds of animals and calculate the average age of each kind of animal 
	//using a static method (you may use LINQ).

	public class Test
	{		
		static void Main()
		{
			Animals firstDog = new Dog("PeshoNinja", 8, Sex.Male);			
            Console.WriteLine(firstDog);
			Cat pisence = new Kitten("Pisanka", 4);
            Console.WriteLine(pisence);
			IList<Animals> listOfAnimal = new List<Animals>();  
			listOfAnimal.Add(new Frog("Balkan", 2, Sex.Male));    
			listOfAnimal.Add(new TomCat("Tom", 1));
            listOfAnimal.Add(new Dog("Balkan", 3, Sex.Male));   
			listOfAnimal.Add(new Kitten("Stamat", 5));
            listOfAnimal.Add(new Cat("Mara", 7, Sex.Male));   
			listOfAnimal.Add(new TomCat("Tom", 12));
            listOfAnimal.Add(new Dog("Balkan", 65, Sex.Male));       
			listOfAnimal.Add(new Kitten("Stamat", 47));
            listOfAnimal.Add(new Frog("Stamat", 12, Sex.Male));    
			listOfAnimal.Add(new TomCat("Tomas", 36));
            listOfAnimal.Add(new Dog("Balkan", 15, Sex.Male));
            listOfAnimal.Add(new Cat("Sirenko", 7, Sex.Male));
            foreach (var animal in listOfAnimal)
            {
                Console.WriteLine(animal);
                animal.MakeSound();
            }

			Console.WriteLine("The average age of all animals is: {0}", Animals.AverageAge(listOfAnimal));
            var sortTomcats = listOfAnimal.OfType<TomCat>();
            foreach (var item in sortTomcats)
            {
                Console.WriteLine(item);
            }

            var sortDogs = listOfAnimal.OfType<Dog>();
            foreach (var item in sortDogs)
            {
                Console.WriteLine(item);
            }
            var averageAge = sortDogs.Average(d => d.Age);
            Console.WriteLine("Average age of dogs is: {0:F3}", averageAge);            					            
			
		}
	}
}