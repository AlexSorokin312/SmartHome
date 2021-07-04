
namespace SmartHome
{
    partial class SmartHomeForm 
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCamera = new System.Windows.Forms.Button();
            this.Devices = new System.Windows.Forms.GroupBox();
            this.btnTemperatureSensor = new System.Windows.Forms.Button();
            this.btnBoiler = new System.Windows.Forms.Button();
            this.Remoter = new System.Windows.Forms.GroupBox();
            this.DeviceState = new System.Windows.Forms.GroupBox();
            this.isMovementSensorOn = new System.Windows.Forms.Label();
            this.isOn = new System.Windows.Forms.Label();
            this.boilerTemperature = new System.Windows.Forms.Label();
            this.Devices.SuspendLayout();
            this.DeviceState.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCamera
            // 
            this.btnCamera.Location = new System.Drawing.Point(6, 26);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(238, 42);
            this.btnCamera.Text = " Камера";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // Devices
            // 
            this.Devices.Controls.Add(this.btnTemperatureSensor);
            this.Devices.Controls.Add(this.btnBoiler);
            this.Devices.Controls.Add(this.btnCamera);
            this.Devices.Location = new System.Drawing.Point(12, 12);
            this.Devices.Name = "Devices";
            this.Devices.Size = new System.Drawing.Size(250, 387);
            this.Devices.Text = "Устройства";
            // 
            // btnTemperatureSensor
            // 
            this.btnTemperatureSensor.Location = new System.Drawing.Point(6, 122);
            this.btnTemperatureSensor.Name = "btnTemperatureSensor";
            this.btnTemperatureSensor.Size = new System.Drawing.Size(238, 48);
            this.btnTemperatureSensor.Text = "Датчик тепературы";
            this.btnTemperatureSensor.Click += new System.EventHandler(this.btnTemperatureSensor_Click);
            // 
            // btnBoiler
            // 
            this.btnBoiler.Location = new System.Drawing.Point(5, 74);
            this.btnBoiler.Name = "btnBoiler";
            this.btnBoiler.Size = new System.Drawing.Size(238, 42);
            this.btnBoiler.Text = "Котел";
            this.btnBoiler.Click += new System.EventHandler(this.btnBoiler_Click);
            // 
            // Remoter
            // 
            this.Remoter.Location = new System.Drawing.Point(269, 12);
            this.Remoter.Name = "Remoter";
            this.Remoter.Size = new System.Drawing.Size(250, 387);
            this.Remoter.Text = "Пульт";
            // 
            // DeviceState
            // 
            this.DeviceState.Controls.Add(this.boilerTemperature);
            this.DeviceState.Controls.Add(this.isMovementSensorOn);
            this.DeviceState.Controls.Add(this.isOn);
            this.DeviceState.Location = new System.Drawing.Point(525, 12);
            this.DeviceState.Name = "DeviceState";
            this.DeviceState.Size = new System.Drawing.Size(250, 387);
            this.DeviceState.Text = "Состояние устройства";
            // 
            // isMovementSensorOn
            // 
            this.isMovementSensorOn.Location = new System.Drawing.Point(6, 46);
            this.isMovementSensorOn.Name = "isMovementSensorOn";
            this.isMovementSensorOn.Size = new System.Drawing.Size(100, 23);
            // 
            // isOn
            // 
            this.isOn.Location = new System.Drawing.Point(6, 23);
            this.isOn.Name = "isOn";
            this.isOn.Size = new System.Drawing.Size(100, 23);
            this.isOn.Visible = false;
            // 
            // boilerTemperature
            // 
            this.boilerTemperature.Location = new System.Drawing.Point(6, 49);
            this.boilerTemperature.Name = "boilerTemperature";
            this.boilerTemperature.Size = new System.Drawing.Size(0, 20);
            this.boilerTemperature.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 413);
            this.Controls.Add(this.DeviceState);
            this.Controls.Add(this.Remoter);
            this.Controls.Add(this.Devices);
            this.Name = "Form1";
            this.Text = "SmartHome";
            this.Devices.ResumeLayout(false);
            this.DeviceState.ResumeLayout(false);
            this.DeviceState.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.GroupBox Devices;
        private System.Windows.Forms.Button btnTemperatureSensor;
        private System.Windows.Forms.Button btnBoiler;
        private System.Windows.Forms.GroupBox Remoter;
        private System.Windows.Forms.GroupBox DeviceState;
        private System.Windows.Forms.Label isOn;
        private System.Windows.Forms.Label isMovementSensorOn;
        private System.Windows.Forms.Label boilerTemperature;
    }
}

