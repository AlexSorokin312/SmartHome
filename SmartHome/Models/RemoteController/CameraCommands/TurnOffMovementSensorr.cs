using SmartHome.Models.Devices;

namespace SmartHome.Models.RemoteController
{
    class TurnOffMovementSensor : ICommand
    {
        private Camera _camera;

        public TurnOffMovementSensor(Camera camera)
        {
            _camera = camera;
        }

        public void execute()
        {
            _camera.TurnOffMovementSenseor();
        }
    }
}
