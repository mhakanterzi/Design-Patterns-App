using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.State
{
    public class Account
    {
        private IUserState _userState;

        public Account(IUserState initialState)
        {
            _userState = initialState;
        }

        public void SetState(IUserState state)
        {
            _userState = state;
        }

        public void ViewContent()
        {
            _userState.ViewContent();
        }

        public void ManageContent()
        {
            _userState.ManageContent();
        }

        public void NextLevel()
        {
            _userState.NextLevel(this);
        }

    }
}
