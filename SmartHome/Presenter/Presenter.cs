using SmartHome.Models.DeviceFactory;
using SmartHome.Models.Devices;
using SmartHome.Models.Devices.IWindowBlind;
using SmartHome.Models.RemoteController;
using SmartHome.Models.RemoteController.BoilerCommands;
using SmartHome.Models.RemoteController.ITemperatureSensor;
using SmartHome.Models.RemoteController.WindowBlindCommands;
using SmartHome.View;
using System;

namespace SmartHome.Presenter
{
    class SmartHomePresenter
    {
        private DevicesFactory factory = new DevicesFactory();

        public const string CAMERA_IS_ON = "Камера включена";
        public const string CAMERA_IS_OFF = "Камера выключена";
        public const string BOILER_IS_ON = "Котёл включен";
        public const string BOILER_IS_OFF = "Котёл выключен";
        public const string SENSOR_TEMPERATURE_IS_ON = "Датчик температуры включен";
        public const string SENSOR_TEMPERATURE_IS_OFF = "Датчик температуры выключен";
        public const string SENSOR_MOVEMENT_IS_ON = "Датчик движения включен";
        public const string SENSOR_MOVEMENT_IS_OFF = "Датчик движения выключен";
        public const string BOILER_TEMPERATURE = "Температура ";
        public const int INITIAL_BOILER_TEMOERATURE = 10;

        private IView _view;

        private Device camera_device;
        private Camera camera;

        private Device boiler_device;
        private Boiler boiler;

        private Device temperatureSensor_device;
        private TemperatureSensor temperatureSensor;

        private Device windowBlind_Device;
        private WindowBlind windowBlind;

        private RemoteController remoteController;

        public SmartHomePresenter(IView view)
        {
            _view = view;

            camera_device = factory.createDevice(DeviceType.Camera, "Камера наблюдения");
            camera = (Camera)camera_device;

            boiler_device = factory.createDevice(DeviceType.Boiler, "Котёл №1");
            boiler = (Boiler)boiler_device;

            temperatureSensor_device = factory.createDevice(DeviceType.TemperatureSensor, "Датчик температуры №1");
            temperatureSensor = (TemperatureSensor)temperatureSensor_device;

            windowBlind_Device = factory.createDevice(DeviceType.WindowBlind, "Котёл №1");
            windowBlind = (WindowBlind)windowBlind_Device;

            ICommand turnOnCamera = new TurnCameraOn(camera);
            ICommand turnOffCamera = new TurnCameraOff(camera);
            ICommand turnOnMovementSensor = new TurnOnMovementSensor(camera);
            ICommand turnOffMovementSensor = new TurnOffMovementSensor(camera);

            ICommand turnOnBoiler = new TurnBoilerOn(boiler);
            ICommand turnOffBoiler = new TurnBoilerOff(boiler);
            ICommand increaseTemperatureByOne = new IncreaseTemperatureByOne(boiler);
            ICommand decreaseTemperatureByOne = new DecreaseTemperatureByOne(boiler);
            ICommand setTemperatureToDefault = new SetTemperatureToDefault(boiler);

            ICommand turnOnTemperatureSensor = new TurnTemperatureSensorOn(temperatureSensor);
            ICommand turnOffTemperatureSensor = new TurnTemperatureSensorOff(temperatureSensor);

            ICommand windowBlinndOneStepAhead = new WindowBlindOneStepAhead(windowBlind);
            ICommand windowBlinndOneStepBack = new WindowBlindOneStepBack(windowBlind);

            remoteController = new RemoteController(turnOnCamera, turnOffCamera, turnOnMovementSensor, turnOffMovementSensor,
                turnOnBoiler, turnOffBoiler, increaseTemperatureByOne, decreaseTemperatureByOne, turnOnTemperatureSensor,
                turnOffTemperatureSensor, setTemperatureToDefault, windowBlinndOneStepAhead, windowBlinndOneStepBack);

        }
        public static SmartHomePresenter getPresenterInstance(SmartHomePresenter presenter, IView view)
        {
            if (presenter != null) return presenter;
            return new SmartHomePresenter(view);
        }

        public void TurnCameraOn()
        {

            remoteController.TurnOnCamera();
            _view.setIsOn = CAMERA_IS_ON;
        }

        public void TurnCameraOff()
        {
            remoteController.TurnOffCamera();
            _view.setIsOn = CAMERA_IS_OFF;
        }

        public void turnBoilerOn()
        {
            if (!boiler._isOn)
            {
                remoteController.TurnOnBoiler();
                setTemperatureToDefault();
                _view.setIsOn = BOILER_IS_ON;
            }
        }

        public void turnBoilerOff()
        {

            remoteController.TurnOffBoiler();
            setTemperatureToDefault();
            _view.setIsOn = BOILER_IS_OFF;
        }

        public void TurnMovementSensor()
        {
            if (camera._isSensorMovementOn || !camera._isOn)
            {
                remoteController.TurnOffSensorMovement();
                _view.setIsMovementSensorOn = SENSOR_MOVEMENT_IS_OFF;
            }
            else
            {
                remoteController.TurnOnSensorMovement();
                _view.setIsMovementSensorOn = SENSOR_MOVEMENT_IS_ON;
            }
        }

        public void TurnOnTemperatureSensor()
        {

            remoteController.TurnOnTemperatureSensor();
            _view.setIsOn = SENSOR_TEMPERATURE_IS_ON;
        }

        public void TurnOffTemperatureSensor()
        {
            remoteController.TurnOffTemperatureSensor();
            _view.setIsOn = SENSOR_TEMPERATURE_IS_OFF;
        }

        public void increseBoilerTemperatureByOne()
        {
            remoteController.IncreaseTemperatureByOne();


        }

        public void decreseBoilerTemperatureByOne()
        {
            remoteController.DecreaseTemperatureByOne();

        }

        public void setTemperatureToDefault()
        {
            remoteController.SetTemperatureByDefault();
        }

        public void windowBlindOneStepAhead()
        {
            remoteController.WindowBlindOneStepAhead();
        }

        public void windowBlindOneStepBack()
        {
            remoteController.WindowBlindOneStepBack();
        }

        public void identifyCameraState()
        {
            if (camera._isOn) _view.setIsOn = CAMERA_IS_ON;
            else
            {
                _view.setIsOn = CAMERA_IS_OFF;
            }
        }
        public void identifyMevomentSensorState()
        {
            if (camera._isSensorMovementOn) _view.setIsMovementSensorOn = "Датчик движения включен";
            else
            {
                _view.setIsMovementSensorOn = "Датчик движения выключен";
            }
        }

        public void identifyBoilerState()
        {
            if (boiler._isOn) _view.setIsOn = BOILER_IS_ON;
            else
            {
                _view.setIsOn = BOILER_IS_OFF;
            }
            _view.setBoilerTemperature = String.Format("{0} : {1}", BOILER_TEMPERATURE, boiler.boilerTemperature.ToString());
        }

        public void identifySensorTemperatureState()
        {
            if (temperatureSensor._isOn) _view.setIsOn = SENSOR_TEMPERATURE_IS_ON;
            else
            {
                _view.setIsOn = SENSOR_TEMPERATURE_IS_OFF;
            }
        }

        public void identifyWindowBlindState()
        {
            _view.setWindowBlindStep = windowBlind.currentStep.ToString();
        }

    }
}
