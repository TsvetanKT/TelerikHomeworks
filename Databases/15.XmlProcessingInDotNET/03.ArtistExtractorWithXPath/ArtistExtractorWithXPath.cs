namespace ArtistExtractorWithXPath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;

    class ArtistExtractorWithXPath
    {
        //03. Implement using XPath:
        //  Write program that extracts all different artists which are found in the catalog.xml. 
        //  For each author you should print the number of albums in the catalogue. 
        //  Use the DOM parser and a hash-table

        static void Main()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../01.Catalog.xml");

            string xPathQuery = "/catalog/album";
            Dictionary<string, int> artists = new Dictionary<string, int>();

            XmlNodeList artistsList = xmlDoc.SelectNodes(xPathQuery);

            foreach (XmlNode artist in artistsList)
            {
                string currentArtist = artist.SelectSingleNode("artist").InnerText;
                if (artists.Keys.Contains(currentArtist))
                {
                    artists[currentArtist]++;
                }
                else
                {
                    artists.Add(currentArtist, 1);
                }
            }

            foreach (var artist in artists)
            {
                Console.WriteLine("Artist: {0} -> Albums: {1}", artist.Key, artist.Value);
            } 
        }
    }
}
