using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.State
{
    public class Guest : IUserState
    {
        public void ViewContent()
        {
            Console.WriteLine("Guest Can only see public content.");
        }

        public void ManageContent()
        {
            Console.WriteLine("Guest can't manage content.");
        }

        public void NextLevel(Account account)
        {
            Console.WriteLine("Next Level is User");
            account.SetState(new User());
        }
    }
}
