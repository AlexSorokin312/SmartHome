using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHome.Models.Devices;

namespace SmartHome.Models.RemoteController.BoilerCommands
{
    class TurnBoilerOn : ICommand
    {
        Boiler _boiler;

        public TurnBoilerOn(Boiler boiler)
        {
            _boiler = boiler;
        }

        public void execute()
        {
            _boiler.TurnOn();
        }
    }
}
