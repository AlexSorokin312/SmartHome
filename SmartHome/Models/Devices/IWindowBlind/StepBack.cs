using SmartHome.Models.Devices.IMovementSensor;

namespace SmartHome.Models.Devices.IWindowBlind
{
    class WindowBlindStepBack : ICgangeWindiwBlindStep
    {
        private const int MIN_VALUE = 0;
        public int changeStep(int currentStep, int stepsNumber)
        {
            if (currentStep == MIN_VALUE) return MIN_VALUE;

            return currentStep - stepsNumber;
        }
    }
}
