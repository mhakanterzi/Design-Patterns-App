using Design_Pattern.PatternLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Pattern.PatternLib;
using Design_Pattern.PatternApp;

namespace Design_Pattern.PatternApp
{
    public class DisplayMenu
    {
        public void SingletonMenu()
        {
            Console.Clear();
            Console.WriteLine("Singleton Pattern Örneği\n");
            Console.WriteLine("Burada iki adet değeri aynı değere atamaya çalışıyoruz. İlk gelen değer atanıyor. Ve Bu sayede tüm çıktılar aynı oluyor.");
            Console.WriteLine("GetInstance sınıfını artık nereye çağırırsak 'First Instance' çıktısını alırız.");

            // Attempting to create two Singleton instances
            var instance1 = Singleton.GetInstance("First Instance");
            var instance2 = Singleton.GetInstance("Second Instance");

            // Checking if both instances are the same
            Console.WriteLine($"Are instance1 and instance2 the same? {ReferenceEquals(instance1, instance2)}");

            // Display the value stored in the singleton instance
            Console.WriteLine($"Instance1 Value: {instance1.Value}");
            Console.WriteLine($"Instance2 Value: {instance2.Value}");

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
            var program = new Program();
            program.CreationalPatterns();
        }
    }
}
