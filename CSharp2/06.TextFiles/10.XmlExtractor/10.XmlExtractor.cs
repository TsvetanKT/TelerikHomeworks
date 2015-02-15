using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/*10.Write a program that extracts from given XML file all the text without the tags. Example:
 * <?xml version="1.0"><student><name>Pesho</name>
 * <age>21</age><interests count="3"><interest> 
 * Games</instrest><interest>C#</instrest><interest> 
 * Java</instrest></interests></student> 
 */
class XmlExtractor
{
    static void Main() 
    {
        StreamReader read = new StreamReader(@"..\..\..\TextFiles\Input10.xml"); //path to my the file -in the folder TextFiles in the solution
        List<string> text = new List<string>();
        using (read)
        {           
            bool openTag = false;
            string line = read.ReadLine();
            string currentText = "";
            while (line != null)
            {
                for (int i = 0; i < line.Length; i++)
                {

                    if (line[i] == '>')
                    {
                        openTag = true;
                        continue;
                    }
                    if (line[i] == '<')                  // only when '<' appears, curentText is added to the list, and after that,
                    {                                    //   currentText is set to defout value of ""
                        openTag = false;
                        if (currentText != "")  
                        {
                            text.Add(currentText);
                            currentText = "";
                        }
                    }

                    if (openTag == true)  // after we met '>' and  have not met any '<' yet  , openTag = true
                    {
                        currentText = currentText + line[i]; // adding the current char (line[i]) to the current text 
                    }
                }
                line = read.ReadLine();
            }
        }

        Console.WriteLine("10.Extracted text: \n");
        foreach (string element in text)
        {
            Console.WriteLine(element);
        }
    }
}

