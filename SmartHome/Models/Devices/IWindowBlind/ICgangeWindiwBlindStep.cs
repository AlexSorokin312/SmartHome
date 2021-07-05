using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Models.Devices.IMovementSensor
{
    interface ICgangeWindiwBlindStep
    {
        public int changeStep(int currentStep, int stepsNumber);
    }
}
