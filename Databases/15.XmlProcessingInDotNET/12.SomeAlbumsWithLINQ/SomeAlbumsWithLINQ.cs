namespace SomeAlbumsWithLINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    class SomeAlbumsWithLINQ
    {
        //12. Write a program, which extract from the file catalog.xml the prices for 
        //    all albums, published 5 years ago or earlier. Use LINQ query.

        static void Main()
        {
            XDocument xmlDoc = XDocument.Load("../../../01.Catalog.xml");
            int yearsAgo = 1; // to show some results

            var oldAlbums =
            (from album in xmlDoc.Descendants("album")
             where int.Parse(album.Element("year").Value) < (DateTime.Now.Year - yearsAgo)
                select album).ToList();

            foreach (var album in oldAlbums)
            {
                Console.WriteLine("{0} costs {1}", album.Element("name").Value, album.Element("price").Value);
            } 
        }
    }
}
