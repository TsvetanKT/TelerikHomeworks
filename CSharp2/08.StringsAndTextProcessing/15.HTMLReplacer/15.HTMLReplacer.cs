using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//15.Write a program that replaces in a HTML document given as string all the tags 
//   <a href="…">…</a> with corresponding tags [URL=…]…/URL]. Sample HTML fragment:
//
//   <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose 
//   a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss 
//   the courses.</p>
//
//   <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training
//   course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>


class HTMLReplacer 
{
    static void Main()
    {
        string[] searchedTags = { "<a href=\"", "\">", "</a>" }; 
        string[] replacingTags = { "[URL=", "]", "[/URL]" };

        //Using @ cuz of /
        string htmlText = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

        Console.WriteLine("15.Original HTML document:\n"+htmlText);
        for (int i = 0; i < searchedTags.Length; i++)
        {
            htmlText = htmlText.Replace(searchedTags[i], replacingTags[i]);
        }
        Console.WriteLine();
        Console.WriteLine("HTML document with replaced tags:\n" + htmlText);
    }
}