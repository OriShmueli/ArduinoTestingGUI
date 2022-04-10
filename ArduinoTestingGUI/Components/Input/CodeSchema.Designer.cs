namespace ArduinoTestingGUI.Components.Input
{
    partial class CodeSchema
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
            // CodeSchema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TitleSchemaTextBox);
            this.Name = "CodeSchema";
            this.Size = new System.Drawing.Size(442, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleSchemaTextBox;
    }
}
