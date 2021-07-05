using SmartHome.Models.Devices;

namespace SmartHome.Models.RemoteController.ITemperatureSensor
{
    class TurnTemperatureSensorOn : ICommand
    {
        TemperatureSensor _temperatureSensor;

        public TurnTemperatureSensorOn(TemperatureSensor temperatureSensor)
        {
            this._temperatureSensor = temperatureSensor;
        }

        public void execute()
        {
            _temperatureSensor.TurnOn();
        }
    }
}

