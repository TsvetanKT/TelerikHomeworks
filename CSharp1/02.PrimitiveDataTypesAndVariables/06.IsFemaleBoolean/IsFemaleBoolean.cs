using System;

class IsFemaleBoolean
{
    //06.Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.
    static void Main()
    {        
        bool isFemale;
        Console.WriteLine("Please enter your gender (male/female):");
        string enterGender = Console.ReadLine();

        if (enterGender == "female")
        {
            isFemale = true;
        }
        else
        {
            isFemale = false;
        }

        Console.WriteLine(new string('_', 50));
        Console.WriteLine(" Are you female? -> {0}.\n", isFemale);
    }
}
