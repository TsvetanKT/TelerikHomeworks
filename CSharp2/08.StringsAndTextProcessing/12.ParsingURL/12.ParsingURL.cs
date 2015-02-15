using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

//12.Write a program that parses an URL address given in the format:
//   [protocol]://[server]/[resource]
//   and extracts from it the [protocol], [server] and [resource] elements. For example from the 
//   URL http://www.devbg.org/forum/index.php the following information should be extracted:
//		[protocol] = "http"
//		[server] = "www.devbg.org"
//		[resource] = "/forum/index.php"

class ParsingURL
{
    static void Main()
    {
        string url = "http://www.devbg.org/forum/index.php";
        var fragments = Regex.Match(url, "(.*)://(.*?)(/.*)").Groups;
        Console.WriteLine("12.Inspecting URL: "+url);
        Console.WriteLine("[protocol] = " + fragments[1]);
        Console.WriteLine("[server] = " + fragments[2]);
        Console.WriteLine("[resource] = " + fragments[3]);
    }
}

