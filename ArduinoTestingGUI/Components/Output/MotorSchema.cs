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
    public partial class MotorSchema : UserControl
    {
        static MotorSchema _motorSchema;

        public static MotorSchema motorSchema
        {
            get
            {
                if(_motorSchema == null)
                {
                    _motorSchema = new MotorSchema();
                }
                return _motorSchema;
            }
        }

        public MotorSchema()
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
