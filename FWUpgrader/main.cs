using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FWUpgrader
{
    public partial class main : Form
    {
        const Int32 TIMEOUT_MS = 5;
        const Int32 ESCAPE_TIMEOUT = 2;
        const Int32 ESCAPE_COUNTER = 2500; 
        const Int32 TIMEOUT_GO_WRITE = 4000;
        const Int32 TIMEOUT_GO_READ = 4000;
        const Int32 GPNVM_TIMEOUT = 100;
        const string appletCommandInit = "00000000";
        const string appletCommandWrite = "00000002";
        const string appletCommandRead = "00000003";
        const string appletCommandGPNVM = "00000006";
        List<byte[]> fileToSendBytesList = new List<byte[]>();
        byte[] binaryImageSent;
        byte[] binaryImageRead = new byte[0];
        Int32 fileToSendSize = 0;

        public main()
        {
            InitializeComponent();
        }

        /* Search for available COM ports: */
        private void comboBoxPort_Click(object sender, EventArgs e)
        {
            List<string> serialPortNames = new List<string>(System.IO.Ports.SerialPort.GetPortNames());
            comboBoxPort.DataSource = serialPortNames;
        }

        /* Open selected COM port*/
        private void buttonOpenPort_Click(object sender, EventArgs e)
        {
            serialPort.PortName = comboBoxPort.GetItemText(comboBoxPort.SelectedItem);
            serialPort.Encoding = Encoding.GetEncoding(1252);
            serialPort.Open();
        }

        /* Close selected COM port*/
        private void buttonClosePort_Click(object sender, EventArgs e)
        {
            serialPort.Close();
        }

        /* Change sam-ba monitor to binary mode: */
        private void buttonChangeToBinary_Click(object sender, EventArgs e)
        {
            SetBusy();
            SendSerialByString("N#");
            if (textBoxReceivedData.Text != "0d0a")
            {
                MessageBox.Show("ERROR: did not change to binary mode");
            }
            SetReady();
        }

        /* Read the chip ID and compare to the expected: */
        private void buttonReadChipID_Click(object sender, EventArgs e)
        {
            SetBusy();
            SendSerialByString(GenerateCommandReadInt(textBoxChipIDAddress.Text));
            if (textBoxReceivedData.Text != textBoxExpectedChipID.Text)
            {
                MessageBox.Show("ERROR: Chip ID does not match");
            }
            SetReady();
        }

        /* Load bin file into (big) array. 
           Note, loading another file will overwrite the array to the new one data. */
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            SetBusy();
            Stream myStream = null;
            fileToSendBytesList.Clear();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            MemoryStream memoryStream = new MemoryStream();
                            myStream.CopyTo(memoryStream);
                            byte[] binaryData = memoryStream.ToArray();
                            fileToSendSize = binaryData.Length;
                            if ((fileToSendSize % 128 != 0)) //Allign file to 128
                            {
                                byte[] auxData = new byte[128 - (binaryData.Length % 128)];
                                for (int i = 0; i < auxData.Length; i++)
                                {
                                    auxData[i] = 0;
                                }
                                binaryData = binaryData.Concat(auxData).ToArray();
                            }

                            binaryImageSent = binaryData;

                            Int64 fileSize = binaryData.Length;
                            byte packetNumber = 1;
                            Int64 index = 0;
                            while (index < fileSize)
                            {
                                byte[] currentData = new byte[128];
                                Array.Copy(binaryData, index, currentData, 0, 128);
                                Int16 crc16 = calcCrc(currentData);
                                byte[] fullCurrentPacket = new byte[133];
                                fullCurrentPacket[0] = 1;
                                fullCurrentPacket[1] = packetNumber;
                                fullCurrentPacket[2] = (byte)(255 - packetNumber);
                                Array.Copy(currentData, 0, fullCurrentPacket, 3, 128);
                                fullCurrentPacket[131] = (byte)(crc16 >> 8 & 0xFF);
                                fullCurrentPacket[132] = (byte)(crc16 & 0xFF);
                                fileToSendBytesList.Add(fullCurrentPacket);
                                packetNumber += 1;
                                index += 128;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            SetReady();
        }

        /* Send the (choosen) applet data into the SRAM: */
        private void buttonSendAppletData_Click(object sender, EventArgs e)
        {
            SetBusy();
            SendFile(textBoxAppletAddress.Text, fileToSendSize.ToString("X8"), fileToSendBytesList);
            SetReady();
        }

        /* Send any command by string. try for example to send "V#" (watch the result by serial monitor) */
        private void buttonSend_Click(object sender, EventArgs e)
        {
            SendSerialByString(textBoxCommand.Text);
        }

        /* Run the flash applet initialization to get some important data: */
        private void buttonInitApplet_Click(object sender, EventArgs e)
        {
            SetBusy();

            SendSerialByString(GenerateCommandWriteInt(textBoxARGV0Address.Text, textBoxCommunicationType.Text), false);
            System.Threading.Thread.Sleep(TIMEOUT_MS);
            SendSerialByString(GenerateCommandWriteInt(textBoxMailboxAddress.Text, appletCommandInit), false);
            System.Threading.Thread.Sleep(TIMEOUT_MS);
            SendSerialByString(GenerateCommandGo(textBoxAppletAddress.Text));
            if (textBoxReceivedData.Text != "06")
            {
                MessageBox.Show("ERROR: did not get '06' character after 'Go' command");
            }
            SendSerialByString(GenerateCommandReadInt(textBoxMailboxAddress.Text));
            if (textBoxReceivedData.Text != "ffffffff")
            {
                MessageBox.Show("ERROR: did not finish the applet excecution");
            }
            SendSerialByString(GenerateCommandReadInt(textBoxStatusAddress.Text));
            if (textBoxReceivedData.Text != "00000000")
            {
                MessageBox.Show("ERROR: applet status is not equal to 0");
            }
            SendSerialByString(GenerateCommandReadInt(textBoxARGV1Address.Text));
            textBoxBufferAddress.Text = textBoxReceivedData.Text;
            SendSerialByString(GenerateCommandReadInt(textBoxARGV2Address.Text));
            textBoxBufferSize.Text = textBoxReceivedData.Text;
            SetReady();
        }

        /* Load binary file: */
        private void buttonBrowseImage_Click(object sender, EventArgs e)
        {
            buttonBrowse.PerformClick();
        }

        /* Send the WHOLE image to its location in the flash: */
        private void buttonSendImage_Click(object sender, EventArgs e)
        {
            SetBusy();
            Int32 bufferSize = Convert.ToInt32(textBoxBufferSize.Text, 16);
            Int32 writeOffset = 0;
            while (fileToSendBytesList.Count > 0) //Each iteration send only bufferSize size to SRAM and then the applet will write into flash
            {
                List<byte[]> currentChunk;

                if (fileToSendBytesList.Count >= bufferSize / 128)
                {
                    currentChunk = fileToSendBytesList.Take(bufferSize / 128).ToList();
                    fileToSendBytesList.RemoveRange(0, bufferSize / 128);
                }
                else
                {
                    currentChunk = fileToSendBytesList.Take(fileToSendBytesList.Count).ToList();
                    fileToSendBytesList.RemoveRange(0, fileToSendBytesList.Count);
                }

                SendFile(textBoxBufferAddress.Text, textBoxBufferSize.Text, currentChunk);

                SendSerialByString(GenerateCommandWriteInt(textBoxMailboxAddress.Text, appletCommandWrite), false);
                SendSerialByString(GenerateCommandWriteInt(textBoxARGV0Address.Text, textBoxBufferAddress.Text), false);
                SendSerialByString(GenerateCommandWriteInt(textBoxARGV1Address.Text, textBoxBufferSize.Text), false);
                SendSerialByString(GenerateCommandWriteInt(textBoxARGV2Address.Text, writeOffset.ToString("X8")), false);
                SendSerialByString(GenerateCommandGo(textBoxAppletAddress.Text), false);
                System.Threading.Thread.Sleep(TIMEOUT_GO_WRITE);
                SendSerialByString(GenerateCommandReadInt(textBoxMailboxAddress.Text));
                if (textBoxReceivedData.Text != "fffffffd")
                {
                    MessageBox.Show("ERROR: did not finish the applet excecution");
                }
                SendSerialByString(GenerateCommandReadInt(textBoxStatusAddress.Text));
                if (textBoxReceivedData.Text != "00000000")
                {
                    MessageBox.Show("ERROR: applet status is not equal to 0");
                }
                SendSerialByString(GenerateCommandReadInt(textBoxARGV0Address.Text));
                textBoxNumberOfBytesWrote.Text = textBoxReceivedData.Text;

                writeOffset += bufferSize;
            }
            SetReady();
        }

        /* Run the flash applet with the commad of setting the GPNVM bits (for booting from flash rather than from ROM): */
        private void buttonGPNVMSet_Click(object sender, EventArgs e)
        {
            SetBusy();
            SendSerialByString(GenerateCommandWriteInt(textBoxMailboxAddress.Text, appletCommandGPNVM), false);
            System.Threading.Thread.Sleep(TIMEOUT_MS);
            SendSerialByString(GenerateCommandWriteInt(textBoxARGV0Address.Text, "00000001"), false); //GPNVM bit 1 (?)
            System.Threading.Thread.Sleep(TIMEOUT_MS);
            SendSerialByString(GenerateCommandWriteInt(textBoxARGV1Address.Text, "00000001"), false); // Set command (?)
            System.Threading.Thread.Sleep(TIMEOUT_MS);
            SendSerialByString(GenerateCommandGo(textBoxAppletAddress.Text));
            System.Threading.Thread.Sleep(GPNVM_TIMEOUT);
            if (textBoxReceivedData.Text != "06")
            {
                MessageBox.Show("ERROR: did not get '06' character after 'Go' command");
            }
            SendSerialByString(GenerateCommandReadInt(textBoxMailboxAddress.Text));
            if (textBoxReceivedData.Text != "fffffff9")
            {
                MessageBox.Show("ERROR: did not finish the applet excecution");
            }
            SendSerialByString(GenerateCommandReadInt(textBoxStatusAddress.Text));
            if (textBoxReceivedData.Text != "00000000")
            {
                MessageBox.Show("ERROR: applet status is not equal to 0");
            }
            SetReady();
        }

        /* Load binary: */
        private void buttonLowlevelBrowse_Click(object sender, EventArgs e)
        {
            buttonBrowse.PerformClick();
        }

        /* Send the lowlevel applet into SRAM*/
        private void buttonLowlevelSend_Click(object sender, EventArgs e)
        {
            buttonSendAppletData.PerformClick();
        }

        /* Run the lowlevel applet: (for my SAM4S Xplained board I can ignore this step. weird...)*/
        private void buttonLowlevelInit_Click(object sender, EventArgs e)
        {
            SetBusy();

            SendSerialByString(GenerateCommandWriteInt(textBoxMailboxAddress.Text, appletCommandInit), false);
            System.Threading.Thread.Sleep(TIMEOUT_MS);
            SendSerialByString(GenerateCommandWriteInt(textBoxARGV0Address.Text, textBoxLowlevelArgv0Val.Text), false);
            System.Threading.Thread.Sleep(TIMEOUT_MS);
            SendSerialByString(GenerateCommandWriteInt(textBoxARGV1Address.Text, textBoxLowlevelArgv1Val.Text), false);
            System.Threading.Thread.Sleep(TIMEOUT_MS);
            SendSerialByString(GenerateCommandWriteInt(textBoxARGV2Address.Text, textBoxLowlevelArgv2Val.Text), false);
            System.Threading.Thread.Sleep(TIMEOUT_MS);
            SendSerialByString(GenerateCommandWriteInt(textBoxARGV3Address.Text, textBoxLowlevelArgv3Val.Text), false);
            System.Threading.Thread.Sleep(TIMEOUT_MS);
            SendSerialByString(GenerateCommandWriteInt(textBoxARGV4Address.Text, textBoxLowlevelArgv4Val.Text), false);
            System.Threading.Thread.Sleep(TIMEOUT_MS);

            SendSerialByString(GenerateCommandGo(textBoxAppletAddress.Text));
            if (textBoxReceivedData.Text != "06")
            {
                MessageBox.Show("ERROR: did not get '06' character after 'Go' command");
            }
            SendSerialByString(GenerateCommandReadInt(textBoxMailboxAddress.Text));
            if (textBoxReceivedData.Text != "ffffffff")
            {
                MessageBox.Show("ERROR: did not finish the applet excecution");
            }
            SendSerialByString(GenerateCommandReadInt(textBoxStatusAddress.Text));
            if (textBoxReceivedData.Text != "00000000")
            {
                MessageBox.Show("ERROR: applet status is not equal to 0");
            }
            SetReady();
        }

        /* Read the WHOLE image from the flash to (a big one) array: */
        private void buttonRead_Click(object sender, EventArgs e)
        {
            SetBusy();
            Int32 bufferSize = Convert.ToInt32(textBoxBufferSize.Text, 16);
            Int32 ReadOffset = 0;
            while (binaryImageRead.Length < binaryImageSent.Length) //Each iteration read only chunk from SRAM
            {
                SendSerialByString(GenerateCommandWriteInt(textBoxMailboxAddress.Text, appletCommandRead), false);
                SendSerialByString(GenerateCommandWriteInt(textBoxARGV0Address.Text, textBoxBufferAddress.Text), false);
                SendSerialByString(GenerateCommandWriteInt(textBoxARGV1Address.Text, textBoxBufferSize.Text), false);
                SendSerialByString(GenerateCommandWriteInt(textBoxARGV2Address.Text, ReadOffset.ToString("X8")), false);
                SendSerialByString(GenerateCommandGo(textBoxAppletAddress.Text), false);
                System.Threading.Thread.Sleep(TIMEOUT_GO_READ);
                SendSerialByString(GenerateCommandReadInt(textBoxMailboxAddress.Text));
                if (textBoxReceivedData.Text != "fffffffc")
                {
                    MessageBox.Show("ERROR: did not finish the applet excecution");
                }
                SendSerialByString(GenerateCommandReadInt(textBoxStatusAddress.Text));
                if (textBoxReceivedData.Text != "00000000")
                {
                    MessageBox.Show("ERROR: applet status is not equal to 0");
                }

                binaryImageRead = binaryImageRead.Concat(ReadFile(textBoxBufferAddress.Text, textBoxBufferSize.Text)).ToArray();
                ReadOffset += bufferSize;
            }

            binaryImageRead = binaryImageRead.Take(binaryImageSent.Length).ToArray();
            SetReady();
        }

        /* Compare Read data and sent data to make sure flash is not corrupted: */
        private void buttonCompare_Click(object sender, EventArgs e)
        {
            SetBusy();
            if (binaryImageRead.SequenceEqual(binaryImageSent) == false)
            {
                MessageBox.Show("ERROR: Binaries are different");
            }
            else
            {
                MessageBox.Show("GOOD: Binaries are equal");
            }
            SetReady();
        }

        /* Indicate user "busy" */
        private void SetBusy()
        {
            labelStatus.Text = "Busy";
            labelStatus.ForeColor = Color.Red;
            labelStatus.Refresh();
        }

        /* Indicate user "ready" */
        private void SetReady()
        {
            labelStatus.Text = "Ready";
            labelStatus.ForeColor = Color.Green;
            labelStatus.Refresh();
        }

        /* Send chunk of bytes to SRAM */
        private void SendFile(string address, string size, List<byte[]> file)
        {
            SendSerialByString(GenerateCommandWriteData(address, size));
            if (textBoxReceivedData.Text != "43")
            {
                MessageBox.Show("ERROR: did not get '43' character");
            }

            for (Int32 i = 0; i < file.Count; i++)
            {
                SendSerialByBytes(file[i]);

                if (textBoxReceivedData.Text != "06")
                {
                    MessageBox.Show("ERROR: did not get '06' character");
                }
            }

            SendSerialByBytes(new byte[] { 0x04 });
            if (textBoxReceivedData.Text != "06")
            {
                MessageBox.Show("ERROR: did not get '06' character");
            }
        }

        /* Read chunk of bytes from SRAM */
        private byte[] ReadFile(string address, string bufferSize)
        {
            SendSerialByString(GenerateCommandReadData(address, bufferSize), false);

            SendSerialByString("C", false);

            byte[] receivedData = new byte[0];

            while (receivedData.Length < Convert.ToInt32(textBoxBufferSize.Text, 16))
            {
                byte[] fullPacket = ReadSerial(133);
                byte[] onlyData = new byte[128];
                Array.Copy(fullPacket, 3, onlyData, 0, 128);
                receivedData = receivedData.Concat(onlyData).ToArray();
                SendSerialByBytes(new byte[] { 0x06 }, false);
            }

            if (ReadSerial(1).SequenceEqual(new byte[] { 0x04} ) == false)
            {
                MessageBox.Show("ERROR: did not get end of transmission:");
            }

            SendSerialByBytes(new byte[] { 0x06 }, false);

            return receivedData;


        }

        /* Send any command using strings. wait for incoming data if needed: */
        private void SendSerialByString(string command, bool waitForData = true)
        {
            textBoxReceivedData.Clear();
            textBoxReceivedData.Refresh();
            textBoxCommand.Text = command;
            if (serialPort.BytesToRead != 0)
            {
                MessageBox.Show(string.Format("Warning: {0} unread bytes", serialPort.BytesToRead));
            }
            serialPort.DiscardInBuffer();
            serialPort.Write(command);

            /* Wait for incoming data: */
            if (waitForData)
            {
                Int32 escape = 2500;
                while (serialPort.BytesToRead == 0)
                {
                    System.Threading.Thread.Sleep(ESCAPE_TIMEOUT);
                    escape--;
                    if (escape == 0)
                    {
                        MessageBox.Show("ERROR: Serial timeout. Aborted");
                        return;
                    }
                }
                System.Threading.Thread.Sleep(TIMEOUT_MS);

                Int32 numOfBytes = serialPort.BytesToRead;
                byte[] receivedData = new byte[numOfBytes];
                serialPort.Read(receivedData, 0, numOfBytes);

                for (Int32 i = 0; i < numOfBytes; i++)
                {
                    textBoxReceivedData.Text = receivedData[i].ToString("x2") + textBoxReceivedData.Text;
                }
            }
        }

        /* Send any command using byte array. wait for incoming data if needed: */
        private void SendSerialByBytes(byte[] command, bool waitForData = true)
        {
            textBoxReceivedData.Clear();
            textBoxReceivedData.Refresh();
            if (serialPort.BytesToRead != 0)
            {
                MessageBox.Show(string.Format("Warning: {0} unread bytes", serialPort.BytesToRead));
            }
            serialPort.DiscardInBuffer();
            serialPort.Write(command, 0, command.Length);

            /* Wait for incoming data: */
            if (waitForData)
            {
                Int32 escape = 2500;
                while (serialPort.BytesToRead == 0)
                {
                    System.Threading.Thread.Sleep(ESCAPE_TIMEOUT);
                    escape--;
                    if (escape == 0)
                    {
                        MessageBox.Show("ERROR: Serial timeout. Aborted");
                        return;
                    }
                }
                System.Threading.Thread.Sleep(TIMEOUT_MS);

                Int32 numOfBytes = serialPort.BytesToRead;
                byte[] receivedData = new byte[numOfBytes];
                serialPort.Read(receivedData, 0, numOfBytes);

                for (Int32 i = 0; i < numOfBytes; i++)
                {
                    textBoxReceivedData.Text = receivedData[i].ToString("x2") + textBoxReceivedData.Text;
                }
            }
        }

        /* Read specific number of bytes from serial: */
        private byte[] ReadSerial(Int32 size)
        {
            /* Wait for incoming data: */
            Int32 escape = 2500;
            while (serialPort.BytesToRead < size)
            {
                System.Threading.Thread.Sleep(ESCAPE_TIMEOUT);
                escape--;
                if (escape == 0)
                {
                    MessageBox.Show("ERROR: Serial timeout. Aborted");
                    return null;
                }
            }

            byte[] receivedData = new byte[size];
            serialPort.Read(receivedData, 0, size);

            return receivedData;
        }

        /* Generate commands: */
        private string GenerateCommandReadInt(string address)
        {
            return "w" + address + ",4#";
        }

        private string GenerateCommandWriteInt(string address, string value)
        {
            return "W" + address + "," + value + "#";
        }

        private string GenerateCommandWriteData(string address, string length)
        {
            return "S" + address + ',' + length + "#";
        }

        private string GenerateCommandReadData(string address, string length)
        {
            return "R" + address + ',' + length + "#";
        }

        private string GenerateCommandGo(string address)
        {
            return "G" + address + "#";
        }

        /* Calculate the xmodem crc: */
        private Int16 calcCrc(byte[] data)
        {
            unchecked
            {
                Int16 crc = 0;

                for (Int32 j = 0; j < data.Length; j++)
                {
                    crc ^= (Int16)(data[j] << 8);
                    for (Int32 i = 0; i < 8; i++)
                    {
                        if ((crc & 0x8000) != 0)
                            crc = (Int16)((crc << 1) ^ 0x1021);
                        else
                            crc = (Int16)(crc << 1);
                    }
                }
                return crc;
            }
        }
    }
}