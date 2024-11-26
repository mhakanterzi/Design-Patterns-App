using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.StructuralPatternsLib.Proxy
{
    public class UserService :IUsers
    {
        public void UserSystem(string username, string email, string password)
        {
            Console.WriteLine($"Succesfuly... Welcome {username}");
        }
    }
}
