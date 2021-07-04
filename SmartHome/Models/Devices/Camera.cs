
using SmartHome.Models.Devices.ITemperature;

namespace SmartHome.Models.Devices
{
    class Camera : Device
    {
        IMovementSensorTurnOn turnOnSensorBehaviour;
        IMovementSensorTurnOff turnOffSensorBehaviour;

        public bool _isSensorMovementOn { get; set; }
        public Camera(string name) : base(name)
        {
            _isSensorMovementOn = false;
            turnOnSensorBehaviour = new TurnOnSensorNow(this);
            turnOffSensorBehaviour = new TurnOffSensorNow(this);
        }

        public void TurnOnMovementSenseor()
        {  
            turnOnSensorBehaviour.TurnOnMovementSensor();
        }

        public void TurnOffMovementSenseor()
        {
            turnOffSensorBehaviour.TurnOffMovementSensor();
        }
    }
}
