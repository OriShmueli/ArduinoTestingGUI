
namespace ArduinoTestingGUI.Components.Other
{
    partial class Open
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
            this.OpenJsonFileButton = new System.Windows.Forms.Button();
            this.OpenProjectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileNameShowLabel = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.OpenGroupBox = new System.Windows.Forms.GroupBox();
            this.OpenGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenJsonFileButton
            // 
            this.OpenJsonFileButton.Location = new System.Drawing.Point(6, 31);
            this.OpenJsonFileButton.Name = "OpenJsonFileButton";
            this.OpenJsonFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenJsonFileButton.TabIndex = 4;
            this.OpenJsonFileButton.Text = "Open File";
            this.OpenJsonFileButton.UseVisualStyleBackColor = true;
            this.OpenJsonFileButton.Click += new System.EventHandler(this.OpenJsonFileButton_Click_1);
            // 
            // OpenProjectOpenFileDialog
            // 
            this.OpenProjectFileDialog.FileName = "openFileDialog1";
            // 
            // FileNameShowLabel
            // 
            this.FileNameShowLabel.AutoSize = true;
            this.FileNameShowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FileNameShowLabel.Location = new System.Drawing.Point(166, 38);
            this.FileNameShowLabel.Name = "FileNameShowLabel";
            this.FileNameShowLabel.Size = new System.Drawing.Size(102, 16);
            this.FileNameShowLabel.TabIndex = 6;
            this.FileNameShowLabel.Text = "some json file... ";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FileNameLabel.Location = new System.Drawing.Point(87, 38);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(73, 16);
            this.FileNameLabel.TabIndex = 5;
            this.FileNameLabel.Text = "File Name:";
            // 
            // OpenGroupBox
            // 
            this.OpenGroupBox.Controls.Add(this.OpenJsonFileButton);
            this.OpenGroupBox.Controls.Add(this.FileNameShowLabel);
            this.OpenGroupBox.Controls.Add(this.FileNameLabel);
            this.OpenGroupBox.Location = new System.Drawing.Point(0, 0);
            this.OpenGroupBox.Name = "OpenGroupBox";
            this.OpenGroupBox.Size = new System.Drawing.Size(467, 150);
            this.OpenGroupBox.TabIndex = 7;
            this.OpenGroupBox.TabStop = false;
            this.OpenGroupBox.Text = "Open Project";
            // 
            // Open
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OpenGroupBox);
            this.Name = "Open";
            this.Size = new System.Drawing.Size(467, 150);
            this.OpenGroupBox.ResumeLayout(false);
            this.OpenGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenJsonFileButton;
        private System.Windows.Forms.OpenFileDialog OpenProjectFileDialog;
        private System.Windows.Forms.Label FileNameShowLabel;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.GroupBox OpenGroupBox;
    }
}
