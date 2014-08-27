using System;

class CompanyManager
{
    static void Main()
    {
        Console.WriteLine("Enter Company Name:");
        string companyName = (Console.ReadLine());
        Console.WriteLine("Enter Address:");
        string companyAddress = (Console.ReadLine());
        Console.WriteLine("Enter Phone Number:");
        string companyNumber = Console.ReadLine();
        int number;
        int.TryParse(companyNumber, out number);
        Console.WriteLine("Enter Fax Number:");
        string companyFaxNumber = Console.ReadLine();
        int faxNumber;
        int.TryParse(companyFaxNumber, out faxNumber);
        Console.WriteLine("WebSite:");
        string webSite = (Console.ReadLine());
        Console.WriteLine("Manager:");
        string companyManager = (Console.ReadLine());
        Console.WriteLine("Manager's First Name:");
        string firstName = (Console.ReadLine());
        Console.WriteLine("Manager's Last Name:");
        string lastName = (Console.ReadLine());
        Console.WriteLine("Age:");
        string age = Console.ReadLine();
        int age2;
        int.TryParse(age, out age2);
        Console.WriteLine("Manager's Phone Number:");
        string managerNumber = Console.ReadLine();
        int manNumber;
        int.TryParse(managerNumber, out manNumber);
        Console.WriteLine(
        " Company: {0} \n Address: {1} \n Phone: {2} \n Fax: {3}\n WebSite: {4} \n Manager: {5}",
        companyName, companyAddress, companyNumber, companyFaxNumber, webSite, companyManager);
        Console.WriteLine(
        " Manager's First Name: {0} \n LastName: {1} \n Age: {2} \n Phone: {3}"
        , firstName, lastName, age, managerNumber);
    }
}