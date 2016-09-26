namespace Terminal
{
    partial class SerialTerminal
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
            this.components = new System.ComponentModel.Container();
            this.ComPortDropDown = new System.Windows.Forms.ComboBox();
            this.ComRefreshButton = new System.Windows.Forms.Button();
            this.ComPortGroup = new System.Windows.Forms.GroupBox();
            this.ComConnectionButton = new System.Windows.Forms.Button();
            this.BaudGroup = new System.Windows.Forms.GroupBox();
            this.Baudrate57600Radio = new System.Windows.Forms.RadioButton();
            this.Baudrate14400Radio = new System.Windows.Forms.RadioButton();
            this.Baudrate115200Radio = new System.Windows.Forms.RadioButton();
            this.Baudrate19200Radio = new System.Windows.Forms.RadioButton();
            this.Baudrate9600Radio = new System.Windows.Forms.RadioButton();
            this.DataBitsGroup = new System.Windows.Forms.GroupBox();
            this.DataBits8Radio = new System.Windows.Forms.RadioButton();
            this.SerialDataPort = new System.IO.Ports.SerialPort(this.components);
            this.ParityGroup = new System.Windows.Forms.GroupBox();
            this.ParityOddRadio = new System.Windows.Forms.RadioButton();
            this.ParitySpaceRadio = new System.Windows.Forms.RadioButton();
            this.ParityMarkRadio = new System.Windows.Forms.RadioButton();
            this.ParityNoneRadio = new System.Windows.Forms.RadioButton();
            this.ParityEvenRadio = new System.Windows.Forms.RadioButton();
            this.StopBitsGroup = new System.Windows.Forms.GroupBox();
            this.StopBitsTwoRadio = new System.Windows.Forms.RadioButton();
            this.StopBitsOneRadio = new System.Windows.Forms.RadioButton();
            this.HandshakeNoneRadio = new System.Windows.Forms.RadioButton();
            this.HandshakeRTSRadio = new System.Windows.Forms.RadioButton();
            this.HandshakeGroup = new System.Windows.Forms.GroupBox();
            this.TransmitTerminationGroup = new System.Windows.Forms.GroupBox();
            this.TransmitTerminationCrLfRadio = new System.Windows.Forms.RadioButton();
            this.TransmitTerminationLfRadio = new System.Windows.Forms.RadioButton();
            this.TransmitTerminationCrRadio = new System.Windows.Forms.RadioButton();
            this.TransmitTerminationNoneRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SerialPortDtrCheckbox = new System.Windows.Forms.CheckBox();
            this.ReceivedDataTextBox = new System.Windows.Forms.RichTextBox();
            this.ReceivedDataTextBoxContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReceivedDataClearContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReceivedDataFontContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReceivedDataFontDialog = new System.Windows.Forms.FontDialog();
            this.ReceivedDataAutoscrollContextitem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReceivedDataClearOnConnectContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReceivedDataTimestampContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComPortGroup.SuspendLayout();
            this.BaudGroup.SuspendLayout();
            this.DataBitsGroup.SuspendLayout();
            this.ParityGroup.SuspendLayout();
            this.StopBitsGroup.SuspendLayout();
            this.HandshakeGroup.SuspendLayout();
            this.TransmitTerminationGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ReceivedDataTextBoxContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComPortDropDown
            // 
            this.ComPortDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPortDropDown.DropDownWidth = 80;
            this.ComPortDropDown.FormattingEnabled = true;
            this.ComPortDropDown.Location = new System.Drawing.Point(10, 24);
            this.ComPortDropDown.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.ComPortDropDown.Name = "ComPortDropDown";
            this.ComPortDropDown.Size = new System.Drawing.Size(94, 28);
            this.ComPortDropDown.Sorted = true;
            this.ComPortDropDown.TabIndex = 0;
            // 
            // ComRefreshButton
            // 
            this.ComRefreshButton.Location = new System.Drawing.Point(10, 62);
            this.ComRefreshButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.ComRefreshButton.Name = "ComRefreshButton";
            this.ComRefreshButton.Size = new System.Drawing.Size(94, 30);
            this.ComRefreshButton.TabIndex = 1;
            this.ComRefreshButton.Text = "Refresh";
            this.ComRefreshButton.UseVisualStyleBackColor = true;
            this.ComRefreshButton.Click += new System.EventHandler(this.ComRefreshButton_Click);
            // 
            // ComPortGroup
            // 
            this.ComPortGroup.Controls.Add(this.ComConnectionButton);
            this.ComPortGroup.Controls.Add(this.ComPortDropDown);
            this.ComPortGroup.Controls.Add(this.ComRefreshButton);
            this.ComPortGroup.Location = new System.Drawing.Point(10, 10);
            this.ComPortGroup.Margin = new System.Windows.Forms.Padding(5);
            this.ComPortGroup.Name = "ComPortGroup";
            this.ComPortGroup.Padding = new System.Windows.Forms.Padding(0);
            this.ComPortGroup.Size = new System.Drawing.Size(114, 140);
            this.ComPortGroup.TabIndex = 2;
            this.ComPortGroup.TabStop = false;
            this.ComPortGroup.Text = "COM port";
            // 
            // ComConnectionButton
            // 
            this.ComConnectionButton.Enabled = false;
            this.ComConnectionButton.Location = new System.Drawing.Point(10, 102);
            this.ComConnectionButton.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.ComConnectionButton.Name = "ComConnectionButton";
            this.ComConnectionButton.Size = new System.Drawing.Size(94, 30);
            this.ComConnectionButton.TabIndex = 2;
            this.ComConnectionButton.Text = "Connect";
            this.ComConnectionButton.UseVisualStyleBackColor = true;
            this.ComConnectionButton.Click += new System.EventHandler(this.ComConnectionButton_Click);
            // 
            // BaudGroup
            // 
            this.BaudGroup.Controls.Add(this.Baudrate57600Radio);
            this.BaudGroup.Controls.Add(this.Baudrate14400Radio);
            this.BaudGroup.Controls.Add(this.Baudrate115200Radio);
            this.BaudGroup.Controls.Add(this.Baudrate19200Radio);
            this.BaudGroup.Controls.Add(this.Baudrate9600Radio);
            this.BaudGroup.Location = new System.Drawing.Point(134, 10);
            this.BaudGroup.Margin = new System.Windows.Forms.Padding(5);
            this.BaudGroup.Name = "BaudGroup";
            this.BaudGroup.Padding = new System.Windows.Forms.Padding(0);
            this.BaudGroup.Size = new System.Drawing.Size(100, 140);
            this.BaudGroup.TabIndex = 3;
            this.BaudGroup.TabStop = false;
            this.BaudGroup.Text = "Baudrate";
            // 
            // Baudrate57600Radio
            // 
            this.Baudrate57600Radio.Location = new System.Drawing.Point(10, 86);
            this.Baudrate57600Radio.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.Baudrate57600Radio.Name = "Baudrate57600Radio";
            this.Baudrate57600Radio.Size = new System.Drawing.Size(85, 20);
            this.Baudrate57600Radio.TabIndex = 4;
            this.Baudrate57600Radio.Tag = "57600";
            this.Baudrate57600Radio.Text = "57600";
            this.Baudrate57600Radio.UseVisualStyleBackColor = true;
            this.Baudrate57600Radio.CheckedChanged += new System.EventHandler(this.BaudrateChanged);
            // 
            // Baudrate14400Radio
            // 
            this.Baudrate14400Radio.Location = new System.Drawing.Point(10, 42);
            this.Baudrate14400Radio.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.Baudrate14400Radio.Name = "Baudrate14400Radio";
            this.Baudrate14400Radio.Size = new System.Drawing.Size(85, 20);
            this.Baudrate14400Radio.TabIndex = 3;
            this.Baudrate14400Radio.Tag = "14400";
            this.Baudrate14400Radio.Text = "14400";
            this.Baudrate14400Radio.UseVisualStyleBackColor = true;
            this.Baudrate14400Radio.CheckedChanged += new System.EventHandler(this.BaudrateChanged);
            // 
            // Baudrate115200Radio
            // 
            this.Baudrate115200Radio.Checked = true;
            this.Baudrate115200Radio.Location = new System.Drawing.Point(10, 108);
            this.Baudrate115200Radio.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.Baudrate115200Radio.Name = "Baudrate115200Radio";
            this.Baudrate115200Radio.Size = new System.Drawing.Size(85, 20);
            this.Baudrate115200Radio.TabIndex = 2;
            this.Baudrate115200Radio.TabStop = true;
            this.Baudrate115200Radio.Tag = "115200";
            this.Baudrate115200Radio.Text = "115200";
            this.Baudrate115200Radio.UseVisualStyleBackColor = true;
            this.Baudrate115200Radio.CheckedChanged += new System.EventHandler(this.BaudrateChanged);
            // 
            // Baudrate19200Radio
            // 
            this.Baudrate19200Radio.Location = new System.Drawing.Point(10, 64);
            this.Baudrate19200Radio.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.Baudrate19200Radio.Name = "Baudrate19200Radio";
            this.Baudrate19200Radio.Size = new System.Drawing.Size(85, 20);
            this.Baudrate19200Radio.TabIndex = 1;
            this.Baudrate19200Radio.Tag = "19200";
            this.Baudrate19200Radio.Text = "19200";
            this.Baudrate19200Radio.UseVisualStyleBackColor = true;
            this.Baudrate19200Radio.CheckedChanged += new System.EventHandler(this.BaudrateChanged);
            // 
            // Baudrate9600Radio
            // 
            this.Baudrate9600Radio.Location = new System.Drawing.Point(10, 20);
            this.Baudrate9600Radio.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.Baudrate9600Radio.Name = "Baudrate9600Radio";
            this.Baudrate9600Radio.Size = new System.Drawing.Size(85, 20);
            this.Baudrate9600Radio.TabIndex = 0;
            this.Baudrate9600Radio.Tag = "9600";
            this.Baudrate9600Radio.Text = "9600";
            this.Baudrate9600Radio.UseVisualStyleBackColor = true;
            this.Baudrate9600Radio.CheckedChanged += new System.EventHandler(this.BaudrateChanged);
            // 
            // DataBitsGroup
            // 
            this.DataBitsGroup.Controls.Add(this.DataBits8Radio);
            this.DataBitsGroup.Location = new System.Drawing.Point(244, 10);
            this.DataBitsGroup.Margin = new System.Windows.Forms.Padding(5);
            this.DataBitsGroup.Name = "DataBitsGroup";
            this.DataBitsGroup.Padding = new System.Windows.Forms.Padding(0);
            this.DataBitsGroup.Size = new System.Drawing.Size(94, 140);
            this.DataBitsGroup.TabIndex = 5;
            this.DataBitsGroup.TabStop = false;
            this.DataBitsGroup.Text = "Data Bits";
            // 
            // DataBits8Radio
            // 
            this.DataBits8Radio.Checked = true;
            this.DataBits8Radio.Location = new System.Drawing.Point(10, 20);
            this.DataBits8Radio.Margin = new System.Windows.Forms.Padding(0);
            this.DataBits8Radio.Name = "DataBits8Radio";
            this.DataBits8Radio.Size = new System.Drawing.Size(50, 20);
            this.DataBits8Radio.TabIndex = 0;
            this.DataBits8Radio.TabStop = true;
            this.DataBits8Radio.Tag = "8";
            this.DataBits8Radio.Text = "8";
            this.DataBits8Radio.UseVisualStyleBackColor = true;
            this.DataBits8Radio.CheckedChanged += new System.EventHandler(this.DataBitsChanged);
            // 
            // SerialDataPort
            // 
            this.SerialDataPort.Handshake = System.IO.Ports.Handshake.RequestToSend;
            this.SerialDataPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPortDataReceived);
            // 
            // ParityGroup
            // 
            this.ParityGroup.Controls.Add(this.ParityOddRadio);
            this.ParityGroup.Controls.Add(this.ParitySpaceRadio);
            this.ParityGroup.Controls.Add(this.ParityMarkRadio);
            this.ParityGroup.Controls.Add(this.ParityNoneRadio);
            this.ParityGroup.Controls.Add(this.ParityEvenRadio);
            this.ParityGroup.Location = new System.Drawing.Point(348, 10);
            this.ParityGroup.Margin = new System.Windows.Forms.Padding(5);
            this.ParityGroup.Name = "ParityGroup";
            this.ParityGroup.Padding = new System.Windows.Forms.Padding(0);
            this.ParityGroup.Size = new System.Drawing.Size(95, 140);
            this.ParityGroup.TabIndex = 6;
            this.ParityGroup.TabStop = false;
            this.ParityGroup.Text = "Parity";
            // 
            // ParityOddRadio
            // 
            this.ParityOddRadio.Location = new System.Drawing.Point(5, 42);
            this.ParityOddRadio.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.ParityOddRadio.Name = "ParityOddRadio";
            this.ParityOddRadio.Size = new System.Drawing.Size(85, 20);
            this.ParityOddRadio.TabIndex = 8;
            this.ParityOddRadio.Tag = "1";
            this.ParityOddRadio.Text = "Odd";
            this.ParityOddRadio.UseVisualStyleBackColor = true;
            this.ParityOddRadio.CheckedChanged += new System.EventHandler(this.ParityChanged);
            // 
            // ParitySpaceRadio
            // 
            this.ParitySpaceRadio.Location = new System.Drawing.Point(5, 108);
            this.ParitySpaceRadio.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.ParitySpaceRadio.Name = "ParitySpaceRadio";
            this.ParitySpaceRadio.Size = new System.Drawing.Size(85, 24);
            this.ParitySpaceRadio.TabIndex = 7;
            this.ParitySpaceRadio.Tag = "4";
            this.ParitySpaceRadio.Text = "Space";
            this.ParitySpaceRadio.UseVisualStyleBackColor = true;
            this.ParitySpaceRadio.CheckedChanged += new System.EventHandler(this.ParityChanged);
            // 
            // ParityMarkRadio
            // 
            this.ParityMarkRadio.Location = new System.Drawing.Point(5, 86);
            this.ParityMarkRadio.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.ParityMarkRadio.Name = "ParityMarkRadio";
            this.ParityMarkRadio.Size = new System.Drawing.Size(85, 20);
            this.ParityMarkRadio.TabIndex = 9;
            this.ParityMarkRadio.Tag = "3";
            this.ParityMarkRadio.Text = "Mark";
            this.ParityMarkRadio.UseVisualStyleBackColor = true;
            this.ParityMarkRadio.CheckedChanged += new System.EventHandler(this.ParityChanged);
            // 
            // ParityNoneRadio
            // 
            this.ParityNoneRadio.Checked = true;
            this.ParityNoneRadio.Location = new System.Drawing.Point(5, 20);
            this.ParityNoneRadio.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.ParityNoneRadio.Name = "ParityNoneRadio";
            this.ParityNoneRadio.Size = new System.Drawing.Size(85, 20);
            this.ParityNoneRadio.TabIndex = 5;
            this.ParityNoneRadio.TabStop = true;
            this.ParityNoneRadio.Tag = "0";
            this.ParityNoneRadio.Text = "None";
            this.ParityNoneRadio.UseVisualStyleBackColor = true;
            this.ParityNoneRadio.CheckedChanged += new System.EventHandler(this.ParityChanged);
            // 
            // ParityEvenRadio
            // 
            this.ParityEvenRadio.Location = new System.Drawing.Point(5, 64);
            this.ParityEvenRadio.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.ParityEvenRadio.Name = "ParityEvenRadio";
            this.ParityEvenRadio.Size = new System.Drawing.Size(85, 20);
            this.ParityEvenRadio.TabIndex = 6;
            this.ParityEvenRadio.Tag = "2";
            this.ParityEvenRadio.Text = "Even";
            this.ParityEvenRadio.UseVisualStyleBackColor = true;
            this.ParityEvenRadio.CheckedChanged += new System.EventHandler(this.ParityChanged);
            // 
            // StopBitsGroup
            // 
            this.StopBitsGroup.Controls.Add(this.StopBitsTwoRadio);
            this.StopBitsGroup.Controls.Add(this.StopBitsOneRadio);
            this.StopBitsGroup.Location = new System.Drawing.Point(453, 10);
            this.StopBitsGroup.Margin = new System.Windows.Forms.Padding(5);
            this.StopBitsGroup.Name = "StopBitsGroup";
            this.StopBitsGroup.Padding = new System.Windows.Forms.Padding(0);
            this.StopBitsGroup.Size = new System.Drawing.Size(95, 140);
            this.StopBitsGroup.TabIndex = 7;
            this.StopBitsGroup.TabStop = false;
            this.StopBitsGroup.Text = "Stop Bits";
            // 
            // StopBitsTwoRadio
            // 
            this.StopBitsTwoRadio.Location = new System.Drawing.Point(5, 42);
            this.StopBitsTwoRadio.Margin = new System.Windows.Forms.Padding(0);
            this.StopBitsTwoRadio.Name = "StopBitsTwoRadio";
            this.StopBitsTwoRadio.Size = new System.Drawing.Size(50, 20);
            this.StopBitsTwoRadio.TabIndex = 8;
            this.StopBitsTwoRadio.Tag = "2";
            this.StopBitsTwoRadio.Text = "2";
            this.StopBitsTwoRadio.UseVisualStyleBackColor = true;
            this.StopBitsTwoRadio.CheckedChanged += new System.EventHandler(this.StopBitsChanged);
            // 
            // StopBitsOneRadio
            // 
            this.StopBitsOneRadio.Checked = true;
            this.StopBitsOneRadio.Location = new System.Drawing.Point(5, 20);
            this.StopBitsOneRadio.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.StopBitsOneRadio.Name = "StopBitsOneRadio";
            this.StopBitsOneRadio.Size = new System.Drawing.Size(50, 20);
            this.StopBitsOneRadio.TabIndex = 5;
            this.StopBitsOneRadio.TabStop = true;
            this.StopBitsOneRadio.Tag = "1";
            this.StopBitsOneRadio.Text = "1";
            this.StopBitsOneRadio.UseVisualStyleBackColor = true;
            this.StopBitsOneRadio.CheckedChanged += new System.EventHandler(this.StopBitsChanged);
            // 
            // HandshakeNoneRadio
            // 
            this.HandshakeNoneRadio.Checked = true;
            this.HandshakeNoneRadio.Location = new System.Drawing.Point(5, 20);
            this.HandshakeNoneRadio.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.HandshakeNoneRadio.Name = "HandshakeNoneRadio";
            this.HandshakeNoneRadio.Size = new System.Drawing.Size(100, 20);
            this.HandshakeNoneRadio.TabIndex = 5;
            this.HandshakeNoneRadio.TabStop = true;
            this.HandshakeNoneRadio.Tag = "0";
            this.HandshakeNoneRadio.Text = "None";
            this.HandshakeNoneRadio.UseVisualStyleBackColor = true;
            this.HandshakeNoneRadio.CheckedChanged += new System.EventHandler(this.HandshakeChanged);
            // 
            // HandshakeRTSRadio
            // 
            this.HandshakeRTSRadio.Location = new System.Drawing.Point(5, 41);
            this.HandshakeRTSRadio.Margin = new System.Windows.Forms.Padding(0);
            this.HandshakeRTSRadio.Name = "HandshakeRTSRadio";
            this.HandshakeRTSRadio.Size = new System.Drawing.Size(110, 22);
            this.HandshakeRTSRadio.TabIndex = 8;
            this.HandshakeRTSRadio.Tag = "2";
            this.HandshakeRTSRadio.Text = "RTS/CTS";
            this.HandshakeRTSRadio.UseVisualStyleBackColor = true;
            this.HandshakeRTSRadio.CheckedChanged += new System.EventHandler(this.HandshakeChanged);
            // 
            // HandshakeGroup
            // 
            this.HandshakeGroup.Controls.Add(this.HandshakeRTSRadio);
            this.HandshakeGroup.Controls.Add(this.HandshakeNoneRadio);
            this.HandshakeGroup.Location = new System.Drawing.Point(558, 10);
            this.HandshakeGroup.Margin = new System.Windows.Forms.Padding(5);
            this.HandshakeGroup.Name = "HandshakeGroup";
            this.HandshakeGroup.Padding = new System.Windows.Forms.Padding(0);
            this.HandshakeGroup.Size = new System.Drawing.Size(120, 140);
            this.HandshakeGroup.TabIndex = 8;
            this.HandshakeGroup.TabStop = false;
            this.HandshakeGroup.Text = "Handshake";
            // 
            // TransmitTerminationGroup
            // 
            this.TransmitTerminationGroup.Controls.Add(this.TransmitTerminationCrLfRadio);
            this.TransmitTerminationGroup.Controls.Add(this.TransmitTerminationLfRadio);
            this.TransmitTerminationGroup.Controls.Add(this.TransmitTerminationCrRadio);
            this.TransmitTerminationGroup.Controls.Add(this.TransmitTerminationNoneRadio);
            this.TransmitTerminationGroup.Location = new System.Drawing.Point(688, 10);
            this.TransmitTerminationGroup.Margin = new System.Windows.Forms.Padding(5);
            this.TransmitTerminationGroup.Name = "TransmitTerminationGroup";
            this.TransmitTerminationGroup.Padding = new System.Windows.Forms.Padding(0);
            this.TransmitTerminationGroup.Size = new System.Drawing.Size(178, 140);
            this.TransmitTerminationGroup.TabIndex = 10;
            this.TransmitTerminationGroup.TabStop = false;
            this.TransmitTerminationGroup.Text = "Transmit termination";
            // 
            // TransmitTerminationCrLfRadio
            // 
            this.TransmitTerminationCrLfRadio.AutoSize = true;
            this.TransmitTerminationCrLfRadio.Location = new System.Drawing.Point(5, 84);
            this.TransmitTerminationCrLfRadio.Margin = new System.Windows.Forms.Padding(0);
            this.TransmitTerminationCrLfRadio.Name = "TransmitTerminationCrLfRadio";
            this.TransmitTerminationCrLfRadio.Size = new System.Drawing.Size(126, 24);
            this.TransmitTerminationCrLfRadio.TabIndex = 10;
            this.TransmitTerminationCrLfRadio.Text = "CR+LF (\\r\\n)";
            this.TransmitTerminationCrLfRadio.UseVisualStyleBackColor = true;
            this.TransmitTerminationCrLfRadio.CheckedChanged += new System.EventHandler(this.TransmitTerminationChanged);
            // 
            // TransmitTerminationLfRadio
            // 
            this.TransmitTerminationLfRadio.AutoSize = true;
            this.TransmitTerminationLfRadio.Location = new System.Drawing.Point(5, 62);
            this.TransmitTerminationLfRadio.Margin = new System.Windows.Forms.Padding(0);
            this.TransmitTerminationLfRadio.Name = "TransmitTerminationLfRadio";
            this.TransmitTerminationLfRadio.Size = new System.Drawing.Size(81, 24);
            this.TransmitTerminationLfRadio.TabIndex = 9;
            this.TransmitTerminationLfRadio.Text = "LF (\\n)";
            this.TransmitTerminationLfRadio.UseVisualStyleBackColor = true;
            this.TransmitTerminationLfRadio.CheckedChanged += new System.EventHandler(this.TransmitTerminationChanged);
            // 
            // TransmitTerminationCrRadio
            // 
            this.TransmitTerminationCrRadio.AutoSize = true;
            this.TransmitTerminationCrRadio.Location = new System.Drawing.Point(5, 40);
            this.TransmitTerminationCrRadio.Margin = new System.Windows.Forms.Padding(0);
            this.TransmitTerminationCrRadio.Name = "TransmitTerminationCrRadio";
            this.TransmitTerminationCrRadio.Size = new System.Drawing.Size(82, 24);
            this.TransmitTerminationCrRadio.TabIndex = 8;
            this.TransmitTerminationCrRadio.Text = "CR (\\r)";
            this.TransmitTerminationCrRadio.UseVisualStyleBackColor = true;
            this.TransmitTerminationCrRadio.CheckedChanged += new System.EventHandler(this.TransmitTerminationChanged);
            // 
            // TransmitTerminationNoneRadio
            // 
            this.TransmitTerminationNoneRadio.AutoSize = true;
            this.TransmitTerminationNoneRadio.Checked = true;
            this.TransmitTerminationNoneRadio.Location = new System.Drawing.Point(5, 18);
            this.TransmitTerminationNoneRadio.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.TransmitTerminationNoneRadio.Name = "TransmitTerminationNoneRadio";
            this.TransmitTerminationNoneRadio.Size = new System.Drawing.Size(69, 24);
            this.TransmitTerminationNoneRadio.TabIndex = 5;
            this.TransmitTerminationNoneRadio.TabStop = true;
            this.TransmitTerminationNoneRadio.Text = "None";
            this.TransmitTerminationNoneRadio.UseVisualStyleBackColor = true;
            this.TransmitTerminationNoneRadio.CheckedChanged += new System.EventHandler(this.TransmitTerminationChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SerialPortDtrCheckbox);
            this.groupBox1.Controls.Add(this.ReceivedDataTextBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 327);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receive";
            // 
            // SerialPortDtrCheckbox
            // 
            this.SerialPortDtrCheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SerialPortDtrCheckbox.AutoSize = true;
            this.SerialPortDtrCheckbox.Location = new System.Drawing.Point(796, 25);
            this.SerialPortDtrCheckbox.Name = "SerialPortDtrCheckbox";
            this.SerialPortDtrCheckbox.Size = new System.Drawing.Size(54, 30);
            this.SerialPortDtrCheckbox.TabIndex = 1;
            this.SerialPortDtrCheckbox.Text = "DTR";
            this.SerialPortDtrCheckbox.UseVisualStyleBackColor = true;
            this.SerialPortDtrCheckbox.CheckedChanged += new System.EventHandler(this.SerialPortDtrChanged);
            // 
            // ReceivedDataTextBox
            // 
            this.ReceivedDataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReceivedDataTextBox.ContextMenuStrip = this.ReceivedDataTextBoxContextMenu;
            this.ReceivedDataTextBox.DetectUrls = false;
            this.ReceivedDataTextBox.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceivedDataTextBox.Location = new System.Drawing.Point(6, 25);
            this.ReceivedDataTextBox.Name = "ReceivedDataTextBox";
            this.ReceivedDataTextBox.ReadOnly = true;
            this.ReceivedDataTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.ReceivedDataTextBox.Size = new System.Drawing.Size(784, 296);
            this.ReceivedDataTextBox.TabIndex = 0;
            this.ReceivedDataTextBox.Text = "";
            // 
            // ReceivedDataTextBoxContextMenu
            // 
            this.ReceivedDataTextBoxContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ReceivedDataTextBoxContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReceivedDataAutoscrollContextitem,
            this.ReceivedDataClearContextItem,
            this.ReceivedDataClearOnConnectContextItem,
            this.ReceivedDataFontContextItem,
            this.ReceivedDataTimestampContextItem});
            this.ReceivedDataTextBoxContextMenu.Name = "ReceivedDataTextBoxContextMenu";
            this.ReceivedDataTextBoxContextMenu.Size = new System.Drawing.Size(196, 134);
            // 
            // ReceivedDataClearContextItem
            // 
            this.ReceivedDataClearContextItem.Name = "ReceivedDataClearContextItem";
            this.ReceivedDataClearContextItem.Size = new System.Drawing.Size(195, 26);
            this.ReceivedDataClearContextItem.Text = "Clear";
            this.ReceivedDataClearContextItem.Click += new System.EventHandler(this.ClearContextMenu_Click);
            // 
            // ReceivedDataFontContextItem
            // 
            this.ReceivedDataFontContextItem.Name = "ReceivedDataFontContextItem";
            this.ReceivedDataFontContextItem.Size = new System.Drawing.Size(195, 26);
            this.ReceivedDataFontContextItem.Text = "Font";
            this.ReceivedDataFontContextItem.Click += new System.EventHandler(this.ReceivedDataFont_Click);
            // 
            // ReceivedDataAutoscrollContextitem
            // 
            this.ReceivedDataAutoscrollContextitem.Checked = global::Terminal.Properties.Settings.Default.AutoscrollEnabled;
            this.ReceivedDataAutoscrollContextitem.CheckOnClick = true;
            this.ReceivedDataAutoscrollContextitem.Name = "ReceivedDataAutoscrollContextitem";
            this.ReceivedDataAutoscrollContextitem.Size = new System.Drawing.Size(195, 26);
            this.ReceivedDataAutoscrollContextitem.Text = "Autoscroll";
            this.ReceivedDataAutoscrollContextitem.CheckedChanged += new System.EventHandler(this.AutoscrollContextMenuChanged);
            // 
            // ReceivedDataClearOnConnectContextItem
            // 
            this.ReceivedDataClearOnConnectContextItem.Checked = global::Terminal.Properties.Settings.Default.ClearOnConnect;
            this.ReceivedDataClearOnConnectContextItem.CheckOnClick = true;
            this.ReceivedDataClearOnConnectContextItem.Name = "ReceivedDataClearOnConnectContextItem";
            this.ReceivedDataClearOnConnectContextItem.Size = new System.Drawing.Size(195, 26);
            this.ReceivedDataClearOnConnectContextItem.Text = "Clear on connect";
            this.ReceivedDataClearOnConnectContextItem.CheckedChanged += new System.EventHandler(this.ReceivedDataClearOnconnect_Changed);
            // 
            // ReceivedDataTimestampContextItem
            // 
            this.ReceivedDataTimestampContextItem.Checked = global::Terminal.Properties.Settings.Default.TimestampEnabled;
            this.ReceivedDataTimestampContextItem.CheckOnClick = true;
            this.ReceivedDataTimestampContextItem.Name = "ReceivedDataTimestampContextItem";
            this.ReceivedDataTimestampContextItem.Size = new System.Drawing.Size(195, 26);
            this.ReceivedDataTimestampContextItem.Text = "Timestamp";
            this.ReceivedDataTimestampContextItem.CheckedChanged += new System.EventHandler(this.ReceivedDataTimestampChanged);
            // 
            // SerialTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 725);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TransmitTerminationGroup);
            this.Controls.Add(this.HandshakeGroup);
            this.Controls.Add(this.StopBitsGroup);
            this.Controls.Add(this.ParityGroup);
            this.Controls.Add(this.DataBitsGroup);
            this.Controls.Add(this.BaudGroup);
            this.Controls.Add(this.ComPortGroup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.Name = "SerialTerminal";
            this.ShowIcon = false;
            this.Text = "Serial Terminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SerialTerminal_FormClosing);
            this.Load += new System.EventHandler(this.SerialTerminal_FormLoad);
            this.ComPortGroup.ResumeLayout(false);
            this.BaudGroup.ResumeLayout(false);
            this.DataBitsGroup.ResumeLayout(false);
            this.ParityGroup.ResumeLayout(false);
            this.StopBitsGroup.ResumeLayout(false);
            this.HandshakeGroup.ResumeLayout(false);
            this.TransmitTerminationGroup.ResumeLayout(false);
            this.TransmitTerminationGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ReceivedDataTextBoxContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComPortDropDown;
        private System.Windows.Forms.Button ComRefreshButton;
        private System.Windows.Forms.GroupBox ComPortGroup;
        private System.Windows.Forms.Button ComConnectionButton;
        private System.Windows.Forms.GroupBox BaudGroup;
        private System.Windows.Forms.RadioButton Baudrate14400Radio;
        private System.Windows.Forms.RadioButton Baudrate115200Radio;
        private System.Windows.Forms.RadioButton Baudrate19200Radio;
        private System.Windows.Forms.RadioButton Baudrate9600Radio;
        private System.Windows.Forms.RadioButton Baudrate57600Radio;
        private System.Windows.Forms.GroupBox DataBitsGroup;
        private System.Windows.Forms.RadioButton DataBits8Radio;
        private System.IO.Ports.SerialPort SerialDataPort;
        private System.Windows.Forms.GroupBox ParityGroup;
        private System.Windows.Forms.RadioButton ParityMarkRadio;
        private System.Windows.Forms.RadioButton ParityOddRadio;
        private System.Windows.Forms.RadioButton ParitySpaceRadio;
        private System.Windows.Forms.RadioButton ParityEvenRadio;
        private System.Windows.Forms.RadioButton ParityNoneRadio;
        private System.Windows.Forms.GroupBox StopBitsGroup;
        private System.Windows.Forms.RadioButton StopBitsTwoRadio;
        private System.Windows.Forms.RadioButton StopBitsOneRadio;
        private System.Windows.Forms.RadioButton HandshakeNoneRadio;
        private System.Windows.Forms.RadioButton HandshakeRTSRadio;
        private System.Windows.Forms.GroupBox HandshakeGroup;
        private System.Windows.Forms.GroupBox TransmitTerminationGroup;
        private System.Windows.Forms.RadioButton TransmitTerminationCrLfRadio;
        private System.Windows.Forms.RadioButton TransmitTerminationLfRadio;
        private System.Windows.Forms.RadioButton TransmitTerminationCrRadio;
        private System.Windows.Forms.RadioButton TransmitTerminationNoneRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox ReceivedDataTextBox;
        private System.Windows.Forms.ContextMenuStrip ReceivedDataTextBoxContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ReceivedDataClearContextItem;
        private System.Windows.Forms.ToolStripMenuItem ReceivedDataAutoscrollContextitem;
        private System.Windows.Forms.ToolStripMenuItem ReceivedDataFontContextItem;
        private System.Windows.Forms.FontDialog ReceivedDataFontDialog;
        private System.Windows.Forms.CheckBox SerialPortDtrCheckbox;
        private System.Windows.Forms.ToolStripMenuItem ReceivedDataTimestampContextItem;
        private System.Windows.Forms.ToolStripMenuItem ReceivedDataClearOnConnectContextItem;

    }
}

