using System;
using System.IO;
using System.Net;

namespace HTML_ScraperPro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Global Variable Declarations
            string Scraper_Killer = "Press any key to exit...";
            string HTML_Error = "The HTML webpage was unable to be downloaded successfully.";

            try
            {
                //Main Code Which Shall Execute During .NET Runtime
                Console.WriteLine("Welcome To HTML Scraper Pro!");
                Console.WriteLine(@"NOTICE: The HTML text file will be downloaded to your C:\ directory.");
                Console.Write("Please specify the HTML webpage URL to download: http://");
                WebClient client = new WebClient();
                string userValue = Console.ReadLine();
                string startup = "http://";
                string webpage = (userValue);
                string reply = client.DownloadString(startup + webpage);
                string directory = @"C:\HTML_Scrape.txt";
                Console.WriteLine(reply);
                Console.WriteLine();
                Console.WriteLine("Webpage: {0}{1} HTML code was successfully saved to:", startup, webpage);
                Console.WriteLine(directory);
                Console.WriteLine(Scraper_Killer);
                File.WriteAllText(directory, reply);
            }

            catch (ArgumentException ex)
            {
                //Handling for exception of a given argument in the event of a ArgumentException.
                Console.Clear();
                Console.WriteLine("Uh-Oh! Sorry, an ArgumentException occured in the process.");
                Console.WriteLine();
                Console.WriteLine(HTML_Error);
                Console.WriteLine();
                Console.WriteLine("In other words, whatever you did or didn't type simply didn't work.");
                Console.WriteLine();
                Console.WriteLine("Exception Message: " + ex.Message + "  Sucks4U!");
                Console.WriteLine();
                Console.WriteLine(Scraper_Killer);
            }

            catch (WebException ex)
            {
                //Exception handling for unexpected WebExceptions during runtime.
                Console.Clear();
                Console.WriteLine("Uh-Oh! Sorry, a WebException occured in the process.");
                Console.WriteLine();
                Console.WriteLine(HTML_Error);
                Console.WriteLine();
                Console.WriteLine("The link you inserted could not be located or was formatted incorrectly.");
                Console.WriteLine();
                Console.WriteLine("Exception Message: " + ex.Message + "  Sucks4U!");
                Console.WriteLine();
                Console.WriteLine(Scraper_Killer);
            }

            catch (DirectoryNotFoundException ex)
            {
                //Exception thrown during the event of the specified directory MIA.
                Console.Clear();
                Console.WriteLine("Uh-Oh! Sorry, a DirectoryNotFoundException occured in the process.");
                Console.WriteLine();
                Console.WriteLine(HTML_Error);
                Console.WriteLine();
                Console.WriteLine("The C:\\ directory was unable to be detected.");
                Console.WriteLine();
                Console.WriteLine("Exception Message: " + ex.Message + "  Sucks4U!");
                Console.WriteLine();
                Console.WriteLine(Scraper_Killer);
            }

            catch (NotSupportedException ex)
            {
                //Exception thrown during the event of an unsupported Web Type.
                Console.Clear();
                Console.WriteLine("Uh-Oh! Sorry, a NotSupportedException occured in the process.");
                Console.WriteLine();
                Console.WriteLine(HTML_Error);
                Console.WriteLine();
                Console.WriteLine("The link you inserted is that of an unsupported type.");
                Console.WriteLine();
                Console.WriteLine("Exception Message: " + ex.Message + "  Sucks4U!");
                Console.WriteLine();
                Console.WriteLine(Scraper_Killer);
            }

            catch (Exception ex)
            {
                //Exception handling for any other random problems users shall cause.
                Console.Clear();
                Console.WriteLine("Uh-Oh! Sorry, an error exception occured in the process.");
                Console.WriteLine();
                Console.WriteLine(HTML_Error);
                Console.WriteLine();
                Console.WriteLine("Exception Message: " + ex.Message + "  Sucks4U!");
                Console.WriteLine();
                Console.WriteLine(Scraper_Killer);
            }
            Console.ReadKey();
        }
    }
}
