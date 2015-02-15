namespace XSLTtoXMLApplyer
{
    using System;
    using System.Xml.Xsl;

    class XSLTtoXMLApplyer
    {
        //14. Write a C# program to apply the XSLT stylesheet transformation on 
        //    the file catalog.xml using the class XslTransform.

        static void Main()
        {
            XslCompiledTransform xslt =
                new XslCompiledTransform();
            xslt.Load("../../../13.Catalog.xslt");
            xslt.Transform("../../../01.Catalog.xml", "../../../14.CatalogWithStyle.html");
            Console.WriteLine("Successfully transformed!");
        }
    }
}
