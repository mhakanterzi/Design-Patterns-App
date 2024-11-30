using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.State
{
    public class RunState
    {

        public void StateRun()
        {
            Account account = new Account(new Guest());

            account.ViewContent();
            account.ManageContent();
            account.NextLevel();

            Console.WriteLine();

            account.ViewContent();
            account.ManageContent();
            account.NextLevel();

            Console.WriteLine();

            account.ViewContent();
            account.ManageContent();
            account.NextLevel();
        }
    }
}
