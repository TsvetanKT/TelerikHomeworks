using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

//04.Write a program that downloads a file from Internet 
//   (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
//   Find in Google how to download files in C#. Be sure to catch all exceptions 
//   and to free any used resources in the finally block.

class InternetDownloader
{
    static void Main()
    {
        using (WebClient webClient = new WebClient())
        {
            try
            {
                webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "../../logo.jpg");
            }

            catch (WebException we)
            {
                Console.Error.WriteLine("The address is invalid. " + we.Message);
            }

            catch (NotSupportedException)
            {
                Console.Error.WriteLine("The method has been called simultaneously on multiple threads.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You entered an empty address.");
            }
        }
        Console.WriteLine("04.Ready!");
    }
}