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
    public partial class LedSchema : UserControl
    {
        static LedSchema _instance;

        public static LedSchema ledSchema
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new LedSchema();
                }
                return _instance;
            }
        }

        public LedSchema()
        {
            InitializeComponent();
        }

        private void LedSchema_Load(object sender, EventArgs e)
        {

        }

        private void TitleSchemaTextBox_TextChanged(object sender, EventArgs e)
        {
             Title = TitleSchemaTextBox.Text;
        }

        public string Title { get; set; } 
    }
}
