
using SmartHome.Models.Devices;

namespace SmartHome.Models.RemoteController.BoilerCommands
{
    class TurnBoilerOff : ICommand
    {
        Boiler _boiler;

        public TurnBoilerOff(Boiler boiler)
        {
            _boiler = boiler;
        }

        public void execute()
        {
            _boiler.TurnOff();
        }
    }
}
