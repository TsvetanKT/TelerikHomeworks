using System;
using System.Text;
using System.Text.RegularExpressions;

//05.You are given a text. Write a program that changes the text in all regions surrounded by 
//   the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example:
//    We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//   The expected result:
//    We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.


class UppercaseInTags
{
    static void Main()
    {
        Console.WriteLine("05.Original text :");
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine(text);
        Console.WriteLine();
        Console.WriteLine("Converted text:");
        Console.WriteLine(Regex.Replace(text, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper()));
    }
}