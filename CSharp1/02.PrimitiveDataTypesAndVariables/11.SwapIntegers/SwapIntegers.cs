using System;

class SwapIntegers
{
    //11.Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.
    static void Main()
    {       
        Console.WriteLine(" Swap \n");

        int x = 5;     
        int y = 10;  

        Console.WriteLine(" Before the swap x: {0} y: {1}", x, y);

        x = x ^ y; // x = 15
        y = y ^ x; // y = 5
        x = x ^ y; // x = 10

        Console.WriteLine(" After the swap x: {0} y: {1} \n", x, y);
    }
}

