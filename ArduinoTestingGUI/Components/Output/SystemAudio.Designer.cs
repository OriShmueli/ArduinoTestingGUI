namespace ArduinoTestingGUI.Components.Output
{
    partial class SystemAudio
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
            this.components = new System.ComponentModel.Container();
            this.ComponentTitleLabel = new System.Windows.Forms.Label();
            this.AudioDevicesComboBox = new System.Windows.Forms.ComboBox();
            this.AvailbleDevicesLabel = new System.Windows.Forms.Label();
            this.AudioDisplayProgressBar = new System.Windows.Forms.ProgressBar();
            this.ControlID = new System.Windows.Forms.Label();
            this.RemoveComponentButton = new System.Windows.Forms.Button();
            this.AudioTimer = new System.Windows.Forms.Timer(this.components);
            this.NumLabel = new System.Windows.Forms.Label();
            this.SerialDataLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComponentTitleLabel
            // 
            this.ComponentTitleLabel.AutoSize = true;
            this.ComponentTitleLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ComponentTitleLabel.Location = new System.Drawing.Point(4, 4);
            this.ComponentTitleLabel.Name = "ComponentTitleLabel";
            this.ComponentTitleLabel.Size = new System.Drawing.Size(100, 20);
            this.ComponentTitleLabel.TabIndex = 0;
            this.ComponentTitleLabel.Text = "System Audio";
            // 
            // AudioDevicesComboBox
            // 
            this.AudioDevicesComboBox.FormattingEnabled = true;
            this.AudioDevicesComboBox.Location = new System.Drawing.Point(6, 60);
            this.AudioDevicesComboBox.Name = "AudioDevicesComboBox";
            this.AudioDevicesComboBox.Size = new System.Drawing.Size(299, 21);
            this.AudioDevicesComboBox.TabIndex = 1;
            // 
            // AvailbleDevicesLabel
            // 
            this.AvailbleDevicesLabel.AutoSize = true;
            this.AvailbleDevicesLabel.Location = new System.Drawing.Point(3, 40);
            this.AvailbleDevicesLabel.Name = "AvailbleDevicesLabel";
            this.AvailbleDevicesLabel.Size = new System.Drawing.Size(93, 13);
            this.AvailbleDevicesLabel.TabIndex = 2;
            this.AvailbleDevicesLabel.Text = "Available devices:";
            // 
            // AudioDisplayProgressBar
            // 
            this.AudioDisplayProgressBar.Location = new System.Drawing.Point(136, 4);
            this.AudioDisplayProgressBar.Name = "AudioDisplayProgressBar";
            this.AudioDisplayProgressBar.Size = new System.Drawing.Size(166, 36);
            this.AudioDisplayProgressBar.TabIndex = 3;
            // 
            // ControlID
            // 
            this.ControlID.AutoSize = true;
            this.ControlID.Location = new System.Drawing.Point(8, 27);
            this.ControlID.Name = "ControlID";
            this.ControlID.Size = new System.Drawing.Size(0, 13);
            this.ControlID.TabIndex = 4;
            // 
            // RemoveComponentButton
            // 
            this.RemoveComponentButton.Location = new System.Drawing.Point(240, 87);
            this.RemoveComponentButton.Name = "RemoveComponentButton";
            this.RemoveComponentButton.Size = new System.Drawing.Size(62, 23);
            this.RemoveComponentButton.TabIndex = 5;
            this.RemoveComponentButton.Text = "Remove";
            this.RemoveComponentButton.UseVisualStyleBackColor = true;
            this.RemoveComponentButton.Click += new System.EventHandler(this.RemoveComponentButton_Click);
            // 
            // AudioTimer
            // 
            this.AudioTimer.Enabled = true;
            this.AudioTimer.Interval = 10;
            this.AudioTimer.Tick += new System.EventHandler(this.AudioTimer_Tick);
            // 
            // NumLabel
            // 
            this.NumLabel.AutoSize = true;
            this.NumLabel.Location = new System.Drawing.Point(11, 96);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(35, 13);
            this.NumLabel.TabIndex = 6;
            this.NumLabel.Text = "label1";
            // 
            // SerialDataLabel
            // 
            this.SerialDataLabel.AutoSize = true;
            this.SerialDataLabel.Location = new System.Drawing.Point(121, 92);
            this.SerialDataLabel.Name = "SerialDataLabel";
            this.SerialDataLabel.Size = new System.Drawing.Size(35, 13);
            this.SerialDataLabel.TabIndex = 7;
            this.SerialDataLabel.Text = "label1";
            // 
            // SystemAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SerialDataLabel);
            this.Controls.Add(this.NumLabel);
            this.Controls.Add(this.RemoveComponentButton);
            this.Controls.Add(this.ControlID);
            this.Controls.Add(this.AudioDisplayProgressBar);
            this.Controls.Add(this.AvailbleDevicesLabel);
            this.Controls.Add(this.AudioDevicesComboBox);
            this.Controls.Add(this.ComponentTitleLabel);
            this.Name = "SystemAudio";
            this.Size = new System.Drawing.Size(310, 113);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ComponentTitleLabel;
        private System.Windows.Forms.ComboBox AudioDevicesComboBox;
        private System.Windows.Forms.Label AvailbleDevicesLabel;
        private System.Windows.Forms.ProgressBar AudioDisplayProgressBar;
        private System.Windows.Forms.Label ControlID;
        private System.Windows.Forms.Button RemoveComponentButton;
        private System.Windows.Forms.Timer AudioTimer;
        private System.Windows.Forms.Label NumLabel;
        private System.Windows.Forms.Label SerialDataLabel;
    }
}
