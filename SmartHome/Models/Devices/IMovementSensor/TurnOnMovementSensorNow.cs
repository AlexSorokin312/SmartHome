
namespace SmartHome.Models.Devices.MovementSensor
{
    class TurnOnSensorNow : IMovementSensorTurnOn
    {
        Camera _camera;
        public TurnOnSensorNow(Camera camera)
        {
            _camera = camera;
        }

        public void TurnOnMovementSensor()
        {
            _camera._isSensorMovementOn = true;
        }
    }
}
