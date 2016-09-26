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
        bool SerialPortConnected = false;

        // Settings
        string TransmitTerminationCharacter = "";
        bool AutoscrollEnabled = false;
        bool TimestampEnabled = false;
        bool ClearOnConnectEnabled = false;

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
                TransmitTerminationCharacter = Settings.Default.TransmitTerminationCharacter;
                AutoscrollEnabled = Settings.Default.AutoscrollEnabled;
                TimestampEnabled = Settings.Default.TimestampEnabled;
                ClearOnConnectEnabled = Settings.Default.ClearOnConnect;
                ReceivedDataTextBox.Font = Settings.Default.SystemFont;

                // Set all radiobuttons to their stored values and set the baudrate, data bits, parity,
                // and handshake to the value they were when te application was closed.
                RestoreRadiobuttonSettings(TransmitTerminationGroup, Settings.Default.TransmitTermination);
                
                CheckedRadio = RestoreRadiobuttonSettings(BaudGroup, Settings.Default.Baudrate);
                SerialDataPort.BaudRate = Convert.ToInt32(CheckedRadio.Tag);

                CheckedRadio = RestoreRadiobuttonSettings(DataBitsGroup, Settings.Default.DataBits);
                SerialDataPort.DataBits = Convert.ToInt32(CheckedRadio.Tag);

                CheckedRadio = RestoreRadiobuttonSettings(ParityGroup, Settings.Default.Parity);
                SerialDataPort.Parity = (Parity) Convert.ToInt32(CheckedRadio.Tag);

                CheckedRadio = RestoreRadiobuttonSettings(StopBitsGroup, Settings.Default.StopBits);
                SerialDataPort.StopBits = (StopBits) Convert.ToInt32(CheckedRadio.Tag);

                CheckedRadio = RestoreRadiobuttonSettings(HandshakeGroup, Settings.Default.Handshake);
                SerialDataPort.Handshake = (Handshake) Convert.ToInt32(CheckedRadio.Tag);
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
                Settings.Default.TransmitTerminationCharacter = TransmitTerminationCharacter;
                Settings.Default.AutoscrollEnabled = AutoscrollEnabled;
                Settings.Default.TimestampEnabled = TimestampEnabled;
                Settings.Default.ClearOnConnect = ClearOnConnectEnabled;
                Settings.Default.SystemFont = ReceivedDataTextBox.Font;

                // Save which radiobuttons are checked.
                SaveRadiobuttonSettings(BaudGroup, "Baudrate");
                SaveRadiobuttonSettings(DataBitsGroup, "DataBits");
                SaveRadiobuttonSettings(ParityGroup, "Parity");
                SaveRadiobuttonSettings(StopBitsGroup, "StopBits");
                SaveRadiobuttonSettings(HandshakeGroup, "Handshake");
                SaveRadiobuttonSettings(TransmitTerminationGroup, "TransmitTermination");

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

                        SerialPortConnected = false;
                        break;

                    case false:
                        // Select the correct COM port.
                        SerialDataPort.PortName = ComPortDropDown.Text;

                        // Open a serial connection to a device.
                        SerialDataPort.Open();

                        // Clear the buffers before using the COM port.
                        SerialDataPort.DiscardInBuffer();
                        SerialDataPort.DiscardOutBuffer();

                        // Update the text of the connection button.
                        ComConnectionButton.Text = "Disconnect";

                        // Is Clear on connect enabled?
                        // Yes, clear the received data textbox.
                        if (ClearOnConnectEnabled == true)
                        {
                            ClearContextMenu_Click(sender, e);
                        }

                        // Disable the COM port list.
                        ComPortDropDown.Enabled = false;

                        SerialPortConnected = true;
                        break;

                    default:
                        // Close the serial connection.
                        SerialDataPort.Close();
                        
                        // Update the text of the conneciton button.
                        ComConnectionButton.Text = "Connect";

                        // Enable the COM port list.
                        ComPortDropDown.Enabled = true;

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
                    // Update the baudrate of the serial connection with the selected value.
                    SerialDataPort.BaudRate = Convert.ToInt32(changedRadio.Text);
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error updating the baudrate:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
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
                // Determine which transmit termination character is selected and store it.
                if (TransmitTerminationNoneRadio.Checked == true)
                {
                    TransmitTerminationCharacter = "";
                }

                else if (TransmitTerminationCrRadio.Checked == true)
                {
                    TransmitTerminationCharacter = "\r";
                }

                else if (TransmitTerminationLfRadio.Checked == true)
                {
                    TransmitTerminationCharacter = "\n";
                }

                else if (TransmitTerminationCrLfRadio.Checked == true)
                {
                    TransmitTerminationCharacter = "\r\n";
                }

                else
                {
                    TransmitTerminationCharacter = "";
                }
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

                /* This does not work properly, needs fixing. */
                // Does the received string contain a Line Feed character and are timestamps enabled?
                // Yes, add the timestamp to the data.
                if (TimestampEnabled == true)
                {
                    // Read lines form the buffer until there is no data left.
                    while(SerialDataPort.BytesToRead != 0)
                    {
                        // Read a line of data form the reception buffer.
                        ReceivedData = SerialDataPort.ReadLine();

                        // Prepend the current time to the received data.
                        ReceivedDataTextBox.Invoke(new MethodInvoker(delegate { ReceivedDataTextBox.AppendText(DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo) + "\t"); }));

                        // Add the received data to the output textbox.
                        ReceivedDataTextBox.Invoke(new MethodInvoker(delegate { ReceivedDataTextBox.AppendText(ReceivedData + "\n"); }));
                    }
                }

                else
                {
                    // Retrieve all received data.
                    ReceivedData = SerialDataPort.ReadExisting();

                    // Add the received data to the output textbox.
                    ReceivedDataTextBox.Invoke(new MethodInvoker(delegate { ReceivedDataTextBox.AppendText(ReceivedData); }));
                }

                // Is autoscroll enabled?
                // Yes, scroll to the end of the data.
                if (AutoscrollEnabled == true)
                {
                    ReceivedDataTextBox.Invoke(new MethodInvoker(delegate { ReceivedDataTextBox.SelectionStart = ReceivedDataTextBox.Text.Length; }));
                    ReceivedDataTextBox.Invoke(new MethodInvoker(delegate { ReceivedDataTextBox.ScrollToCaret(); }));
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

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Context menu ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void ClearContextMenu_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the contents of the rich text box.
                ReceivedDataTextBox.Invoke(new MethodInvoker(delegate { ReceivedDataTextBox.Clear(); }));
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error clearing the data.\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void AutoscrollContextMenuChanged(object sender, EventArgs e)
        {
            try
            {
                // Copy the boolean checked state of the context menu item to the enable/disable flag.
                AutoscrollEnabled = ReceivedDataAutoscrollContextitem.Checked;
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error clearing the data:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void ReceivedDataFont_Click(object sender, EventArgs e)
        {
            try
            {
                // Show the Font dialog. Did the user accept the changes?
                // Yes, update the font of all received data.
                if (ReceivedDataFontDialog.ShowDialog() != DialogResult.Cancel)
                {
                    ReceivedDataTextBox.Font = ReceivedDataFontDialog.Font;
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error changing the font:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
            }
        }

        private void ReceivedDataTimestampChanged(object sender, EventArgs e)
        {
            try
            {
                // Copy the boolean checked state of the context menu item to the setting.
                TimestampEnabled = ReceivedDataTimestampContextItem.Checked;
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
                // Set or clear the clear on connect property.
                ClearOnConnectEnabled = ReceivedDataClearOnConnectContextItem.Checked; ;
            }

            catch (Exception exc)
            {
                MessageBox.Show("There was an error setting the Clear on connect property:\n\n" + exc.Message + "\n\n" + exc.StackTrace);
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
            foreach (RadioButton Radio in RadiobuttonGroup.Controls)
            {
                // Is this the readiobutton that was checked at the time the user closed the application?
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

            return (CheckedRadio);
        }

        private void SaveRadiobuttonSettings(GroupBox RadiobuttonGroup, string StringSettingName)
        {
            // Loop through all radiobuttons in the group until the checked one is found. Then,
            // save it's text in the settings.
            foreach (RadioButton Radio in RadiobuttonGroup.Controls)
            {
                // Is this radiobutton checked?
                // Yes, update the setting.
                if (Radio.Checked == true)
                {
                    Settings.Default[StringSettingName] = Radio.Text;
                }
            }
        }
    }
}
