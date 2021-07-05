
using SmartHome.Models.Devices.MovementSensor;
using SmartHome.Models.Devices.ITurnOnDevice;
using SmartHome.Models.Devices.ITurnOffDevice;

namespace SmartHome.Models.Devices
{
    class Camera : Device
    {
        IMovementSensorTurnOn turnOnSensorBehaviour;
        IMovementSensorTurnOff turnOffSensorBehaviour;
        ITurnOn turnOnCamera;
        ITurnOff turnOffCamera;
        public bool _isOn { get; set; }
        public bool _isSensorMovementOn { get; set; }
        public Camera(string name) : base(name)
        {
            _isSensorMovementOn = false;
            _isOn = false;
            turnOnCamera = new TurnOn();
            turnOffCamera = new TurnOff();
            turnOnSensorBehaviour = new TurnOnSensorNow(this);
            turnOffSensorBehaviour = new TurnOffSensorNow(this);
        }

        public void TurnOn()
        {
            _isOn = turnOnCamera.TurnOnDevice();
        }
        public void TurnOff()
        {
            _isOn = turnOffCamera.TurnOffDevice();
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
