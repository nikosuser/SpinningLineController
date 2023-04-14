using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Security.Policy;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace ControlNew
{
    public partial class Form1 : Form
    {
        List<string> logData = new List<string>();

        String[] ports;
        SerialPort port;
        bool isConnected = false;
        private bool isRunning = false;
        float stringConversion;

        float windingSpeed;
        float bobbinDiameter;
        float fiberSpacing;
        bool windingUpwards;

        float currentWinderPower;
        float microstepValue;
        float RPMvalue;
        float stepperSpeedValue;
        bool directionSwitchValue;
        string connectedCOMvalue;
        float liveSpeed;
        bool isDisconnect = true;

        string receivedData=null;

        Chart DataChart = new Chart();
        Series winderSpeed = new Series();

        public Form1()
        {
            InitializeComponent();
            getAvailableCOM_PORTS();

            InitChart();
            foreach (string port in ports)
            {
                COMports.Items.Add(port);
                Console.WriteLine(port);

                if (ports[0] != null)
                {
                    COMports.SelectedItem = ports[0];
                }
            }

        }
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (port.BytesToRead > 0)
            {
                try
                {
                    receivedData = port.ReadLine();
                    //logData.Add(DateTime.Now.ToString("HH:mm:ss") + "," + receivedData);
                    string[] values = receivedData.Split(',');
                    currentWinderPower = float.Parse(values[0]);
                    microstepValue = float.Parse(values[1]);
                    RPMvalue = float.Parse(values[2]);
                    stepperSpeedValue = float.Parse(values[3]);
                    if (values[4] == "1")
                    {
                        directionSwitchValue = true;
                    }
                    else { directionSwitchValue = false; }
                    liveSpeed = float.Parse(values[5]);
                }
                catch
                {

                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }


        private void getAvailableCOM_PORTS()
        {
            ports = SerialPort.GetPortNames();
        }

        private void connectToArduino()
        {
            if (ports[0] == null)
            {
                statusLabel.Text = "ERROR: No COMport connection found, please plug in Arduino and make sure it appears on the Device Manager.";
                statusLabel.BackColor = Color.Red;
                return;
            }
            connectedCOMvalue = COMports.GetItemText(COMports.SelectedItem);
            port = new SerialPort(connectedCOMvalue, 9600, Parity.None, 8, StopBits.One);
            try
            {
                isConnected = true;
            }
            catch
            {
                statusLabel.Text = "ERROR: Cannot connect to Arduino, please make sure it is plugged and the correct COM port has been selected as it appears on the Device Manager.";
                statusLabel.BackColor = Color.Red;
                return;
            }

            port.Open();
            connectButton.Text = "Disconnect";
            timer1.Start();
            port.DataReceived += port_DataReceived;
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Close();
            connectButton.Text = "Connect";
        }

        private void COMports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void connectButton_Click_1(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
                isDisconnect = true;
                //updateData();
                statusLabel.Text = "Connected to Arduino";
                statusLabel.BackColor = Color.Green;
            }

            else
            {

                microstepValue = 0;
                RPMvalue = 0;
                stepperSpeedValue = 0;
                currentWinderPower = 0;
                isDisconnect = false;

                updateData();
                windingButton.Text = "Start Spinning";
                disconnectFromArduino();

                statusLabel.Text = "Disconnected from Arduino";
                statusLabel.BackColor = Color.Blue;

            }
        }

        private void selectedCOM_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isConnected) {
                winderSpeed.Points.AddY(liveSpeed);
                DataChart.Refresh();

                microstepSettingLabel.Text = microstepValue.ToString();
                RPMValueLabel.Text = RPMvalue.ToString();
                directionSwitchLabel.Text = directionSwitchValue.ToString();
                stepperSpeedLabel.Text = stepperSpeedValue.ToString();
                winderPowerLabel.Text = currentWinderPower.ToString();
                connectedCOMLabel.Text = connectedCOMvalue.ToString();
            }

            if (receivedData != null)
            {
                logData.Add(DateTime.Now.ToString("HH:mm:ss") + "," + receivedData);
            }
        }

        private void windingButton_Click(object sender, EventArgs e)
        {
            statusLabel.BackColor = Color.Gray;
            windingButton.Text = "Start Winding";
            if (!isRunning)
            {
                isRunning = true;
                windingButton.Text = "Stop Winding";
                updateData();
                statusLabel.Text = "Started Spinning";
                statusLabel.BackColor = Color.Blue;

            }
            else
            {
                isRunning = false;
                windingButton.Text = "Start Winding";
                updateData();
                statusLabel.Text = "Stopped Winding";
                statusLabel.BackColor = Color.Gray;
            }

        }

        private float parseFloat(TextBox TextBox)
        {
            if (float.TryParse(TextBox.Text, out stringConversion))
            {
                return stringConversion;
            }
            else
            {
                statusLabel.Text = "ERROR: One or more input values cannot be parsed, make sure all of them are float or integer numbers.";
                statusLabel.BackColor = Color.Red;
                return 0;
            }
        }

        private void InitChart() //initializing the chart
        {
            DataChart.Parent = this;
            //DataChart.Dock = DockStyle.Fill;
            ChartArea chartArea1 = new ChartArea();
            DataChart.ChartAreas.Add(chartArea1);
            DataChart.Titles.Clear();
            Title title = DataChart.Titles.Add("Winding Speed");


            DataChart.ChartAreas[0].AxisX.IsStartedFromZero = false; //in case we get negative number
            DataChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 1; //no grids
            DataChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 1;
            DataChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            DataChart.ChartAreas[0].AxisX.MinorGrid.LineColor = Color.Gray;
            DataChart.ChartAreas[0].AxisX.Title = "Elapsed Time (s)"; //name of the x-y axis
            DataChart.ChartAreas[0].AxisY.Title = "Winding Speed (m/min)";
            DataChart.ChartAreas[0].AxisX.Enabled = AxisEnabled.True;
            DataChart.ChartAreas[0].AxisY.Enabled = AxisEnabled.True;
            DataChart.ChartAreas[0].CursorX.AutoScroll = true;
            DataChart.BringToFront();

            DataChart.Location = new Point(330, 50);
            DataChart.Size = new Size(450, 240);


            DataChart.Series.Add(winderSpeed);

            // Set the chart type for the series (e.g. Line, Bar, Pie, etc.)
            winderSpeed.ChartType = SeriesChartType.Line;
            winderSpeed.Color = Color.Red;

            // Add data points to the series (x,y)
            winderSpeed.Points.AddXY(0, 0);

            // Refresh the chart
            DataChart.Refresh();

            //Check the MSDN documentation!

            //series for the channel1
            Series series = new Series()
            {
                Name = "Channel1",
                Color = System.Drawing.Color.Black,
                ChartType = SeriesChartType.FastLine,
                IsXValueIndexed = true
            };

            DataChart.Series.Add(series);

        }

        private void runningChart_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateData();

            statusLabel.Text = "Data Updated Successfully";
            statusLabel.BackColor = Color.Blue;
        }

        public void updateData()
        {
            string sendData = parseFloat(speed) + "," + parseFloat(diameter) + "," + parseFloat(spacing) + "," + ReverseTurning.Checked.ToString() + "," + isRunning.ToString() + "," + isDisconnect.ToString() + ",";
            port.WriteLine(sendData);
        }

        private void clearLog_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear the log data?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                winderSpeed.Points.Clear();
                DataChart.Refresh();
                logData.Clear();
                statusLabel.Text = "Log Cleared";
                statusLabel.BackColor= Color.Blue;
                // perform the action
            }

        }
        public void WriteMatrixToCsv(List<string> logData, string filename)
        {
            var csv = new StringBuilder();
            try
            {
                string[] output = logData.ToArray();
                csv.AppendLine("Time,MainMotorPower,MicrostepMode,RPM,StepperSpeed,DirectionSwitch,RecordedLinearSpeed");
                for (int i = 0; i < logData.Count(); i++)
                {
                    csv.Append(output[i]);
                }
                File.WriteAllText(filename, csv.ToString());
                
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Data could not be written to the CSV file.";
                statusLabel.BackColor = Color.Red;
                return;
            }

            statusLabel.Text = "Log successfully saved at: " + filename;
            statusLabel.BackColor = Color.Blue;
        }

        private void exportLog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            // Set the initial selected folder
            folderBrowserDialog1.SelectedPath = @"C:\";

            // Show the dialog and get the result
            DialogResult result = folderBrowserDialog1.ShowDialog();
            string saveNameFolder=@"c:/";
            // Check if the user clicked the OK button
            if (result == DialogResult.OK)
            {
                // Get the selected folder path
                saveNameFolder = folderBrowserDialog1.SelectedPath;

                // Use the selected folder path to save the file
                // ...
            }
            string saveName = saveNameFolder + "\\SpinningLog" + DateTime.Now.ToString("yyyy-MM-dd__HH-mm-ss") + ".csv";
            WriteMatrixToCsv(logData, saveName);

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void speed_TextChanged(object sender, EventArgs e)
        {

        }

        private void diameter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




