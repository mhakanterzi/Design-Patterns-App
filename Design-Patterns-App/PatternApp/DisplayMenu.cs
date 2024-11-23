using Design_Pattern.PatternLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Pattern.PatternLib;
using Design_Pattern.PatternApp;
using System.Runtime.Intrinsics.Arm;
using Design_Patterns_App.PatternLib;

namespace Design_Pattern.PatternApp
{
    public class DisplayMenu
    {
        public void SingletonMenu()
        {
            Console.Clear();
            Console.WriteLine("Singleton: Bir sınıfın yanlızca tek örneğinin olması ve o sınıfa küresel erişim sağlayan bir patterndir.\n\n");
            Console.WriteLine("Singleton Pattern Örneği\n");
            Console.WriteLine("Burada iki adet değeri aynı değere atamaya çalışıyoruz. İlk gelen değer atanıyor. Ve Bu sayede tüm çıktılar aynı oluyor.");
            Console.WriteLine("GetInstance sınıfını artık nereye çağırırsak 'First Instance' çıktısını alırız.\n");

            // Attempting to create two Singleton instances
            var instance1 = Singleton.GetInstance("Birinci Instance");
            var instance2 = Singleton.GetInstance("İkinci Instance");

            // Checking if both instances are the same
            Console.WriteLine($" instance1 ve instance2 aynı mı? {ReferenceEquals(instance1, instance2)}");

            // Display the value stored in the singleton instance
            Console.WriteLine($"Instance1 Value: {instance1.Value}");
            Console.WriteLine($"Instance2 Value: {instance2.Value}");

            Console.WriteLine("\nÇıkmak için herhangi bir tuşa basınız...");
            Console.ReadKey();
            var program = new Program();
            program.CreationalPatterns();
        }

        public void FactoryMethodMenu()
        {
            Console.Clear();
            Console.WriteLine("Factory Method: bu yöntem ile üst sınıfa bağlı alt sınıflarda nesneler oluşturulur. Üst sınıf arayüzü sağlar.\n\n");

            // User selects a car type
            Console.WriteLine("Enter way type (Airway, Seaway, Roadway):");
            string wayType = Console.ReadLine();

            try
            {
                // Create the car object using the factory
                FactoryMethodBase car = FactoryMethod.CreateWay(wayType);

                // Display the car details
                car.DisplayDetails();
            }
            catch (ArgumentException ex)
            {
                // Handle invalid input
                Console.WriteLine(ex.Message);
            }


        Console.WriteLine("\nÇıkmak için herhangi bir tuşa basınız...");
            Console.ReadKey();
            var program = new Program();
            program.CreationalPatterns();
        }
    }
}
