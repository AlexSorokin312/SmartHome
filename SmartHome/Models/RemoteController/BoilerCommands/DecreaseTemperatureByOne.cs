using SmartHome.Models.Devices;

namespace SmartHome.Models.RemoteController.BoilerCommands
{
    class DecreaseTemperatureByOne : ICommand
    {

        private Boiler _boiler;

        public DecreaseTemperatureByOne(Boiler boiler)
        {
            _boiler = boiler;
        }

        public void execute()
        {
            _boiler.DecreaseTemperatureByOneDegree();
        }
    }
}
