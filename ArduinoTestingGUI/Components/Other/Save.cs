using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArduinoTestingGUI.SaveSystem;
using Newtonsoft.Json;

namespace ArduinoTestingGUI.Components.Other
{
    public partial class Save : UserControl
    {
        static Save _instance;

        public static Save save
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Save();
                }
                return _instance;
            }
        }

        public Save()
        {
            InitializeComponent();
            SaveProjectFileDialog.Filter = "json files|*.json"; //txt files (*.txt)|*.txt|All files (*.*)|*.*      json files (*.json)|*.json
            SaveProjectFileDialog.Title = "Save Json File";
            //SaveProjectFileDialog.CheckFileExists = true;
            //SaveProjectFileDialog.CheckPathExists = true;
            SaveProjectFileDialog.RestoreDirectory = true;
            //SaveProjectFileDialog.FileName = "project1.json";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {//FileNameShowLabel.Text = SaveProjectFileDialog.FileName;
            try
            {
                TestSystem.writeJson(SaveProjectFileDialog.FileName);
            }
            catch
            {
                MessageBox.Show("error");
            }
            
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            SaveProjectFileDialog.ShowDialog();
            TestSystem.writeJson(SaveProjectFileDialog.FileName);
            /*try
            {
                File.WriteAllText(SaveProjectFileDialog.FileName, "Name");
            }
            catch
            {

            }*/
        }
    }
}
