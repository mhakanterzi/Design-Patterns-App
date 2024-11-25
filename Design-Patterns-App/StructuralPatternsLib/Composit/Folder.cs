using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.StructuralPatternsLib.Composit
{
    public class Folder : IFile
    {
        private string _name; // Klasörün adı
        private List<IFile> _items = new List<IFile>(); // Klasör içindeki öğeler (dosya/klasör)

        public Folder(string name)
        {
            _name = name;
        }

        public void AddItem(IFile item)
        {
            _items.Add(item);
        }

        public void RemoveItem(IFile item)
        {
            _items.Remove(item);
        }

        public void Display(string file)
        {
            // Önce klasör ismini yazdırır
            Console.WriteLine($"{file}+ Klasör: {_name}");

            foreach (var item in _items)
            {
                item.Display(file + "   ");
            }
        }
    }
}
