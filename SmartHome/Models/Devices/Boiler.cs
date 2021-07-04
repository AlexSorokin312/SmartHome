using SmartHome.Models.Devices.ITemperature;

namespace SmartHome.Models.Devices
{


     class Boiler : Device
    {
        public const int INITIAL_TEMPERATURE = 10;
        private const int DEGREE = 1;
        public int boilerTemperature { get; set; }

        public Boiler(string name) : base(name)
        {
            _isOn = false;
            boilerTemperature = INITIAL_TEMPERATURE;
            increaseTemperature = new IncreaseTemperature();
            decreaseTemperature = new DecreaseTemperature();
            setTemperatyreToDefault = new SetTemperatureToDefault();
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
