namespace ArduinoTestingGUI
{
    partial class MainWindow
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
            this.ConnectSettingsGrup = new System.Windows.Forms.GroupBox();
            this.DefaultSettingsButton = new System.Windows.Forms.Button();
            this.HandShakeGroupBox = new System.Windows.Forms.GroupBox();
            this.RequestToSendXOnXOffHandshakeRadioButton = new System.Windows.Forms.RadioButton();
            this.RequestToSendHandshakeRadioButton = new System.Windows.Forms.RadioButton();
            this.XonXoffHandshakeRadioButton = new System.Windows.Forms.RadioButton();
            this.NoneHandshakeRadioButton = new System.Windows.Forms.RadioButton();
            this.DataBitsDefaultLabel = new System.Windows.Forms.Label();
            this.StopBitsGroupBox = new System.Windows.Forms.GroupBox();
            this.TwoStopBitsRadioButton = new System.Windows.Forms.RadioButton();
            this.OnePointFiveStopBitsRadioButton = new System.Windows.Forms.RadioButton();
            this.OneStopBitsRadioButton = new System.Windows.Forms.RadioButton();
            this.NoneStopBitsRadioButton = new System.Windows.Forms.RadioButton();
            this.DataBitsLabel = new System.Windows.Forms.Label();
            this.DataBitsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ParitygroupBox = new System.Windows.Forms.GroupBox();
            this.SpaceParityRadioButton = new System.Windows.Forms.RadioButton();
            this.MarkParityRadioButton = new System.Windows.Forms.RadioButton();
            this.EvenParityRadioButton = new System.Windows.Forms.RadioButton();
            this.OddParityRadioButton = new System.Windows.Forms.RadioButton();
            this.NoneParityRadioButton = new System.Windows.Forms.RadioButton();
            this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ApplySettingsButton = new System.Windows.Forms.Button();
            this.PortSelectionLabel = new System.Windows.Forms.Label();
            this.PortSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.ComponentsOutputFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ComponentOutputAddGroupBox = new System.Windows.Forms.GroupBox();
            this.ComponentOutputPanel = new System.Windows.Forms.Panel();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputComponentsComboBox = new System.Windows.Forms.ComboBox();
            this.AddInputComponentButton = new System.Windows.Forms.Button();
            this.ComponentInputAddGroupBox = new System.Windows.Forms.GroupBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.ComponentInputPanel = new System.Windows.Forms.Panel();
            this.InputConponentComboBox = new System.Windows.Forms.ComboBox();
            this.AddOutputComponentButton = new System.Windows.Forms.Button();
            this.ComponentsInputFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.InputComponenetsTitleLabel = new System.Windows.Forms.Label();
            this.OutputComponenetsTitleLabel = new System.Windows.Forms.Label();
            this.ComponenetsPanel = new System.Windows.Forms.Panel();
            this.SaveJsonButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MoreGroupBox = new System.Windows.Forms.GroupBox();
            this.OpenJsonButton = new System.Windows.Forms.Button();
            this.HiddenFeaturesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ConnectSettingsGrup.SuspendLayout();
            this.HandShakeGroupBox.SuspendLayout();
            this.StopBitsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBitsNumericUpDown)).BeginInit();
            this.ParitygroupBox.SuspendLayout();
            this.ComponentOutputAddGroupBox.SuspendLayout();
            this.ComponentInputAddGroupBox.SuspendLayout();
            this.ComponenetsPanel.SuspendLayout();
            this.MoreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectSettingsGrup
            // 
            this.ConnectSettingsGrup.BackColor = System.Drawing.SystemColors.Control;
            this.ConnectSettingsGrup.Controls.Add(this.DefaultSettingsButton);
            this.ConnectSettingsGrup.Controls.Add(this.HandShakeGroupBox);
            this.ConnectSettingsGrup.Controls.Add(this.DataBitsDefaultLabel);
            this.ConnectSettingsGrup.Controls.Add(this.StopBitsGroupBox);
            this.ConnectSettingsGrup.Controls.Add(this.DataBitsLabel);
            this.ConnectSettingsGrup.Controls.Add(this.DataBitsNumericUpDown);
            this.ConnectSettingsGrup.Controls.Add(this.ParitygroupBox);
            this.ConnectSettingsGrup.Controls.Add(this.BaudRateComboBox);
            this.ConnectSettingsGrup.Controls.Add(this.BaudRateLabel);
            this.ConnectSettingsGrup.Controls.Add(this.DisconnectButton);
            this.ConnectSettingsGrup.Controls.Add(this.ConnectButton);
            this.ConnectSettingsGrup.Controls.Add(this.ApplySettingsButton);
            this.ConnectSettingsGrup.Controls.Add(this.PortSelectionLabel);
            this.ConnectSettingsGrup.Controls.Add(this.PortSelectionComboBox);
            this.ConnectSettingsGrup.Location = new System.Drawing.Point(12, 12);
            this.ConnectSettingsGrup.Name = "ConnectSettingsGrup";
            this.ConnectSettingsGrup.Size = new System.Drawing.Size(468, 268);
            this.ConnectSettingsGrup.TabIndex = 0;
            this.ConnectSettingsGrup.TabStop = false;
            this.ConnectSettingsGrup.Text = "Connect Settings";
            // 
            // DefaultSettingsButton
            // 
            this.DefaultSettingsButton.Location = new System.Drawing.Point(252, 236);
            this.DefaultSettingsButton.Name = "DefaultSettingsButton";
            this.DefaultSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.DefaultSettingsButton.TabIndex = 13;
            this.DefaultSettingsButton.Text = "Default";
            this.DefaultSettingsButton.UseVisualStyleBackColor = true;
            this.DefaultSettingsButton.Click += new System.EventHandler(this.DefaultSettingsButton_Click);
            // 
            // HandShakeGroupBox
            // 
            this.HandShakeGroupBox.Controls.Add(this.RequestToSendXOnXOffHandshakeRadioButton);
            this.HandShakeGroupBox.Controls.Add(this.RequestToSendHandshakeRadioButton);
            this.HandShakeGroupBox.Controls.Add(this.XonXoffHandshakeRadioButton);
            this.HandShakeGroupBox.Controls.Add(this.NoneHandshakeRadioButton);
            this.HandShakeGroupBox.Location = new System.Drawing.Point(133, 101);
            this.HandShakeGroupBox.Name = "HandShakeGroupBox";
            this.HandShakeGroupBox.Size = new System.Drawing.Size(203, 121);
            this.HandShakeGroupBox.TabIndex = 12;
            this.HandShakeGroupBox.TabStop = false;
            this.HandShakeGroupBox.Text = "Handshake";
            // 
            // RequestToSendXOnXOffHandshakeRadioButton
            // 
            this.RequestToSendXOnXOffHandshakeRadioButton.AutoSize = true;
            this.RequestToSendXOnXOffHandshakeRadioButton.Location = new System.Drawing.Point(7, 91);
            this.RequestToSendXOnXOffHandshakeRadioButton.Name = "RequestToSendXOnXOffHandshakeRadioButton";
            this.RequestToSendXOnXOffHandshakeRadioButton.Size = new System.Drawing.Size(186, 17);
            this.RequestToSendXOnXOffHandshakeRadioButton.TabIndex = 3;
            this.RequestToSendXOnXOffHandshakeRadioButton.TabStop = true;
            this.RequestToSendXOnXOffHandshakeRadioButton.Text = "RequestToSendXOnXOff (default)";
            this.RequestToSendXOnXOffHandshakeRadioButton.UseVisualStyleBackColor = true;
            // 
            // RequestToSendHandshakeRadioButton
            // 
            this.RequestToSendHandshakeRadioButton.AutoSize = true;
            this.RequestToSendHandshakeRadioButton.Location = new System.Drawing.Point(7, 67);
            this.RequestToSendHandshakeRadioButton.Name = "RequestToSendHandshakeRadioButton";
            this.RequestToSendHandshakeRadioButton.Size = new System.Drawing.Size(103, 17);
            this.RequestToSendHandshakeRadioButton.TabIndex = 2;
            this.RequestToSendHandshakeRadioButton.TabStop = true;
            this.RequestToSendHandshakeRadioButton.Text = "RequestToSend";
            this.RequestToSendHandshakeRadioButton.UseVisualStyleBackColor = true;
            // 
            // XonXoffHandshakeRadioButton
            // 
            this.XonXoffHandshakeRadioButton.AutoSize = true;
            this.XonXoffHandshakeRadioButton.Location = new System.Drawing.Point(7, 43);
            this.XonXoffHandshakeRadioButton.Name = "XonXoffHandshakeRadioButton";
            this.XonXoffHandshakeRadioButton.Size = new System.Drawing.Size(67, 17);
            this.XonXoffHandshakeRadioButton.TabIndex = 1;
            this.XonXoffHandshakeRadioButton.TabStop = true;
            this.XonXoffHandshakeRadioButton.Text = "XOnXOff";
            this.XonXoffHandshakeRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoneHandshakeRadioButton
            // 
            this.NoneHandshakeRadioButton.AutoSize = true;
            this.NoneHandshakeRadioButton.Location = new System.Drawing.Point(7, 20);
            this.NoneHandshakeRadioButton.Name = "NoneHandshakeRadioButton";
            this.NoneHandshakeRadioButton.Size = new System.Drawing.Size(51, 17);
            this.NoneHandshakeRadioButton.TabIndex = 0;
            this.NoneHandshakeRadioButton.TabStop = true;
            this.NoneHandshakeRadioButton.Text = "None";
            this.NoneHandshakeRadioButton.UseVisualStyleBackColor = true;
            // 
            // DataBitsDefaultLabel
            // 
            this.DataBitsDefaultLabel.Location = new System.Drawing.Point(306, 65);
            this.DataBitsDefaultLabel.Name = "DataBitsDefaultLabel";
            this.DataBitsDefaultLabel.Size = new System.Drawing.Size(100, 23);
            this.DataBitsDefaultLabel.TabIndex = 14;
            // 
            // StopBitsGroupBox
            // 
            this.StopBitsGroupBox.Controls.Add(this.TwoStopBitsRadioButton);
            this.StopBitsGroupBox.Controls.Add(this.OnePointFiveStopBitsRadioButton);
            this.StopBitsGroupBox.Controls.Add(this.OneStopBitsRadioButton);
            this.StopBitsGroupBox.Controls.Add(this.NoneStopBitsRadioButton);
            this.StopBitsGroupBox.Location = new System.Drawing.Point(349, 105);
            this.StopBitsGroupBox.Name = "StopBitsGroupBox";
            this.StopBitsGroupBox.Size = new System.Drawing.Size(109, 117);
            this.StopBitsGroupBox.TabIndex = 11;
            this.StopBitsGroupBox.TabStop = false;
            this.StopBitsGroupBox.Text = "Stop Bits";
            // 
            // TwoStopBitsRadioButton
            // 
            this.TwoStopBitsRadioButton.AutoSize = true;
            this.TwoStopBitsRadioButton.Location = new System.Drawing.Point(7, 88);
            this.TwoStopBitsRadioButton.Name = "TwoStopBitsRadioButton";
            this.TwoStopBitsRadioButton.Size = new System.Drawing.Size(46, 17);
            this.TwoStopBitsRadioButton.TabIndex = 4;
            this.TwoStopBitsRadioButton.TabStop = true;
            this.TwoStopBitsRadioButton.Text = "Two";
            this.TwoStopBitsRadioButton.UseVisualStyleBackColor = true;
            // 
            // OnePointFiveStopBitsRadioButton
            // 
            this.OnePointFiveStopBitsRadioButton.AutoSize = true;
            this.OnePointFiveStopBitsRadioButton.Location = new System.Drawing.Point(7, 65);
            this.OnePointFiveStopBitsRadioButton.Name = "OnePointFiveStopBitsRadioButton";
            this.OnePointFiveStopBitsRadioButton.Size = new System.Drawing.Size(95, 17);
            this.OnePointFiveStopBitsRadioButton.TabIndex = 3;
            this.OnePointFiveStopBitsRadioButton.TabStop = true;
            this.OnePointFiveStopBitsRadioButton.Text = "One Point Five";
            this.OnePointFiveStopBitsRadioButton.UseVisualStyleBackColor = true;
            // 
            // OneStopBitsRadioButton
            // 
            this.OneStopBitsRadioButton.AutoSize = true;
            this.OneStopBitsRadioButton.Location = new System.Drawing.Point(6, 42);
            this.OneStopBitsRadioButton.Name = "OneStopBitsRadioButton";
            this.OneStopBitsRadioButton.Size = new System.Drawing.Size(86, 17);
            this.OneStopBitsRadioButton.TabIndex = 2;
            this.OneStopBitsRadioButton.TabStop = true;
            this.OneStopBitsRadioButton.Text = "One (default)";
            this.OneStopBitsRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoneStopBitsRadioButton
            // 
            this.NoneStopBitsRadioButton.AutoSize = true;
            this.NoneStopBitsRadioButton.Location = new System.Drawing.Point(6, 19);
            this.NoneStopBitsRadioButton.Name = "NoneStopBitsRadioButton";
            this.NoneStopBitsRadioButton.Size = new System.Drawing.Size(51, 17);
            this.NoneStopBitsRadioButton.TabIndex = 1;
            this.NoneStopBitsRadioButton.TabStop = true;
            this.NoneStopBitsRadioButton.Text = "None";
            this.NoneStopBitsRadioButton.UseVisualStyleBackColor = true;
            // 
            // DataBitsLabel
            // 
            this.DataBitsLabel.AutoSize = true;
            this.DataBitsLabel.Location = new System.Drawing.Point(130, 68);
            this.DataBitsLabel.Name = "DataBitsLabel";
            this.DataBitsLabel.Size = new System.Drawing.Size(42, 13);
            this.DataBitsLabel.TabIndex = 9;
            this.DataBitsLabel.Text = "DataBit";
            // 
            // DataBitsNumericUpDown
            // 
            this.DataBitsNumericUpDown.Location = new System.Drawing.Point(184, 66);
            this.DataBitsNumericUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.DataBitsNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DataBitsNumericUpDown.Name = "DataBitsNumericUpDown";
            this.DataBitsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.DataBitsNumericUpDown.TabIndex = 8;
            this.DataBitsNumericUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.DataBitsNumericUpDown.ValueChanged += new System.EventHandler(this.DataBitsNumericUpDown_ValueChanged);
            // 
            // ParitygroupBox
            // 
            this.ParitygroupBox.Controls.Add(this.SpaceParityRadioButton);
            this.ParitygroupBox.Controls.Add(this.MarkParityRadioButton);
            this.ParitygroupBox.Controls.Add(this.EvenParityRadioButton);
            this.ParitygroupBox.Controls.Add(this.OddParityRadioButton);
            this.ParitygroupBox.Controls.Add(this.NoneParityRadioButton);
            this.ParitygroupBox.Location = new System.Drawing.Point(9, 51);
            this.ParitygroupBox.Name = "ParitygroupBox";
            this.ParitygroupBox.Size = new System.Drawing.Size(109, 133);
            this.ParitygroupBox.TabIndex = 7;
            this.ParitygroupBox.TabStop = false;
            this.ParitygroupBox.Text = "Parity";
            // 
            // SpaceParityRadioButton
            // 
            this.SpaceParityRadioButton.AutoSize = true;
            this.SpaceParityRadioButton.Location = new System.Drawing.Point(7, 107);
            this.SpaceParityRadioButton.Name = "SpaceParityRadioButton";
            this.SpaceParityRadioButton.Size = new System.Drawing.Size(56, 17);
            this.SpaceParityRadioButton.TabIndex = 4;
            this.SpaceParityRadioButton.TabStop = true;
            this.SpaceParityRadioButton.Text = "Space";
            this.SpaceParityRadioButton.UseVisualStyleBackColor = true;
            // 
            // MarkParityRadioButton
            // 
            this.MarkParityRadioButton.AutoSize = true;
            this.MarkParityRadioButton.Location = new System.Drawing.Point(7, 83);
            this.MarkParityRadioButton.Name = "MarkParityRadioButton";
            this.MarkParityRadioButton.Size = new System.Drawing.Size(49, 17);
            this.MarkParityRadioButton.TabIndex = 3;
            this.MarkParityRadioButton.TabStop = true;
            this.MarkParityRadioButton.Text = "Mark";
            this.MarkParityRadioButton.UseVisualStyleBackColor = true;
            // 
            // EvenParityRadioButton
            // 
            this.EvenParityRadioButton.AutoSize = true;
            this.EvenParityRadioButton.Location = new System.Drawing.Point(7, 59);
            this.EvenParityRadioButton.Name = "EvenParityRadioButton";
            this.EvenParityRadioButton.Size = new System.Drawing.Size(50, 17);
            this.EvenParityRadioButton.TabIndex = 2;
            this.EvenParityRadioButton.TabStop = true;
            this.EvenParityRadioButton.Text = "Even";
            this.EvenParityRadioButton.UseVisualStyleBackColor = true;
            // 
            // OddParityRadioButton
            // 
            this.OddParityRadioButton.AutoSize = true;
            this.OddParityRadioButton.Location = new System.Drawing.Point(7, 35);
            this.OddParityRadioButton.Name = "OddParityRadioButton";
            this.OddParityRadioButton.Size = new System.Drawing.Size(45, 17);
            this.OddParityRadioButton.TabIndex = 1;
            this.OddParityRadioButton.TabStop = true;
            this.OddParityRadioButton.Text = "Odd";
            this.OddParityRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoneParityRadioButton
            // 
            this.NoneParityRadioButton.AutoSize = true;
            this.NoneParityRadioButton.Location = new System.Drawing.Point(7, 12);
            this.NoneParityRadioButton.Name = "NoneParityRadioButton";
            this.NoneParityRadioButton.Size = new System.Drawing.Size(92, 17);
            this.NoneParityRadioButton.TabIndex = 0;
            this.NoneParityRadioButton.TabStop = true;
            this.NoneParityRadioButton.Text = "None (default)";
            this.NoneParityRadioButton.UseVisualStyleBackColor = true;
            // 
            // BaudRateComboBox
            // 
            this.BaudRateComboBox.FormattingEnabled = true;
            this.BaudRateComboBox.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.BaudRateComboBox.Location = new System.Drawing.Point(257, 24);
            this.BaudRateComboBox.Name = "BaudRateComboBox";
            this.BaudRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.BaudRateComboBox.TabIndex = 6;
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Location = new System.Drawing.Point(198, 27);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(58, 13);
            this.BaudRateLabel.TabIndex = 5;
            this.BaudRateLabel.Text = "Baud Rate";
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Enabled = false;
            this.DisconnectButton.Location = new System.Drawing.Point(9, 236);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(75, 23);
            this.DisconnectButton.TabIndex = 4;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Enabled = false;
            this.ConnectButton.Location = new System.Drawing.Point(90, 236);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 3;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ApplySettingsButton
            // 
            this.ApplySettingsButton.Location = new System.Drawing.Point(171, 236);
            this.ApplySettingsButton.Name = "ApplySettingsButton";
            this.ApplySettingsButton.Size = new System.Drawing.Size(75, 23);
            this.ApplySettingsButton.TabIndex = 2;
            this.ApplySettingsButton.Text = "Apply";
            this.ApplySettingsButton.UseVisualStyleBackColor = true;
            this.ApplySettingsButton.Click += new System.EventHandler(this.ApplySettingsButton_Click);
            // 
            // PortSelectionLabel
            // 
            this.PortSelectionLabel.AutoSize = true;
            this.PortSelectionLabel.Location = new System.Drawing.Point(6, 27);
            this.PortSelectionLabel.Name = "PortSelectionLabel";
            this.PortSelectionLabel.Size = new System.Drawing.Size(59, 13);
            this.PortSelectionLabel.TabIndex = 1;
            this.PortSelectionLabel.Text = "Select Port";
            // 
            // PortSelectionComboBox
            // 
            this.PortSelectionComboBox.FormattingEnabled = true;
            this.PortSelectionComboBox.Location = new System.Drawing.Point(70, 24);
            this.PortSelectionComboBox.Name = "PortSelectionComboBox";
            this.PortSelectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.PortSelectionComboBox.TabIndex = 0;
            // 
            // ComponentsOutputFlowLayoutPanel
            // 
            this.ComponentsOutputFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ComponentsOutputFlowLayoutPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ComponentsOutputFlowLayoutPanel.Location = new System.Drawing.Point(486, 36);
            this.ComponentsOutputFlowLayoutPanel.Name = "ComponentsOutputFlowLayoutPanel";
            this.ComponentsOutputFlowLayoutPanel.Size = new System.Drawing.Size(310, 665);
            this.ComponentsOutputFlowLayoutPanel.TabIndex = 1;
            // 
            // ComponentOutputAddGroupBox
            // 
            this.ComponentOutputAddGroupBox.Controls.Add(this.ComponentOutputPanel);
            this.ComponentOutputAddGroupBox.Controls.Add(this.OutputLabel);
            this.ComponentOutputAddGroupBox.Controls.Add(this.OutputComponentsComboBox);
            this.ComponentOutputAddGroupBox.Location = new System.Drawing.Point(13, 3);
            this.ComponentOutputAddGroupBox.Name = "ComponentOutputAddGroupBox";
            this.ComponentOutputAddGroupBox.Size = new System.Drawing.Size(468, 132);
            this.ComponentOutputAddGroupBox.TabIndex = 0;
            this.ComponentOutputAddGroupBox.TabStop = false;
            this.ComponentOutputAddGroupBox.Text = "Add Component";
            // 
            // ComponentOutputPanel
            // 
            this.ComponentOutputPanel.Location = new System.Drawing.Point(1, 46);
            this.ComponentOutputPanel.Name = "ComponentOutputPanel";
            this.ComponentOutputPanel.Size = new System.Drawing.Size(466, 84);
            this.ComponentOutputPanel.TabIndex = 3;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.OutputLabel.Location = new System.Drawing.Point(13, 21);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(46, 16);
            this.OutputLabel.TabIndex = 5;
            this.OutputLabel.Text = "Output";
            // 
            // OutputComponentsComboBox
            // 
            this.OutputComponentsComboBox.FormattingEnabled = true;
            this.OutputComponentsComboBox.Items.AddRange(new object[] {
            "Led",
            "Motor",
            "Costume",
            "Code",
            "Audio"});
            this.OutputComponentsComboBox.Location = new System.Drawing.Point(70, 19);
            this.OutputComponentsComboBox.Name = "OutputComponentsComboBox";
            this.OutputComponentsComboBox.Size = new System.Drawing.Size(121, 21);
            this.OutputComponentsComboBox.TabIndex = 0;
            this.OutputComponentsComboBox.SelectedIndexChanged += new System.EventHandler(this.OutputComponentsComboBox_SelectedIndexChanged);
            // 
            // AddInputComponentButton
            // 
            this.AddInputComponentButton.Location = new System.Drawing.Point(13, 313);
            this.AddInputComponentButton.Name = "AddInputComponentButton";
            this.AddInputComponentButton.Size = new System.Drawing.Size(75, 23);
            this.AddInputComponentButton.TabIndex = 2;
            this.AddInputComponentButton.Text = "Add";
            this.AddInputComponentButton.UseVisualStyleBackColor = true;
            this.AddInputComponentButton.Click += new System.EventHandler(this.AddInputComponentButton_Click);
            // 
            // ComponentInputAddGroupBox
            // 
            this.ComponentInputAddGroupBox.Controls.Add(this.InputLabel);
            this.ComponentInputAddGroupBox.Controls.Add(this.ComponentInputPanel);
            this.ComponentInputAddGroupBox.Controls.Add(this.InputConponentComboBox);
            this.ComponentInputAddGroupBox.Location = new System.Drawing.Point(13, 177);
            this.ComponentInputAddGroupBox.Name = "ComponentInputAddGroupBox";
            this.ComponentInputAddGroupBox.Size = new System.Drawing.Size(468, 132);
            this.ComponentInputAddGroupBox.TabIndex = 4;
            this.ComponentInputAddGroupBox.TabStop = false;
            this.ComponentInputAddGroupBox.Text = "Add Component";
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.InputLabel.Location = new System.Drawing.Point(13, 20);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(36, 16);
            this.InputLabel.TabIndex = 4;
            this.InputLabel.Text = "Input";
            // 
            // ComponentInputPanel
            // 
            this.ComponentInputPanel.Location = new System.Drawing.Point(1, 46);
            this.ComponentInputPanel.Name = "ComponentInputPanel";
            this.ComponentInputPanel.Size = new System.Drawing.Size(466, 84);
            this.ComponentInputPanel.TabIndex = 3;
            // 
            // InputConponentComboBox
            // 
            this.InputConponentComboBox.FormattingEnabled = true;
            this.InputConponentComboBox.Items.AddRange(new object[] {
            "Led",
            "Motor",
            "Costume",
            "Code"});
            this.InputConponentComboBox.Location = new System.Drawing.Point(70, 20);
            this.InputConponentComboBox.Name = "InputConponentComboBox";
            this.InputConponentComboBox.Size = new System.Drawing.Size(121, 21);
            this.InputConponentComboBox.TabIndex = 0;
            this.InputConponentComboBox.SelectedIndexChanged += new System.EventHandler(this.InputComponentComboBox_SelectedIndexChanged);
            // 
            // AddOutputComponentButton
            // 
            this.AddOutputComponentButton.Location = new System.Drawing.Point(13, 139);
            this.AddOutputComponentButton.Name = "AddOutputComponentButton";
            this.AddOutputComponentButton.Size = new System.Drawing.Size(75, 23);
            this.AddOutputComponentButton.TabIndex = 5;
            this.AddOutputComponentButton.Text = "Add";
            this.AddOutputComponentButton.UseVisualStyleBackColor = true;
            this.AddOutputComponentButton.Click += new System.EventHandler(this.AddOutputComponentButton_Click);
            // 
            // ComponentsInputFlowLayoutPanel
            // 
            this.ComponentsInputFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ComponentsInputFlowLayoutPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ComponentsInputFlowLayoutPanel.Location = new System.Drawing.Point(817, 36);
            this.ComponentsInputFlowLayoutPanel.Name = "ComponentsInputFlowLayoutPanel";
            this.ComponentsInputFlowLayoutPanel.Size = new System.Drawing.Size(310, 665);
            this.ComponentsInputFlowLayoutPanel.TabIndex = 2;
            // 
            // InputComponenetsTitleLabel
            // 
            this.InputComponenetsTitleLabel.AutoSize = true;
            this.InputComponenetsTitleLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.InputComponenetsTitleLabel.Location = new System.Drawing.Point(937, 8);
            this.InputComponenetsTitleLabel.Name = "InputComponenetsTitleLabel";
            this.InputComponenetsTitleLabel.Size = new System.Drawing.Size(78, 25);
            this.InputComponenetsTitleLabel.TabIndex = 6;
            this.InputComponenetsTitleLabel.Text = "Input";
            // 
            // OutputComponenetsTitleLabel
            // 
            this.OutputComponenetsTitleLabel.AutoSize = true;
            this.OutputComponenetsTitleLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputComponenetsTitleLabel.Location = new System.Drawing.Point(599, 8);
            this.OutputComponenetsTitleLabel.Name = "OutputComponenetsTitleLabel";
            this.OutputComponenetsTitleLabel.Size = new System.Drawing.Size(95, 25);
            this.OutputComponenetsTitleLabel.TabIndex = 6;
            this.OutputComponenetsTitleLabel.Text = "Output";
            // 
            // ComponenetsPanel
            // 
            this.ComponenetsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ComponenetsPanel.Controls.Add(this.ComponentOutputAddGroupBox);
            this.ComponenetsPanel.Controls.Add(this.AddOutputComponentButton);
            this.ComponenetsPanel.Controls.Add(this.ComponentInputAddGroupBox);
            this.ComponenetsPanel.Controls.Add(this.AddInputComponentButton);
            this.ComponenetsPanel.Enabled = false;
            this.ComponenetsPanel.Location = new System.Drawing.Point(-1, 286);
            this.ComponenetsPanel.Name = "ComponenetsPanel";
            this.ComponenetsPanel.Size = new System.Drawing.Size(491, 339);
            this.ComponenetsPanel.TabIndex = 7;
            // 
            // SaveJsonButton
            // 
            this.SaveJsonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SaveJsonButton.Location = new System.Drawing.Point(6, 19);
            this.SaveJsonButton.Name = "SaveJsonButton";
            this.SaveJsonButton.Size = new System.Drawing.Size(75, 23);
            this.SaveJsonButton.TabIndex = 8;
            this.SaveJsonButton.Text = "Save";
            this.SaveJsonButton.UseVisualStyleBackColor = true;
            this.SaveJsonButton.Click += new System.EventHandler(this.SaveJsonButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1134, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 665);
            this.panel1.TabIndex = 9;
            // 
            // MoreGroupBox
            // 
            this.MoreGroupBox.Controls.Add(this.OpenJsonButton);
            this.MoreGroupBox.Controls.Add(this.SaveJsonButton);
            this.MoreGroupBox.Location = new System.Drawing.Point(12, 631);
            this.MoreGroupBox.Name = "MoreGroupBox";
            this.MoreGroupBox.Size = new System.Drawing.Size(468, 56);
            this.MoreGroupBox.TabIndex = 11;
            this.MoreGroupBox.TabStop = false;
            this.MoreGroupBox.Text = "More";
            // 
            // OpenJsonButton
            // 
            this.OpenJsonButton.Location = new System.Drawing.Point(87, 19);
            this.OpenJsonButton.Name = "OpenJsonButton";
            this.OpenJsonButton.Size = new System.Drawing.Size(75, 23);
            this.OpenJsonButton.TabIndex = 9;
            this.OpenJsonButton.Text = "Open";
            this.OpenJsonButton.UseVisualStyleBackColor = true;
            this.OpenJsonButton.Click += new System.EventHandler(this.OpenJsonButton_Click);
            // 
            // HiddenFeaturesFlowLayoutPanel
            // 
            this.HiddenFeaturesFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.HiddenFeaturesFlowLayoutPanel.Location = new System.Drawing.Point(13, 693);
            this.HiddenFeaturesFlowLayoutPanel.Name = "HiddenFeaturesFlowLayoutPanel";
            this.HiddenFeaturesFlowLayoutPanel.Size = new System.Drawing.Size(467, 10);
            this.HiddenFeaturesFlowLayoutPanel.TabIndex = 12;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 713);
            this.Controls.Add(this.HiddenFeaturesFlowLayoutPanel);
            this.Controls.Add(this.MoreGroupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OutputComponenetsTitleLabel);
            this.Controls.Add(this.InputComponenetsTitleLabel);
            this.Controls.Add(this.ComponentsInputFlowLayoutPanel);
            this.Controls.Add(this.ComponentsOutputFlowLayoutPanel);
            this.Controls.Add(this.ConnectSettingsGrup);
            this.Controls.Add(this.ComponenetsPanel);
            this.MinimumSize = new System.Drawing.Size(1159, 752);
            this.Name = "MainWindow";
            this.Text = "Serial Nodes";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.ConnectSettingsGrup.ResumeLayout(false);
            this.ConnectSettingsGrup.PerformLayout();
            this.HandShakeGroupBox.ResumeLayout(false);
            this.HandShakeGroupBox.PerformLayout();
            this.StopBitsGroupBox.ResumeLayout(false);
            this.StopBitsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBitsNumericUpDown)).EndInit();
            this.ParitygroupBox.ResumeLayout(false);
            this.ParitygroupBox.PerformLayout();
            this.ComponentOutputAddGroupBox.ResumeLayout(false);
            this.ComponentOutputAddGroupBox.PerformLayout();
            this.ComponentInputAddGroupBox.ResumeLayout(false);
            this.ComponentInputAddGroupBox.PerformLayout();
            this.ComponenetsPanel.ResumeLayout(false);
            this.MoreGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ConnectSettingsGrup;
        private System.Windows.Forms.ComboBox PortSelectionComboBox;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button ApplySettingsButton;
        private System.Windows.Forms.Label PortSelectionLabel;
        private System.Windows.Forms.ComboBox BaudRateComboBox;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.GroupBox ParitygroupBox;
        private System.Windows.Forms.NumericUpDown DataBitsNumericUpDown;
        private System.Windows.Forms.Label DataBitsLabel;
        private System.Windows.Forms.GroupBox StopBitsGroupBox;
        private System.Windows.Forms.GroupBox HandShakeGroupBox;
        private System.Windows.Forms.Button DefaultSettingsButton;
        private System.Windows.Forms.RadioButton TwoStopBitsRadioButton;
        private System.Windows.Forms.RadioButton OnePointFiveStopBitsRadioButton;
        private System.Windows.Forms.RadioButton OneStopBitsRadioButton;
        private System.Windows.Forms.RadioButton NoneStopBitsRadioButton;
        private System.Windows.Forms.RadioButton OddParityRadioButton;
        private System.Windows.Forms.RadioButton NoneParityRadioButton;
        private System.Windows.Forms.RadioButton SpaceParityRadioButton;
        private System.Windows.Forms.RadioButton MarkParityRadioButton;
        private System.Windows.Forms.RadioButton EvenParityRadioButton;
        private System.Windows.Forms.RadioButton RequestToSendXOnXOffHandshakeRadioButton;
        private System.Windows.Forms.RadioButton RequestToSendHandshakeRadioButton;
        private System.Windows.Forms.RadioButton XonXoffHandshakeRadioButton;
        private System.Windows.Forms.RadioButton NoneHandshakeRadioButton;
        private System.Windows.Forms.Label DataBitsDefaultLabel;
        private System.Windows.Forms.FlowLayoutPanel ComponentsOutputFlowLayoutPanel;
        private System.Windows.Forms.GroupBox ComponentOutputAddGroupBox;
        private System.Windows.Forms.ComboBox OutputComponentsComboBox;
        private System.Windows.Forms.Button AddInputComponentButton;
        private System.Windows.Forms.Panel ComponentOutputPanel;
        private System.Windows.Forms.GroupBox ComponentInputAddGroupBox;
        private System.Windows.Forms.Panel ComponentInputPanel;
        private System.Windows.Forms.ComboBox InputConponentComboBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Button AddOutputComponentButton;
        private System.Windows.Forms.FlowLayoutPanel ComponentsInputFlowLayoutPanel;
        private System.Windows.Forms.Label InputComponenetsTitleLabel;
        private System.Windows.Forms.Label OutputComponenetsTitleLabel;
        private System.Windows.Forms.Panel ComponenetsPanel;
        private System.Windows.Forms.Button SaveJsonButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox MoreGroupBox;
        private System.Windows.Forms.Button OpenJsonButton;
        private System.Windows.Forms.FlowLayoutPanel HiddenFeaturesFlowLayoutPanel;
    }
}

