
using SmartHome.Models.Devices;

namespace SmartHome.Models.RemoteController.WindowBlindCommands
{
    class WindowBlindOneStepBack : ICommand
    {
        WindowBlind _windowBlind;

        public WindowBlindOneStepBack(WindowBlind windowBlind)
        {
            _windowBlind = windowBlind;
        }

        public void execute()
        {
            _windowBlind.OneStepBack();
        }
    }
}
