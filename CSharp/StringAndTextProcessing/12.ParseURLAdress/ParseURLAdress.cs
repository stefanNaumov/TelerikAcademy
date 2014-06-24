using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that parses an URL address given in the format:
//[protocol]://[server]/[resource]

//and extracts from it the [protocol], [server] and [resource] elements. 
//For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//[protocol] = "http"
//[server] = "www.devbg.org"
//[resource] = "/forum/index.php"


class ParseURLAdress
{
    static void Main()
    {
        string url = "http://www.devbg.org/forum/index.php";
        int protocolIndex = 0;
        int serverIndex = 0;
        int resourceIndex = 0;
        protocolIndex = url.IndexOf("//", protocolIndex);
        serverIndex = url.IndexOf("/", protocolIndex + 2);
        resourceIndex = serverIndex + 1;
        string[] protocol = new string[protocolIndex];
        string[] server = new string[serverIndex - protocolIndex];
        string[] resource = new string[url.Length - resourceIndex];
        for (int p = 0; p < protocolIndex; p++)
        {
            protocol[p] = url[p].ToString();
        }
        int pos = 0;
        for (int s = protocolIndex + 2; s < serverIndex; s++)
        {

            server[pos] = url[s].ToString();
            pos++;
        }
        pos = 0;
        for (int r = resourceIndex; r < url.Length; r++)
        {
            resource[pos] = url[r].ToString();
            pos++;
        }
        Console.Write("Protocol -> ");
        for (int p = 0; p < protocol.Length; p++)
        {
            Console.Write(protocol[p]);
        }
        Console.WriteLine();
        Console.Write("Server -> ");
        for (int s = 0; s < server.Length; s++)
        {
            Console.Write(server[s]);
        }
        Console.WriteLine();
        Console.Write("Resource -> ");
        for (int r = 0; r < resource.Length; r++)
        {
            Console.Write(resource[r]);
        }
        Console.WriteLine();
    }
}

