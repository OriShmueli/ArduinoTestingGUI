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
    public partial class SaveProject : Form
    {
        public SaveProject()
        {
            InitializeComponent();
            SavePanel.Controls.Add(Save.save);
        }

        private void SaveProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePanel.Controls.Remove(Save.save);
        }
    }
}
