using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WCFWithAjaxHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WCFWithAjax.WCFWithAjaxService)))
            {
                host.Open();
                Console.WriteLine("Service Started @ {0}", DateTime.Now.ToString());
                Console.ReadKey();
            }
        }
    }
}
