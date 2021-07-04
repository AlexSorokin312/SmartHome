using SmartHome.Models.Devices;

namespace SmartHome.Models.RemoteController
{
    class TurnOffDevice : ICommand
    {
        public Device _device;

        public TurnOffDevice(Device device)
        {
            _device = device;
        }

        public void execute()
        {
            _device.TurnOff();
        }
    }
}
