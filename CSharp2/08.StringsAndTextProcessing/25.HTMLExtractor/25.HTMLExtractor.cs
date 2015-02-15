using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

//25.Write a program that extracts from given HTML file its title (if available),
//   and its body text without the HTML tags. Example:
//
//   <html>
//    <head><title>News</title></head>
//    <body><p><a href="http://academy.telerik.com">Telerik
//      Academy</a>aims to provide free real-world practical
//      training for young people who want to turn into
//      skillful .NET software engineers.</p></body>
//   </html>

class HTMLExtractor
{
    static void Main()
    {
        Console.WriteLine("25.Original text:");
        string input = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn into skillful .NET software engineers.</p></body></html>";
        Console.WriteLine(input);

        Console.WriteLine();
        Console.WriteLine("Extracted text:");
        foreach (Match text in Regex.Matches(input, "(?<=>).*?(?=<)"))
        {
            if (!String.IsNullOrWhiteSpace(text.Value)) // Print all but white spaces.
            {
                Console.WriteLine(text);
            }
        }
    }
}
