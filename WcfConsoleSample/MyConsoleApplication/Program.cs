using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost serviceHost = null;
            try
            {
                //Base Address for StudentService
                Uri httpBaseAddress = new Uri("http://localhost:4443/MyAwesomeService");
                
                //Instantiate ServiceHost
                serviceHost = new ServiceHost(typeof(MyService.AwesomeService));
 
                
                //Open
                serviceHost.Open();
                Console.WriteLine("Service is live now at : {0}", httpBaseAddress);
                Console.ReadKey();                
            }

            catch (Exception ex)
            {
                serviceHost = null;
                Console.WriteLine("There is an issue with AwesomeSer" + ex.Message);
            }
        }
    }
}
