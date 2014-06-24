using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _12.DownloadFromURL
{
    class DownloadURL
    {
        static void Main()
        {
            string url = "http://www.facebook.com/photo.php?fbid=4617524079414&set=a.4066181816202.2146756.1331971991&type=1&theater";
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            UrlDownload(url, name);

        }
        static void UrlDownload(string path, string name)
        {
            string fullAdress = path + name;
            WebClient wc = new WebClient();
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            wc.DownloadFile(path, name);
        }
    }
}
