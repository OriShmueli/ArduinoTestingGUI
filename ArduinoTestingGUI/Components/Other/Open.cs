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
    public partial class Open : UserControl
    {
        private static Open _instace;

        public static Open open
        {
            get
            {
                if(_instace == null)
                {
                    _instace = new Open();
                }
                return _instace;
            }
        }

        public Open()
        {
            InitializeComponent();
            OpenProjectFileDialog.Filter = "json files (*.json)|*.json"; //txt files (*.txt)|*.txt|All files (*.*)|*.*
            OpenProjectFileDialog.Title = "Open Json File";
            OpenProjectFileDialog.CheckFileExists = true;
            OpenProjectFileDialog.CheckPathExists = true;
            OpenProjectFileDialog.RestoreDirectory = true;
            OpenProjectFileDialog.FileName = "json file";
        }

        private void OpenJsonFileButton_Click_1(object sender, EventArgs e)
        {
            OpenProjectFileDialog.ShowDialog();

            FileNameShowLabel.Text = OpenProjectFileDialog.FileName;
        }
    }
}
