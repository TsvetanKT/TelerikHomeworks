namespace ArtistExtractor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;

    class ArtistExtractor
    {
        //02.Write program that extracts all different artists which are found in the catalog.xml. 
        //  For each author you should print the number of albums in the catalogue. 
        //  Use the DOM parser and a hash-table

        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../01.Catalog.xml");
            XmlNode root= doc.DocumentElement;

            Dictionary<string, int> artists = new Dictionary<string, int>();
            foreach (XmlNode node in root.ChildNodes)
            {
                string currentArtist = node["artist"].InnerText;
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
