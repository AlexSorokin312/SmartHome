
using SmartHome.Models.Devices;

namespace SmartHome.Models.RemoteController
{
    class TurnCameraOn : ICommand
    {
        private Camera _camera;

        public TurnCameraOn(Camera camera)
        {
            _camera = camera;
        }

        public void execute()
        {
            _camera.TurnOn();
        }
    }
}
