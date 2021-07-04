using SmartHome.Models.Devices;

namespace SmartHome.Models.RemoteController
{
    class TurnOnMovementSensor : ICommand
    {
        public Camera _camera;

        public TurnOnMovementSensor(Camera camera)
        {
            _camera = camera;
        }

        public void execute()
        {
            _camera.TurnOnMovementSenseor();
        }

    }
}
