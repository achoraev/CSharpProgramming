using System;
using System.Net;
//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and 
//stores it the current directory. Find in Google how to download files in C#. 
//Be sure to catch all exceptions and to free any used resources in the finally block

class DownloadFile
{
    static void Main()
    {
        string path = "http://www.devbg.org/img/Logo-BASD.jpg";
        string filename = "D://Logo-BASD.jpg"; // check folder to find file
        try
        {
            using (WebClient Client = new WebClient())
            {
                Client.DownloadFile(path, filename);
            }
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("File not found or is empty!!!");
        }
        catch (WebException)
        {
            Console.WriteLine("URL address is invalid!!!");
        }
        catch (Exception)
        {
            Console.WriteLine("An error occurred while downloading data!!!");
        }        
    }
}