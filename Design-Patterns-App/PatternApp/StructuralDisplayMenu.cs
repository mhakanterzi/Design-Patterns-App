﻿using Design_Patterns_App.StructuralPatternsLib.Adapter;
using Design_Patterns_App.StructuralPatternsLib.Bridge;
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
    }
}
