using System;

class HelloWorldObj
{
    //07.Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and 
    //  assign it with the concatenation of the first two variables (mind adding an interval). Declare a third 
    //  string variable and initialize it with the value of the object variable (you should perform type casting).
    static void Main()
    {
        string word1 = "Hello";
        string word2 = "World";

        object greeting = word1 + " " + word2;
        string castedGreeting = (string)greeting;

        Console.WriteLine(" Printing all variables:\n\n String word 1 = {0}\n String word 2 = {1}\n Object greeting = {2}\n String casted Greeting = {3} \n",
            word1, word2, greeting, castedGreeting);
    }
}
