using System;

class EmployeeRecord
{
    //10.A marketing firm wants to keep record of its employees. Each record would have the following characteristics 
    //  – first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). 
    //  Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.
    static void Main()
    {
        string firstName, familyName;
        byte age;
        char gender;
        int idNumber;
        ushort uniqueEmpNumber; // Adding this number to 27560000

        firstName = "Koko";
        familyName = "Mokov";
        age = 33;
        gender = 'm';
        idNumber = 568;
        uniqueEmpNumber = 574;

        Console.WriteLine(" Personal information about {0} {1}:\n\n First Name: {0}\n Family Name: {1}\n Age: {2}\n Gender: {3}\n ID Number: {4}\n Unique Employee Number: {5}\n", 
            firstName, familyName, age, gender, idNumber, 27560000 + uniqueEmpNumber);
    }
}