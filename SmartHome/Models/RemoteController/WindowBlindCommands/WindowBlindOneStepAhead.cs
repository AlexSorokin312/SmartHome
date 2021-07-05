
using SmartHome.Models.Devices;

namespace SmartHome.Models.RemoteController.WindowBlindCommands
{
    class WindowBlindOneStepAhead : ICommand
    {
        WindowBlind _windowBlind;

        public WindowBlindOneStepAhead(WindowBlind windowBlind)
        {
            _windowBlind = windowBlind;
        }

        public void execute()
        {
            _windowBlind.OneStepAhead();
        }
    }
}
