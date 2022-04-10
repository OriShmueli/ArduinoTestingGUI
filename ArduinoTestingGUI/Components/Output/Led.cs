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
    public partial class Led : UserControl
    {
        //MainWindow mainWindow = new MainWindow();
        SerialPortConnection spc = new SerialPortConnection();

        public Led()
        {
            InitializeComponent();
        }

        /*public Led(string name)
        {
            ComponentTitleLabel.Text = name;
        }*/

        public string Title { get => ComponentTitleLabel.Text; set => ComponentTitleLabel.Text = value; }

        public int Id { get => int.Parse(ControlID.Text); set => ControlID.Text = value.ToString(); }

        private void Led_Load(object sender, EventArgs e)
        {

        }

        private void OnLedButton_Click(object sender, EventArgs e)
        {
            spc.SendData(OnLedCodetextBox.Text);
            //MessageBox.Show(OnLedCodetextBox.Text);
            
        }

        private void OffLedButton_Click(object sender, EventArgs e)
        {
            spc.SendData(OffLedCodetextBox.Text);
        }

        private void RemoveComponentButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
