using SmartHome.Models.Devices;

namespace SmartHome.Models.RemoteController
{
    class TurnOnDevice : ICommand
    {
        public Device _device;

        public TurnOnDevice(Device device)
        {
            _device = device;
        }

        public void execute()
        {
            _device.TurnOn();
        }
    }
}
