using SmartHome.Models.Devices.ITemperature;
using SmartHome.Models.Devices.ITurnOnDevice;
using SmartHome.Models.Devices.ITurnOffDevice;

namespace SmartHome.Models.Devices
{
    class Boiler : Device
    {
        public const int INITIAL_TEMPERATURE = 10;
        private const int DEGREE = 1;
        public int boilerTemperature { get; set; }
        public bool _isOn { get; set; }

        ITurnOn turnOnBoiler;
        ITurnOff turnOffBoiler;
        public Boiler(string name) : base(name)
        {
            _isOn = false;
            boilerTemperature = INITIAL_TEMPERATURE;
            turnOnBoiler = new TurnOn();
            turnOffBoiler = new TurnOff();
            increaseTemperature = new IncreaseTemperature();
            decreaseTemperature = new DecreaseTemperature();
            setTemperatyreToDefault = new SetTemperatureToDefault();
        }

        public void TurnOn()
        {
            _isOn = turnOnBoiler.TurnOnDevice();
        }

        public void TurnOff()
        {
            _isOn = turnOffBoiler.TurnOffDevice();
        }

        public void IncreaseTemperatureByOneDegree()
        {
            boilerTemperature = increaseTemperature.changeTemperature(boilerTemperature, DEGREE);
        }

        public void DecreaseTemperatureByOneDegree()
        {
            boilerTemperature = decreaseTemperature.changeTemperature(boilerTemperature, DEGREE);
        }

        public void SetTenperatureToDefault()
        {
            boilerTemperature = setTemperatyreToDefault.changeTemperature(boilerTemperature, 0);
        }

    }
}
