using System;

class CompanyInformation
{
    static void Main()
    {
        Console.WriteLine("03.A company has name, address, phone number, fax number, web site and manager.");
        Console.WriteLine("The manager has first name, last name, age and a phone number.");
        Console.WriteLine("Write a program that reads the information about a company and its manager ");
        Console.WriteLine("and prints them on the console.");
        Console.WriteLine();
        Console.WriteLine(" Please fill the company details below");
        Console.Write(" Name of the company: ");
        string companyName = Console.ReadLine();
        Console.Write(" Address: ");
        string companyAddress = Console.ReadLine();
        Console.Write(" Phone number: ");
        string companyPhone = Console.ReadLine();
        Console.Write(" Fax: ");
        string companyFax = Console.ReadLine();
        Console.Write(" Website: ");
        string companyWebsite = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine(" Please fill the manager details below");
        Console.Write(" First name: ");
        string firstName = Console.ReadLine();
        Console.Write(" Last name: ");
        string lastName = Console.ReadLine();
        Console.Write(" Age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write(" Phone number: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine();

        String horrizontal = new String('-', 30);
        Console.WriteLine(horrizontal);
        Console.WriteLine("{0,20}", "Company Details");
        Console.WriteLine(" Name: {0}\n Address: {1}\n Phone number: {2}\n Fax: {3}\n Website: {4}",
            companyName, companyAddress, companyPhone, companyFax, companyWebsite);
        Console.WriteLine(horrizontal);
        Console.WriteLine();
        Console.WriteLine("{0,20}", "Manger");
        Console.WriteLine(" Name: {0}\n Age: {1}\n Phone number: {2}", firstName + " " + lastName, age, managerPhone);
        Console.WriteLine(horrizontal);
        Console.WriteLine();
    }
}

