using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.State
{
    public class User : IUserState
    {
        public void ViewContent()
        {
            Console.WriteLine("User can only see public content and private content.");
        }

        public void ManageContent()
        {
            Console.WriteLine("User can manage your own content.");
        }

        public void NextLevel(Account  account)
        {
            Console.WriteLine("Next Level is Admin");
            account.SetState(new Admin());
        }
    }
}
