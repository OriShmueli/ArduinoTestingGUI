namespace ArduinoTestingGUI.Components.Output
{
    partial class MotorSchema
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleSchemaTextBox = new System.Windows.Forms.TextBox();
            this.Motor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleSchemaTextBox
            // 
            this.TitleSchemaTextBox.Location = new System.Drawing.Point(4, 4);
            this.TitleSchemaTextBox.Name = "TitleSchemaTextBox";
            this.TitleSchemaTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleSchemaTextBox.TabIndex = 0;
            this.TitleSchemaTextBox.TextChanged += new System.EventHandler(this.TitleSchemaTextBox_TextChanged);
            // 
            // Motor
            // 
            this.Motor.AutoSize = true;
            this.Motor.Location = new System.Drawing.Point(111, 10);
            this.Motor.Name = "Motor";
            this.Motor.Size = new System.Drawing.Size(34, 13);
            this.Motor.TabIndex = 1;
            this.Motor.Text = "Motor";
            // 
            // MotorSchema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Motor);
            this.Controls.Add(this.TitleSchemaTextBox);
            this.Name = "MotorSchema";
            this.Size = new System.Drawing.Size(442, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleSchemaTextBox;
        private System.Windows.Forms.Label Motor;
    }
}
