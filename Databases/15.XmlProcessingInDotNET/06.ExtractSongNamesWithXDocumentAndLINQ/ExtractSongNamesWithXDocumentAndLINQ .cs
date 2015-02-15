namespace ExtractSongNamesWithXDocumentAndLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class ExtractSongNamesWithXDocumentAndLINQ 
    {
        //06. Rewrite the same using XDocument and LINQ query.
        //    Write a program, which using XmlReader extracts all song titles from catalog.xml.

        static void Main()
        {
            XDocument xmlDoc = XDocument.Load("../../../01.Catalog.xml");

            var allSongs =
                from songs in xmlDoc.Descendants("title")
                select songs.Value;

            foreach (var song in allSongs)
            {
                Console.WriteLine(song);
            }
        }
    }
}
