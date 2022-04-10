using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoTestingGUI.Components.Other
{
    public partial class OpenProject : Form
    {
        public OpenProject()
        {
            InitializeComponent();

            OpenPanel.Controls.Add(Open.open);
        }

        private void OpenProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            OpenPanel.Controls.Remove(Open.open);
        }
    }
}
