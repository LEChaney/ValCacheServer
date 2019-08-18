using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Description;
using System.ServiceModel;
using ValCacheServerLib;

namespace ValCacheServerHost
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a ServiceHost instance.
            using (ServiceHost host = new ServiceHost(typeof(FileServerService)))
            {
                // Start the service.
                host.Open();
                Console.WriteLine("The service is ready.");

                // Close the ServiceHost to stop the service.
                Console.WriteLine("Press <Enter> to terminate the service.");
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
