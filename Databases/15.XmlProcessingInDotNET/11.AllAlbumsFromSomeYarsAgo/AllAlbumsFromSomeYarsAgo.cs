namespace AllAlbumsFromSomeYarsAgo
{
    using System;
    using System.Xml;

    class AllAlbumsFromSomeYarsAgo
    {
        //11. Write a program, which extract from the file catalog.xml the prices for all albums, 
        //    published 5 years ago or earlier. Use XPath query.

        static void Main()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../../01.Catalog.xml");
            string xPathQuery = "/catalog/album";

            int yearsAgo = 1; // to show some results
            XmlNodeList albums = xmlDoc.SelectNodes(xPathQuery);

            foreach (XmlNode album in albums)
            {
                int currentYear = int.Parse(album.SelectSingleNode("year").InnerText);
                if (currentYear < DateTime.Now.Year - yearsAgo)
                {
                    Console.WriteLine("{0} costs {1}", album.SelectSingleNode("name").InnerText, album.SelectSingleNode("price").InnerText);
                }
            }
        }
    }
}
