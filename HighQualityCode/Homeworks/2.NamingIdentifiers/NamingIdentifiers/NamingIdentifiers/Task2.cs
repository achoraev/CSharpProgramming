public class CheckSex
{
    public enum SexOfPerson 
    { 
        male, female
    }

    public void CheckSexOfPerson(int numberOfList)
    {
        Person createPerson = new Person();
        createPerson.Age = numberOfList;
        if (numberOfList % 2 == 0)
        {
            createPerson.Name = "Stoian";
            createPerson.Sex = SexOfPerson.male;
        }
        else
        {
            createPerson.Name = "Nadejda";
            createPerson.Sex = SexOfPerson.female;
        }
    }

    public class Person
    {
        public SexOfPerson Sex { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}