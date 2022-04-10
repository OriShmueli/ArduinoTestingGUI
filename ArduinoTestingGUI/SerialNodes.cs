using ArduinoTestingGUI.Components.Output;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArduinoTestingGUI.Components.Input;
using System.Windows;
using ArduinoTestingGUI.Components.Other;
using ArduinoTestingGUI.SaveSystem;

namespace ArduinoTestingGUI
{
    public partial class MainWindow : Form
    {
        static SerialPortConnection spc = new SerialPortConnection();

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void MainWindow_Load(object sender, EventArgs e)
        {
            foreach(string port in spc.GetPortsNames())
            {
                PortSelectionComboBox.Items.Add(port);
            }
        }

        private void ApplySettingsButton_Click(object sender, EventArgs e)
        {
            
            ConnectButton.Enabled = true;

            spc.DataBits = (int)DataBitsNumericUpDown.Value;
            
            if (PortSelectionComboBox.SelectedItem == null)
            {
                //MessageBox.Show("Please select COM port");
            }
            else
            {
                spc.CurrentPort = PortSelectionComboBox.Text;
            }

            if (BaudRateComboBox.SelectedItem == null)
            {
                //MessageBox.Show("Please select baud rate");
            }
            else
            {
                spc.BaudRate = int.Parse(BaudRateComboBox.Text);
            }
            
            List<RadioButton> ParityRadioButtons = new List<RadioButton>()
            {
                NoneParityRadioButton,
                OddParityRadioButton,
                EvenParityRadioButton,
                MarkParityRadioButton,
                SpaceParityRadioButton
            };

            List<RadioButton> StopBitsRadioButton = new List<RadioButton>()
            {
                NoneStopBitsRadioButton,
                OneStopBitsRadioButton,
                OnePointFiveStopBitsRadioButton,
                TwoStopBitsRadioButton
            };

            List<RadioButton> HandshakeRadioButton = new List<RadioButton>()
            {
                NoneHandshakeRadioButton,
                XonXoffHandshakeRadioButton,
                RequestToSendHandshakeRadioButton,
                RequestToSendXOnXOffHandshakeRadioButton
            };

            for (int i = 0; i < ParityRadioButtons.Count; i++)
            {
                if (ParityRadioButtons[i].Checked == true)
                {
                    spc.Parity = (Parity)i;
                    //MessageBox.Show("Parity Radio button i:" + i);
                }
            }

            for (int i = 0; i < StopBitsRadioButton.Count; i++)
            {
                if(StopBitsRadioButton[i].Checked == true)
                {
                    spc.StopBits = (StopBits)i;
                    //MessageBox.Show("Stop bits Radio button i:" + i);
                }
            }

            for (int i = 0; i < HandshakeRadioButton.Count; i++)
            {
                if(HandshakeRadioButton[i].Checked == true)
                {
                    spc.HandShake = (Handshake)i;
                   //MessageBox.Show("HandShake Radio button i:" + i);
                }
            }
        }

        private void DataBitsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if(DataBitsNumericUpDown.Value == 8)
            {
                DataBitsDefaultLabel.Visible = true;
            }
            else
            {
                DataBitsDefaultLabel.Visible = false;
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if(PortSelectionComboBox.SelectedItem == null)
            {
                //MessageBox.Show("Please select COM port");
            }
            else
            {
                if (spc.Connect())
                {
                    ConnectButton.Enabled = false;
                    DisconnectButton.Enabled = true;
                    DefaultSettingsButton.Enabled = false;
                    ApplySettingsButton.Enabled = false;
                    ComponenetsPanel.Enabled = true;
                }
                else
                {
                    //MessageBox.Show("error");
                }
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            spc.Disconnect();
            ConnectButton.Enabled = false;
            DisconnectButton.Enabled = false;
            DefaultSettingsButton.Enabled = true;
            ApplySettingsButton.Enabled = true;
            ComponenetsPanel.Enabled = false;
        }

        private void DefaultSettingsButton_Click(object sender, EventArgs e)
        {
            NoneParityRadioButton.Checked = true;
            OneStopBitsRadioButton.Checked = true;
            RequestToSendXOnXOffHandshakeRadioButton.Checked = true;
            BaudRateComboBox.SelectedItem = "9600";
            DataBitsNumericUpDown.Value = 8;
            PortSelectionComboBox.SelectedItem = spc.GetPortsNames()[0];
        }

        private void AddInputComponentButton_Click(object sender, EventArgs e)
        {
            switch (InputConponentComboBox.SelectedIndex)
            {
                case 3:
                    Code code = new Code { Title = CodeSchema.codeSchema.Title };
                    ComponentsInputFlowLayoutPanel.Controls.Add(code);
                    TestSystem.AddInput(code);
                    break;
            }
        }

        private void AddOutputComponentButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            switch (OutputComponentsComboBox.SelectedIndex)
            {
                case 0:
                    ComponentsOutputFlowLayoutPanel.Controls.Add(new Led { Title = LedSchema.ledSchema.Title, Id = random.Next(1000, 9999) });
                    break;

                case 1:
                    ComponentsOutputFlowLayoutPanel.Controls.Add(new Motor { Title = MotorSchema.motorSchema.Title, Id = random.Next(1000, 9999) });
                    break;

                case 4:
                    ComponentsOutputFlowLayoutPanel.Controls.Add(new SystemAudio { Title = SystemAudioSchema.systemAudioSchema.Title, Id = random.Next(1000, 9999) });
                    break;
            }
        }

        private Control lastControl;
        private void AddSchemaToOutputMakerPanel(Control control)
        {
            if (lastControl != control)
            {
                ComponentOutputPanel.Controls.Remove(lastControl);
            }

            if (!ComponentOutputPanel.Controls.Contains(control))
            {
                lastControl = control;
                ComponentOutputPanel.Controls.Add(control);
            }
        }

        private void AddSchemaToInputMakerPanel(Control control)
        {
            if (lastControl != control)
            {
                ComponentInputPanel.Controls.Remove(lastControl);
            }

            if (!ComponentInputPanel.Controls.Contains(control))
            {
                lastControl = control;
                ComponentInputPanel.Controls.Add(control);
            }
        }

        private void OutputComponentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (OutputComponentsComboBox.SelectedIndex)
            {
                case 0:
                    AddSchemaToOutputMakerPanel(LedSchema.ledSchema);
                    break;

                case 1:
                    AddSchemaToOutputMakerPanel(MotorSchema.motorSchema);
                    break;

                case 4:
                    AddSchemaToOutputMakerPanel(SystemAudioSchema.systemAudioSchema);
                    break;
            }
        }

        private void InputComponentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (InputConponentComboBox.SelectedIndex)
            {
                case 3:
                    AddSchemaToInputMakerPanel(CodeSchema.codeSchema);
                    break;
            }
        }

        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size.Width >= 1280)
            {

            }
            else
            {

            }

            if(HiddenFeaturesFlowLayoutPanel.Size.Height >= 150)
            {
                SaveJsonButton.Enabled = false;
                HiddenFeaturesFlowLayoutPanel.Controls.Add(Save.save);
            }
            else
            {
                HiddenFeaturesFlowLayoutPanel.Controls.Remove(Save.save);
                
                SaveJsonButton.Enabled = true;
            }

            if (HiddenFeaturesFlowLayoutPanel.Size.Height >= 300)
            {
                HiddenFeaturesFlowLayoutPanel.Controls.Add(Open.open);
                OpenJsonButton.Enabled = false;
            }
            else
            {
                HiddenFeaturesFlowLayoutPanel.Controls.Remove(Open.open);
                OpenJsonButton.Enabled = true;
            }
        }

        private void SaveJsonButton_Click(object sender, EventArgs e)
        {
            SaveProject saveProject = new SaveProject();
            saveProject.Show();
        }

        private void OpenJsonButton_Click(object sender, EventArgs e)
        {
            OpenProject openProject = new OpenProject();
            openProject.Show();
        }
    }
}
