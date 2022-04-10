
namespace ArduinoTestingGUI.Components.Other
{
    partial class Save
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
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileNameShowLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveProjectFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveAsButton = new System.Windows.Forms.Button();
            this.SaveGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FileNameLabel.Location = new System.Drawing.Point(85, 122);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(73, 16);
            this.FileNameLabel.TabIndex = 0;
            this.FileNameLabel.Text = "File Name:";
            // 
            // FileNameShowLabel
            // 
            this.FileNameShowLabel.AutoSize = true;
            this.FileNameShowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FileNameShowLabel.Location = new System.Drawing.Point(164, 122);
            this.FileNameShowLabel.Name = "FileNameShowLabel";
            this.FileNameShowLabel.Size = new System.Drawing.Size(102, 16);
            this.FileNameShowLabel.TabIndex = 1;
            this.FileNameShowLabel.Text = "some json file... ";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(6, 19);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveGroupBox
            // 
            this.SaveGroupBox.Controls.Add(this.SaveAsButton);
            this.SaveGroupBox.Controls.Add(this.FileNameShowLabel);
            this.SaveGroupBox.Controls.Add(this.FileNameLabel);
            this.SaveGroupBox.Controls.Add(this.SaveButton);
            this.SaveGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SaveGroupBox.Name = "SaveGroupBox";
            this.SaveGroupBox.Size = new System.Drawing.Size(467, 150);
            this.SaveGroupBox.TabIndex = 4;
            this.SaveGroupBox.TabStop = false;
            this.SaveGroupBox.Text = "Save Project";
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.Location = new System.Drawing.Point(6, 119);
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(75, 23);
            this.SaveAsButton.TabIndex = 3;
            this.SaveAsButton.Text = "Save As";
            this.SaveAsButton.UseVisualStyleBackColor = true;
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // Save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.SaveGroupBox);
            this.Name = "Save";
            this.Size = new System.Drawing.Size(467, 150);
            this.SaveGroupBox.ResumeLayout(false);
            this.SaveGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label FileNameShowLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox SaveGroupBox;
        private System.Windows.Forms.SaveFileDialog SaveProjectFileDialog;
        private System.Windows.Forms.Button SaveAsButton;
    }
}
