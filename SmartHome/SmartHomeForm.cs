using SmartHome.Presenter;
using SmartHome.View;
using System;
using System.Windows.Forms;

namespace SmartHome
{
    public partial class SmartHomeForm : Form, IView
    {
        private SmartHomePresenter presenter;

        public string setIsOn { get => isOn.Text; set => isOn.Text = value; }
        public string setIsMovementSensorOn { set => isMovementSensorOn.Text = value; }
        public string setBoilerTemperature { set => boilerTemperature.Text = value; }
        public string setWindowBlindStep { set => windowBlindStep.Text = value; }

        public SmartHomeForm()
        {
            InitializeComponent();
        }

        private void turnOnCamera_Click(object sender, EventArgs e)
        {
            presenter.TurnCameraOn();
        }

        private void turnOffCamera_Click(object sender, EventArgs e)
        {
            presenter.TurnCameraOff();
            presenter.TurnMovementSensor();
        }

        private void turnOnBoiler_Click(object sender, EventArgs e)
        {
            presenter.turnBoilerOn();
            boilerTemperature.Visible = true;
            presenter.identifyBoilerState();
        }

        private void turnOffBoiler_Click(object sender, EventArgs e)
        {
            presenter.turnBoilerOff();
            boilerTemperature.Visible = false;
            presenter.identifyBoilerState();
        }

        private void movementSensor_Click(object sender, EventArgs e)
        {
            presenter.TurnMovementSensor();
        }

        public void btnIncreaseTemperatureByOneDegree_Click(object sender, EventArgs e)
        {
            presenter.increseBoilerTemperatureByOne();
            presenter.identifyBoilerState();
        }

        public void btnDecreaseTemperatureByOneDegree_Click(object sender, EventArgs e)
        {
            presenter.decreseBoilerTemperatureByOne();
            presenter.identifyBoilerState();
        }

        private void turnOnTemperatureSensor_Click(object sender, EventArgs e)
        {
            presenter.TurnOnTemperatureSensor();
        }

        private void turnOffTemperatureSensor_Click(object sender, EventArgs e)
        {
            presenter.TurnOffTemperatureSensor();
        }

        private void windowBlindOneStepAhead_Click(object sender, EventArgs e)
        {
            presenter.windowBlindOneStepAhead();
            presenter.identifyWindowBlindState();
        }

        private void windowBlindOneStepBack_Click(object sender, EventArgs e)
        {
            presenter.windowBlindOneStepBack();
            presenter.identifyWindowBlindState();
        }


        private void btnCamera_Click(object sender, EventArgs e)
        {
            Remoter.Controls.Clear();
            DeviceState.Controls.Clear();
            if (presenter == null) presenter = new SmartHomePresenter(this);

            presenter.identifyCameraState();
            presenter.identifyMevomentSensorState();

            Button TurnOn = new Button();
            Remoter.Controls.Add(TurnOn);
            TurnOn.Location = new System.Drawing.Point(5, 20);
            TurnOn.Name = "TurnOn";
            TurnOn.Size = new System.Drawing.Size(238, 42);
            TurnOn.Text = "Включить";
            TurnOn.Click += new EventHandler(turnOnCamera_Click);

            Button TurnOff = new Button();
            Remoter.Controls.Add(TurnOff);
            TurnOff.Location = new System.Drawing.Point(5, 70);
            TurnOff.Name = "TurnOff";
            TurnOff.Size = new System.Drawing.Size(238, 42);
            TurnOff.Text = "Выключить";
            TurnOff.Click += new EventHandler(turnOffCamera_Click);

            Button MovementSensor = new Button();
            Remoter.Controls.Add(MovementSensor);
            MovementSensor.Location = new System.Drawing.Point(5, 120);
            MovementSensor.Name = "MovementController";
            MovementSensor.Size = new System.Drawing.Size(238, 42);
            MovementSensor.Text = "Обнаружение движения";
            MovementSensor.Click += new EventHandler(movementSensor_Click);

            if (!DeviceState.Controls.Contains(isOn)) DeviceState.Controls.Add(isOn);
            isOn.AutoSize = true;
            isOn.Visible = true;
            isOn.Name = "isOn";

            if (!DeviceState.Controls.Contains(isMovementSensorOn)) DeviceState.Controls.Add(isMovementSensorOn);
            isMovementSensorOn.AutoSize = true;
            isMovementSensorOn.Visible = true;
            isMovementSensorOn.Name = "isMovementSensorOn";
        }

        private void btnBoiler_Click(object sender, EventArgs e)
        {
            Remoter.Controls.Clear();
            DeviceState.Controls.Clear();
            if (presenter == null) presenter = new SmartHomePresenter(this);
            presenter.identifyBoilerState();
            DeviceState.Controls.Clear();

            Button TurnOn = new Button();
            Remoter.Controls.Add(TurnOn);
            TurnOn.Location = new System.Drawing.Point(5, 20);
            TurnOn.Name = "TurnOn";
            TurnOn.Size = new System.Drawing.Size(238, 42);
            TurnOn.Text = "Включить";
            TurnOn.Click += new EventHandler(turnOnBoiler_Click);

            Button TurnOff = new Button();
            Remoter.Controls.Add(TurnOff);
            TurnOff.Location = new System.Drawing.Point(5, 70);
            TurnOff.Name = "TurnOff";
            TurnOff.Size = new System.Drawing.Size(238, 42);
            TurnOff.Text = "Выключить";
            TurnOff.Click += new EventHandler(turnOffBoiler_Click);

            Button increaseTempreatureByOneDegree = new Button();
            Remoter.Controls.Add(increaseTempreatureByOneDegree);
            increaseTempreatureByOneDegree.Location = new System.Drawing.Point(5, 120);
            increaseTempreatureByOneDegree.Name = "increaseTempreatureByOneDegree";
            increaseTempreatureByOneDegree.Size = new System.Drawing.Size(238, 42);
            increaseTempreatureByOneDegree.Text = "+1 градус";
            increaseTempreatureByOneDegree.Click += new EventHandler(btnIncreaseTemperatureByOneDegree_Click);

            Button DicreaseTempreatureByOneDegree = new Button();
            Remoter.Controls.Add(DicreaseTempreatureByOneDegree);
            DicreaseTempreatureByOneDegree.Location = new System.Drawing.Point(5, 170);
            DicreaseTempreatureByOneDegree.Name = "increaseTempreatureByOneDegree";
            DicreaseTempreatureByOneDegree.Size = new System.Drawing.Size(238, 42);
            DicreaseTempreatureByOneDegree.Text = "-1 градус";
            DicreaseTempreatureByOneDegree.Click += new EventHandler(this.btnDecreaseTemperatureByOneDegree_Click);

            if (!DeviceState.Controls.Contains(isOn)) DeviceState.Controls.Add(isOn);
            isOn.AutoSize = true;
            isOn.Visible = true;
            isOn.Name = "isOn";

            if (!DeviceState.Controls.Contains(boilerTemperature)) DeviceState.Controls.Add(boilerTemperature);
            boilerTemperature.AutoSize = true;
        }

        private void btnTemperatureSensor_Click(object sender, EventArgs e)
        {
            Remoter.Controls.Clear();
            DeviceState.Controls.Clear();
            if (presenter == null) presenter = new SmartHomePresenter(this);

            presenter.identifySensorTemperatureState();

            Button TurnOn = new Button();
            Remoter.Controls.Add(TurnOn);
            TurnOn.Location = new System.Drawing.Point(5, 20);
            TurnOn.Name = "TurnOn";
            TurnOn.Size = new System.Drawing.Size(238, 42);
            TurnOn.TabIndex = 0;
            TurnOn.Text = "Включить";
            TurnOn.UseVisualStyleBackColor = true;
            TurnOn.Click += new EventHandler(this.turnOnTemperatureSensor_Click);

            Button TurnOff = new Button();
            Remoter.Controls.Add(TurnOff);
            TurnOff.Location = new System.Drawing.Point(5, 70);
            TurnOff.Name = "TurnOff";
            TurnOff.Size = new System.Drawing.Size(238, 42);
            TurnOff.TabIndex = 0;
            TurnOff.Text = "Выключить";
            TurnOff.UseVisualStyleBackColor = true;
            TurnOff.Click += new EventHandler(this.turnOffTemperatureSensor_Click);

            if (!DeviceState.Controls.Contains(isOn)) DeviceState.Controls.Add(isOn);
            isOn.AutoSize = true;
            isOn.Visible = true;
            isOn.Name = "isOn";
        }

        private void WindowBlind_Click(object sender, EventArgs e)
        {
            Remoter.Controls.Clear();
            DeviceState.Controls.Clear();
            if (presenter == null) presenter = new SmartHomePresenter(this);
            presenter.identifyWindowBlindState();
            DeviceState.Controls.Clear();

            Button OneStepAhead = new Button();
            Remoter.Controls.Add(OneStepAhead);
            OneStepAhead.Location = new System.Drawing.Point(5, 20);
            OneStepAhead.Name = "StepAhead";
            OneStepAhead.Size = new System.Drawing.Size(238, 42);
            OneStepAhead.Text = "Шаг вперёд";
            OneStepAhead.Click += new EventHandler(windowBlindOneStepAhead_Click);

            Button OneStepBack = new Button();
            Remoter.Controls.Add(OneStepBack);
            OneStepBack.Location = new System.Drawing.Point(5, 70);
            OneStepBack.Name = "StepBack";
            OneStepBack.Size = new System.Drawing.Size(238, 42);
            OneStepBack.Text = "Шаг назад";
            OneStepBack.Click += new EventHandler(windowBlindOneStepBack_Click);

            if (!DeviceState.Controls.Contains(windowBlindStep)) DeviceState.Controls.Add(windowBlindStep);
            windowBlindStep.Visible = true;
        }
    }
}
