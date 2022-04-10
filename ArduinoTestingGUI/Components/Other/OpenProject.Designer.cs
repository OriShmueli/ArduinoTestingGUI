
namespace ArduinoTestingGUI.Components.Other
{
    partial class OpenProject
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
            this.OpenPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // OpenPanel
            // 
            this.OpenPanel.Location = new System.Drawing.Point(1, 0);
            this.OpenPanel.Name = "OpenPanel";
            this.OpenPanel.Size = new System.Drawing.Size(467, 150);
            this.OpenPanel.TabIndex = 0;
            // 
            // OpenProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 152);
            this.Controls.Add(this.OpenPanel);
            this.Name = "OpenProject";
            this.Text = "OpenProject";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpenProject_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OpenPanel;
    }
}