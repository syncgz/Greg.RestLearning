using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Greg.RestLearning.Service;

namespace Greg.RestLearning.Hoster
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(RestFeedService1));

            host.Open();

            Console.WriteLine("Service is running ...");

            Console.Read();
        }
    }
}
