using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQPC_HW_02
{
    class RenameBadIdentifiers
    {
        const int MAX_COUNT = 6;
        public class UselessPrinter
        {
            public void PrintingBoolToString(bool boolVariable)
            {
                string boolAsString = boolVariable.ToString();
                Console.WriteLine(boolAsString);
            }
        }
        public static void Main()
        {
            UselessPrinter testUselessPrinter = new UselessPrinter();
            testUselessPrinter.PrintingBoolToString(true);
        }
    }
}