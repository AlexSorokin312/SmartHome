using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.View
{
    interface IView
    {
        string setIsOn { set; }
        string setIsMovementSensorOn { set; }
        string setBoilerTemperature { set; }
        string setWindowBlindStep { set; }
    }
}
