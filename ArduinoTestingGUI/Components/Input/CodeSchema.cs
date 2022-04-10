using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoTestingGUI.Components.Input
{
    public partial class CodeSchema : UserControl
    {
        private static CodeSchema _instance;

        public static CodeSchema codeSchema
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CodeSchema();
                }

                return _instance;
            }
            
        }

        public CodeSchema()
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
