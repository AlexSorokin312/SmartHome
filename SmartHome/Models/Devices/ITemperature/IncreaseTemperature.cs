
namespace SmartHome.Models.Devices.ITemperature
{
    class IncreaseTemperature : IChangeTemperature
    {
        public int changeTemperature(int currentTemperature, int changeByValue)
        {
            return currentTemperature += changeByValue;
        }
    }
}
