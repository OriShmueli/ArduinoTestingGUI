namespace ArduinoTestingGUI.Components.Input
{
    partial class Code
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
            this.InputDataTextBox = new System.Windows.Forms.TextBox();
            this.ComponentTitleLabel = new System.Windows.Forms.Label();
            this.PlaceInDataArrayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DataInLabel = new System.Windows.Forms.Label();
            this.PlaceInArrayLabel = new System.Windows.Forms.Label();
            this.RemoveComponentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceInDataArrayNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // InputDataTextBox
            // 
            this.InputDataTextBox.Location = new System.Drawing.Point(88, 26);
            this.InputDataTextBox.Name = "InputDataTextBox";
            this.InputDataTextBox.Size = new System.Drawing.Size(120, 20);
            this.InputDataTextBox.TabIndex = 0;
            // 
            // ComponentTitleLabel
            // 
            this.ComponentTitleLabel.AutoSize = true;
            this.ComponentTitleLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ComponentTitleLabel.Location = new System.Drawing.Point(4, 4);
            this.ComponentTitleLabel.Name = "ComponentTitleLabel";
            this.ComponentTitleLabel.Size = new System.Drawing.Size(44, 20);
            this.ComponentTitleLabel.TabIndex = 1;
            this.ComponentTitleLabel.Text = "Code";
            // 
            // PlaceInDataArrayNumericUpDown
            // 
            this.PlaceInDataArrayNumericUpDown.Location = new System.Drawing.Point(88, 57);
            this.PlaceInDataArrayNumericUpDown.Name = "PlaceInDataArrayNumericUpDown";
            this.PlaceInDataArrayNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.PlaceInDataArrayNumericUpDown.TabIndex = 2;
            // 
            // DataInLabel
            // 
            this.DataInLabel.AutoSize = true;
            this.DataInLabel.Location = new System.Drawing.Point(8, 33);
            this.DataInLabel.Name = "DataInLabel";
            this.DataInLabel.Size = new System.Drawing.Size(30, 13);
            this.DataInLabel.TabIndex = 3;
            this.DataInLabel.Text = "Data";
            // 
            // PlaceInArrayLabel
            // 
            this.PlaceInArrayLabel.AutoSize = true;
            this.PlaceInArrayLabel.Location = new System.Drawing.Point(11, 59);
            this.PlaceInArrayLabel.Name = "PlaceInArrayLabel";
            this.PlaceInArrayLabel.Size = new System.Drawing.Size(71, 13);
            this.PlaceInArrayLabel.TabIndex = 4;
            this.PlaceInArrayLabel.Text = "Place in array";
            // 
            // RemoveComponentButton
            // 
            this.RemoveComponentButton.Location = new System.Drawing.Point(245, 57);
            this.RemoveComponentButton.Name = "RemoveComponentButton";
            this.RemoveComponentButton.Size = new System.Drawing.Size(62, 23);
            this.RemoveComponentButton.TabIndex = 5;
            this.RemoveComponentButton.Text = "Remove";
            this.RemoveComponentButton.UseVisualStyleBackColor = true;
            this.RemoveComponentButton.Click += new System.EventHandler(this.RemoveComponentButton_Click);
            // 
            // Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveComponentButton);
            this.Controls.Add(this.PlaceInArrayLabel);
            this.Controls.Add(this.DataInLabel);
            this.Controls.Add(this.PlaceInDataArrayNumericUpDown);
            this.Controls.Add(this.ComponentTitleLabel);
            this.Controls.Add(this.InputDataTextBox);
            this.Name = "Code";
            this.Size = new System.Drawing.Size(310, 83);
            ((System.ComponentModel.ISupportInitialize)(this.PlaceInDataArrayNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputDataTextBox;
        private System.Windows.Forms.Label ComponentTitleLabel;
        private System.Windows.Forms.NumericUpDown PlaceInDataArrayNumericUpDown;
        private System.Windows.Forms.Label DataInLabel;
        private System.Windows.Forms.Label PlaceInArrayLabel;
        private System.Windows.Forms.Button RemoveComponentButton;
    }
}
