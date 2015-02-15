using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

//18.Write a program for extracting all email addresses from given text. 
//   All substrings that match the format <identifier>@<host>…<domain> 
//   should be recognized as emails.

class EmailExtractor
{
    static void Main()
    {
        Console.WriteLine("18.Original text:");
        string input =
@"Please contact us by phone (+359 222 222 222) or
by email at exa_mple@abv.bg or at baj.ivan@yahoo.co.uk 
This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
        Console.WriteLine(input);
        Console.WriteLine();
        string[] splitted = input.Split(' ');

        Console.WriteLine("Valid Emails:");
        for (int i = 0; i < splitted.Length; i++)
        {
            if (Regex.IsMatch(splitted[i], @"[\w., \-]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}"))
            {
                Console.WriteLine(splitted[i]);
            }
        }
        Console.WriteLine();
    }
}
