namespace TextToXML
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Linq;

    class TextToXML
    {
        //07. In a text file we are given the name, address and phone number of given person 
        //    (each at a single line). Write a program, which creates new XML document, 
        //    which contains these data in structured XML format.

        static void Main()
        {
            string filePath = "../../../07.TextToXML.txt";
            List<string> personInfo = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    personInfo.Add(line);
                }
            }

            XElement catalogXml = new XElement("catalog",
                new XElement("person",
                new XElement("name", personInfo[0]),
                new XElement("address", personInfo[1]),
                new XElement("phoneNumber", personInfo[2])
                )
            );

            catalogXml.Save("../../../07.Person.xml");
            Console.WriteLine("07.Person.xml was created!");
        }
    }
}
