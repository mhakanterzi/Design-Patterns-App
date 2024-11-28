using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Design_Patterns_App.BehavioralPatternsLib.Command
{
    public class Control
    {
        private readonly Stack<ICommand> _commands = new ();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commands.Push(command);
        }

        public void UndoCommand()
        {
            if (_commands.Count > 0)
            {
                ICommand command = _commands.Pop();
                command.Undo();
            }
            else
            {
                Console.WriteLine("No Commands To Undo...");
            }
        }
    }
}
