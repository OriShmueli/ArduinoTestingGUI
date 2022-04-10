using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoTestingGUI.Components.Input
{
    public partial class Code : UserControl
    {
        readonly SerialPortConnection spc = new SerialPortConnection();

        public Code()
        {
            InitializeComponent();
            SerialPortConnection.SerialPort.DataReceived += SerialPort_DataReceived;
        }

        private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            InputDataTextBox.Text = spc.MultiData(int.Parse(PlaceInDataArrayNumericUpDown.Text));
        }

        public string Title { get => ComponentTitleLabel.Text; set => ComponentTitleLabel.Text = value; }
        public int Id { get; set; }

        private void RemoveComponentButton_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
