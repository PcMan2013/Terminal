using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using Terminal.Properties;

namespace Terminal
{
    public partial class SerialTerminal : Form
    {
        // V1.0.2

        private bool SerialPortConnected                    = false;
        private bool BaudrateCustomChecked                  = false;
        private Int32 BaudrateCustom                        = 115200;

        // Settings ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Received data //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private bool ReceivedDataAutoscrollEnabled          = false;
        private bool ReceivedDataTimestampEnabled           = false;
        private bool ReceivedDataClearOnConnectEnabled      = false;
        private bool ReceivedDataHexEnabled                 = false;

        // Transmitted data ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private bool TransmittedDataAutoscrollEnabled       = false;
        private bool TransmittedDataTimestampEnabled        = false;
        private bool TransmittedDataClearOnConnectEnabled   = false;
        private bool TransmitData1HexEnabled                = false;
        private bool TransmitData2HexEnabled                = false;
        private bool TransmitData3HexEnabled                = false;
        private bool TransmitData4HexEnabled                = false;
        private bool TransmitData1TerminateEnabled          = false;
        private bool TransmitData2TerminateEnabled          = false;
        private bool TransmitData3TerminateEnabled          = false;
        private bool TransmitData4TerminateEnabled          = false;
        private bool TransmitDataMultiLineTerminateEnabled  = false;
        private bool TransmitData1ClearOnSendEnabled        = false;
        private bool TransmitData2ClearOnSendEnabled        = false;
        private bool TransmitData3ClearOnSendEnabled        = false;
        private bool TransmitData4ClearOnSendEnabled        = false;
        private bool TransmitDataMultiLineClearOnSendEnabled = false;
    
        private string TransmitTerminationString            = "\r";

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Form ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public SerialTerminal()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Form ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void SerialTerminal_FormLoad(object sender, EventArgs e)
        {
            try
            {
                RadioButton CheckedRadio = new RadioButton();

                // Import the user settings.
                ReceivedDataAutoscrollEnabled           = Settings.Default.ReiceveDataAutoscrollEnabled;
                ReceivedDataTimestampEnabled            = Settings.Default.ReceivedDataTimestampEnabled;
                ReceivedDataClearOnConnectEnabled       = Settings.Default.ReceivedDataClearOnConnect;
                ReceivedDataTextBox.Font                = Settings.Default.SystemFont;
                TransmittedDataTextBox.Font             = Settings.Default.SystemFont;
                ReceivedDataHexEnabled                  = Settings.Default.ReceivedDataHexEnabled;
                TransmittedDataAutoscrollEnabled        = Settings.Default.TransmittedDataAutoscrollEnabled;
                TransmittedDataTimestampEnabled         = Settings.Default.TransmittedDataTimestampEnabled;
                TransmittedDataClearOnConnectEnabled    = Settings.Default.TransmittedDataClearOnConnectEnabled;
                TransmitData1HexEnabled                 = Settings.Default.TransmitData1HexEnabled;
                TransmitData2HexEnabled                 = Settings.Default.TransmitData2HexEnabled;
                TransmitData3HexEnabled                 = Settings.Default.TransmitData3HexEnabled;
                TransmitData4HexEnabled                 = Settings.Default.TransmitData4HexEnabled;
                TransmitDataMultiLineTerminateEnabled   = Settings.Default.TransmitDataMultiLineTerminateEnabled;
                TransmitData1TerminateEnabled           = Settings.Default.TransmitData1TerminateEnabled;
                TransmitData2TerminateEnabled           = Settings.Default.TransmitData2TerminateEnabled;
                TransmitData3TerminateEnabled           = Settings.Default.TransmitData3TerminateEnabled;
                TransmitData4TerminateEnabled           = Settings.Default.TransmitData4TerminateEnabled;
                TransmitData1ClearOnSendEnabled         = Settings.Default.TransmitData1ClearOnSendEnabled;
                TransmitData2ClearOnSendEnabled         = Settings.Default.TransmitData2ClearOnSendEnabled;
                TransmitData3ClearOnSendEnabled         = Settings.Default.TransmitData3ClearOnSendEnabled;
                TransmitData4ClearOnSendEnabled         = Settings.Default.TransmitData4ClearOnSendEnabled;
                TransmitDataMultiLineClearOnSendEnabled = Settings.Default.TransmitDataMultiLineClearOnSendEnabled;
                BaudrateCustomChecked                   = Settings.Default.BaudrateCustomChecked;
                BaudrateCustom                          = Convert.ToInt32(Settings.Default.BaudrateCustom);
               
                BaudrateCustomTextbox.Text = Convert.ToString(BaudrateCustom);

                // Set all radiobuttons to their stored values and set the baudrate, data bits, parity,
                // and handshake to the value they were when te application was closed.
                CheckedRadio = RestoreRadiobuttonSettings(TransmitTerminationGroup, Settings.Default.TransmitTerminationCharacter);
                TransmitTerminationChanged((object)CheckedRadio, new EventArgs());
                
                CheckedRadio = RestoreRadiobuttonSettings(BaudGroup, Settings.Default.Baudrate);
                if (CheckedRadio.Text == "Custom")
                {
                    SerialDataPort.BaudRate = BaudrateCustom;
                }

                else
                {
                    SerialDataPort.BaudRate = Convert.ToInt32(CheckedRadio.Tag);
                }

                CheckedRadio = RestoreRadiobuttonSettings(DataBitsGroup, Settings.Default.DataBits);
                SerialDataPort.DataBits = Convert.ToInt32(CheckedRadio.Tag);

                CheckedRadio = RestoreRadiobuttonSettings(ParityGroup, Settings.Default.Parity);
                SerialDataPort.Parity = (Parity) Convert.ToInt32(CheckedRadio.Tag);

                CheckedRadio = RestoreRadiobuttonSettings(StopBitsGroup, Settings.Default.StopBits);
                SerialDataPort.StopBits = (StopBits) Convert.ToInt32(CheckedRadio.Tag);

                CheckedRadio = RestoreRadiobuttonSettings(HandshakeGroup, Settings.Default.Handshake);
                SerialDataPort.Handshake = (Handshake) Convert.ToInt32(CheckedRadio.Tag);

                // Load the contents of the transmit textboxes.
                TransmitDataMultiLineTextBox.Text = Settings.Default.TransmitDataMultiLineText;
                TransmitData1TextBox.Text = Settings.Default.TransmitData1Text;
                TransmitData2TextBox.Text = Settings.Default.TransmitData2Text;
                TransmitData3TextBox.Text = Settings.Default.TransmitData3Text;
                TransmitData4TextBox.Text = Settings.Default.TransmitData4Text;
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error loading the application:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void SerialTerminal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // Close the COM port before closing the form.
                SerialDataPort.Close();

                // Save the user settings.
                Settings.Default.TransmitTerminationCharacter           = TransmitTerminationString;
                Settings.Default.ReiceveDataAutoscrollEnabled           = ReceivedDataAutoscrollEnabled;
                Settings.Default.ReceivedDataTimestampEnabled           = ReceivedDataTimestampEnabled;
                Settings.Default.ReceivedDataClearOnConnect             = ReceivedDataClearOnConnectEnabled;
                Settings.Default.SystemFont                             = ReceivedDataTextBox.Font;
                Settings.Default.ReceivedDataHexEnabled                 = ReceivedDataHexEnabled;
                Settings.Default.TransmittedDataAutoscrollEnabled       = TransmittedDataAutoscrollEnabled;
                Settings.Default.TransmittedDataTimestampEnabled        = TransmittedDataTimestampEnabled;
                Settings.Default.TransmittedDataClearOnConnectEnabled   = TransmittedDataClearOnConnectEnabled;
                Settings.Default.TransmitData1HexEnabled                = TransmitData1HexEnabled;
                Settings.Default.TransmitData2HexEnabled                = TransmitData2HexEnabled;
                Settings.Default.TransmitData3HexEnabled                = TransmitData3HexEnabled;
                Settings.Default.TransmitData4HexEnabled                = TransmitData4HexEnabled;
                Settings.Default.TransmitDataMultiLineTerminateEnabled  = TransmitDataMultiLineTerminateEnabled;
                Settings.Default.TransmitData1TerminateEnabled          = TransmitData1TerminateEnabled;
                Settings.Default.TransmitData2TerminateEnabled          = TransmitData2TerminateEnabled;
                Settings.Default.TransmitData3TerminateEnabled          = TransmitData3TerminateEnabled;
                Settings.Default.TransmitData4TerminateEnabled          = TransmitData4TerminateEnabled;
                Settings.Default.TransmitData1ClearOnSendEnabled        = TransmitData1ClearOnSendEnabled;
                Settings.Default.TransmitData2ClearOnSendEnabled        = TransmitData2ClearOnSendEnabled;
                Settings.Default.TransmitData3ClearOnSendEnabled        = TransmitData3ClearOnSendEnabled;
                Settings.Default.TransmitData4ClearOnSendEnabled        = TransmitData4ClearOnSendEnabled;
                Settings.Default.TransmitDataMultiLineClearOnSendEnabled = TransmitDataMultiLineClearOnSendEnabled;
                Settings.Default.BaudrateCustomChecked                  = BaudrateCustomChecked;
                Settings.Default.BaudrateCustom                         = Convert.ToString(BaudrateCustom);

                // Save which radiobuttons are checked.
                SaveRadiobuttonSettings(BaudGroup, "Baudrate");
                SaveRadiobuttonSettings(DataBitsGroup, "DataBits");
                SaveRadiobuttonSettings(ParityGroup, "Parity");
                SaveRadiobuttonSettings(StopBitsGroup, "StopBits");
                SaveRadiobuttonSettings(HandshakeGroup, "Handshake");
                SaveRadiobuttonSettings(TransmitTerminationGroup, "TransmitTerminationCharacter");

                // Save the contents of the transmit textboxes.
                Settings.Default.TransmitDataMultiLineText = TransmitDataMultiLineTextBox.Text;
                Settings.Default.TransmitData1Text = TransmitData1TextBox.Text;
                Settings.Default.TransmitData2Text = TransmitData2TextBox.Text;
                Settings.Default.TransmitData3Text = TransmitData3TextBox.Text;
                Settings.Default.TransmitData4Text = TransmitData4TextBox.Text;

                Settings.Default.Save();
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error closing the COM port:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // COM port ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void ComRefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] availableComPorts;

                // Search for any available COM ports.
                availableComPorts = SerialPort.GetPortNames();

                // First clear all items.
                ComPortDropDown.Items.Clear();

                // Add the available COM ports to the dropdown menu list.
                foreach (string port in availableComPorts)
                {
                    ComPortDropDown.Items.Add(port);
                }

                // Were any COM ports found?
                // Yes, show the first COM port.
                if (ComPortDropDown.Items.Count > 0)
                {
                    // Show the first item.
                    ComPortDropDown.SelectedIndex = 0;

                    // Enable the connection button.
                    ComConnectionButton.Enabled = true;
                }

                // No, disable the connection button.
                else
                {
                    ComConnectionButton.Enabled = false;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error refreshing the available COM ports:\n\n" + exc.Message);
            }
        }

        private void ComConnectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (SerialPortConnected)
                {
                    case true:
                        // Close the serial connection.
                        SerialDataPort.Close();

                        // Update the text of the conneciton button.
                        ComConnectionButton.Text = "Connect";

                        // Enable the COM port list.
                        ComPortDropDown.Enabled = true;

                        // Enable all send buttons.
                        TransmitDataMultilineSendButton.Enabled = false;
                        TransmitData1SendButton.Enabled = false;
                        TransmitData2SendButton.Enabled = false;
                        TransmitData3SendButton.Enabled = false;
                        TransmitData4SendButton.Enabled = false;

                        SerialPortConnected = false;
                        break;

                    case false:
                        if(BaudrateCustomChecked == true)
                        {
                            // Update the baudrate of the serial connection with the selected value.
                            SerialDataPort.BaudRate = Convert.ToInt32(BaudrateCustomTextbox.Text);
                        }

                        // Select the correct COM port.
                        SerialDataPort.PortName = ComPortDropDown.Text;

                        // Open a serial connection to a device.
                        SerialDataPort.Open();

                        // Clear the buffers before using the COM port.
                        SerialDataPort.DiscardInBuffer();
                        SerialDataPort.DiscardOutBuffer();

                        // Update the text of the connection button.
                        ComConnectionButton.Text = "Disconnect";

                        // Is Clear on connect for received data enabled?
                        // Yes, clear the received data textbox.
                        if (ReceivedDataClearOnConnectEnabled == true)
                        {
                            ReceivedDataClear_Click(sender, new EventArgs());
                        }

                        // Is Clear on connect for transmitted data enabled?
                        // Yes, clear the transmitted data textbox.
                        if (TransmittedDataClearOnConnectEnabled == true)
                        {
                            TransmittedDataClear_Click(sender, new EventArgs());
                        }

                        // Disable the COM port list.
                        ComPortDropDown.Enabled = false;

                        // Enable all send buttons.
                        TransmitDataMultilineSendButton.Enabled = true;
                        TransmitData1SendButton.Enabled = true;
                        TransmitData2SendButton.Enabled = true;
                        TransmitData3SendButton.Enabled = true;
                        TransmitData4SendButton.Enabled = true;

                        SerialPortConnected = true;
                        break;

                    default:
                        // Close the serial connection.
                        SerialDataPort.Close();
                        
                        // Update the text of the conneciton button.
                        ComConnectionButton.Text = "Connect";

                        // Enable the COM port list.
                        ComPortDropDown.Enabled = true;

                        // Enable all send buttons.
                        TransmitDataMultilineSendButton.Enabled = false;
                        TransmitData1SendButton.Enabled = false;
                        TransmitData2SendButton.Enabled = false;
                        TransmitData3SendButton.Enabled = false;
                        TransmitData4SendButton.Enabled = false;

                        SerialPortConnected = false;
                        break;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error opening the COM port:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void BaudrateChanged(object sender, EventArgs e)
        {
            try
            {
                // Cast the sender of this method to a usable type.
                RadioButton changedRadio = (RadioButton)sender;

                // Is the sender checked?
                // Yes, update the baudrate with the selected baudrate.
                if(changedRadio.Checked == true)
                {
                    // Only change the baudrate if the radiobutton is not the custom one.
                    if (String.Compare(changedRadio.Text, "Custom") == 0)
                    {
                        BaudrateCustomChecked = true;
                    }

                    else
                    {
                        // Update the baudrate of the serial connection with the selected value.
                        SerialDataPort.BaudRate = Convert.ToInt32(changedRadio.Text);

                        BaudrateCustomChecked = false;
                    }
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error updating the baudrate:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void BaudrateCustomTextboxKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Check if the pressed key is numeric but allow backspaces.
                if(e.KeyChar != '\b')
                {
                    e.Handled = !char.IsNumber(e.KeyChar);
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error updating the custom baudrate:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void BaudrateCustomTextboxChanged(object sender, EventArgs e)
        {
            try
            {
                // Update the custom baudrate.
                BaudrateCustom = Convert.ToInt32(BaudrateCustomTextbox.Text);
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error updating the custom baudrate:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void DataBitsChanged(object sender, EventArgs e)
        {
            try
            {
                // Cast the sender of this method to a usable type.
                RadioButton changedRadio = (RadioButton)sender;

                // Is the sender checked?
                // Yes, update the amount of databits with the selected amount.
                if (changedRadio.Checked == true)
                {
                    // Update the amount of databits of the serial connection with the selected value.
                    SerialDataPort.DataBits = Convert.ToInt32(changedRadio.Text);
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error updating the amount of databits:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void ParityChanged(object sender, EventArgs e)
        {
            try
            {
                // Cast the sender of this method to a usable type.
                RadioButton changedRadio = (RadioButton)sender;

                // Is the sender checked?
                // Yes, update the parity with the selected value.
                if (changedRadio.Checked == true)
                {
                    // Set the parity of the serial port the selected value.
                    switch(changedRadio.Text)
                    {
                        case "None":
                            SerialDataPort.Parity = Parity.None;
                            break;

                        case "Odd":
                            SerialDataPort.Parity = Parity.Odd;
                            break;

                        case "Even":
                            SerialDataPort.Parity = Parity.Even;
                            break;

                        case "Mark":
                            SerialDataPort.Parity = Parity.Mark;
                            break;

                        case "Space":
                            SerialDataPort.Parity = Parity.Space;
                            break;
                        
                        // Switch default: set the parity to none.
                        default:
                            SerialDataPort.Parity = Parity.None;
                            break;
                    }
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error updating the parity:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void StopBitsChanged(object sender, EventArgs e)
        {
            try
            {
                // Cast the sender of this method to a usable type.
                RadioButton changedRadio = (RadioButton)sender;

                // Is the sender checked?
                // Yes, update the amount of stop bits with the selected amount.
                if (changedRadio.Checked == true)
                {
                    // Set the stop bits of the serial port the selected value.
                    switch (changedRadio.Text)
                    {
                        case "1":
                            SerialDataPort.StopBits = StopBits.One;
                            break;

                        case "2":
                            SerialDataPort.StopBits = StopBits.Two;
                            break;

                        // Switch default: set the stop bits to 1.
                        default:
                            SerialDataPort.StopBits = StopBits.One;
                            break;
                    }
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error updating the amount of stop bits:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void HandshakeChanged(object sender, EventArgs e)
        {
            try
            {
                // Cast the sender of this method to a usable type.
                RadioButton changedRadio = (RadioButton)sender;

                // Is the sender checked?
                // Yes, update the handshake method of the serial connection.
                if (changedRadio.Checked == true)
                {
                    // Set the handshake method of the serial connection.
                    switch (changedRadio.Text)
                    {
                        case "None":
                            SerialDataPort.Handshake = Handshake.None;
                            break;

                        case "RTS/CTS":
                            SerialDataPort.Handshake = Handshake.RequestToSend;
                            break;

                        // Switch default: set the handshake to none.
                        default:
                            SerialDataPort.Handshake = Handshake.None;
                            break;
                    }
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error updating the handshake:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmitTerminationChanged(object sender, EventArgs e)
        {
            try
            {
                // Find out which radio button was checked and set the termination string
                // accordingly.
                if (TransmitTerminationCrRadio.Checked == true)
                {
                    TransmitTerminationString = "\r";
                }

                else if (TransmitTerminationLfRadio.Checked == true)
                {
                    TransmitTerminationString = "\n";
                }

                else if (TransmitTerminationCrLfRadio.Checked == true)
                {
                    TransmitTerminationString = "\r\n";
                }

                else
                {
                    TransmitTerminationString = "\r";
                }

                SerialDataPort.NewLine = TransmitTerminationString;
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error updating the transmit termination:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Retrieve the received data.
                string ReceivedData = string.Empty;

                // Does the received string contain a Line Feed character and are timestamps enabled?
                // Yes, add the timestamp to the data.
                if (ReceivedDataTimestampEnabled == true)
                {
                    // Read lines form the buffer until there is no data left.
                    while(SerialDataPort.BytesToRead != 0 && ReceivedDataTimestampEnabled == true)
                    {
                        // Read a line of data form the reception buffer.
                        ReceivedData = SerialDataPort.ReadLine();

                        // Prepend the current time to the received data.
                        PrintReceivedData(GetCurrentTimeString() + "\t");

                        // Is the hex view enabled?
                        // Yes, convert the received data to a hexadecimal string and print it.
                        if(ReceivedDataHexEnabled == true)
                        {
                            // Convert the received data to a hexadecimal string.
                            ReceivedData = ConvertAsciiStringToHexString(ReceivedData);
                        }

                        // Add the received data to the output textbox.
                        PrintReceivedData(ReceivedData + "\n");

                        // Is autoscroll enabled?
                        // Yes, scroll to the end of the data.
                        if (ReceivedDataAutoscrollEnabled == true)
                        {
                            ReceivedDataTextboxScrollToEnd();
                        }
                    }
                }

                else
                {
                    // Retrieve all received data.
                    ReceivedData = SerialDataPort.ReadExisting();

                    // Is the hex view enabled?
                    // Yes, convert the received data to a hexadecimal string and print it.
                    if (ReceivedDataHexEnabled == true)
                    {
                        // Convert the received data to a hexadecimal string.
                        ReceivedData = ConvertAsciiStringToHexString(ReceivedData);
                    }

                    // Add the received data to the output textbox.
                    PrintReceivedData(ReceivedData);
                    
                    // Is autoscroll enabled?
                    // Yes, scroll to the end of the data.
                    if (ReceivedDataAutoscrollEnabled == true)
                    {
                        ReceivedDataTextboxScrollToEnd();
                    }
                }
            }

            catch (Exception exc)
            {
                // Is this an IO exception?
                // Yes, catch it.
                if (exc is System.IO.IOException)
                {
                    // Do nothing.
                }

                // No, show an error message.
                else
                {
                    MessageBox.Show("There was an error receiving data.\n\n" + exc.Message + "\n\n" + exc.StackTrace);
                }
            }
        }

        private void TransmitDataMultiLineSend_Click(object sender, EventArgs e)
        {
            try
            {
                string Data;

                // Is there an active COM connection?
                // Yes, send the data to the COM port.
                if (SerialPortConnected == true)
                {
                    // When pressing enter and jumping to a new line, \r\n is added to the text.
                    // Search through the text and replace \r\n with TransmitTerminationString.
                    Data = TransmitDataMultiLineTextBox.Text.Replace("\r\n", TransmitTerminationString);

                    // Send the contents of the textbox to the COM port.
                    SendDataToComPort(Data, false, TransmitDataMultiLineTerminateEnabled, TransmitTerminationString);

                    // Is Clear on send enabled for the transmit multiline textbox?
                    // Yes, clear its contents.
                    if (TransmitDataMultiLineClearOnSendEnabled == true)
                    {
                        TransmitDataMultiLineTextBox.Clear();
                    }
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error transmitting data:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmitData1Send_Click(object sender, EventArgs e)
        {
            try
            {
                // Is there an active COM connection?
                // Yes, send the data to the COM port.
                if (SerialPortConnected == true)
                {
                    // Send the contents of the textbox to the COM port.
                    SendDataToComPort(TransmitData1TextBox.Text, TransmitData1HexEnabled, TransmitData1TerminateEnabled, TransmitTerminationString);

                    // Is Clear on send enabled for transmit textbox1?
                    // Yes, clear its contents.
                    if (TransmitData1ClearOnSendEnabled == true)
                    {
                        TransmitData1TextBox.Clear();
                    }
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error transmitting data:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmitData2Send_Click(object sender, EventArgs e)
        {
            try
            {
                // Is there an active COM connection?
                // Yes, send the data to the COM port.
                if (SerialPortConnected == true)
                {
                    // Send the contents of the textbox to the COM port.
                    SendDataToComPort(TransmitData2TextBox.Text, TransmitData2HexEnabled, TransmitData2TerminateEnabled, TransmitTerminationString);

                    // Is Clear on send enabled for transmit textbox2?
                    // Yes, clear its contents.
                    if (TransmitData2ClearOnSendEnabled == true)
                    {
                        TransmitData2TextBox.Clear();
                    }
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error transmitting data:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmitData3Send_Click(object sender, EventArgs e)
        {
            try
            {
                // Is there an active COM connection?
                // Yes, send the data to the COM port.
                if (SerialPortConnected == true)
                {
                    // Send the contents of the textbox to the COM port.
                    SendDataToComPort(TransmitData3TextBox.Text, TransmitData3HexEnabled, TransmitData3TerminateEnabled, TransmitTerminationString);

                    // Is Clear on send enabled for transmit textbox3?
                    // Yes, clear its contents.
                    if (TransmitData3ClearOnSendEnabled == true)
                    {
                        TransmitData3TextBox.Clear();
                    }
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error transmitting data:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmitData4Send_Click(object sender, EventArgs e)
        {
            try
            {
                // Is there an active COM connection?
                // Yes, send the data to the COM port.
                if (SerialPortConnected == true)
                {
                    // Send the contents of the textbox to the COM port.
                    SendDataToComPort(TransmitData4TextBox.Text, TransmitData4HexEnabled, TransmitData4TerminateEnabled, TransmitTerminationString);

                    // Is Clear on send enabled for transmit textbox4?
                    // Yes, clear its contents.
                    if (TransmitData4ClearOnSendEnabled == true)
                    {
                        TransmitData4TextBox.Clear();
                    }
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error transmitting data:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmitDataMultiLine_KeyDown(object sender, KeyEventArgs e)
        {
            // Send the data if CTRL+ENTER is pressed.
            if (e.KeyData == (Keys.Control | Keys.Enter))
            {
                e.SuppressKeyPress = true;

                TransmitDataMultiLineSend_Click(this, new EventArgs());
            }
        }

        private void TransmitData1_KeyDown(object sender, KeyEventArgs e)
        {
            // Send the data if the enter key is pressed in the textbox.
            if (e.KeyCode == Keys.Enter)
            {
                TransmitData1Send_Click(this, new EventArgs());
            }
        }

        private void TransmitData2_KeyDown(object sender, KeyEventArgs e)
        {
            // Send the data if the enter key is pressed in the textbox.
            if (e.KeyCode == Keys.Enter)
            {
                TransmitData2Send_Click(this, new EventArgs());
            }
        }

        private void TransmitData3_KeyDown(object sender, KeyEventArgs e)
        {
            // Send the data if the enter key is pressed in the textbox.
            if (e.KeyCode == Keys.Enter)
            {
                TransmitData3Send_Click(this, new EventArgs());
            }
        }

        private void TransmitData4_KeyDown(object sender, KeyEventArgs e)
        {
            // Send the data if the enter key is pressed in the textbox.
            if (e.KeyCode == Keys.Enter)
            {
                TransmitData4Send_Click(this, new EventArgs());
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Context menu ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void ReceivedDataClear_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the contents of the rich text box.
                ReceivedDataTextBox.Invoke(new MethodInvoker(delegate 
                { 
                    ReceivedDataTextBox.Clear(); 
                }));
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error clearing the data.\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmittedDataClear_Click(object sender, EventArgs e)
        {
            try
            {
                 // Clear the contents of the rich text box.
                TransmittedDataTextBox.Invoke(new MethodInvoker(delegate 
                { 
                    TransmittedDataTextBox.Clear(); 
                }));
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error clearing the data:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void ReceivedDataAutoscrollContextMenuChanged(object sender, EventArgs e)
        {
            try
            {
                // Is the sender an item from a context menu?
                // Yes, update AutoscrollEnabled from the sender's checked property.
                if (sender is ToolStripMenuItem)
                {
                    ToolStripMenuItem item = (ToolStripMenuItem) sender;
                    ReceivedDataAutoscrollCheckbox.Checked = item.Checked;

                    ReceivedDataAutoscrollEnabled = item.Checked;
                }

                // No, is the sender a checkbox?
                // Yes, update AutoscrollEnabled from the sender's checked property.
                else if (sender is CheckBox)
                {
                    CheckBox item = (CheckBox)sender;
                    ReceivedDataAutoscrollContextitem.Checked = item.Checked;

                    ReceivedDataAutoscrollEnabled = item.Checked;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error clearing the data:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void SystemFont_Click(object sender, EventArgs e)
        {
            try
            {
                // Show the Font dialog. Did the user accept the changes?
                // Yes, update the font of all received data.
                if (SystemFontDialog.ShowDialog() != DialogResult.Cancel)
                {
                    ReceivedDataTextBox.Font = SystemFontDialog.Font;
                    TransmittedDataTextBox.Font = SystemFontDialog.Font;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error changing the system font:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void ReceivedDataTimestampChanged(object sender, EventArgs e)
        {
            try
            {
                // Is the sender an item from a context menu?
                // Yes, update TimestampEnabled from the sender's checked property.
                if (sender is ToolStripMenuItem)
                {
                    ToolStripMenuItem item = (ToolStripMenuItem) sender;
                    ReceivedDataTimestampCheckbox.Checked = item.Checked;

                    ReceivedDataTimestampEnabled = item.Checked;
                }

                // No, is the sender a checkbox?
                // Yes, update TimestampEnabled from the sender's checked property.
                else if (sender is CheckBox)
                {
                    CheckBox item = (CheckBox)sender;
                    ReceivedDataTimestampContextItem.Checked = item.Checked;

                    ReceivedDataTimestampEnabled = item.Checked;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error changing the timestamp:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void SerialPortDtrChanged(object sender, EventArgs e)
        {
            try
            {
                // Is the DTR button checked?
                // Yes, pull the DTR line high and set the color of the DTR button to green.
                if (SerialPortDtrCheckbox.Checked == true)
                {
                    SerialDataPort.DtrEnable = true;

                    SerialPortDtrCheckbox.BackColor = Color.ForestGreen;
                }

                // No, pull the DTR line low and reset the color of the DTR button.
                else
                {
                    SerialDataPort.DtrEnable = false;

                    SerialPortDtrCheckbox.BackColor = SystemColors.Control;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting or clearing the DTR signal:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void ReceivedDataClearOnconnect_Changed(object sender, EventArgs e)
        {
            try
            {
                // Is the sender an item from a context menu?
                // Yes, update ClearOnConnectEnabled from the sender's checked property.
                if (sender is ToolStripMenuItem)
                {
                    ToolStripMenuItem item = (ToolStripMenuItem) sender;
                    ReceivedDataClearOnConnectCheckbox.Checked = item.Checked;

                    ReceivedDataClearOnConnectEnabled = item.Checked;
                }

                // No, is the sender a checkbox?
                // Yes, update ClearOnConnectEnabled from the sender's checked property.
                else if(sender is CheckBox)
                {
                    CheckBox item = (CheckBox)sender;
                    ReceivedDataClearOnConnectContextItem.Checked = item.Checked;

                    ReceivedDataClearOnConnectEnabled = item.Checked;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting the Clear on connect property:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void ReceivedDataHexChanged(object sender, EventArgs e)
        {
            try
            {
                // Is the sender an item from a context menu?
                // Yes, update ClearOnConnectEnabled from the sender's checked property.
                if (sender is ToolStripMenuItem)
                {
                    ToolStripMenuItem item = (ToolStripMenuItem)sender;
                    ReceivedDataHexCheckbox.Checked = item.Checked;

                    ReceivedDataHexEnabled = item.Checked;
                }

                // No, is the sender a checkbox?
                // Yes, update ClearOnConnectEnabled from the sender's checked property.
                else if (sender is CheckBox)
                {
                    CheckBox item = (CheckBox)sender;
                    ReceivedDataHexContextItem.Checked = item.Checked;

                    ReceivedDataHexEnabled = item.Checked;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting the Hex property:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmittedDataAutoscrollChanged(object sender, EventArgs e)
        {
            try
            {
                // Is the sender an item from a context menu?
                // Yes, update Autoscroll from the sender's checked property.
                if (sender is ToolStripMenuItem)
                {
                    ToolStripMenuItem item = (ToolStripMenuItem)sender;
                    TransmittedDataAutoscrollCheckbox.Checked = item.Checked;

                    TransmittedDataAutoscrollEnabled = item.Checked;
                }

                // No, is the sender a checkbox?
                // Yes, update Autoscroll from the sender's checked property.
                else if (sender is CheckBox)
                {
                    CheckBox item = (CheckBox)sender;
                    TransmittedDataAutoscrollContextItem.Checked = item.Checked;

                    TransmittedDataAutoscrollEnabled = item.Checked;
                }
            }


            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting the Autoscroll property:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmittedDataClearOnConnectChanged(object sender, EventArgs e)
        {
            try
            {
                // Is the sender an item from a context menu?
                // Yes, update Clear on Connect from the sender's checked property.
                if (sender is ToolStripMenuItem)
                {
                    ToolStripMenuItem item = (ToolStripMenuItem)sender;
                    TransmittedDataClearOnConnectCheckbox.Checked = item.Checked;

                    TransmittedDataClearOnConnectEnabled = item.Checked;
                }

                // No, is the sender a checkbox?
                // Yes, update Clear on Connect from the sender's checked property.
                else if (sender is CheckBox)
                {
                    CheckBox item = (CheckBox)sender;
                    TransmittedDataClearOnConnectContextItem.Checked = item.Checked;

                    TransmittedDataClearOnConnectEnabled = item.Checked;
                }
            }


            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting the Clear on Connect property:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmittedDataTimestampChanged(object sender, EventArgs e)
        {
            try
            {
                // Is the sender an item from a context menu?
                // Yes, update Timestamp from the sender's checked property.
                if (sender is ToolStripMenuItem)
                {
                    ToolStripMenuItem item = (ToolStripMenuItem)sender;
                    TransmittedDataTimestampCheckbox.Checked = item.Checked;

                    TransmittedDataTimestampEnabled = item.Checked;
                }

                // No, is the sender a checkbox?
                // Yes, update Timestamp from the sender's checked property.
                else if (sender is CheckBox)
                {
                    CheckBox item = (CheckBox)sender;
                    TransmittedDataTimestampContextItem.Checked = item.Checked;

                    TransmittedDataTimestampEnabled = item.Checked;
                }
            }


            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting the Timestamp property:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmitDataMultiLineClearOnSendChanged(object sender, EventArgs e)
        {
            // Cast the sender to the toolstrip menu item type to expose it's properties.
            ToolStripMenuItem item = (ToolStripMenuItem) sender;

            // Update the setting with the new state;
            TransmitDataMultiLineClearOnSendEnabled = item.Checked;
        }

        private void TransmitData1ClearOnSendChanged(object sender, EventArgs e)
        {
            try
            {
                // Cast the sender to the toolstrip menu item type to expose it's properties.
                ToolStripMenuItem item = (ToolStripMenuItem)sender;

                // Update the setting with the new state;
                TransmitData1ClearOnSendEnabled = item.Checked;
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting the Clear on Send property:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmitData2ClearOnSendChanged(object sender, EventArgs e)
        {
            try
            {
                // Cast the sender to the toolstrip menu item type to expose it's properties.
                ToolStripMenuItem item = (ToolStripMenuItem)sender;

                // Update the setting with the new state;
                TransmitData2ClearOnSendEnabled = item.Checked;
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting the Clear on Send property:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmitData3ClearOnSendChanged(object sender, EventArgs e)
        {
            try
            {
                // Cast the sender to the toolstrip menu item type to expose it's properties.
                ToolStripMenuItem item = (ToolStripMenuItem)sender;

                // Update the setting with the new state;
                TransmitData3ClearOnSendEnabled = item.Checked;
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting the Clear on Send property:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmitData4ClearOnSendChanged(object sender, EventArgs e)
        {
            try
            {
                // Cast the sender to the toolstrip menu item type to expose it's properties.
                ToolStripMenuItem item = (ToolStripMenuItem)sender;

                // Update the setting with the new state;
                TransmitData4ClearOnSendEnabled = item.Checked;
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting the Clear on Send property:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmitData1HexChanged(object sender, EventArgs e)
        {
            try
            {
                // Is the sender an item from a context menu?
                // Yes, update Hex from the sender's checked property.
                if (sender is ToolStripMenuItem)
                {
                    ToolStripMenuItem item = (ToolStripMenuItem)sender;
                    TransmitData1HexCheckbox.Checked = item.Checked;

                    TransmitData1HexEnabled = item.Checked;
                }

                // No, is the sender a checkbox?
                // Yes, update Hex from the sender's checked property.
                else if (sender is CheckBox)
                {
                    CheckBox item = (CheckBox)sender;
                    TransmitData1HexContextItem.Checked = item.Checked;

                    TransmitData1HexEnabled = item.Checked;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting the Hex property:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmitData2HexChanged(object sender, EventArgs e)
        {
            try
            {
                // Is the sender an item from a context menu?
                // Yes, update Hex from the sender's checked property.
                if (sender is ToolStripMenuItem)
                {
                    ToolStripMenuItem item = (ToolStripMenuItem)sender;
                    TransmitData2HexCheckbox.Checked = item.Checked;

                    TransmitData2HexEnabled = item.Checked;
                }

                // No, is the sender a checkbox?
                // Yes, update Hex from the sender's checked property.
                else if (sender is CheckBox)
                {
                    CheckBox item = (CheckBox)sender;
                    TransmitData2HexContextItem.Checked = item.Checked;

                    TransmitData2HexEnabled = item.Checked;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting the Hex property:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmitData3HexChanged(object sender, EventArgs e)
        {
            try
            {
                // Is the sender an item from a context menu?
                // Yes, update Hex from the sender's checked property.
                if (sender is ToolStripMenuItem)
                {
                    ToolStripMenuItem item = (ToolStripMenuItem)sender;
                    TransmitData3HexCheckbox.Checked = item.Checked;

                    TransmitData3HexEnabled = item.Checked;
                }

                // No, is the sender a checkbox?
                // Yes, update Hex from the sender's checked property.
                else if (sender is CheckBox)
                {
                    CheckBox item = (CheckBox)sender;
                    TransmitData3HexContextItem.Checked = item.Checked;

                    TransmitData3HexEnabled = item.Checked;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting the Hex property:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmitData4HexChanged(object sender, EventArgs e)
        {
            try
            {
                // Is the sender an item from a context menu?
                // Yes, update Hex from the sender's checked property.
                if (sender is ToolStripMenuItem)
                {
                    ToolStripMenuItem item = (ToolStripMenuItem)sender;
                    TransmitData4HexCheckbox.Checked = item.Checked;

                    TransmitData4HexEnabled = item.Checked;
                }

                // No, is the sender a checkbox?
                // Yes, update Hex from the sender's checked property.
                else if (sender is CheckBox)
                {
                    CheckBox item = (CheckBox)sender;
                    TransmitData4HexContextItem.Checked = item.Checked;

                    TransmitData4HexEnabled = item.Checked;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting the Hex property:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmitDataMultiLineTerminateChanged(object sender, EventArgs e)
        {
            try
            {
                // Is the sender an item from a context menu?
                // Yes, update Terminate from the sender's checked property.
                if (sender is ToolStripMenuItem)
                {
                    ToolStripMenuItem item = (ToolStripMenuItem)sender;
                    TransmitDataMultilineTerminateCheckbox.Checked = item.Checked;

                    TransmitDataMultiLineTerminateEnabled = item.Checked;
                }

                // No, is the sender a checkbox?
                // Yes, update Terminate from the sender's checked property.
                else if (sender is CheckBox)
                {
                    CheckBox item = (CheckBox)sender;
                    TransmitDataMultiLineTerminateContextItem.Checked = item.Checked;

                    TransmitDataMultiLineTerminateEnabled = item.Checked;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting the Terminate property:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmitData1TerminateChanged(object sender, EventArgs e)
        {
            try
            {
                // Is the sender an item from a context menu?
                // Yes, update Terminate from the sender's checked property.
                if (sender is ToolStripMenuItem)
                {
                    ToolStripMenuItem item = (ToolStripMenuItem)sender;
                    TransmitData1TerminateCheckbox.Checked = item.Checked;

                    TransmitData1TerminateEnabled = item.Checked;
                }

                // No, is the sender a checkbox?
                // Yes, update Terminate from the sender's checked property.
                else if (sender is CheckBox)
                {
                    CheckBox item = (CheckBox)sender;
                    TransmitData1TerminateContextItem.Checked = item.Checked;

                    TransmitData1TerminateEnabled = item.Checked;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting the Terminate property:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmitData2TerminateChanged(object sender, EventArgs e)
        {
            try
            {
                // Is the sender an item from a context menu?
                // Yes, update Terminate from the sender's checked property.
                if (sender is ToolStripMenuItem)
                {
                    ToolStripMenuItem item = (ToolStripMenuItem)sender;
                    TransmitData2TerminateCheckbox.Checked = item.Checked;

                    TransmitData2TerminateEnabled = item.Checked;
                }

                // No, is the sender a checkbox?
                // Yes, update Terminate from the sender's checked property.
                else if (sender is CheckBox)
                {
                    CheckBox item = (CheckBox)sender;
                    TransmitData2TerminateContextItem.Checked = item.Checked;

                    TransmitData2TerminateEnabled = item.Checked;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting the Terminate property:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmitData3TerminateChanged(object sender, EventArgs e)
        {
            try
            {
                // Is the sender an item from a context menu?
                // Yes, update Terminate from the sender's checked property.
                if (sender is ToolStripMenuItem)
                {
                    ToolStripMenuItem item = (ToolStripMenuItem)sender;
                    TransmitData3TerminateCheckbox.Checked = item.Checked;

                    TransmitData3TerminateEnabled = item.Checked;
                }

                // No, is the sender a checkbox?
                // Yes, update Terminate from the sender's checked property.
                else if (sender is CheckBox)
                {
                    CheckBox item = (CheckBox)sender;
                    TransmitData3TerminateContextItem.Checked = item.Checked;

                    TransmitData3TerminateEnabled = item.Checked;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting the Terminate property:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmitData4TerminateChanged(object sender, EventArgs e)
        {
            try
            {
                // Is the sender an item from a context menu?
                // Yes, update Terminate from the sender's checked property.
                if (sender is ToolStripMenuItem)
                {
                    ToolStripMenuItem item = (ToolStripMenuItem)sender;
                    TransmitData4TerminateCheckbox.Checked = item.Checked;

                    TransmitData4TerminateEnabled = item.Checked;
                }

                // No, is the sender a checkbox?
                // Yes, update Terminate from the sender's checked property.
                else if (sender is CheckBox)
                {
                    CheckBox item = (CheckBox)sender;
                    TransmitData4TerminateContextItem.Checked = item.Checked;

                    TransmitData4TerminateEnabled = item.Checked;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting the Terminate property:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Non event handlers /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private RadioButton RestoreRadiobuttonSettings(GroupBox RadiobuttonGroup, string StringSetting)
        {
            RadioButton CheckedRadio = new RadioButton();

            // Loop through all radiobuttons within the group. Check the one whose text matches
            // with the text from the setting. Uncheck all other ones.
            foreach (Control control in RadiobuttonGroup.Controls)
            {
                // Make sure to only loop through the radiobuttons.
                if (control is RadioButton)
                {
                    RadioButton Radio = (RadioButton)control;

                    // Is this the readio button that was checked at the time the user closed the application?
                    // Yes, check it again.
                    if (Radio.Text == StringSetting)
                    {
                        Radio.Checked = true;

                        CheckedRadio = Radio;
                    }

                    // No, uncheck it.
                    else
                    {
                        Radio.Checked = false;
                    }
                }
            }

            return (CheckedRadio);
        }

        private void SaveRadiobuttonSettings(GroupBox RadiobuttonGroup, string StringSettingName)
        {
            // Loop through all radiobuttons in the group until the checked one is found. Then,
            // save it's text in the settings.
            foreach (Control control in RadiobuttonGroup.Controls)
            {
                // Make sure to only loop through the radiobuttons.
                if (control is RadioButton)
                {
                    RadioButton Radio = (RadioButton)control;

                    // Is this radiobutton checked?
                    // Yes, update the setting.
                    if (Radio.Checked == true)
                    {
                        // Is the settings string valid?
                        // Yes, update the setting.
                        if (String.IsNullOrEmpty(StringSettingName) == false)
                        {
                            Settings.Default[StringSettingName] = Radio.Text;
                        }
                    }
                }
            }
        }

        private string ConvertAsciiStringToHexString(string InputString)
        {
            // Convert the input string to an array of characters.
            char[] InputCharArray = InputString.ToCharArray();
            string OutputString = "";

            // Loop through all characters and convert them to a hexadecimal string.
            foreach (char Character in InputCharArray)
            {
                OutputString += String.Format("{0:X2} ", Convert.ToInt32(Character));
            }

            return (OutputString);
        }

        private void PrintReceivedData(string InputString)
        {
            try
            {
                // Add the input string to the received data textbox.
                ReceivedDataTextBox.Invoke(new MethodInvoker(delegate 
                { 
                    ReceivedDataTextBox.AppendText(InputString); 
                } ));
            }

            catch(Exception exc)
            {
                MessageBox.Show("There was an error printing the received data:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void ReceivedDataTextboxScrollToEnd()
        {
            try
            {
                ReceivedDataTextBox.Invoke(new MethodInvoker(delegate 
                { 
                    // Set the caret to the end of the text contained in the text box.
                    ReceivedDataTextBox.SelectionStart = ReceivedDataTextBox.Text.Length;

                    // Scroll to the caret.
                    ReceivedDataTextBox.ScrollToCaret();
                }));
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error scrolling to the latest received data:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private string GetCurrentTimeString()
        {
            // Return the current time as a string.
            return(DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo));
        }

        private void SendDataToComPort(string Data, bool HexEnabled, bool TerminateEnabled, string TerminationString)
        {
            try
            {
                string SentData = String.Empty;
                byte[] DataByteArray;

                // Does the data have to be converted to a hex string?
                // Yes, convert the data and send it to the COM port.
                if (HexEnabled == true)
                {
                    // Keep track of what data has been sent.
                    SentData = Data;

                    // Remove all space characters.
                    Data = Data.Replace(" ", String.Empty);

                    // Convert the data to hex string.
                    DataByteArray = ConvertHexStringToByteArray(Data);

                    // Send the hex data to the COM port.
                    SerialDataPort.Write(DataByteArray, 0, DataByteArray.Length);
                }

                // No, just send the data as a string to the COM port.
                else
                {
                    // Keep track of what data has been sent.
                    SentData = Data;

                    // Send out the data to the COM port.
                    SerialDataPort.Write(Data);
                }

                // Does the data have to be terminated?
                // Yes, send the terminator to the COM port.
                if (TerminateEnabled == true)
                {
                    // Keep track of what data has been sent.
                    SentData += TerminationString;

                    SerialDataPort.Write(TerminationString);
                }

                // Do we have to prepend the current time?
                // Yes, do so.
                if (TransmittedDataTimestampEnabled == true)
                {
                    bool NewLineFound = true;
                    int NewLineIndex = 0;

                    // Retrieve the current time in string format.
                    SentData = SentData.Insert(0, GetCurrentTimeString() + "\t");

                    // Insert two tabs after each newline so each line is aligned properly with the previous one.
                    while (NewLineFound == true)
                    {
                        // Find the newline.
                        NewLineIndex = SentData.IndexOf(TerminationString, NewLineIndex);

                        // Did we find the newline?
                        // Yes, insert two tabs after it.
                        if (NewLineIndex != -1)
                        {   
                            // Is this the last termination string in the data?
                            // No, add the time string after it.
                            if (NewLineIndex != SentData.Length - TerminationString.Length)
                            {
                                NewLineIndex += TerminationString.Length;
                                SentData = SentData.Insert(NewLineIndex, GetCurrentTimeString() + "\t");
                            }
                            
                            // Yes, stop searching.
                            else
                            {
                                NewLineFound = false;
                            }
                        }

                        // No, clear the flag to indicate that.
                        else
                        {
                            NewLineFound = false;
                        }
                    }

                    // Add the transmitted data to the TransmittedData textbox.
                    PrintTransmittedData(SentData);
                }

                // No, just print the sent string.
                else
                {
                    // Add the transmitted data to the TransmittedData textbox.
                    PrintTransmittedData(SentData);
                }

                // Is autoscroll enabled?
                // Yes, scroll to the latest transmitted data.
                if (TransmittedDataAutoscrollEnabled)
                {
                    TransmittedDataScrollToEnd();
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error sending the data to the COM port:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void PrintTransmittedData(string InputString)
        {
            try
            {
                // Add the input string to the transmitted data textbox.
                TransmittedDataTextBox.Invoke(new MethodInvoker(delegate
                {
                    TransmittedDataTextBox.AppendText(InputString);
                }));
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error printing the received data:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void TransmittedDataScrollToEnd()
        {
            try
            {
                TransmittedDataTextBox.Invoke(new MethodInvoker(delegate
                {
                    // Set the caret to the end of the text contained in the text box.
                    TransmittedDataTextBox.SelectionStart = TransmittedDataTextBox.Text.Length;

                    // Scroll to the caret.
                    TransmittedDataTextBox.ScrollToCaret();
                }));
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error scrolling to the latest transmitted data:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private byte[] ConvertHexStringToByteArray(string HexInputString)
        {
            try
            {
                int HexInputStringIndex;
                int DataStringsIndex = 0;

                // First make sure the string has an even amount of characters.
                if (HexInputString.Length % 2 == 1)
                {
                    HexInputString += "0";
                }

                // Now it's safe to create the internal arrays because they too will now have an even length.
                string DataString = String.Empty;
                byte[] DataByteArray = new byte[HexInputString.Length / 2];

                // Sort the characters of the string into pairs and convert them to hex values.
                for (HexInputStringIndex = 0; HexInputStringIndex < HexInputString.Length; HexInputStringIndex += 2)
                {
                    // Temporarily store the two next characters from the input string.
                    DataString = HexInputString[HexInputStringIndex].ToString() + HexInputString[HexInputStringIndex + 1].ToString();

                    // Convert the string into hex.
                    DataByteArray[DataStringsIndex] = (byte) Convert.ToByte(DataString, 16);

                    DataStringsIndex++;
                }

                return (DataByteArray);
            }

            catch (Exception exc)
            {
                byte[] CatchReturn = new byte[1];

                MessageBox.Show("There was an error converting the hex string to a byte array:\n\n" + exc.Message + "\n\n" + exc.StackTrace);

                // Make sure to always return something.
                return (CatchReturn);
            }
        }
    }
}
