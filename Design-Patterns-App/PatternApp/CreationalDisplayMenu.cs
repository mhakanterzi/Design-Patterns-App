using Design_Pattern.CreationalPatternsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Pattern.PatternApp;
using System.Runtime.Intrinsics.Arm;
using Design_Patterns_App.CreationalPatternsLib.FactoryMethod;
using Design_Patterns_App.CreationalPatternsLib.AbstractFactory;
using Design_Patterns_App.CreationalPatternsLib.Builder;
using Design_Patterns_App.CreationalPatternsLib.Prototype;


namespace Design_Pattern.PatternApp
{
    public class CreationalDisplayMenu
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

         
            Console.WriteLine("Kargonun nasıl gideceğini yazınız (Havayolu, Karayolu, Denizyolu):");
            string wayType = Console.ReadLine();

            FactoryMethodBase factory = FactoryMethod.CreateWay(wayType);

            factory.DisplayDetails();

            Console.WriteLine("\nÇıkmak için herhangi bir tuşa basınız...");
            Console.ReadKey();
            var program = new Program();
            program.CreationalPatterns();
        }

        public void AbstractFactoryMenu()
        {
            Console.Clear();
            Console.WriteLine("Abstract Factory: Bu yöntem factory methoda benziyor. Bu yöntemde somut sınıflarını belirtmeden ilişkili aile nesneleri oluşturmamıza yarıyor.\n\n");

            AbstractFactoryInterface select;
            Console.WriteLine("1-Oyun Modu\n2-Çalışma Modu");
            int mode =int.Parse(Console.ReadLine());

            if (mode == 1)
            {
                select = new GameMode();
            }
            else 
            {
                select = new WorkMode();
            }

            var lighting = select.CreateLighting();
            var volume = select.CreateVolume();

            lighting.SetLighting();
            volume.SetVolume();

            Console.WriteLine("\nÇıkmak için herhangi bir tuşa basınız...");
            Console.ReadKey();

            var program = new Program();
            program.CreationalPatterns();
        }

        public void Builder()
        {
            var program = new Program();
            Console.Clear();
            Console.WriteLine("Builder: Bu yöntem inşaat mantığıyla çalışır. Bir nesne oluşturmak için adım adım ilerlenir.\n\n");

            Console.WriteLine("Araç Modeli Giriniz(SUV,Spor)");
            string carType = Console.ReadLine();

            CarInterface builder;

            if (carType.Equals("Spor", StringComparison.OrdinalIgnoreCase))
            {
                builder = new SporCarBuilder();
            }
            else if(carType.Equals("SUV", StringComparison.OrdinalIgnoreCase))
            {
                builder = new SUVBuilder();
            }
            else
            {
                Console.WriteLine("Geçerli Bir Model Giriniz");
                Console.ReadKey();
                program.CreationalPatterns();
                return;
            }

            CarBuilder director = new CarBuilder(builder);
            Car car = director.Construct();

            Console.WriteLine("\nSeçtiğiniz Araç:");
            car.ShowDetail();

            Console.ReadKey();
            program.CreationalPatterns();
        }

        public void Prototype()
        {
            Console.Clear();
            Console.WriteLine("Prorotype: Bu yöntem nesneleri klonlamamızı sağlıyor. Büyük ve karmaşık nesneleri tekrar tekrar oluşturmak yerine bu pattern ile klonlayabiliyoruz.\n\n");

            Console.WriteLine("Aşağıda Biri orijinal diğeri orjinal araçtan klonlanmış başka bir araç\n");

            Prototype originalCar = new Prototype("Porche", "Beyaz", 2);
            Console.WriteLine("Orjinal Araç:");
            originalCar.ShowDetails();

            Prototype clonedCar = (Prototype)originalCar.GetClone();
            Console.WriteLine("\nKlonlanmış Araç:");
            clonedCar.ShowDetails();

            Console.ReadKey();
            Program program = new Program();
            program.CreationalPatterns();
        }
    }
}
