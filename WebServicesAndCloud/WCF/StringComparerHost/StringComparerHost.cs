using StringComparer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace StringComparerHost
{
    class StringComparerHost
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:5044";
            ServiceHost serviceHost = new ServiceHost(typeof(StringComparerService), new Uri(url));

            var behavior = new ServiceMetadataBehavior();
            behavior.HttpGetEnabled = true;

            serviceHost.Description.Behaviors.Add(behavior);
            serviceHost.Open();
            Console.WriteLine("Service started");

            Console.ReadKey();
        }
    }
}
