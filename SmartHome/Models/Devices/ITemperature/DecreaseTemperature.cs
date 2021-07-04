
namespace SmartHome.Models.Devices.ITemperature
{
    class DecreaseTemperature : IChangeTemperature
    {
        public int changeTemperature(int currentTemperature, int changeByValue)
        {
            return currentTemperature -= changeByValue;
        }
    }
}
