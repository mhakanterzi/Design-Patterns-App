using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.State
{
    public class Admin : IUserState
    {
        public void ViewContent()
        {
            Console.WriteLine("Admin can see all content.");
        }

        public void ManageContent()
        {
            Console.WriteLine("Admin can manage all content.");
        }

        public void NextLevel(Account account)
        {
            Console.WriteLine("The highest level.");
        }
    }
}
