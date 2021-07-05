
using SmartHome.Models.Devices;

namespace SmartHome.Models.RemoteController
{
    class TurnCameraOff : ICommand
    {
        private Camera _camera;

        public TurnCameraOff(Camera camera)
        {
            _camera = camera;
        }

        public void execute()
        {
            _camera.TurnOff();
        }
    }
}
