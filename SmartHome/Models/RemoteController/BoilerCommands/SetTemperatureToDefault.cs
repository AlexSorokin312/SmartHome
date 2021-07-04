using SmartHome.Models.Devices;

namespace SmartHome.Models.RemoteController.BoilerCommands
{
    class SetTemperatureToDefault : ICommand
    {
        private Boiler _boiler;

        public SetTemperatureToDefault(Boiler boiler)
        {
            _boiler = boiler;
        }

        public void execute()
        {
            _boiler.SetTenperatureToDefault();
        }
    }
}
