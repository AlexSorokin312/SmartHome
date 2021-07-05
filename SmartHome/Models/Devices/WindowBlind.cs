using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHome.Models.Devices.IMovementSensor;
using SmartHome.Models.Devices.IWindowBlind;

namespace SmartHome.Models.Devices
{
    class WindowBlind : Device
    {
        private const int INITIAL_STEP_POSITION = 5;
        public int currentStep {get; set; }
        private ICgangeWindiwBlindStep stepAhead;
        private ICgangeWindiwBlindStep stepBack;

        public WindowBlind(string name) : base(name)
        {
            currentStep = INITIAL_STEP_POSITION;
            stepAhead = new WindowBlindStepAhead();
            stepBack = new WindowBlindStepBack();
        }

        public void OneStepAhead()
        {
            currentStep = stepAhead.changeStep(currentStep, 1);
        }

        public void OneStepBack()
        {
            currentStep = stepBack.changeStep(currentStep, 1);
        }

    }
}
