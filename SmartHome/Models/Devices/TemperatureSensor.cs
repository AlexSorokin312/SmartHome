using SmartHome.Models.Devices.ITurnOnDevice;
using SmartHome.Models.Devices.ITurnOffDevice;

namespace SmartHome.Models.Devices
{
    class TemperatureSensor : Device
    {
    ITurnOn turnOnTemperatureSensor;
    ITurnOff turnOffTemperatureSensor;
    public bool _isOn { get; set; }
        public TemperatureSensor(string name) : base(name)
        {
            _isOn = false;
            turnOnTemperatureSensor = new TurnOn();
            turnOffTemperatureSensor = new TurnOff();
        }
        public void TurnOn()
        {
            _isOn = turnOnTemperatureSensor.TurnOnDevice();
        }

        public void TurnOff()
        {
            _isOn = turnOffTemperatureSensor.TurnOffDevice();
        }
    }
}
