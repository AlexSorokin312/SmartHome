
namespace SmartHome.Models.Devices
{
    class TemperatureSensor : Device
    {
       public TemperatureSensor(string name) : base(name)
        {
            _isOn = false;
        }
    }
}
