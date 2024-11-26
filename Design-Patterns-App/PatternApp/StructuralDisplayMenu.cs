using Design_Patterns_App.StructuralPatternsLib.Adapter;
using Design_Patterns_App.StructuralPatternsLib.Bridge;
using Design_Patterns_App.StructuralPatternsLib.Composit;
using Design_Patterns_App.StructuralPatternsLib.Decorator;
using Design_Patterns_App.StructuralPatternsLib.Facade;
using Design_Patterns_App.StructuralPatternsLib.FlyWeight;
using Design_Patterns_App.StructuralPatternsLib.Proxy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.PatternApp
{
    public class StructuralDisplayMenu
    {
        public void AdapterMenu()
        {
            Console.Clear();
            Console.WriteLine("Adapter: Bu yöntem birbirinden uyumsuz iki arayüzü birbirine bağlamaya yarayan patterndir.\n\n");

            Console.WriteLine("Burada girilen dolar miktarını Tl ye çeviriyoruz.");

            Console.WriteLine("Dolar Miktarını Gİriniz:");
            double usdValue ;
            while (!double.TryParse(Console.ReadLine(), out usdValue))
            {
                Console.WriteLine("Geçerli bir sayı giriniz.");
            }

            USD usd = new USD(usdValue);

            double exchange =  30;

            InterfaceTL currancyTL = new Adapter(usd, exchange);
            Console.WriteLine($"Döviz değeri TL olarak: {currancyTL.GetTL():0.00} TL");


            Console.WriteLine("Çıkmak için herhangi bir uşa basınız...");
            Console.ReadKey();
            var program = new Program();
            program.StructuralPatterns();
        }

        public void BridgeMenu()
        {
            Console.Clear ();
            Console.WriteLine("Bridge: Bu yöntemde büyük sınıfları veya bağlantılı sınıfları birbirinden bağımsız şekilde geliştirmemizi sağlar.\n\n");

            Console.WriteLine("burada renkleri ve şekilleri ayrı sınıflarda tanımlayıp sonradan birleştirdik. Bu sayede geliştirme aşamaları daha rahat yapılabilir");

            IColor red = new ColorRed();
            IColor green = new ColorGreen();
            IColor blue = new ColorBlue();

            Shape circle = new Circle(red);
            Shape square = new Square(green);
            Shape circle2 = new Circle(blue);

            // Draw shapes
            circle.Draw();
            square.Draw();
            circle2.Draw();


            Console.ReadKey ();
            var program = new Program();
            program.StructuralPatterns();
        }

        public void CompositMenu()
        {
            Console.Clear ();
            Console.WriteLine("Composite: Bu yapı nesneleri ağaç yapısında düzenlemeye ve tek bir nesne gibi işlem yapmamızı sağlar.");

            Files file1 = new Files("Belge1.txt");
            Files file2 = new Files("Resim1.png");
            Files file3 = new Files("Sunum.pptx");
            Files file4 = new Files("Notlar.docx");

            Folder folder1 = new Folder("İş");
            Folder folder2 = new Folder("Projeler");
            Folder rootFolder = new Folder("Ana Klasör");

            folder1.AddItem(file1);
            folder1.AddItem(file2);
            folder2.AddItem(file3);

            rootFolder.AddItem(folder1);
            rootFolder.AddItem(folder2);
            rootFolder.AddItem(file4);

            rootFolder.Display("");

            Console.ReadKey();

            var program = new Program();
            program.StructuralPatterns();
        }

        public void DecoratorMenu()
        {
            Console.Clear();
            Console.WriteLine("Decorator: Bu yapı nesnelere yeni özellikler eklememizi sağlar. Bu yöntem sayesinde istediğimiz nesneye rahatça yeni davranışlar ekleyip çıkartabiliriz.\n\n");

            IGame game = new AC();
            Console.WriteLine($"{game.GetName()} : Normal Package ->{game.GetCost()} $");

            game = new SkinsDLC(game);
            Console.WriteLine($"{game.GetName()} : Gold Package -> {game.GetCost()} $");

            game = new MapDLC(game);
            Console.WriteLine($"{game.GetName()} : Platinum Package -> {game.GetCost()} $");

            Console.ReadKey ();
            var program = new Program();
            program.StructuralPatterns();
        }

        public void FacadeMenu()
        {
            Console.Clear ();
            Console.WriteLine("Facade: Bu yöntem kodları sadeleştirmeye yarıyor. Kodun alt sınıflarını gizler. Tüm nesneleri tek tek başlatmanın zor olacağından tek kısımda başlatılır.\n\n");

            FacadeStart launch = new FacadeStart();

            launch.StartsPc();

            Console.ReadKey();
            var program = new Program();
            program.StructuralPatterns();
        }

        public void FlyWeightMenu()
        {
            Console.Clear();
            Console.WriteLine("Fly Weight: Bu yapı aynı türden çok sayıda nesne oluşturmanın maliyetli olacağından bellekte tasarruf etmek için kullanılır. Ortak nesne durumları paylaşılır.\n\n");

            AddingCar addingCar = new AddingCar();
            addingCar.AddCar();

            Console.ReadKey();
            var program = new Program();
            program.StructuralPatterns();
        }

        public void ProxyMenu()
        {
            Console.Clear();
            Console.WriteLine("Proxy: Bu yöntem sayesinde bir nesne için geçici bir vekil atayarak gerçek nesneye olan erişimi kontrol etmemize olanak sağlar.\n\n");

            ProxyRun run = new ProxyRun();
            run.ProxyStart();

            Console.ReadKey();
            var program = new Program();
            program.StructuralPatterns();
        }
    }
}
