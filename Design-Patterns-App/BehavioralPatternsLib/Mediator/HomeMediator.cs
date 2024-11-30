using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Mediator
{
    public class HomeMediator :IMediator
    {
        private Lights _lights;
        private AirCondition _airCondition;
        private Camera _camera;

        public HomeMediator(Lights lights, AirCondition airCondition, Camera camera)
        {
            _lights = lights;
            _airCondition = airCondition;
            _camera = camera;

            _lights.SetMediator(this);
            _airCondition.SetMediator(this);
            _camera.SetMediator(this);
        }

        public void Notify(Component sender, string message)
        {
            if (message == "entered home")
            {
                Console.WriteLine("Mediator: Admin entered the house...");
                _lights.TurnOn();
                _airCondition.TurnOn();
                _camera.TurnOff();
            }
            else
            {
                Console.WriteLine("Mediator: Admin left the house...");
                _lights.TurnOff();
                _airCondition.TurnOff();
                _camera.TurnOn();
            }
        }
    }
}
