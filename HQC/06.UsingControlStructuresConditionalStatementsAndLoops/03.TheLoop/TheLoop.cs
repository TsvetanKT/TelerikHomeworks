namespace TheLoop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RefactorLoop
    {
        public static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30, 77 };
            int expectedValue = 30;
            bool isFound = false;
            int len = array.Length;
            int divider = 10;

            // replacing the magic number 666 with bool value
            for (int i = 0; i < len; i++)
            {
                Console.Write(array[i] + " ");
                if (i % divider == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        isFound = true;
                        break;
                    }
                }
            }

            Console.WriteLine();

            if (isFound)
            {
                Console.WriteLine("Value <<" + expectedValue + ">> is found");
            }
            else
            {
                Console.WriteLine("Value <<" + expectedValue + ">> is Not found");
            }
        }
    }
}
