using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.StructuralPatternsLib.Composit
{
    public class Files : IFile
    {
        private string _name; 

        public Files(string name)
        {
            _name = name;
        }

        public void Display(string file)
        {
            Console.WriteLine($"{file}- Dosya: {_name}");
        }
    }
}
