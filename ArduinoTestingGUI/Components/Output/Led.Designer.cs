namespace ArduinoTestingGUI.Components.Output
{
    partial class Led
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
            this.OnLedButton = new System.Windows.Forms.Button();
            this.OffLedButton = new System.Windows.Forms.Button();
            this.OnCodeLedLabel = new System.Windows.Forms.Label();
            this.OffCodeLedLabel = new System.Windows.Forms.Label();
            this.OnLedCodetextBox = new System.Windows.Forms.TextBox();
            this.OffLedCodetextBox = new System.Windows.Forms.TextBox();
            this.ComponentTitleLabel = new System.Windows.Forms.Label();
            this.ControlID = new System.Windows.Forms.Label();
            this.RemoveComponentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OnLedButton
            // 
            this.OnLedButton.Location = new System.Drawing.Point(3, 28);
            this.OnLedButton.Name = "OnLedButton";
            this.OnLedButton.Size = new System.Drawing.Size(75, 23);
            this.OnLedButton.TabIndex = 0;
            this.OnLedButton.Text = "On";
            this.OnLedButton.UseVisualStyleBackColor = true;
            this.OnLedButton.Click += new System.EventHandler(this.OnLedButton_Click);
            // 
            // OffLedButton
            // 
            this.OffLedButton.Location = new System.Drawing.Point(3, 57);
            this.OffLedButton.Name = "OffLedButton";
            this.OffLedButton.Size = new System.Drawing.Size(75, 23);
            this.OffLedButton.TabIndex = 1;
            this.OffLedButton.Text = "Off";
            this.OffLedButton.UseVisualStyleBackColor = true;
            this.OffLedButton.Click += new System.EventHandler(this.OffLedButton_Click);
            // 
            // OnCodeLedLabel
            // 
            this.OnCodeLedLabel.AutoSize = true;
            this.OnCodeLedLabel.Location = new System.Drawing.Point(84, 33);
            this.OnCodeLedLabel.Name = "OnCodeLedLabel";
            this.OnCodeLedLabel.Size = new System.Drawing.Size(48, 13);
            this.OnCodeLedLabel.TabIndex = 2;
            this.OnCodeLedLabel.Text = "On code";
            // 
            // OffCodeLedLabel
            // 
            this.OffCodeLedLabel.AutoSize = true;
            this.OffCodeLedLabel.Location = new System.Drawing.Point(84, 62);
            this.OffCodeLedLabel.Name = "OffCodeLedLabel";
            this.OffCodeLedLabel.Size = new System.Drawing.Size(48, 13);
            this.OffCodeLedLabel.TabIndex = 3;
            this.OffCodeLedLabel.Text = "Off code";
            // 
            // OnLedCodetextBox
            // 
            this.OnLedCodetextBox.Location = new System.Drawing.Point(139, 30);
            this.OnLedCodetextBox.Name = "OnLedCodetextBox";
            this.OnLedCodetextBox.Size = new System.Drawing.Size(30, 20);
            this.OnLedCodetextBox.TabIndex = 4;
            // 
            // OffLedCodetextBox
            // 
            this.OffLedCodetextBox.Location = new System.Drawing.Point(139, 59);
            this.OffLedCodetextBox.Name = "OffLedCodetextBox";
            this.OffLedCodetextBox.Size = new System.Drawing.Size(30, 20);
            this.OffLedCodetextBox.TabIndex = 5;
            // 
            // ComponentTitleLabel
            // 
            this.ComponentTitleLabel.AutoSize = true;
            this.ComponentTitleLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComponentTitleLabel.Location = new System.Drawing.Point(3, 5);
            this.ComponentTitleLabel.Name = "ComponentTitleLabel";
            this.ComponentTitleLabel.Size = new System.Drawing.Size(33, 20);
            this.ComponentTitleLabel.TabIndex = 6;
            this.ComponentTitleLabel.Text = "Led";
            // 
            // ControlID
            // 
            this.ControlID.AutoSize = true;
            this.ControlID.Location = new System.Drawing.Point(42, 11);
            this.ControlID.Name = "ControlID";
            this.ControlID.Size = new System.Drawing.Size(0, 13);
            this.ControlID.TabIndex = 7;
            // 
            // RemoveComponentButton
            // 
            this.RemoveComponentButton.Location = new System.Drawing.Point(245, 57);
            this.RemoveComponentButton.Name = "RemoveComponentButton";
            this.RemoveComponentButton.Size = new System.Drawing.Size(62, 23);
            this.RemoveComponentButton.TabIndex = 8;
            this.RemoveComponentButton.Text = "Remove";
            this.RemoveComponentButton.UseVisualStyleBackColor = true;
            this.RemoveComponentButton.Click += new System.EventHandler(this.RemoveComponentButton_Click);
            // 
            // Led
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveComponentButton);
            this.Controls.Add(this.ControlID);
            this.Controls.Add(this.ComponentTitleLabel);
            this.Controls.Add(this.OffLedCodetextBox);
            this.Controls.Add(this.OnLedCodetextBox);
            this.Controls.Add(this.OffCodeLedLabel);
            this.Controls.Add(this.OnCodeLedLabel);
            this.Controls.Add(this.OffLedButton);
            this.Controls.Add(this.OnLedButton);
            this.Name = "Led";
            this.Size = new System.Drawing.Size(310, 83);
            this.Load += new System.EventHandler(this.Led_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OnLedButton;
        private System.Windows.Forms.Button OffLedButton;
        private System.Windows.Forms.Label OnCodeLedLabel;
        private System.Windows.Forms.Label OffCodeLedLabel;
        private System.Windows.Forms.TextBox OnLedCodetextBox;
        private System.Windows.Forms.TextBox OffLedCodetextBox;
        private System.Windows.Forms.Label ComponentTitleLabel;
        private System.Windows.Forms.Label ControlID;
        private System.Windows.Forms.Button RemoveComponentButton;
    }
}
