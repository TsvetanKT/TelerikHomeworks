namespace DeleteWithDOMParser
{
    using System;
    using System.Xml;

    class DeleteWithDOMParser
    {
        //04. Using the DOM parser write a program to delete from catalog.xml all albums having price > 20.

        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../01.Catalog.xml");
            XmlNode rootNode = doc.DocumentElement;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                double currentPrice = double.Parse(node["price"].InnerText.Trim());
                if (currentPrice > 20)
                {
                    rootNode.RemoveChild(node);
                }
            }

            doc.Save("../../../04.ClearedCatalog.xml");
            Console.WriteLine("Done");
        }
    }
}
