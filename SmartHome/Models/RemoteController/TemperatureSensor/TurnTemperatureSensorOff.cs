using SmartHome.Models.Devices;

namespace SmartHome.Models.RemoteController.ITemperatureSensor
{
    class TurnTemperatureSensorOff : ICommand
    {
        TemperatureSensor _temperatureSensor;

        public TurnTemperatureSensorOff(TemperatureSensor temperatureSensor)
        {
            this._temperatureSensor = temperatureSensor;
        }

        public void execute()
        {
            _temperatureSensor.TurnOff();
        }
    }
}

