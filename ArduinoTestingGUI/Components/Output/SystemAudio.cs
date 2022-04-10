using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.CoreAudioApi;

namespace ArduinoTestingGUI.Components.Output
{
    public partial class SystemAudio : UserControl
    {
        SerialPortConnection spc = new SerialPortConnection();

        public SystemAudio()
        {
            InitializeComponent();
            try
            {
                MMDeviceEnumerator devicesEnum = new MMDeviceEnumerator();
                var devices = devicesEnum.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
                AudioDevicesComboBox.Items.AddRange(devices.ToArray());
                startAudio();
            }
            catch
            {

            }
            
        }

        public string Title { get => ComponentTitleLabel.Text; set => ComponentTitleLabel.Text = value; }

        public int Id { get => int.Parse(ControlID.Text); set => ControlID.Text = value.ToString(); }

        private void RemoveComponentButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private int _map(int x, int in_min, int int_max, int out_min, int out_max)
        {
            return (x - in_min) * (out_max - out_min) / (int_max - in_min) + out_min;
        }

        int AudioData = 1;
        int sendAudio;
        //Thread th = new Thread(new ThreadStart());
        Timer timer = new Timer();
        private void AudioTimer_Tick(object sender, EventArgs e)
        {
            
            if (AudioDevicesComboBox.SelectedItem != null)
            {

                var device = (MMDevice)AudioDevicesComboBox.SelectedItem;
                AudioData = (int)Math.Round(device.AudioMeterInformation.MasterPeakValue * 100);
                AudioDisplayProgressBar.Value = AudioData;
                
                if(AudioData > 30)
                {
                    AudioData = 30;
                }
                AudioData = _map(AudioData, 0, 30, 0, 14);
                NumLabel.Text = AudioData.ToString();
                sendAudio = AudioData;
                
            }

            /*spc.GetData();
            SerialDataLabel.Text = spc.GetReceivedData;*/
        }

        public void startAudio()
        {
            timer.Interval = 300;
            timer.Tick += Timer_Tick;
            timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            spc.SendData(sendAudio.ToString());
            
            
        }
    }
}
