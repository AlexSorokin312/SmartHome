using SmartHome.Models.Devices.IMovementSensor;

namespace SmartHome.Models.Devices.IWindowBlind
{
    class WindowBlindStepAhead : ICgangeWindiwBlindStep
    {

        private const int MAX_VALUE = 10;
        public int changeStep(int currentStep, int stepsNumber)
        {
            if (currentStep == MAX_VALUE) return MAX_VALUE;
            return currentStep + stepsNumber;
        }


    }
}
