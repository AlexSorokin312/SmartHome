
using SmartHome.Models.Devices;

namespace SmartHome.Models.RemoteController.BoilerCommands
{
    class IncreaseTemperatureByOne : ICommand
    {
        private Boiler _boiler;

        public IncreaseTemperatureByOne(Boiler boiler)
        {
            _boiler = boiler;
        }

        public void execute()
        {
           _boiler.IncreaseTemperatureByOneDegree();
        }
    }
}
