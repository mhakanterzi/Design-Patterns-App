using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.StructuralPatternsLib.Proxy
{
    public class UserProxy : IUsers
    {
        private UserService _userService = new UserService();

        private readonly string validUsername = "Hakan";
        private readonly string validEmail = "trz.hakanterzi@gmail.com";
        private readonly string validPassword = "Hakan5353";

        public void UserSystem(string username, string email, string pasword)
        {
            if (username == "Hakan" && email == "trz.hakanterzi@gmail.com" && pasword == "Hakan5353")
            {
                Console.WriteLine("Authentication Succesfuly.");
                _userService.UserSystem(username, email, pasword);
            }
            else
            {
                Console.WriteLine("Authentication Failed! Try Again...");
            }
        }
    }
}
