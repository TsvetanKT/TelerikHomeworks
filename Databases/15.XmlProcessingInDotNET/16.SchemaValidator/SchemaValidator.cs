namespace SchemaValidator
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    class SchemaValidator
    {
        //16. Using Visual Studio generate an XSD schema for the file catalog.xml. Write a C# 
        //    program that takes an XML file and an XSD file (schema) and validates the XML 
        //    file against the schema. Test it with valid XML catalogs and invalid XML catalogs.

        static void Main()
        {
            XmlSchemaSet schemas = new XmlSchemaSet();

            schemas.Add("", "../../16.Catalog.xsd");

            XDocument doc = XDocument.Load("../../../01.Catalog.xml");

            Validator(schemas, doc);

            Console.WriteLine("Trying invalid catalog now:");

            XDocument docInvalid = XDocument.Load("../../../01.Catalog - INVALID.xml");

            Validator(schemas, docInvalid);

        }

        public static void Validator(XmlSchemaSet schemas, XDocument doc)
        {
            string msg = String.Empty;

            doc.Validate(schemas, (o, e) =>
            {
                msg = e.Message;
            });

            Console.WriteLine(msg == "" ? "Document is valid!" : "Document is invalid: " + msg);
        }
    }
}
