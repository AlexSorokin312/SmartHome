
namespace SmartHome.Models.Devices.MovementSensor
{
    class TurnOffSensorNow : IMovementSensorTurnOff
    {
        Camera _camera;
        public TurnOffSensorNow(Camera camera)
        {
            _camera = camera;
        }

        public void TurnOffMovementSensor()
        {
            _camera._isSensorMovementOn = false;
        }
    }
}
