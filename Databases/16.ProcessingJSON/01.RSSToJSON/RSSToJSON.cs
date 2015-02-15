namespace RSSToJSON
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using CustomExtensions;
    using System.Xml.Linq;

    class RSSToJSON
    {
        //Using JSON.NET and the Telerik Academy Forums RSS feed implement the following:
        //01. The RSS feed is at http://forums.academy.telerik.com/feed/qa.rss 
        //02. Download the content of the feed programmatically
        //     You can use WebClient.DownloadFile()
        //03. Parse the XML from the feed to JSON
        //04. Using LINQ-to-JSON select all the question titles and print them to the console
        //05. Parse the JSON string to POCO
        //06. Using the parsed objects create a HTML page that lists all questions from the RSS their 
        //      categories and a link to the question's page


        private const string RssFeedUrl = @"http://forums.academy.telerik.com/feed/qa.rss";

        private const string RssFilePath = @"../../rssAsXml.xml";

        private const string JsonFilePath = @"../../rssAsJson.json";

        private const string HtmlFilePath = @"../../rssAsHtml.html";

        static void Main()
        {
            // 1.
            Console.WriteLine("Connecting to rss feed.");

            using (var webClient = new WebClient())
            {
                webClient.DownloadFile(RssFeedUrl, RssFilePath);
            }

            // 2.
            var rssAsXml = XElement.Load(RssFilePath);
            string rssAsJson = JsonConvert.SerializeXNode(rssAsXml, Newtonsoft.Json.Formatting.Indented);
            Extension.CreateFile(JsonFilePath, rssAsJson);

            // 3.
            var jsonObj = JObject.Parse(rssAsJson);
            var allTitles = jsonObj["rss"]["channel"]["item"].Select(e => e["title"]);
            Console.WriteLine(string.Join(Environment.NewLine, allTitles));

            // 4.
            var itemsAsJson = jsonObj["rss"]["channel"]["item"].ToString();
            var allItems = JsonConvert.DeserializeObject<Unit[]>(itemsAsJson);

            // 5.
            CreateHtmlPage(allItems);
        }

        private static void CreateHtmlPage(IEnumerable<Unit> units)
        {
            var htmlGenerator = new CustomHTML();
            string html = htmlGenerator.GenerateHtml(units);
            Extension.CreateFile(HtmlFilePath, html);
            Console.WriteLine("The created html page is saved to {0}.", HtmlFilePath);
        }
    }
}
