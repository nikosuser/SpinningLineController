namespace ControlNew
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.connectButton = new System.Windows.Forms.Button();
            this.windingButton = new System.Windows.Forms.Button();
            this.speed = new System.Windows.Forms.TextBox();
            this.COMports = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ReverseTurning = new System.Windows.Forms.CheckBox();
            this.spacing = new System.Windows.Forms.TextBox();
            this.diameter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearLog = new System.Windows.Forms.Button();
            this.exportLog = new System.Windows.Forms.Button();
            this.runningChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.microstepSettingLabel = new System.Windows.Forms.Label();
            this.RPMValueLabel = new System.Windows.Forms.Label();
            this.directionSwitchLabel = new System.Windows.Forms.Label();
            this.stepperSpeedLabel = new System.Windows.Forms.Label();
            this.connectedCOMLabel = new System.Windows.Forms.Label();
            this.winderPowerLabel = new System.Windows.Forms.Label();
            this.selectedCOM = new System.Windows.Forms.Label();
            this.dirSwitch = new System.Windows.Forms.Label();
            this.stepperSpeed = new System.Windows.Forms.Label();
            this.rpm = new System.Windows.Forms.Label();
            this.microstep = new System.Windows.Forms.Label();
            this.winderPower = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runningChart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.connectButton.Location = new System.Drawing.Point(329, 309);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(99, 111);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click_1);
            // 
            // windingButton
            // 
            this.windingButton.Location = new System.Drawing.Point(434, 309);
            this.windingButton.Name = "windingButton";
            this.windingButton.Size = new System.Drawing.Size(103, 111);
            this.windingButton.TabIndex = 1;
            this.windingButton.Text = "Start Winding";
            this.windingButton.UseVisualStyleBackColor = true;
            this.windingButton.Click += new System.EventHandler(this.windingButton_Click);
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(167, 17);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(100, 20);
            this.speed.TabIndex = 2;
            this.speed.TextChanged += new System.EventHandler(this.speed_TextChanged);
            // 
            // COMports
            // 
            this.COMports.FormattingEnabled = true;
            this.COMports.Location = new System.Drawing.Point(167, 160);
            this.COMports.Name = "COMports";
            this.COMports.Size = new System.Drawing.Size(100, 21);
            this.COMports.TabIndex = 3;
            this.COMports.SelectedIndexChanged += new System.EventHandler(this.COMports_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ReverseTurning);
            this.groupBox1.Controls.Add(this.COMports);
            this.groupBox1.Controls.Add(this.spacing);
            this.groupBox1.Controls.Add(this.diameter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.speed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 204);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Winding Setup";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "COM Port:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ReverseTurning
            // 
            this.ReverseTurning.AutoSize = true;
            this.ReverseTurning.Location = new System.Drawing.Point(209, 128);
            this.ReverseTurning.Name = "ReverseTurning";
            this.ReverseTurning.Size = new System.Drawing.Size(15, 14);
            this.ReverseTurning.TabIndex = 6;
            this.ReverseTurning.UseVisualStyleBackColor = true;
            // 
            // spacing
            // 
            this.spacing.Location = new System.Drawing.Point(167, 89);
            this.spacing.Name = "spacing";
            this.spacing.Size = new System.Drawing.Size(100, 20);
            this.spacing.TabIndex = 5;
            // 
            // diameter
            // 
            this.diameter.Location = new System.Drawing.Point(167, 54);
            this.diameter.Name = "diameter";
            this.diameter.Size = new System.Drawing.Size(100, 20);
            this.diameter.TabIndex = 4;
            this.diameter.TextChanged += new System.EventHandler(this.diameter_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reverse Winding:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiber Spacing (mm):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Set Bobbin Diameter (mm):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set Speed (m/min):";
            // 
            // clearLog
            // 
            this.clearLog.Location = new System.Drawing.Point(660, 309);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(128, 57);
            this.clearLog.TabIndex = 5;
            this.clearLog.Text = "Clear Log";
            this.clearLog.UseVisualStyleBackColor = true;
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // exportLog
            // 
            this.exportLog.Location = new System.Drawing.Point(660, 372);
            this.exportLog.Name = "exportLog";
            this.exportLog.Size = new System.Drawing.Size(128, 48);
            this.exportLog.TabIndex = 6;
            this.exportLog.Text = "Export Log";
            this.exportLog.UseVisualStyleBackColor = true;
            this.exportLog.Click += new System.EventHandler(this.exportLog_Click);
            // 
            // runningChart
            // 
            chartArea1.Name = "ChartArea1";
            this.runningChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.runningChart.Legends.Add(legend1);
            this.runningChart.Location = new System.Drawing.Point(329, 49);
            this.runningChart.Name = "runningChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Speed";
            this.runningChart.Series.Add(series1);
            this.runningChart.Size = new System.Drawing.Size(459, 243);
            this.runningChart.TabIndex = 7;
            this.runningChart.Click += new System.EventHandler(this.runningChart_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.statusLabel.Location = new System.Drawing.Point(-1, -1);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(55, 0, 3, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(803, 44);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Idle";
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.microstepSettingLabel);
            this.groupBox2.Controls.Add(this.RPMValueLabel);
            this.groupBox2.Controls.Add(this.directionSwitchLabel);
            this.groupBox2.Controls.Add(this.stepperSpeedLabel);
            this.groupBox2.Controls.Add(this.connectedCOMLabel);
            this.groupBox2.Controls.Add(this.winderPowerLabel);
            this.groupBox2.Controls.Add(this.selectedCOM);
            this.groupBox2.Controls.Add(this.dirSwitch);
            this.groupBox2.Controls.Add(this.stepperSpeed);
            this.groupBox2.Controls.Add(this.rpm);
            this.groupBox2.Controls.Add(this.microstep);
            this.groupBox2.Controls.Add(this.winderPower);
            this.groupBox2.Location = new System.Drawing.Point(33, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 153);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Parameters";
            // 
            // microstepSettingLabel
            // 
            this.microstepSettingLabel.AutoSize = true;
            this.microstepSettingLabel.Location = new System.Drawing.Point(167, 42);
            this.microstepSettingLabel.Name = "microstepSettingLabel";
            this.microstepSettingLabel.Size = new System.Drawing.Size(41, 13);
            this.microstepSettingLabel.TabIndex = 12;
            this.microstepSettingLabel.Text = "label12";
            // 
            // RPMValueLabel
            // 
            this.RPMValueLabel.AutoSize = true;
            this.RPMValueLabel.Location = new System.Drawing.Point(167, 64);
            this.RPMValueLabel.Name = "RPMValueLabel";
            this.RPMValueLabel.Size = new System.Drawing.Size(41, 13);
            this.RPMValueLabel.TabIndex = 11;
            this.RPMValueLabel.Text = "label11";
            // 
            // directionSwitchLabel
            // 
            this.directionSwitchLabel.AutoSize = true;
            this.directionSwitchLabel.Location = new System.Drawing.Point(167, 108);
            this.directionSwitchLabel.Name = "directionSwitchLabel";
            this.directionSwitchLabel.Size = new System.Drawing.Size(41, 13);
            this.directionSwitchLabel.TabIndex = 10;
            this.directionSwitchLabel.Text = "label10";
            // 
            // stepperSpeedLabel
            // 
            this.stepperSpeedLabel.AutoSize = true;
            this.stepperSpeedLabel.Location = new System.Drawing.Point(167, 86);
            this.stepperSpeedLabel.Name = "stepperSpeedLabel";
            this.stepperSpeedLabel.Size = new System.Drawing.Size(35, 13);
            this.stepperSpeedLabel.TabIndex = 9;
            this.stepperSpeedLabel.Text = "label9";
            // 
            // connectedCOMLabel
            // 
            this.connectedCOMLabel.AutoSize = true;
            this.connectedCOMLabel.Location = new System.Drawing.Point(167, 131);
            this.connectedCOMLabel.Name = "connectedCOMLabel";
            this.connectedCOMLabel.Size = new System.Drawing.Size(35, 13);
            this.connectedCOMLabel.TabIndex = 8;
            this.connectedCOMLabel.Text = "label8";
            // 
            // winderPowerLabel
            // 
            this.winderPowerLabel.AutoSize = true;
            this.winderPowerLabel.Location = new System.Drawing.Point(167, 19);
            this.winderPowerLabel.Name = "winderPowerLabel";
            this.winderPowerLabel.Size = new System.Drawing.Size(35, 13);
            this.winderPowerLabel.TabIndex = 6;
            this.winderPowerLabel.Text = "label6";
            // 
            // selectedCOM
            // 
            this.selectedCOM.AutoSize = true;
            this.selectedCOM.Location = new System.Drawing.Point(6, 131);
            this.selectedCOM.Name = "selectedCOM";
            this.selectedCOM.Size = new System.Drawing.Size(89, 13);
            this.selectedCOM.TabIndex = 5;
            this.selectedCOM.Text = "Connected COM:";
            this.selectedCOM.Click += new System.EventHandler(this.selectedCOM_Click);
            // 
            // dirSwitch
            // 
            this.dirSwitch.AutoSize = true;
            this.dirSwitch.Location = new System.Drawing.Point(7, 108);
            this.dirSwitch.Name = "dirSwitch";
            this.dirSwitch.Size = new System.Drawing.Size(87, 13);
            this.dirSwitch.TabIndex = 4;
            this.dirSwitch.Text = "Direction Switch:";
            this.dirSwitch.Click += new System.EventHandler(this.label11_Click);
            // 
            // stepperSpeed
            // 
            this.stepperSpeed.AutoSize = true;
            this.stepperSpeed.Location = new System.Drawing.Point(6, 86);
            this.stepperSpeed.Name = "stepperSpeed";
            this.stepperSpeed.Size = new System.Drawing.Size(81, 13);
            this.stepperSpeed.TabIndex = 3;
            this.stepperSpeed.Text = "Stepper Speed:";
            // 
            // rpm
            // 
            this.rpm.AutoSize = true;
            this.rpm.Location = new System.Drawing.Point(6, 64);
            this.rpm.Name = "rpm";
            this.rpm.Size = new System.Drawing.Size(34, 13);
            this.rpm.TabIndex = 2;
            this.rpm.Text = "RPM:";
            // 
            // microstep
            // 
            this.microstep.AutoSize = true;
            this.microstep.Location = new System.Drawing.Point(7, 42);
            this.microstep.Name = "microstep";
            this.microstep.Size = new System.Drawing.Size(92, 13);
            this.microstep.TabIndex = 1;
            this.microstep.Text = "Microstep Setting:";
            // 
            // winderPower
            // 
            this.winderPower.AutoSize = true;
            this.winderPower.Location = new System.Drawing.Point(7, 20);
            this.winderPower.Name = "winderPower";
            this.winderPower.Size = new System.Drawing.Size(114, 13);
            this.winderPower.TabIndex = 0;
            this.winderPower.Text = "Current Winder Power:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(543, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 111);
            this.button1.TabIndex = 10;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.runningChart);
            this.Controls.Add(this.exportLog);
            this.Controls.Add(this.clearLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.windingButton);
            this.Controls.Add(this.connectButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runningChart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button windingButton;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.ComboBox COMports;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox diameter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox spacing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ReverseTurning;
        private System.Windows.Forms.Button clearLog;
        private System.Windows.Forms.Button exportLog;
        private System.Windows.Forms.DataVisualization.Charting.Chart runningChart;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label dirSwitch;
        private System.Windows.Forms.Label stepperSpeed;
        private System.Windows.Forms.Label rpm;
        private System.Windows.Forms.Label microstep;
        private System.Windows.Forms.Label winderPower;
        private System.Windows.Forms.Label selectedCOM;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label microstepSettingLabel;
        private System.Windows.Forms.Label RPMValueLabel;
        private System.Windows.Forms.Label directionSwitchLabel;
        private System.Windows.Forms.Label stepperSpeedLabel;
        private System.Windows.Forms.Label connectedCOMLabel;
        private System.Windows.Forms.Label winderPowerLabel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
    }
}

