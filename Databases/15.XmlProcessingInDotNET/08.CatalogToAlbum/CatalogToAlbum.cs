namespace CatalogToAlbum
{
    using System;
    using System.Text;
    using System.Xml;

    class CatalogToAlbum
    {
        //08. Write a program, which (using XmlReader and XmlWriter) reads the file catalog.xml
        //    and creates the file album.xml, in which stores in appropriate way the names of 
        //    all albums and their authors.

        static void Main()
        {
            string fileName = "../../../08.Album.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");

            using (XmlReader reader = XmlReader.Create("../../../01.Catalog.xml"))
            {
                using (XmlTextWriter writer = new XmlTextWriter(fileName, encoding))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.IndentChar = '\t';
                    writer.Indentation = 1;

                    writer.WriteStartDocument();
                    writer.WriteStartElement("AlbumsCatalogSimplified");
                    writer.WriteAttributeString("name", "Albums catalog");

                    while (reader.Read())
                    {
                        if ((reader.NodeType == XmlNodeType.Element))
                        {
                            if (reader.Name == "name")
                            {
                                writer.WriteStartElement("album"); // opening tag <album>
                                writer.WriteElementString("name", reader.ReadElementString()); //<name>...</name>
                            }

                            if (reader.Name == "artist")
                            {
                                writer.WriteElementString("artist", reader.ReadElementString());
                                writer.WriteEndElement(); //closing tab </album>
                            }
                        }
                    }
                }
            }

            Console.WriteLine("08.Album.xml was created!");
        }
    }
}
