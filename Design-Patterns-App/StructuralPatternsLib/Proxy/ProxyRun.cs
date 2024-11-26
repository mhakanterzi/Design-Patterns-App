using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.StructuralPatternsLib.Proxy
{
    public class ProxyRun
    {
        public void ProxyStart()
        {
            IUsers proxy = new UserProxy();

            Console.WriteLine("Attempting successful login:");
            proxy.UserSystem("Hakan", "trz.hakanterzi@gmail.com", "Hakan5353");

            Console.WriteLine();

            Console.WriteLine("Attempting failed login:");
            proxy.UserSystem("name", "asd@asd.com", "password.");
        }
    }
}
