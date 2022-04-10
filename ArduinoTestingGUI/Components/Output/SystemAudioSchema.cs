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
    public partial class SystemAudioSchema : UserControl
    {
        static SystemAudioSchema _instance;

        public static SystemAudioSchema systemAudioSchema
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new SystemAudioSchema();
                }
                return _instance;
            }
        }

        public SystemAudioSchema()
        {
            InitializeComponent();
        }

        public string Title { get; set; }

        private void TitleSchemaTextBox_TextChanged(object sender, EventArgs e)
        {
            Title = TitleSchemaTextBox.Text;
        }
    }
}
