
namespace SmartHome.Models.Devices.ITemperature
{
    class SetTemperatureToDefault : IChangeTemperature
    {
        private const int defaultValue = 10;
        public int changeTemperature(int currentTemperature, int changeByValue = 0)
        {
            return currentTemperature = defaultValue;
        }   

    }
}
