using System;

class DataTypes
{
    //01.Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, 
    //  short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
    static void Main()
    {
        ushort var1 = 52130;
        sbyte var2 = -115;
        int var3 = 4825932; 
        byte var4 = 97;
        short var5 = -10000; 

        Console.WriteLine(" Printing the variables: {0} ; {1} ; {2} ; {3} ; {4}\n", var1, var2, var3, var4, var5);
        bool koko = ((5/3)==(4/3));
        Console.WriteLine(koko);
        double a = 1.0f;
        double b = 0.33f;
        double sum = 1.33f;
        bool equal = (a + b == sum); // False!!!
        Console.WriteLine("a + b = {0}\nsum = {1}\nequal = {2}", a + b, sum, equal);

        char symbol = 'a';
        Console.WriteLine("The code of '{0}' is: {1}", symbol, (int)symbol);      
    }
}
