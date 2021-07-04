
using SmartHome.Models.Devices.ITemperature;

namespace SmartHome.Models.Devices
{
    abstract class Device
    {
        public string _name { get; set; }
        public bool _isOn { get; set; }
        protected IChangeTemperature increaseTemperature;
        protected IChangeTemperature decreaseTemperature;
        protected IChangeTemperature setTemperatyreToDefault;

        public Device(string name)
        {
            _name = name;
            _isOn = false;
        }

        public void TurnOn()
        {
            _isOn = true;
        }

        public void TurnOff()
        {
            _isOn = false;
        }

    }
}
