using Design_Pattern;
using Microsoft.VisualBasic;
using Design_Pattern.PatternApp;
using Design_Patterns_App.PatternApp;


public class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "Design Patterns";
        Program app = new Program();
        app.mainMenu();
    }

    public void mainMenu()
    {
        string prompt = "Design Pattern Uygulamasına Hoş geldiniz";

        string[] options = { "Creational Patterns (Yaratıcı Desenler)", "Structural Patterns (Yapısal Desenler)", "Behavioral Patterns (Davranışsal Desenler)","Çıkış" };
        MenuControl main = new MenuControl(options,prompt);
        int SelectedIndex = main.Run();

        switch (SelectedIndex)
        {
            case 0:
                CreationalPatterns();
                break;
            case 1:
                StructuralPatterns();
                break;
            case 2:
                BehavioralPatterns();
                break;
            case 3:
                ExitApp();
                break;
        }
    }

    public void CreationalPatterns()
    {
        var creationaldisplaymenu = new CreationalDisplayMenu();
        string prompt = "Creational Patterns(Yaratıcı Desenler): Kodun esnekliğini ve yeniden kullanımını arttıran pattern'lerdir.";
        string[] options = { "Singleton","Factory Method","Abstract Factory","Builder","Prototype","Ana Menü" };
        MenuControl main = new MenuControl(options, prompt);
        int SelectedIndex = main.Run();

        switch (SelectedIndex)
        {
            case 0:
                creationaldisplaymenu.SingletonMenu();
                break;
            case 1:
                creationaldisplaymenu.FactoryMethodMenu();
                break;
            case 2:
                creationaldisplaymenu.AbstractFactoryMenu();
                break;
            case 3:
                creationaldisplaymenu.Builder();
                break;
            case 4:
                creationaldisplaymenu.Prototype();
                break;
            case 5:
                mainMenu();
                break;
        }
    }

    public void StructuralPatterns()
    {
        var structuralDisplayMenu = new StructuralDisplayMenu();
        string prompt = "Structural Patterns (Yapısal Desenler): nesnelerin ve sınıfların daha büyük yapılarda nasıl birleşeceğini ayarlar ve bu yapıların esnek ve verimli kalmasını sağlar";
        string[] options = { "Adapter","Bridge","Composite","Decorator","Facade","Fly Weight","Proxy","Ana Menü" };
        MenuControl main = new MenuControl (options, prompt);
        int SelectedIndex = main.Run();

        switch (SelectedIndex) 
        {
            case 0:
                structuralDisplayMenu.AdapterMenu();
                break;
            case 1:
                structuralDisplayMenu.BridgeMenu();
                break;
            case 2:
                structuralDisplayMenu.CompositMenu();
                break;
            case 3:
                structuralDisplayMenu.DecoratorMenu();
                break;
            case 4:
                structuralDisplayMenu.FacadeMenu();
                break;
            case 5:
                structuralDisplayMenu.FlyWeightMenu();
                break;
            case 6:
                structuralDisplayMenu.ProxyMenu();
                break;
            case 7:
                mainMenu();
                break;
        }
    }

    public void BehavioralPatterns()
    {
        var behavioralDisplayMenu = new BehavioralDisplayMenu();
        string prompt = "Behavioral Patterns (Davranışsal Desenler): nesneler arası etkileşimi ve sorumluluk dağılımlarını gösterir";
        string[] options = { "Chain of Responsibility","Command","Iterator","Mediator","Memento","Observer","State","Strategy","template Method","Visitor","Ana Menü" };
        MenuControl main = new MenuControl(options, prompt);
        int SelectedIndex = main.Run();

        switch (SelectedIndex)
        {
            case 0:
                behavioralDisplayMenu.ChainOfResponsibilityMenu();
                break;
            case 1:
                behavioralDisplayMenu.CommandMenu();
                break;
            case 2:
                behavioralDisplayMenu.IteratorMenu();
                break;
            case 3:
                behavioralDisplayMenu.MediatorMenu();
                break;
            case 4:
                behavioralDisplayMenu.MementoMenu();
                break;
            case 5:
                behavioralDisplayMenu.ObserverMenu();
                break;
            case 6:
                behavioralDisplayMenu.StateMenu();
                break;
            case 7:
                behavioralDisplayMenu.StrategyMenu();
                break;
            case 8:
                behavioralDisplayMenu.TemplateMethodMenu();
                break;
            case 9:
                behavioralDisplayMenu.VisitorMenu();
                break;
            case 10:
                mainMenu();
                break;
        }
    }

    private void ExitApp()
    {
        Console.Write("\nÇıkmak için herhangi bir tuşa basınız... ");
        Console.ReadKey(true);
        Environment.Exit(0);
    }


    internal class MenuControl
    {
        private int SelectedIndex;

        private string[] Options;

        private string Prompt;

        public MenuControl(string[] options, string prompt)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }

        private void DisplayOptions()
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;

                if (i == SelectedIndex)
                {
                    prefix = ">";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine($"{prefix} {currentOption}");
            }

            Console.ResetColor();
        }



        public int Run()
        {
            ConsoleKey keyPressed;

            do
            {
                Console.Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;

                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;

                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }
                else if (keyPressed == ConsoleKey.Escape)
                {
                    Program app = new Program();
                    app.mainMenu();
                }
            } while (keyPressed != ConsoleKey.Enter);
            return SelectedIndex;
        }
    }
}
