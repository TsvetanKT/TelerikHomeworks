using System;

class AddTenYearsToYourAge
{
    //12.* Write a program to read your age from the console and print how old you will be after 10 years.
    static void Main() 
    {      
        Console.Write("My age now is: ");
        int Age = int.Parse(Console.ReadLine());
        Age += 10;
        Console.WriteLine("My age after ten years will be: " + Age);
    }
}