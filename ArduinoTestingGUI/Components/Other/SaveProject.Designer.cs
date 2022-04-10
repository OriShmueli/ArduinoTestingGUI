
namespace ArduinoTestingGUI.Components.Other
{
    partial class SaveProject
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SavePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SavePanel
            // 
            this.SavePanel.BackColor = System.Drawing.SystemColors.Control;
            this.SavePanel.Location = new System.Drawing.Point(1, 1);
            this.SavePanel.Name = "SavePanel";
            this.SavePanel.Size = new System.Drawing.Size(467, 150);
            this.SavePanel.TabIndex = 0;
            // 
            // SaveProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(469, 152);
            this.Controls.Add(this.SavePanel);
            this.Name = "SaveProject";
            this.Text = "SaveProject";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveProject_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SavePanel;
    }
}