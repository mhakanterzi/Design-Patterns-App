using Design_Patterns_App.StructuralPatternsLib.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Mediator
{
    public class HomeMediatorRun
    {
        public void HomeRun()
        {
            Lights lights = new Lights();
            AirCondition airCondition = new AirCondition();
            Camera camera = new Camera();
            Home user = new Home();

            HomeMediator mediator = new HomeMediator(lights, airCondition, camera);
            user.SetMediator(mediator);

            Console.WriteLine("Scenario: Admin is entering the house.");
            user.EnterHome();

            Console.WriteLine();

            Console.WriteLine("Scenario: Admin is leaving the house.");
            user.LeaveHome();
        }
    }
}
