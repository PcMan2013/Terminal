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
            this.BaudrateCustomTextbox = new System.Windows.Forms.TextBox();
            this.BaudrateCustomRadio = new System.Windows.Forms.RadioButton();
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
            this.ReceiveDataGroup = new System.Windows.Forms.GroupBox();
            this.ReceivedDataClearButton = new System.Windows.Forms.Button();
            this.ReceivedDataHexCheckbox = new System.Windows.Forms.CheckBox();
            this.ReceivedDataTimestampCheckbox = new System.Windows.Forms.CheckBox();
            this.ReceivedDataClearOnConnectCheckbox = new System.Windows.Forms.CheckBox();
            this.ReceivedDataAutoscrollCheckbox = new System.Windows.Forms.CheckBox();
            this.SerialPortDtrCheckbox = new System.Windows.Forms.CheckBox();
            this.ReceivedDataTextBox = new System.Windows.Forms.RichTextBox();
            this.ReceivedDataTextBoxContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReceivedDataAutoscrollContextitem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReceivedDataClearContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReceivedDataClearOnConnectContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReceivedDataFontContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReceivedDataHexContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReceivedDataTimestampContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemFontDialog = new System.Windows.Forms.FontDialog();
            this.TransmitDataGroup = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TransmitDataMultilineTerminateCheckbox = new System.Windows.Forms.CheckBox();
            this.TransmitData4TerminateCheckbox = new System.Windows.Forms.CheckBox();
            this.TransmitData3TerminateCheckbox = new System.Windows.Forms.CheckBox();
            this.TransmitData2TerminateCheckbox = new System.Windows.Forms.CheckBox();
            this.TransmitData1TerminateCheckbox = new System.Windows.Forms.CheckBox();
            this.TransmitDataMultilineSendButton = new System.Windows.Forms.Button();
            this.TransmitDataMultiLineTextBox = new System.Windows.Forms.TextBox();
            this.TransmitDataMultiLineContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TransmitDataMultiLineClearOnSendContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransmitDataMultiLineTerminateContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransmitData3SendButton = new System.Windows.Forms.Button();
            this.TransmitData3TextBox = new System.Windows.Forms.TextBox();
            this.TransmitData3ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TransmitData3ClearOnSendContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransmitData3HexContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransmitData3TerminateContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransmitData3HexCheckbox = new System.Windows.Forms.CheckBox();
            this.TransmitData2SendButton = new System.Windows.Forms.Button();
            this.TransmitData2TextBox = new System.Windows.Forms.TextBox();
            this.TransmitData2ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TransmitData2ClearOnSendContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransmitData2HexContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransmitData2TerminateContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransmitData2HexCheckbox = new System.Windows.Forms.CheckBox();
            this.TransmitData4HexCheckbox = new System.Windows.Forms.CheckBox();
            this.TransmitData1SendButton = new System.Windows.Forms.Button();
            this.TransmitData1TextBox = new System.Windows.Forms.TextBox();
            this.TransmitData1ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TransmitData1ClearOnSendContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransmitData1HexContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransmitData1TerminateContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransmittedDataClearButton = new System.Windows.Forms.Button();
            this.TransmitData1HexCheckbox = new System.Windows.Forms.CheckBox();
            this.TransmittedDataTimestampCheckbox = new System.Windows.Forms.CheckBox();
            this.TransmittedDataClearOnConnectCheckbox = new System.Windows.Forms.CheckBox();
            this.TransmittedDataAutoscrollCheckbox = new System.Windows.Forms.CheckBox();
            this.TransmitData4SendButton = new System.Windows.Forms.Button();
            this.TransmitData4TextBox = new System.Windows.Forms.TextBox();
            this.TransmitData4ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TransmitData4ClearOnSendContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransmitData4HexContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransmitData4TerminateContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransmittedDataTextBox = new System.Windows.Forms.RichTextBox();
            this.TransmittedDataTextBoxContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TransmittedDataAutoscrollContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransmittedDataClearContextitem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransmittedDataClearOnConnectContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransmittedDataTimestampContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TerminalNotes = new System.Windows.Forms.TextBox();
            this.ComPortGroup.SuspendLayout();
            this.BaudGroup.SuspendLayout();
            this.DataBitsGroup.SuspendLayout();
            this.ParityGroup.SuspendLayout();
            this.StopBitsGroup.SuspendLayout();
            this.HandshakeGroup.SuspendLayout();
            this.TransmitTerminationGroup.SuspendLayout();
            this.ReceiveDataGroup.SuspendLayout();
            this.ReceivedDataTextBoxContextMenu.SuspendLayout();
            this.TransmitDataGroup.SuspendLayout();
            this.TransmitDataMultiLineContextMenu.SuspendLayout();
            this.TransmitData3ContextMenu.SuspendLayout();
            this.TransmitData2ContextMenu.SuspendLayout();
            this.TransmitData1ContextMenu.SuspendLayout();
            this.TransmitData4ContextMenu.SuspendLayout();
            this.TransmittedDataTextBoxContextMenu.SuspendLayout();
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
            this.BaudGroup.Controls.Add(this.BaudrateCustomTextbox);
            this.BaudGroup.Controls.Add(this.BaudrateCustomRadio);
            this.BaudGroup.Controls.Add(this.Baudrate57600Radio);
            this.BaudGroup.Controls.Add(this.Baudrate14400Radio);
            this.BaudGroup.Controls.Add(this.Baudrate115200Radio);
            this.BaudGroup.Controls.Add(this.Baudrate19200Radio);
            this.BaudGroup.Controls.Add(this.Baudrate9600Radio);
            this.BaudGroup.Location = new System.Drawing.Point(134, 10);
            this.BaudGroup.Margin = new System.Windows.Forms.Padding(5);
            this.BaudGroup.Name = "BaudGroup";
            this.BaudGroup.Padding = new System.Windows.Forms.Padding(0);
            this.BaudGroup.Size = new System.Drawing.Size(204, 140);
            this.BaudGroup.TabIndex = 3;
            this.BaudGroup.TabStop = false;
            this.BaudGroup.Text = "Baudrate";
            // 
            // BaudrateCustomTextbox
            // 
            this.BaudrateCustomTextbox.Location = new System.Drawing.Point(105, 42);
            this.BaudrateCustomTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.BaudrateCustomTextbox.MaxLength = 7;
            this.BaudrateCustomTextbox.Name = "BaudrateCustomTextbox";
            this.BaudrateCustomTextbox.Size = new System.Drawing.Size(94, 26);
            this.BaudrateCustomTextbox.TabIndex = 10;
            this.BaudrateCustomTextbox.TextChanged += new System.EventHandler(this.BaudrateCustomTextboxChanged);
            this.BaudrateCustomTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BaudrateCustomTextboxKeyPress);
            // 
            // BaudrateCustomRadio
            // 
            this.BaudrateCustomRadio.Location = new System.Drawing.Point(105, 20);
            this.BaudrateCustomRadio.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.BaudrateCustomRadio.Name = "BaudrateCustomRadio";
            this.BaudrateCustomRadio.Size = new System.Drawing.Size(94, 22);
            this.BaudrateCustomRadio.TabIndex = 9;
            this.BaudrateCustomRadio.Tag = "Custom";
            this.BaudrateCustomRadio.Text = "Custom";
            this.BaudrateCustomRadio.UseVisualStyleBackColor = true;
            this.BaudrateCustomRadio.CheckedChanged += new System.EventHandler(this.BaudrateChanged);
            // 
            // Baudrate57600Radio
            // 
            this.Baudrate57600Radio.Location = new System.Drawing.Point(10, 86);
            this.Baudrate57600Radio.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.Baudrate57600Radio.Name = "Baudrate57600Radio";
            this.Baudrate57600Radio.Size = new System.Drawing.Size(85, 20);
            this.Baudrate57600Radio.TabIndex = 7;
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
            this.Baudrate14400Radio.TabIndex = 5;
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
            this.Baudrate115200Radio.TabIndex = 8;
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
            this.Baudrate19200Radio.TabIndex = 6;
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
            this.Baudrate9600Radio.TabIndex = 1;
            this.Baudrate9600Radio.Tag = "9600";
            this.Baudrate9600Radio.Text = "9600";
            this.Baudrate9600Radio.UseVisualStyleBackColor = true;
            this.Baudrate9600Radio.CheckedChanged += new System.EventHandler(this.BaudrateChanged);
            // 
            // DataBitsGroup
            // 
            this.DataBitsGroup.Controls.Add(this.DataBits8Radio);
            this.DataBitsGroup.Location = new System.Drawing.Point(453, 10);
            this.DataBitsGroup.Margin = new System.Windows.Forms.Padding(5);
            this.DataBitsGroup.Name = "DataBitsGroup";
            this.DataBitsGroup.Padding = new System.Windows.Forms.Padding(0);
            this.DataBitsGroup.Size = new System.Drawing.Size(95, 52);
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
            this.ParityOddRadio.TabIndex = 1;
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
            this.ParitySpaceRadio.TabIndex = 4;
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
            this.ParityMarkRadio.TabIndex = 3;
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
            this.ParityNoneRadio.TabIndex = 0;
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
            this.ParityEvenRadio.TabIndex = 2;
            this.ParityEvenRadio.Tag = "2";
            this.ParityEvenRadio.Text = "Even";
            this.ParityEvenRadio.UseVisualStyleBackColor = true;
            this.ParityEvenRadio.CheckedChanged += new System.EventHandler(this.ParityChanged);
            // 
            // StopBitsGroup
            // 
            this.StopBitsGroup.Controls.Add(this.StopBitsTwoRadio);
            this.StopBitsGroup.Controls.Add(this.StopBitsOneRadio);
            this.StopBitsGroup.Location = new System.Drawing.Point(453, 72);
            this.StopBitsGroup.Margin = new System.Windows.Forms.Padding(5);
            this.StopBitsGroup.Name = "StopBitsGroup";
            this.StopBitsGroup.Padding = new System.Windows.Forms.Padding(0);
            this.StopBitsGroup.Size = new System.Drawing.Size(95, 78);
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
            this.StopBitsTwoRadio.TabIndex = 1;
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
            this.StopBitsOneRadio.TabIndex = 0;
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
            this.HandshakeNoneRadio.TabIndex = 0;
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
            this.HandshakeRTSRadio.TabIndex = 1;
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
            this.TransmitTerminationCrLfRadio.Location = new System.Drawing.Point(6, 65);
            this.TransmitTerminationCrLfRadio.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.TransmitTerminationCrLfRadio.Name = "TransmitTerminationCrLfRadio";
            this.TransmitTerminationCrLfRadio.Size = new System.Drawing.Size(126, 24);
            this.TransmitTerminationCrLfRadio.TabIndex = 2;
            this.TransmitTerminationCrLfRadio.Tag = "\\r\\n";
            this.TransmitTerminationCrLfRadio.Text = "CR+LF (\\r\\n)";
            this.TransmitTerminationCrLfRadio.UseVisualStyleBackColor = true;
            this.TransmitTerminationCrLfRadio.CheckedChanged += new System.EventHandler(this.TransmitTerminationChanged);
            // 
            // TransmitTerminationLfRadio
            // 
            this.TransmitTerminationLfRadio.AutoSize = true;
            this.TransmitTerminationLfRadio.Location = new System.Drawing.Point(6, 40);
            this.TransmitTerminationLfRadio.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.TransmitTerminationLfRadio.Name = "TransmitTerminationLfRadio";
            this.TransmitTerminationLfRadio.Size = new System.Drawing.Size(81, 24);
            this.TransmitTerminationLfRadio.TabIndex = 1;
            this.TransmitTerminationLfRadio.Tag = "\\n";
            this.TransmitTerminationLfRadio.Text = "LF (\\n)";
            this.TransmitTerminationLfRadio.UseVisualStyleBackColor = true;
            this.TransmitTerminationLfRadio.CheckedChanged += new System.EventHandler(this.TransmitTerminationChanged);
            // 
            // TransmitTerminationCrRadio
            // 
            this.TransmitTerminationCrRadio.AutoSize = true;
            this.TransmitTerminationCrRadio.Checked = true;
            this.TransmitTerminationCrRadio.Location = new System.Drawing.Point(5, 18);
            this.TransmitTerminationCrRadio.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.TransmitTerminationCrRadio.Name = "TransmitTerminationCrRadio";
            this.TransmitTerminationCrRadio.Size = new System.Drawing.Size(82, 24);
            this.TransmitTerminationCrRadio.TabIndex = 0;
            this.TransmitTerminationCrRadio.TabStop = true;
            this.TransmitTerminationCrRadio.Tag = "\\r";
            this.TransmitTerminationCrRadio.Text = "CR (\\r)";
            this.TransmitTerminationCrRadio.UseVisualStyleBackColor = true;
            this.TransmitTerminationCrRadio.CheckedChanged += new System.EventHandler(this.TransmitTerminationChanged);
            // 
            // ReceiveDataGroup
            // 
            this.ReceiveDataGroup.Controls.Add(this.ReceivedDataClearButton);
            this.ReceiveDataGroup.Controls.Add(this.ReceivedDataHexCheckbox);
            this.ReceiveDataGroup.Controls.Add(this.ReceivedDataTimestampCheckbox);
            this.ReceiveDataGroup.Controls.Add(this.ReceivedDataClearOnConnectCheckbox);
            this.ReceiveDataGroup.Controls.Add(this.ReceivedDataAutoscrollCheckbox);
            this.ReceiveDataGroup.Controls.Add(this.SerialPortDtrCheckbox);
            this.ReceiveDataGroup.Controls.Add(this.ReceivedDataTextBox);
            this.ReceiveDataGroup.Location = new System.Drawing.Point(10, 154);
            this.ReceiveDataGroup.Name = "ReceiveDataGroup";
            this.ReceiveDataGroup.Size = new System.Drawing.Size(1011, 327);
            this.ReceiveDataGroup.TabIndex = 11;
            this.ReceiveDataGroup.TabStop = false;
            this.ReceiveDataGroup.Text = "Receive";
            // 
            // ReceivedDataClearButton
            // 
            this.ReceivedDataClearButton.AutoSize = true;
            this.ReceivedDataClearButton.Location = new System.Drawing.Point(10, 25);
            this.ReceivedDataClearButton.Name = "ReceivedDataClearButton";
            this.ReceivedDataClearButton.Size = new System.Drawing.Size(75, 30);
            this.ReceivedDataClearButton.TabIndex = 0;
            this.ReceivedDataClearButton.Text = "Clear";
            this.ReceivedDataClearButton.UseVisualStyleBackColor = true;
            this.ReceivedDataClearButton.Click += new System.EventHandler(this.ReceivedDataClear_Click);
            // 
            // ReceivedDataHexCheckbox
            // 
            this.ReceivedDataHexCheckbox.AutoSize = true;
            this.ReceivedDataHexCheckbox.Checked = global::Terminal.Properties.Settings.Default.ReceivedDataHexEnabled;
            this.ReceivedDataHexCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Terminal.Properties.Settings.Default, "ReceivedDataHexEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ReceivedDataHexCheckbox.Location = new System.Drawing.Point(487, 29);
            this.ReceivedDataHexCheckbox.Name = "ReceivedDataHexCheckbox";
            this.ReceivedDataHexCheckbox.Size = new System.Drawing.Size(61, 24);
            this.ReceivedDataHexCheckbox.TabIndex = 4;
            this.ReceivedDataHexCheckbox.Text = "Hex";
            this.ReceivedDataHexCheckbox.UseVisualStyleBackColor = true;
            this.ReceivedDataHexCheckbox.CheckedChanged += new System.EventHandler(this.ReceivedDataHexChanged);
            // 
            // ReceivedDataTimestampCheckbox
            // 
            this.ReceivedDataTimestampCheckbox.AutoSize = true;
            this.ReceivedDataTimestampCheckbox.Checked = global::Terminal.Properties.Settings.Default.ReceivedDataTimestampEnabled;
            this.ReceivedDataTimestampCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Terminal.Properties.Settings.Default, "ReceivedDataTimestampEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ReceivedDataTimestampCheckbox.Location = new System.Drawing.Point(367, 29);
            this.ReceivedDataTimestampCheckbox.Name = "ReceivedDataTimestampCheckbox";
            this.ReceivedDataTimestampCheckbox.Size = new System.Drawing.Size(114, 24);
            this.ReceivedDataTimestampCheckbox.TabIndex = 3;
            this.ReceivedDataTimestampCheckbox.Text = "Timestamp";
            this.ReceivedDataTimestampCheckbox.UseVisualStyleBackColor = true;
            this.ReceivedDataTimestampCheckbox.CheckedChanged += new System.EventHandler(this.ReceivedDataTimestampChanged);
            // 
            // ReceivedDataClearOnConnectCheckbox
            // 
            this.ReceivedDataClearOnConnectCheckbox.AutoSize = true;
            this.ReceivedDataClearOnConnectCheckbox.Checked = global::Terminal.Properties.Settings.Default.ReceivedDataClearOnConnect;
            this.ReceivedDataClearOnConnectCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Terminal.Properties.Settings.Default, "ReceivedDataClearOnConnect", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ReceivedDataClearOnConnectCheckbox.Location = new System.Drawing.Point(203, 29);
            this.ReceivedDataClearOnConnectCheckbox.Name = "ReceivedDataClearOnConnectCheckbox";
            this.ReceivedDataClearOnConnectCheckbox.Size = new System.Drawing.Size(158, 24);
            this.ReceivedDataClearOnConnectCheckbox.TabIndex = 2;
            this.ReceivedDataClearOnConnectCheckbox.Text = "Clear on connect";
            this.ReceivedDataClearOnConnectCheckbox.UseVisualStyleBackColor = true;
            this.ReceivedDataClearOnConnectCheckbox.CheckedChanged += new System.EventHandler(this.ReceivedDataClearOnconnect_Changed);
            // 
            // ReceivedDataAutoscrollCheckbox
            // 
            this.ReceivedDataAutoscrollCheckbox.AutoSize = true;
            this.ReceivedDataAutoscrollCheckbox.Checked = global::Terminal.Properties.Settings.Default.ReiceveDataAutoscrollEnabled;
            this.ReceivedDataAutoscrollCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Terminal.Properties.Settings.Default, "ReiceveDataAutoscrollEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ReceivedDataAutoscrollCheckbox.Location = new System.Drawing.Point(91, 29);
            this.ReceivedDataAutoscrollCheckbox.Name = "ReceivedDataAutoscrollCheckbox";
            this.ReceivedDataAutoscrollCheckbox.Size = new System.Drawing.Size(106, 24);
            this.ReceivedDataAutoscrollCheckbox.TabIndex = 1;
            this.ReceivedDataAutoscrollCheckbox.Text = "Autoscroll";
            this.ReceivedDataAutoscrollCheckbox.UseVisualStyleBackColor = true;
            this.ReceivedDataAutoscrollCheckbox.CheckedChanged += new System.EventHandler(this.ReceivedDataAutoscrollContextMenuChanged);
            // 
            // SerialPortDtrCheckbox
            // 
            this.SerialPortDtrCheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SerialPortDtrCheckbox.AutoSize = true;
            this.SerialPortDtrCheckbox.Location = new System.Drawing.Point(951, 25);
            this.SerialPortDtrCheckbox.Name = "SerialPortDtrCheckbox";
            this.SerialPortDtrCheckbox.Size = new System.Drawing.Size(54, 30);
            this.SerialPortDtrCheckbox.TabIndex = 5;
            this.SerialPortDtrCheckbox.Text = "DTR";
            this.SerialPortDtrCheckbox.UseVisualStyleBackColor = true;
            this.SerialPortDtrCheckbox.CheckedChanged += new System.EventHandler(this.SerialPortDtrChanged);
            // 
            // ReceivedDataTextBox
            // 
            this.ReceivedDataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReceivedDataTextBox.ContextMenuStrip = this.ReceivedDataTextBoxContextMenu;
            this.ReceivedDataTextBox.DetectUrls = false;
            this.ReceivedDataTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceivedDataTextBox.Location = new System.Drawing.Point(10, 61);
            this.ReceivedDataTextBox.Name = "ReceivedDataTextBox";
            this.ReceivedDataTextBox.ReadOnly = true;
            this.ReceivedDataTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.ReceivedDataTextBox.Size = new System.Drawing.Size(995, 260);
            this.ReceivedDataTextBox.TabIndex = 6;
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
            this.ReceivedDataHexContextItem,
            this.ReceivedDataTimestampContextItem});
            this.ReceivedDataTextBoxContextMenu.Name = "ReceivedDataTextBoxContextMenu";
            this.ReceivedDataTextBoxContextMenu.ShowCheckMargin = true;
            this.ReceivedDataTextBoxContextMenu.ShowImageMargin = false;
            this.ReceivedDataTextBoxContextMenu.Size = new System.Drawing.Size(190, 148);
            // 
            // ReceivedDataAutoscrollContextitem
            // 
            this.ReceivedDataAutoscrollContextitem.Checked = global::Terminal.Properties.Settings.Default.ReiceveDataAutoscrollEnabled;
            this.ReceivedDataAutoscrollContextitem.CheckOnClick = true;
            this.ReceivedDataAutoscrollContextitem.Name = "ReceivedDataAutoscrollContextitem";
            this.ReceivedDataAutoscrollContextitem.Size = new System.Drawing.Size(189, 24);
            this.ReceivedDataAutoscrollContextitem.Text = "Autoscroll";
            this.ReceivedDataAutoscrollContextitem.CheckedChanged += new System.EventHandler(this.ReceivedDataAutoscrollContextMenuChanged);
            // 
            // ReceivedDataClearContextItem
            // 
            this.ReceivedDataClearContextItem.Name = "ReceivedDataClearContextItem";
            this.ReceivedDataClearContextItem.Size = new System.Drawing.Size(189, 24);
            this.ReceivedDataClearContextItem.Text = "Clear";
            this.ReceivedDataClearContextItem.Click += new System.EventHandler(this.ReceivedDataClear_Click);
            // 
            // ReceivedDataClearOnConnectContextItem
            // 
            this.ReceivedDataClearOnConnectContextItem.Checked = global::Terminal.Properties.Settings.Default.ReceivedDataClearOnConnect;
            this.ReceivedDataClearOnConnectContextItem.CheckOnClick = true;
            this.ReceivedDataClearOnConnectContextItem.Name = "ReceivedDataClearOnConnectContextItem";
            this.ReceivedDataClearOnConnectContextItem.Size = new System.Drawing.Size(189, 24);
            this.ReceivedDataClearOnConnectContextItem.Text = "Clear on connect";
            this.ReceivedDataClearOnConnectContextItem.CheckedChanged += new System.EventHandler(this.ReceivedDataClearOnconnect_Changed);
            // 
            // ReceivedDataFontContextItem
            // 
            this.ReceivedDataFontContextItem.Name = "ReceivedDataFontContextItem";
            this.ReceivedDataFontContextItem.Size = new System.Drawing.Size(189, 24);
            this.ReceivedDataFontContextItem.Text = "Font";
            this.ReceivedDataFontContextItem.Click += new System.EventHandler(this.SystemFont_Click);
            // 
            // ReceivedDataHexContextItem
            // 
            this.ReceivedDataHexContextItem.Checked = global::Terminal.Properties.Settings.Default.ReceivedDataHexEnabled;
            this.ReceivedDataHexContextItem.CheckOnClick = true;
            this.ReceivedDataHexContextItem.Name = "ReceivedDataHexContextItem";
            this.ReceivedDataHexContextItem.Size = new System.Drawing.Size(189, 24);
            this.ReceivedDataHexContextItem.Text = "Hex";
            this.ReceivedDataHexContextItem.CheckedChanged += new System.EventHandler(this.ReceivedDataHexChanged);
            // 
            // ReceivedDataTimestampContextItem
            // 
            this.ReceivedDataTimestampContextItem.Checked = global::Terminal.Properties.Settings.Default.ReceivedDataTimestampEnabled;
            this.ReceivedDataTimestampContextItem.CheckOnClick = true;
            this.ReceivedDataTimestampContextItem.Name = "ReceivedDataTimestampContextItem";
            this.ReceivedDataTimestampContextItem.Size = new System.Drawing.Size(189, 24);
            this.ReceivedDataTimestampContextItem.Text = "Timestamp";
            this.ReceivedDataTimestampContextItem.CheckedChanged += new System.EventHandler(this.ReceivedDataTimestampChanged);
            // 
            // TransmitDataGroup
            // 
            this.TransmitDataGroup.Controls.Add(this.textBox1);
            this.TransmitDataGroup.Controls.Add(this.TransmitDataMultilineTerminateCheckbox);
            this.TransmitDataGroup.Controls.Add(this.TransmitData4TerminateCheckbox);
            this.TransmitDataGroup.Controls.Add(this.TransmitData3TerminateCheckbox);
            this.TransmitDataGroup.Controls.Add(this.TransmitData2TerminateCheckbox);
            this.TransmitDataGroup.Controls.Add(this.TransmitData1TerminateCheckbox);
            this.TransmitDataGroup.Controls.Add(this.TransmitDataMultilineSendButton);
            this.TransmitDataGroup.Controls.Add(this.TransmitDataMultiLineTextBox);
            this.TransmitDataGroup.Controls.Add(this.TransmitData3SendButton);
            this.TransmitDataGroup.Controls.Add(this.TransmitData3TextBox);
            this.TransmitDataGroup.Controls.Add(this.TransmitData3HexCheckbox);
            this.TransmitDataGroup.Controls.Add(this.TransmitData2SendButton);
            this.TransmitDataGroup.Controls.Add(this.TransmitData2TextBox);
            this.TransmitDataGroup.Controls.Add(this.TransmitData2HexCheckbox);
            this.TransmitDataGroup.Controls.Add(this.TransmitData4HexCheckbox);
            this.TransmitDataGroup.Controls.Add(this.TransmitData1SendButton);
            this.TransmitDataGroup.Controls.Add(this.TransmitData1TextBox);
            this.TransmitDataGroup.Controls.Add(this.TransmittedDataClearButton);
            this.TransmitDataGroup.Controls.Add(this.TransmitData1HexCheckbox);
            this.TransmitDataGroup.Controls.Add(this.TransmittedDataTimestampCheckbox);
            this.TransmitDataGroup.Controls.Add(this.TransmittedDataClearOnConnectCheckbox);
            this.TransmitDataGroup.Controls.Add(this.TransmittedDataAutoscrollCheckbox);
            this.TransmitDataGroup.Controls.Add(this.TransmitData4SendButton);
            this.TransmitDataGroup.Controls.Add(this.TransmitData4TextBox);
            this.TransmitDataGroup.Controls.Add(this.TransmittedDataTextBox);
            this.TransmitDataGroup.Location = new System.Drawing.Point(12, 487);
            this.TransmitDataGroup.Name = "TransmitDataGroup";
            this.TransmitDataGroup.Size = new System.Drawing.Size(1009, 507);
            this.TransmitDataGroup.TabIndex = 12;
            this.TransmitDataGroup.TabStop = false;
            this.TransmitDataGroup.Text = "Transmit";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(756, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(247, 70);
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = "Please note that each line is terminated with the selected termination option.";
            // 
            // TransmitDataMultilineTerminateCheckbox
            // 
            this.TransmitDataMultilineTerminateCheckbox.AutoSize = true;
            this.TransmitDataMultilineTerminateCheckbox.Checked = global::Terminal.Properties.Settings.Default.TransmitDataMultiLineTerminateEnabled;
            this.TransmitDataMultilineTerminateCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Terminal.Properties.Settings.Default, "TransmitDataMultiLineTerminateEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TransmitDataMultilineTerminateCheckbox.Location = new System.Drawing.Point(897, 160);
            this.TransmitDataMultilineTerminateCheckbox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.TransmitDataMultilineTerminateCheckbox.Name = "TransmitDataMultilineTerminateCheckbox";
            this.TransmitDataMultilineTerminateCheckbox.Size = new System.Drawing.Size(106, 24);
            this.TransmitDataMultilineTerminateCheckbox.TabIndex = 6;
            this.TransmitDataMultilineTerminateCheckbox.Text = "Terminate";
            this.TransmitDataMultilineTerminateCheckbox.UseVisualStyleBackColor = true;
            this.TransmitDataMultilineTerminateCheckbox.CheckedChanged += new System.EventHandler(this.TransmitDataMultiLineTerminateChanged);
            // 
            // TransmitData4TerminateCheckbox
            // 
            this.TransmitData4TerminateCheckbox.AutoSize = true;
            this.TransmitData4TerminateCheckbox.Checked = global::Terminal.Properties.Settings.Default.TransmitData4TerminateEnabled;
            this.TransmitData4TerminateCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Terminal.Properties.Settings.Default, "TransmitData4TerminateEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TransmitData4TerminateCheckbox.Location = new System.Drawing.Point(897, 304);
            this.TransmitData4TerminateCheckbox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.TransmitData4TerminateCheckbox.Name = "TransmitData4TerminateCheckbox";
            this.TransmitData4TerminateCheckbox.Size = new System.Drawing.Size(106, 24);
            this.TransmitData4TerminateCheckbox.TabIndex = 21;
            this.TransmitData4TerminateCheckbox.Text = "Terminate";
            this.TransmitData4TerminateCheckbox.UseVisualStyleBackColor = true;
            this.TransmitData4TerminateCheckbox.CheckedChanged += new System.EventHandler(this.TransmitData4TerminateChanged);
            // 
            // TransmitData3TerminateCheckbox
            // 
            this.TransmitData3TerminateCheckbox.AutoSize = true;
            this.TransmitData3TerminateCheckbox.Checked = global::Terminal.Properties.Settings.Default.TransmitData3TerminateEnabled;
            this.TransmitData3TerminateCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Terminal.Properties.Settings.Default, "TransmitData3TerminateEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TransmitData3TerminateCheckbox.Location = new System.Drawing.Point(897, 268);
            this.TransmitData3TerminateCheckbox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.TransmitData3TerminateCheckbox.Name = "TransmitData3TerminateCheckbox";
            this.TransmitData3TerminateCheckbox.Size = new System.Drawing.Size(106, 24);
            this.TransmitData3TerminateCheckbox.TabIndex = 17;
            this.TransmitData3TerminateCheckbox.Text = "Terminate";
            this.TransmitData3TerminateCheckbox.UseVisualStyleBackColor = true;
            this.TransmitData3TerminateCheckbox.CheckedChanged += new System.EventHandler(this.TransmitData3TerminateChanged);
            // 
            // TransmitData2TerminateCheckbox
            // 
            this.TransmitData2TerminateCheckbox.AutoSize = true;
            this.TransmitData2TerminateCheckbox.Checked = global::Terminal.Properties.Settings.Default.TransmitData2TerminateEnabled;
            this.TransmitData2TerminateCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Terminal.Properties.Settings.Default, "TransmitData2TerminateEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TransmitData2TerminateCheckbox.Location = new System.Drawing.Point(897, 232);
            this.TransmitData2TerminateCheckbox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.TransmitData2TerminateCheckbox.Name = "TransmitData2TerminateCheckbox";
            this.TransmitData2TerminateCheckbox.Size = new System.Drawing.Size(106, 24);
            this.TransmitData2TerminateCheckbox.TabIndex = 13;
            this.TransmitData2TerminateCheckbox.Text = "Terminate";
            this.TransmitData2TerminateCheckbox.UseVisualStyleBackColor = true;
            this.TransmitData2TerminateCheckbox.CheckedChanged += new System.EventHandler(this.TransmitData2TerminateChanged);
            // 
            // TransmitData1TerminateCheckbox
            // 
            this.TransmitData1TerminateCheckbox.AutoSize = true;
            this.TransmitData1TerminateCheckbox.Checked = global::Terminal.Properties.Settings.Default.TransmitData1TerminateEnabled;
            this.TransmitData1TerminateCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Terminal.Properties.Settings.Default, "TransmitData1TerminateEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TransmitData1TerminateCheckbox.Location = new System.Drawing.Point(897, 196);
            this.TransmitData1TerminateCheckbox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.TransmitData1TerminateCheckbox.Name = "TransmitData1TerminateCheckbox";
            this.TransmitData1TerminateCheckbox.Size = new System.Drawing.Size(106, 24);
            this.TransmitData1TerminateCheckbox.TabIndex = 9;
            this.TransmitData1TerminateCheckbox.Text = "Terminate";
            this.TransmitData1TerminateCheckbox.UseVisualStyleBackColor = true;
            this.TransmitData1TerminateCheckbox.CheckedChanged += new System.EventHandler(this.TransmitData1TerminateChanged);
            // 
            // TransmitDataMultilineSendButton
            // 
            this.TransmitDataMultilineSendButton.AutoSize = true;
            this.TransmitDataMultilineSendButton.Enabled = false;
            this.TransmitDataMultilineSendButton.Location = new System.Drawing.Point(755, 156);
            this.TransmitDataMultilineSendButton.Name = "TransmitDataMultilineSendButton";
            this.TransmitDataMultilineSendButton.Size = new System.Drawing.Size(75, 30);
            this.TransmitDataMultilineSendButton.TabIndex = 5;
            this.TransmitDataMultilineSendButton.Text = "Send";
            this.TransmitDataMultilineSendButton.UseVisualStyleBackColor = true;
            this.TransmitDataMultilineSendButton.Click += new System.EventHandler(this.TransmitDataMultiLineSend_Click);
            // 
            // TransmitDataMultiLineTextBox
            // 
            this.TransmitDataMultiLineTextBox.AcceptsReturn = true;
            this.TransmitDataMultiLineTextBox.AcceptsTab = true;
            this.TransmitDataMultiLineTextBox.AllowDrop = true;
            this.TransmitDataMultiLineTextBox.ContextMenuStrip = this.TransmitDataMultiLineContextMenu;
            this.TransmitDataMultiLineTextBox.Location = new System.Drawing.Point(9, 61);
            this.TransmitDataMultiLineTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 7);
            this.TransmitDataMultiLineTextBox.MaxLength = 4069;
            this.TransmitDataMultiLineTextBox.Multiline = true;
            this.TransmitDataMultiLineTextBox.Name = "TransmitDataMultiLineTextBox";
            this.TransmitDataMultiLineTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TransmitDataMultiLineTextBox.Size = new System.Drawing.Size(740, 123);
            this.TransmitDataMultiLineTextBox.TabIndex = 4;
            this.TransmitDataMultiLineTextBox.WordWrap = false;
            this.TransmitDataMultiLineTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TransmitDataMultiLine_KeyDown);
            // 
            // TransmitDataMultiLineContextMenu
            // 
            this.TransmitDataMultiLineContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TransmitDataMultiLineContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TransmitDataMultiLineClearOnSendContextItem,
            this.TransmitDataMultiLineTerminateContextItem});
            this.TransmitDataMultiLineContextMenu.Name = "TransmitDataMultiLineContextMenu";
            this.TransmitDataMultiLineContextMenu.Size = new System.Drawing.Size(169, 52);
            // 
            // TransmitDataMultiLineClearOnSendContextItem
            // 
            this.TransmitDataMultiLineClearOnSendContextItem.Checked = global::Terminal.Properties.Settings.Default.TransmitDataMultiLineClearOnSendEnabled;
            this.TransmitDataMultiLineClearOnSendContextItem.CheckOnClick = true;
            this.TransmitDataMultiLineClearOnSendContextItem.Name = "TransmitDataMultiLineClearOnSendContextItem";
            this.TransmitDataMultiLineClearOnSendContextItem.Size = new System.Drawing.Size(168, 24);
            this.TransmitDataMultiLineClearOnSendContextItem.Text = "Clear on send";
            this.TransmitDataMultiLineClearOnSendContextItem.CheckedChanged += new System.EventHandler(this.TransmitDataMultiLineClearOnSendChanged);
            // 
            // TransmitDataMultiLineTerminateContextItem
            // 
            this.TransmitDataMultiLineTerminateContextItem.Checked = global::Terminal.Properties.Settings.Default.TransmitDataMultiLineTerminateEnabled;
            this.TransmitDataMultiLineTerminateContextItem.CheckOnClick = true;
            this.TransmitDataMultiLineTerminateContextItem.Name = "TransmitDataMultiLineTerminateContextItem";
            this.TransmitDataMultiLineTerminateContextItem.Size = new System.Drawing.Size(168, 24);
            this.TransmitDataMultiLineTerminateContextItem.Text = "Terminate";
            this.TransmitDataMultiLineTerminateContextItem.CheckedChanged += new System.EventHandler(this.TransmitDataMultiLineTerminateChanged);
            // 
            // TransmitData3SendButton
            // 
            this.TransmitData3SendButton.AutoSize = true;
            this.TransmitData3SendButton.Enabled = false;
            this.TransmitData3SendButton.Location = new System.Drawing.Point(755, 264);
            this.TransmitData3SendButton.Name = "TransmitData3SendButton";
            this.TransmitData3SendButton.Size = new System.Drawing.Size(75, 30);
            this.TransmitData3SendButton.TabIndex = 15;
            this.TransmitData3SendButton.Text = "Send";
            this.TransmitData3SendButton.UseVisualStyleBackColor = true;
            this.TransmitData3SendButton.Click += new System.EventHandler(this.TransmitData3Send_Click);
            // 
            // TransmitData3TextBox
            // 
            this.TransmitData3TextBox.AcceptsTab = true;
            this.TransmitData3TextBox.AllowDrop = true;
            this.TransmitData3TextBox.ContextMenuStrip = this.TransmitData3ContextMenu;
            this.TransmitData3TextBox.Location = new System.Drawing.Point(9, 266);
            this.TransmitData3TextBox.MaxLength = 4069;
            this.TransmitData3TextBox.Name = "TransmitData3TextBox";
            this.TransmitData3TextBox.Size = new System.Drawing.Size(740, 26);
            this.TransmitData3TextBox.TabIndex = 14;
            this.TransmitData3TextBox.WordWrap = false;
            this.TransmitData3TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TransmitData3_KeyDown);
            // 
            // TransmitData3ContextMenu
            // 
            this.TransmitData3ContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TransmitData3ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TransmitData3ClearOnSendContextItem,
            this.TransmitData3HexContextItem,
            this.TransmitData3TerminateContextItem});
            this.TransmitData3ContextMenu.Name = "TransmitDataMultiLineContextMenu";
            this.TransmitData3ContextMenu.Size = new System.Drawing.Size(169, 76);
            // 
            // TransmitData3ClearOnSendContextItem
            // 
            this.TransmitData3ClearOnSendContextItem.Checked = global::Terminal.Properties.Settings.Default.TransmitData3ClearOnSendEnabled;
            this.TransmitData3ClearOnSendContextItem.CheckOnClick = true;
            this.TransmitData3ClearOnSendContextItem.Name = "TransmitData3ClearOnSendContextItem";
            this.TransmitData3ClearOnSendContextItem.Size = new System.Drawing.Size(168, 24);
            this.TransmitData3ClearOnSendContextItem.Text = "Clear on send";
            this.TransmitData3ClearOnSendContextItem.CheckedChanged += new System.EventHandler(this.TransmitData3ClearOnSendChanged);
            // 
            // TransmitData3HexContextItem
            // 
            this.TransmitData3HexContextItem.Checked = global::Terminal.Properties.Settings.Default.TransmitData3HexEnabled;
            this.TransmitData3HexContextItem.CheckOnClick = true;
            this.TransmitData3HexContextItem.Name = "TransmitData3HexContextItem";
            this.TransmitData3HexContextItem.Size = new System.Drawing.Size(168, 24);
            this.TransmitData3HexContextItem.Text = "Hex";
            this.TransmitData3HexContextItem.CheckedChanged += new System.EventHandler(this.TransmitData3HexChanged);
            // 
            // TransmitData3TerminateContextItem
            // 
            this.TransmitData3TerminateContextItem.Checked = global::Terminal.Properties.Settings.Default.TransmitData3TerminateEnabled;
            this.TransmitData3TerminateContextItem.CheckOnClick = true;
            this.TransmitData3TerminateContextItem.Name = "TransmitData3TerminateContextItem";
            this.TransmitData3TerminateContextItem.Size = new System.Drawing.Size(168, 24);
            this.TransmitData3TerminateContextItem.Text = "Terminate";
            this.TransmitData3TerminateContextItem.CheckedChanged += new System.EventHandler(this.TransmitData3TerminateChanged);
            // 
            // TransmitData3HexCheckbox
            // 
            this.TransmitData3HexCheckbox.AutoSize = true;
            this.TransmitData3HexCheckbox.Checked = global::Terminal.Properties.Settings.Default.TransmitData3HexEnabled;
            this.TransmitData3HexCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Terminal.Properties.Settings.Default, "TransmitData3HexEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TransmitData3HexCheckbox.Location = new System.Drawing.Point(836, 268);
            this.TransmitData3HexCheckbox.Name = "TransmitData3HexCheckbox";
            this.TransmitData3HexCheckbox.Size = new System.Drawing.Size(61, 24);
            this.TransmitData3HexCheckbox.TabIndex = 16;
            this.TransmitData3HexCheckbox.Text = "Hex";
            this.TransmitData3HexCheckbox.UseVisualStyleBackColor = true;
            this.TransmitData3HexCheckbox.CheckedChanged += new System.EventHandler(this.TransmitData3HexChanged);
            // 
            // TransmitData2SendButton
            // 
            this.TransmitData2SendButton.AutoSize = true;
            this.TransmitData2SendButton.Enabled = false;
            this.TransmitData2SendButton.Location = new System.Drawing.Point(755, 228);
            this.TransmitData2SendButton.Name = "TransmitData2SendButton";
            this.TransmitData2SendButton.Size = new System.Drawing.Size(75, 30);
            this.TransmitData2SendButton.TabIndex = 11;
            this.TransmitData2SendButton.Text = "Send";
            this.TransmitData2SendButton.UseVisualStyleBackColor = true;
            this.TransmitData2SendButton.Click += new System.EventHandler(this.TransmitData2Send_Click);
            // 
            // TransmitData2TextBox
            // 
            this.TransmitData2TextBox.AcceptsTab = true;
            this.TransmitData2TextBox.AllowDrop = true;
            this.TransmitData2TextBox.ContextMenuStrip = this.TransmitData2ContextMenu;
            this.TransmitData2TextBox.Location = new System.Drawing.Point(9, 230);
            this.TransmitData2TextBox.MaxLength = 4069;
            this.TransmitData2TextBox.Name = "TransmitData2TextBox";
            this.TransmitData2TextBox.Size = new System.Drawing.Size(740, 26);
            this.TransmitData2TextBox.TabIndex = 10;
            this.TransmitData2TextBox.WordWrap = false;
            this.TransmitData2TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TransmitData2_KeyDown);
            // 
            // TransmitData2ContextMenu
            // 
            this.TransmitData2ContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TransmitData2ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TransmitData2ClearOnSendContextItem,
            this.TransmitData2HexContextItem,
            this.TransmitData2TerminateContextItem});
            this.TransmitData2ContextMenu.Name = "TransmitDataMultiLineContextMenu";
            this.TransmitData2ContextMenu.Size = new System.Drawing.Size(169, 76);
            // 
            // TransmitData2ClearOnSendContextItem
            // 
            this.TransmitData2ClearOnSendContextItem.Checked = global::Terminal.Properties.Settings.Default.TransmitData2ClearOnSendEnabled;
            this.TransmitData2ClearOnSendContextItem.CheckOnClick = true;
            this.TransmitData2ClearOnSendContextItem.Name = "TransmitData2ClearOnSendContextItem";
            this.TransmitData2ClearOnSendContextItem.Size = new System.Drawing.Size(168, 24);
            this.TransmitData2ClearOnSendContextItem.Text = "Clear on send";
            this.TransmitData2ClearOnSendContextItem.CheckedChanged += new System.EventHandler(this.TransmitData2ClearOnSendChanged);
            // 
            // TransmitData2HexContextItem
            // 
            this.TransmitData2HexContextItem.Checked = global::Terminal.Properties.Settings.Default.TransmitData2HexEnabled;
            this.TransmitData2HexContextItem.CheckOnClick = true;
            this.TransmitData2HexContextItem.Name = "TransmitData2HexContextItem";
            this.TransmitData2HexContextItem.Size = new System.Drawing.Size(168, 24);
            this.TransmitData2HexContextItem.Text = "Hex";
            this.TransmitData2HexContextItem.CheckedChanged += new System.EventHandler(this.TransmitData2HexChanged);
            // 
            // TransmitData2TerminateContextItem
            // 
            this.TransmitData2TerminateContextItem.Checked = global::Terminal.Properties.Settings.Default.TransmitData2TerminateEnabled;
            this.TransmitData2TerminateContextItem.CheckOnClick = true;
            this.TransmitData2TerminateContextItem.Name = "TransmitData2TerminateContextItem";
            this.TransmitData2TerminateContextItem.Size = new System.Drawing.Size(168, 24);
            this.TransmitData2TerminateContextItem.Text = "Terminate";
            this.TransmitData2TerminateContextItem.CheckedChanged += new System.EventHandler(this.TransmitData2TerminateChanged);
            // 
            // TransmitData2HexCheckbox
            // 
            this.TransmitData2HexCheckbox.AutoSize = true;
            this.TransmitData2HexCheckbox.Checked = global::Terminal.Properties.Settings.Default.TransmitData2HexEnabled;
            this.TransmitData2HexCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Terminal.Properties.Settings.Default, "TransmitData2HexEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TransmitData2HexCheckbox.Location = new System.Drawing.Point(836, 232);
            this.TransmitData2HexCheckbox.Name = "TransmitData2HexCheckbox";
            this.TransmitData2HexCheckbox.Size = new System.Drawing.Size(61, 24);
            this.TransmitData2HexCheckbox.TabIndex = 12;
            this.TransmitData2HexCheckbox.Text = "Hex";
            this.TransmitData2HexCheckbox.UseVisualStyleBackColor = true;
            this.TransmitData2HexCheckbox.CheckedChanged += new System.EventHandler(this.TransmitData2HexChanged);
            // 
            // TransmitData4HexCheckbox
            // 
            this.TransmitData4HexCheckbox.AutoSize = true;
            this.TransmitData4HexCheckbox.Checked = global::Terminal.Properties.Settings.Default.TransmitData4HexEnabled;
            this.TransmitData4HexCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Terminal.Properties.Settings.Default, "TransmitData4HexEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TransmitData4HexCheckbox.Location = new System.Drawing.Point(836, 304);
            this.TransmitData4HexCheckbox.Name = "TransmitData4HexCheckbox";
            this.TransmitData4HexCheckbox.Size = new System.Drawing.Size(61, 24);
            this.TransmitData4HexCheckbox.TabIndex = 20;
            this.TransmitData4HexCheckbox.Text = "Hex";
            this.TransmitData4HexCheckbox.UseVisualStyleBackColor = true;
            this.TransmitData4HexCheckbox.CheckedChanged += new System.EventHandler(this.TransmitData4HexChanged);
            // 
            // TransmitData1SendButton
            // 
            this.TransmitData1SendButton.AutoSize = true;
            this.TransmitData1SendButton.Enabled = false;
            this.TransmitData1SendButton.Location = new System.Drawing.Point(755, 192);
            this.TransmitData1SendButton.Name = "TransmitData1SendButton";
            this.TransmitData1SendButton.Size = new System.Drawing.Size(75, 30);
            this.TransmitData1SendButton.TabIndex = 21;
            this.TransmitData1SendButton.Text = "Send";
            this.TransmitData1SendButton.UseVisualStyleBackColor = true;
            this.TransmitData1SendButton.Click += new System.EventHandler(this.TransmitData1Send_Click);
            // 
            // TransmitData1TextBox
            // 
            this.TransmitData1TextBox.AcceptsTab = true;
            this.TransmitData1TextBox.AllowDrop = true;
            this.TransmitData1TextBox.ContextMenuStrip = this.TransmitData1ContextMenu;
            this.TransmitData1TextBox.Location = new System.Drawing.Point(9, 194);
            this.TransmitData1TextBox.MaxLength = 4069;
            this.TransmitData1TextBox.Name = "TransmitData1TextBox";
            this.TransmitData1TextBox.Size = new System.Drawing.Size(740, 26);
            this.TransmitData1TextBox.TabIndex = 7;
            this.TransmitData1TextBox.WordWrap = false;
            this.TransmitData1TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TransmitData1_KeyDown);
            // 
            // TransmitData1ContextMenu
            // 
            this.TransmitData1ContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TransmitData1ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TransmitData1ClearOnSendContextItem,
            this.TransmitData1HexContextItem,
            this.TransmitData1TerminateContextItem});
            this.TransmitData1ContextMenu.Name = "TransmitDataMultiLineContextMenu";
            this.TransmitData1ContextMenu.Size = new System.Drawing.Size(169, 76);
            // 
            // TransmitData1ClearOnSendContextItem
            // 
            this.TransmitData1ClearOnSendContextItem.Checked = global::Terminal.Properties.Settings.Default.TransmitData1ClearOnSendEnabled;
            this.TransmitData1ClearOnSendContextItem.CheckOnClick = true;
            this.TransmitData1ClearOnSendContextItem.Name = "TransmitData1ClearOnSendContextItem";
            this.TransmitData1ClearOnSendContextItem.Size = new System.Drawing.Size(168, 24);
            this.TransmitData1ClearOnSendContextItem.Text = "Clear on send";
            this.TransmitData1ClearOnSendContextItem.CheckedChanged += new System.EventHandler(this.TransmitData1ClearOnSendChanged);
            // 
            // TransmitData1HexContextItem
            // 
            this.TransmitData1HexContextItem.Checked = global::Terminal.Properties.Settings.Default.TransmitData1HexEnabled;
            this.TransmitData1HexContextItem.CheckOnClick = true;
            this.TransmitData1HexContextItem.Name = "TransmitData1HexContextItem";
            this.TransmitData1HexContextItem.Size = new System.Drawing.Size(168, 24);
            this.TransmitData1HexContextItem.Text = "Hex";
            this.TransmitData1HexContextItem.CheckedChanged += new System.EventHandler(this.TransmitData1HexChanged);
            // 
            // TransmitData1TerminateContextItem
            // 
            this.TransmitData1TerminateContextItem.Checked = global::Terminal.Properties.Settings.Default.TransmitData1TerminateEnabled;
            this.TransmitData1TerminateContextItem.CheckOnClick = true;
            this.TransmitData1TerminateContextItem.Name = "TransmitData1TerminateContextItem";
            this.TransmitData1TerminateContextItem.Size = new System.Drawing.Size(168, 24);
            this.TransmitData1TerminateContextItem.Text = "Terminate";
            this.TransmitData1TerminateContextItem.CheckedChanged += new System.EventHandler(this.TransmitData1TerminateChanged);
            // 
            // TransmittedDataClearButton
            // 
            this.TransmittedDataClearButton.AutoSize = true;
            this.TransmittedDataClearButton.Location = new System.Drawing.Point(8, 25);
            this.TransmittedDataClearButton.Name = "TransmittedDataClearButton";
            this.TransmittedDataClearButton.Size = new System.Drawing.Size(75, 30);
            this.TransmittedDataClearButton.TabIndex = 0;
            this.TransmittedDataClearButton.Text = "Clear";
            this.TransmittedDataClearButton.UseVisualStyleBackColor = true;
            this.TransmittedDataClearButton.Click += new System.EventHandler(this.TransmittedDataClear_Click);
            // 
            // TransmitData1HexCheckbox
            // 
            this.TransmitData1HexCheckbox.AutoSize = true;
            this.TransmitData1HexCheckbox.Checked = global::Terminal.Properties.Settings.Default.TransmitData1HexEnabled;
            this.TransmitData1HexCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Terminal.Properties.Settings.Default, "TransmitData1HexEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TransmitData1HexCheckbox.Location = new System.Drawing.Point(836, 196);
            this.TransmitData1HexCheckbox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.TransmitData1HexCheckbox.Name = "TransmitData1HexCheckbox";
            this.TransmitData1HexCheckbox.Size = new System.Drawing.Size(61, 24);
            this.TransmitData1HexCheckbox.TabIndex = 8;
            this.TransmitData1HexCheckbox.Text = "Hex";
            this.TransmitData1HexCheckbox.UseVisualStyleBackColor = true;
            this.TransmitData1HexCheckbox.CheckedChanged += new System.EventHandler(this.TransmitData1HexChanged);
            // 
            // TransmittedDataTimestampCheckbox
            // 
            this.TransmittedDataTimestampCheckbox.AutoSize = true;
            this.TransmittedDataTimestampCheckbox.Checked = global::Terminal.Properties.Settings.Default.TransmittedDataTimestampEnabled;
            this.TransmittedDataTimestampCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Terminal.Properties.Settings.Default, "TransmittedDataTimestampEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TransmittedDataTimestampCheckbox.Location = new System.Drawing.Point(365, 29);
            this.TransmittedDataTimestampCheckbox.Name = "TransmittedDataTimestampCheckbox";
            this.TransmittedDataTimestampCheckbox.Size = new System.Drawing.Size(114, 24);
            this.TransmittedDataTimestampCheckbox.TabIndex = 3;
            this.TransmittedDataTimestampCheckbox.Text = "Timestamp";
            this.TransmittedDataTimestampCheckbox.UseVisualStyleBackColor = true;
            this.TransmittedDataTimestampCheckbox.CheckedChanged += new System.EventHandler(this.TransmittedDataTimestampChanged);
            // 
            // TransmittedDataClearOnConnectCheckbox
            // 
            this.TransmittedDataClearOnConnectCheckbox.AutoSize = true;
            this.TransmittedDataClearOnConnectCheckbox.Checked = global::Terminal.Properties.Settings.Default.TransmittedDataClearOnConnectEnabled;
            this.TransmittedDataClearOnConnectCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Terminal.Properties.Settings.Default, "TransmittedDataClearOnConnectEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TransmittedDataClearOnConnectCheckbox.Location = new System.Drawing.Point(201, 29);
            this.TransmittedDataClearOnConnectCheckbox.Name = "TransmittedDataClearOnConnectCheckbox";
            this.TransmittedDataClearOnConnectCheckbox.Size = new System.Drawing.Size(158, 24);
            this.TransmittedDataClearOnConnectCheckbox.TabIndex = 2;
            this.TransmittedDataClearOnConnectCheckbox.Text = "Clear on connect";
            this.TransmittedDataClearOnConnectCheckbox.UseVisualStyleBackColor = true;
            this.TransmittedDataClearOnConnectCheckbox.CheckedChanged += new System.EventHandler(this.TransmittedDataClearOnConnectChanged);
            // 
            // TransmittedDataAutoscrollCheckbox
            // 
            this.TransmittedDataAutoscrollCheckbox.AutoSize = true;
            this.TransmittedDataAutoscrollCheckbox.Checked = global::Terminal.Properties.Settings.Default.TransmittedDataAutoscrollEnabled;
            this.TransmittedDataAutoscrollCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Terminal.Properties.Settings.Default, "TransmittedDataAutoscrollEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TransmittedDataAutoscrollCheckbox.Location = new System.Drawing.Point(89, 29);
            this.TransmittedDataAutoscrollCheckbox.Name = "TransmittedDataAutoscrollCheckbox";
            this.TransmittedDataAutoscrollCheckbox.Size = new System.Drawing.Size(106, 24);
            this.TransmittedDataAutoscrollCheckbox.TabIndex = 1;
            this.TransmittedDataAutoscrollCheckbox.Text = "Autoscroll";
            this.TransmittedDataAutoscrollCheckbox.UseVisualStyleBackColor = true;
            this.TransmittedDataAutoscrollCheckbox.CheckedChanged += new System.EventHandler(this.TransmittedDataAutoscrollChanged);
            // 
            // TransmitData4SendButton
            // 
            this.TransmitData4SendButton.AutoSize = true;
            this.TransmitData4SendButton.Enabled = false;
            this.TransmitData4SendButton.Location = new System.Drawing.Point(755, 300);
            this.TransmitData4SendButton.Name = "TransmitData4SendButton";
            this.TransmitData4SendButton.Size = new System.Drawing.Size(75, 30);
            this.TransmitData4SendButton.TabIndex = 19;
            this.TransmitData4SendButton.Text = "Send";
            this.TransmitData4SendButton.UseVisualStyleBackColor = true;
            this.TransmitData4SendButton.Click += new System.EventHandler(this.TransmitData4Send_Click);
            // 
            // TransmitData4TextBox
            // 
            this.TransmitData4TextBox.AcceptsTab = true;
            this.TransmitData4TextBox.AllowDrop = true;
            this.TransmitData4TextBox.ContextMenuStrip = this.TransmitData4ContextMenu;
            this.TransmitData4TextBox.Location = new System.Drawing.Point(9, 302);
            this.TransmitData4TextBox.MaxLength = 4069;
            this.TransmitData4TextBox.Name = "TransmitData4TextBox";
            this.TransmitData4TextBox.Size = new System.Drawing.Size(740, 26);
            this.TransmitData4TextBox.TabIndex = 18;
            this.TransmitData4TextBox.WordWrap = false;
            this.TransmitData4TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TransmitData4_KeyDown);
            // 
            // TransmitData4ContextMenu
            // 
            this.TransmitData4ContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TransmitData4ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TransmitData4ClearOnSendContextItem,
            this.TransmitData4HexContextItem,
            this.TransmitData4TerminateContextItem});
            this.TransmitData4ContextMenu.Name = "TransmitDataMultiLineContextMenu";
            this.TransmitData4ContextMenu.Size = new System.Drawing.Size(169, 76);
            // 
            // TransmitData4ClearOnSendContextItem
            // 
            this.TransmitData4ClearOnSendContextItem.Checked = global::Terminal.Properties.Settings.Default.TransmitData4ClearOnSendEnabled;
            this.TransmitData4ClearOnSendContextItem.CheckOnClick = true;
            this.TransmitData4ClearOnSendContextItem.Name = "TransmitData4ClearOnSendContextItem";
            this.TransmitData4ClearOnSendContextItem.Size = new System.Drawing.Size(168, 24);
            this.TransmitData4ClearOnSendContextItem.Text = "Clear on send";
            this.TransmitData4ClearOnSendContextItem.CheckedChanged += new System.EventHandler(this.TransmitData4ClearOnSendChanged);
            // 
            // TransmitData4HexContextItem
            // 
            this.TransmitData4HexContextItem.Checked = global::Terminal.Properties.Settings.Default.TransmitData4HexEnabled;
            this.TransmitData4HexContextItem.CheckOnClick = true;
            this.TransmitData4HexContextItem.Name = "TransmitData4HexContextItem";
            this.TransmitData4HexContextItem.Size = new System.Drawing.Size(168, 24);
            this.TransmitData4HexContextItem.Text = "Hex";
            this.TransmitData4HexContextItem.CheckedChanged += new System.EventHandler(this.TransmitData4HexChanged);
            // 
            // TransmitData4TerminateContextItem
            // 
            this.TransmitData4TerminateContextItem.Checked = global::Terminal.Properties.Settings.Default.TransmitData4TerminateEnabled;
            this.TransmitData4TerminateContextItem.CheckOnClick = true;
            this.TransmitData4TerminateContextItem.Name = "TransmitData4TerminateContextItem";
            this.TransmitData4TerminateContextItem.Size = new System.Drawing.Size(168, 24);
            this.TransmitData4TerminateContextItem.Text = "Terminate";
            this.TransmitData4TerminateContextItem.CheckedChanged += new System.EventHandler(this.TransmitData4TerminateChanged);
            // 
            // TransmittedDataTextBox
            // 
            this.TransmittedDataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransmittedDataTextBox.ContextMenuStrip = this.TransmittedDataTextBoxContextMenu;
            this.TransmittedDataTextBox.DetectUrls = false;
            this.TransmittedDataTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransmittedDataTextBox.Location = new System.Drawing.Point(6, 336);
            this.TransmittedDataTextBox.Name = "TransmittedDataTextBox";
            this.TransmittedDataTextBox.ReadOnly = true;
            this.TransmittedDataTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TransmittedDataTextBox.Size = new System.Drawing.Size(997, 165);
            this.TransmittedDataTextBox.TabIndex = 22;
            this.TransmittedDataTextBox.Text = "";
            // 
            // TransmittedDataTextBoxContextMenu
            // 
            this.TransmittedDataTextBoxContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TransmittedDataTextBoxContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TransmittedDataAutoscrollContextItem,
            this.TransmittedDataClearContextitem,
            this.TransmittedDataClearOnConnectContextItem,
            this.fontToolStripMenuItem,
            this.TransmittedDataTimestampContextItem});
            this.TransmittedDataTextBoxContextMenu.Name = "TransmittedDataTextBoxContextMenu";
            this.TransmittedDataTextBoxContextMenu.ShowCheckMargin = true;
            this.TransmittedDataTextBoxContextMenu.ShowImageMargin = false;
            this.TransmittedDataTextBoxContextMenu.Size = new System.Drawing.Size(190, 124);
            // 
            // TransmittedDataAutoscrollContextItem
            // 
            this.TransmittedDataAutoscrollContextItem.Checked = global::Terminal.Properties.Settings.Default.TransmittedDataAutoscrollEnabled;
            this.TransmittedDataAutoscrollContextItem.CheckOnClick = true;
            this.TransmittedDataAutoscrollContextItem.Name = "TransmittedDataAutoscrollContextItem";
            this.TransmittedDataAutoscrollContextItem.Size = new System.Drawing.Size(189, 24);
            this.TransmittedDataAutoscrollContextItem.Text = "Autoscroll";
            this.TransmittedDataAutoscrollContextItem.CheckedChanged += new System.EventHandler(this.TransmittedDataAutoscrollChanged);
            // 
            // TransmittedDataClearContextitem
            // 
            this.TransmittedDataClearContextitem.Name = "TransmittedDataClearContextitem";
            this.TransmittedDataClearContextitem.Size = new System.Drawing.Size(189, 24);
            this.TransmittedDataClearContextitem.Text = "Clear";
            this.TransmittedDataClearContextitem.Click += new System.EventHandler(this.TransmittedDataClear_Click);
            // 
            // TransmittedDataClearOnConnectContextItem
            // 
            this.TransmittedDataClearOnConnectContextItem.Checked = global::Terminal.Properties.Settings.Default.TransmittedDataClearOnConnectEnabled;
            this.TransmittedDataClearOnConnectContextItem.CheckOnClick = true;
            this.TransmittedDataClearOnConnectContextItem.Name = "TransmittedDataClearOnConnectContextItem";
            this.TransmittedDataClearOnConnectContextItem.Size = new System.Drawing.Size(189, 24);
            this.TransmittedDataClearOnConnectContextItem.Text = "Clear on connect";
            this.TransmittedDataClearOnConnectContextItem.CheckedChanged += new System.EventHandler(this.TransmittedDataClearOnConnectChanged);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.SystemFont_Click);
            // 
            // TransmittedDataTimestampContextItem
            // 
            this.TransmittedDataTimestampContextItem.Checked = global::Terminal.Properties.Settings.Default.TransmittedDataTimestampEnabled;
            this.TransmittedDataTimestampContextItem.CheckOnClick = true;
            this.TransmittedDataTimestampContextItem.Name = "TransmittedDataTimestampContextItem";
            this.TransmittedDataTimestampContextItem.Size = new System.Drawing.Size(189, 24);
            this.TransmittedDataTimestampContextItem.Text = "Timestamp";
            this.TransmittedDataTimestampContextItem.CheckedChanged += new System.EventHandler(this.TransmittedDataTimestampChanged);
            // 
            // TerminalNotes
            // 
            this.TerminalNotes.Location = new System.Drawing.Point(875, 13);
            this.TerminalNotes.Multiline = true;
            this.TerminalNotes.Name = "TerminalNotes";
            this.TerminalNotes.Size = new System.Drawing.Size(146, 137);
            this.TerminalNotes.TabIndex = 13;
            // 
            // SerialTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 1006);
            this.Controls.Add(this.TerminalNotes);
            this.Controls.Add(this.TransmitDataGroup);
            this.Controls.Add(this.ReceiveDataGroup);
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
            this.Text = "Serial Terminal V1.0.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SerialTerminal_FormClosing);
            this.Load += new System.EventHandler(this.SerialTerminal_FormLoad);
            this.ComPortGroup.ResumeLayout(false);
            this.BaudGroup.ResumeLayout(false);
            this.BaudGroup.PerformLayout();
            this.DataBitsGroup.ResumeLayout(false);
            this.ParityGroup.ResumeLayout(false);
            this.StopBitsGroup.ResumeLayout(false);
            this.HandshakeGroup.ResumeLayout(false);
            this.TransmitTerminationGroup.ResumeLayout(false);
            this.TransmitTerminationGroup.PerformLayout();
            this.ReceiveDataGroup.ResumeLayout(false);
            this.ReceiveDataGroup.PerformLayout();
            this.ReceivedDataTextBoxContextMenu.ResumeLayout(false);
            this.TransmitDataGroup.ResumeLayout(false);
            this.TransmitDataGroup.PerformLayout();
            this.TransmitDataMultiLineContextMenu.ResumeLayout(false);
            this.TransmitData3ContextMenu.ResumeLayout(false);
            this.TransmitData2ContextMenu.ResumeLayout(false);
            this.TransmitData1ContextMenu.ResumeLayout(false);
            this.TransmitData4ContextMenu.ResumeLayout(false);
            this.TransmittedDataTextBoxContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox ReceiveDataGroup;
        private System.Windows.Forms.RichTextBox ReceivedDataTextBox;
        private System.Windows.Forms.ContextMenuStrip ReceivedDataTextBoxContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ReceivedDataClearContextItem;
        private System.Windows.Forms.ToolStripMenuItem ReceivedDataAutoscrollContextitem;
        private System.Windows.Forms.ToolStripMenuItem ReceivedDataFontContextItem;
        private System.Windows.Forms.FontDialog SystemFontDialog;
        private System.Windows.Forms.CheckBox SerialPortDtrCheckbox;
        private System.Windows.Forms.ToolStripMenuItem ReceivedDataTimestampContextItem;
        private System.Windows.Forms.ToolStripMenuItem ReceivedDataClearOnConnectContextItem;
        private System.Windows.Forms.CheckBox ReceivedDataTimestampCheckbox;
        private System.Windows.Forms.CheckBox ReceivedDataClearOnConnectCheckbox;
        private System.Windows.Forms.CheckBox ReceivedDataAutoscrollCheckbox;
        private System.Windows.Forms.CheckBox ReceivedDataHexCheckbox;
        private System.Windows.Forms.ToolStripMenuItem ReceivedDataHexContextItem;
        private System.Windows.Forms.Button ReceivedDataClearButton;
        private System.Windows.Forms.GroupBox TransmitDataGroup;
        private System.Windows.Forms.Button TransmitData4SendButton;
        private System.Windows.Forms.TextBox TransmitData4TextBox;
        private System.Windows.Forms.RichTextBox TransmittedDataTextBox;
        private System.Windows.Forms.Button TransmitData3SendButton;
        private System.Windows.Forms.TextBox TransmitData3TextBox;
        private System.Windows.Forms.CheckBox TransmitData3HexCheckbox;
        private System.Windows.Forms.Button TransmitData2SendButton;
        private System.Windows.Forms.TextBox TransmitData2TextBox;
        private System.Windows.Forms.CheckBox TransmitData2HexCheckbox;
        private System.Windows.Forms.CheckBox TransmitData4HexCheckbox;
        private System.Windows.Forms.Button TransmitData1SendButton;
        private System.Windows.Forms.TextBox TransmitData1TextBox;
        private System.Windows.Forms.Button TransmittedDataClearButton;
        private System.Windows.Forms.CheckBox TransmitData1HexCheckbox;
        private System.Windows.Forms.CheckBox TransmittedDataTimestampCheckbox;
        private System.Windows.Forms.CheckBox TransmittedDataClearOnConnectCheckbox;
        private System.Windows.Forms.CheckBox TransmittedDataAutoscrollCheckbox;
        private System.Windows.Forms.Button TransmitDataMultilineSendButton;
        private System.Windows.Forms.TextBox TransmitDataMultiLineTextBox;
        private System.Windows.Forms.CheckBox TransmitDataMultilineTerminateCheckbox;
        private System.Windows.Forms.CheckBox TransmitData4TerminateCheckbox;
        private System.Windows.Forms.CheckBox TransmitData3TerminateCheckbox;
        private System.Windows.Forms.CheckBox TransmitData2TerminateCheckbox;
        private System.Windows.Forms.CheckBox TransmitData1TerminateCheckbox;
        private System.Windows.Forms.ContextMenuStrip TransmittedDataTextBoxContextMenu;
        private System.Windows.Forms.ToolStripMenuItem TransmittedDataAutoscrollContextItem;
        private System.Windows.Forms.ToolStripMenuItem TransmittedDataClearContextitem;
        private System.Windows.Forms.ToolStripMenuItem TransmittedDataClearOnConnectContextItem;
        private System.Windows.Forms.ToolStripMenuItem TransmittedDataTimestampContextItem;
        private System.Windows.Forms.ContextMenuStrip TransmitDataMultiLineContextMenu;
        private System.Windows.Forms.ToolStripMenuItem TransmitDataMultiLineClearOnSendContextItem;
        private System.Windows.Forms.ToolStripMenuItem TransmitDataMultiLineTerminateContextItem;
        private System.Windows.Forms.ContextMenuStrip TransmitData1ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem TransmitData1ClearOnSendContextItem;
        private System.Windows.Forms.ContextMenuStrip TransmitData2ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem TransmitData2ClearOnSendContextItem;
        private System.Windows.Forms.ContextMenuStrip TransmitData3ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem TransmitData3ClearOnSendContextItem;
        private System.Windows.Forms.ToolStripMenuItem TransmitData3HexContextItem;
        private System.Windows.Forms.ToolStripMenuItem TransmitData3TerminateContextItem;
        private System.Windows.Forms.ToolStripMenuItem TransmitData2HexContextItem;
        private System.Windows.Forms.ToolStripMenuItem TransmitData2TerminateContextItem;
        private System.Windows.Forms.ToolStripMenuItem TransmitData1HexContextItem;
        private System.Windows.Forms.ToolStripMenuItem TransmitData1TerminateContextItem;
        private System.Windows.Forms.ContextMenuStrip TransmitData4ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem TransmitData4ClearOnSendContextItem;
        private System.Windows.Forms.ToolStripMenuItem TransmitData4HexContextItem;
        private System.Windows.Forms.ToolStripMenuItem TransmitData4TerminateContextItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.TextBox TerminalNotes;
        private System.Windows.Forms.RadioButton BaudrateCustomRadio;
        private System.Windows.Forms.TextBox BaudrateCustomTextbox;

    }
}

