using SmartHome.Models.Devices;

namespace SmartHome.Models.DeviceFactory
{

    enum DeviceType{
        Camera,
        Boiler,
        TemperatureSensor,
        WindowBlind
    }

    class DevicesFactory
    {

        public Device createDevice(DeviceType deviceType, string name)
        {
            switch (deviceType)
            {
                case DeviceType.Camera:
                    return new Camera(name);
                case DeviceType.Boiler:
                    return new Boiler(name);
               case DeviceType.TemperatureSensor:
                     return new TemperatureSensor(name);
                case DeviceType.WindowBlind:
                    return new WindowBlind(name);
                default:
                    return null;
            }
        }

    }
}
