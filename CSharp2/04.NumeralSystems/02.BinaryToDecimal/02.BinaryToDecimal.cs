using System;

//02.Write a program to convert binary numbers to their decimal representation.


public class BinaryToDecimal
{
    public static string Reverser(string text) //reversing the string - string.Reverse() don't works
    {
        if (text == null) return null;
        char[] array = text.ToCharArray();
        Array.Reverse(array);
        return new String(array);        
    } 

    static int BinaryToDecimalCalc(string n)
    {
        int sum = 0;
        int twoPow = 1;         //i'am not using Math.Pow, so i need to calculate 2^i manualy

        for (int i = 0; i < n.Length; i++)
        {
            int current = (n[i] - '0');       //cool way to convert char numbers into int : int number = charNumber - '0';
            if ((current!=0)&&(current!=1))
            {
                Console.WriteLine("Invalid input data !");
                Environment.Exit(0);   //end program
            }

            sum = sum + (current * twoPow);           
            twoPow = twoPow * 2;
        }
        return sum;
    }
    static void Main()
    {
        Console.Write("02.Imput binary number : ");
        string text = Console.ReadLine();
        Console.Write("The binary representation of your number is : ");
        Console.WriteLine(BinaryToDecimalCalc(Reverser(text)));
    }
}

