
namespace SmartHome.Models.RemoteController
{
    class RemoteController
    {
        public ICommand _turnOnCamera;
        public ICommand _turnOffCamera;
        public ICommand _turnOnMovementSensor;
        public ICommand _turnOffMovementSensor;

        public ICommand _turnOnBoiler;
        public ICommand _turnOffBoiler;
        public ICommand _increaseTemperatureByOne;
        public ICommand _decreaseTemperatureByOne;
        public ICommand _setTemperatureToDefault;

        public ICommand _turnOnTemperatureSensor;
        public ICommand _turnOffTemperatureSensor;

        public ICommand _windowBlindOneStepAhead;
        public ICommand _windowBlindOneStepBack;

        public RemoteController(ICommand turnOnCamera, ICommand turnOffCamera, ICommand turnOnMovementSensor,
            ICommand turnOffMovementSensor, ICommand turnOnBoiler, ICommand turnOffBoiler,
            ICommand increaseTemperatureByOne, ICommand decreaseTemperatureByOne, ICommand turnOnTemperatureSensor,
            ICommand turnOffTemperatureSensor, ICommand setTemperatureToDefault,
            ICommand windowBlindoneStepAhed, ICommand windoWBlindOneStepBack)
        {
            _turnOnCamera = turnOnCamera;
            _turnOffCamera = turnOffCamera;
            _turnOnMovementSensor = turnOnMovementSensor;
            _turnOffMovementSensor = turnOffMovementSensor;

            _turnOnBoiler = turnOnBoiler;
            _turnOffBoiler = turnOffBoiler;
            _increaseTemperatureByOne = increaseTemperatureByOne;
            _decreaseTemperatureByOne = decreaseTemperatureByOne;
            _setTemperatureToDefault = setTemperatureToDefault;

            _turnOnTemperatureSensor = turnOnTemperatureSensor;
            _turnOffTemperatureSensor = turnOffTemperatureSensor;

            _windowBlindOneStepAhead = windowBlindoneStepAhed;
            _windowBlindOneStepBack = windoWBlindOneStepBack;
        }

        public void TurnOnCamera()
        {
            _turnOnCamera.execute();
        }

        public void TurnOffCamera()
        {
            _turnOffCamera.execute();
        }

        public void TurnOnSensorMovement()
        {
            _turnOnMovementSensor.execute();
        }

        public void TurnOffSensorMovement()
        {
            _turnOffMovementSensor.execute();
        }

        public void TurnOnBoiler()
        {
            _turnOnBoiler.execute();
        }

        public void TurnOffBoiler()
        {
            _turnOffBoiler.execute();
        }


        public void IncreaseTemperatureByOne()
        {
            _increaseTemperatureByOne.execute();
        }


        public void DecreaseTemperatureByOne()
        {
            _decreaseTemperatureByOne.execute();
        }

        public void SetTemperatureByDefault()
        {
            _setTemperatureToDefault.execute();
        }

        public void TurnOnTemperatureSensor()
        {
            _turnOnTemperatureSensor.execute();
        }


        public void TurnOffTemperatureSensor()
        {
            _turnOffTemperatureSensor.execute();
        }

        public void WindowBlindOneStepAhead()
        {
            _windowBlindOneStepAhead.execute();
        }

        public void WindowBlindOneStepBack()
        {
            _windowBlindOneStepBack.execute();
        }

    }
}
