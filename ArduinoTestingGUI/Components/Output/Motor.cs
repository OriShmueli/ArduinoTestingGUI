using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoTestingGUI.Components.Output
{
    public partial class Motor : UserControl
    {
        private SerialPortConnection spc = new SerialPortConnection();

        public Motor()
        {
            InitializeComponent();
        }

        public string Title { get => ComponentTitleLabel.Text; set => ComponentTitleLabel.Text = value; }
        public int Id { get => int.Parse(ControlID.Text); set => ControlID.Text = value.ToString(); }

        private void StartRotatingButton_Click(object sender, EventArgs e)
        {
            spc.SendData(StartRotatingCodeTextBox.Text);
        }

        private void StopRotatingButton_Click(object sender, EventArgs e)
        {
            spc.SendData(StopRotatingCodeTextBox.Text);
        }

        private void LeftRotateButton_Click(object sender, EventArgs e)
        {
            spc.SendData(LeftRotateCodeTextBox.Text);
        }

        private void RightRotateButton_Click(object sender, EventArgs e)
        {
            spc.SendData(RightRotateCodeTextBox.Text);
        }

        private void RemoveComponentButton_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        
    }
}
