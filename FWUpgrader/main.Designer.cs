namespace FWUpgrader
{
    partial class main
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
            this.groupBoxCommunication = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonClosePort = new System.Windows.Forms.Button();
            this.buttonOpenPort = new System.Windows.Forms.Button();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.groupBoxCommands = new System.Windows.Forms.GroupBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelReceivedData = new System.Windows.Forms.Label();
            this.textBoxReceivedData = new System.Windows.Forms.TextBox();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.labelCommand = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.buttonLowlevelInit = new System.Windows.Forms.Button();
            this.buttonLowlevelSend = new System.Windows.Forms.Button();
            this.buttonLowlevelBrowse = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonGPNVMSet = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonSendImage = new System.Windows.Forms.Button();
            this.buttonBrowseImage = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonInitApplet = new System.Windows.Forms.Button();
            this.buttonSendAppletData = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonReadChipID = new System.Windows.Forms.Button();
            this.buttonChangeToBinary = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxChipIDAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExpectedChipID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAppletAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMailboxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxARGV0Address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxARGV1Address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxStatusAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxARGV2Address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxBufferSize = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxBufferAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCommunicationType = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxNumberOfBytesWrote = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxLowlevelArgv0Val = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxLowlevelArgv1Val = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxLowlevelArgv2Val = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxLowlevelArgv3Val = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxLowlevelArgv4Val = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxARGV3Address = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxARGV4Address = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxCommunication.SuspendLayout();
            this.groupBoxCommands.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCommunication
            // 
            this.groupBoxCommunication.Controls.Add(this.labelStatus);
            this.groupBoxCommunication.Controls.Add(this.buttonClosePort);
            this.groupBoxCommunication.Controls.Add(this.buttonOpenPort);
            this.groupBoxCommunication.Controls.Add(this.comboBoxPort);
            this.groupBoxCommunication.Controls.Add(this.labelPort);
            this.groupBoxCommunication.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxCommunication.Location = new System.Drawing.Point(12, 23);
            this.groupBoxCommunication.Name = "groupBoxCommunication";
            this.groupBoxCommunication.Size = new System.Drawing.Size(1132, 72);
            this.groupBoxCommunication.TabIndex = 1;
            this.groupBoxCommunication.TabStop = false;
            this.groupBoxCommunication.Text = "Communication:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelStatus.ForeColor = System.Drawing.Color.Green;
            this.labelStatus.Location = new System.Drawing.Point(728, 29);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(54, 16);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Ready";
            // 
            // buttonClosePort
            // 
            this.buttonClosePort.Location = new System.Drawing.Point(369, 24);
            this.buttonClosePort.Name = "buttonClosePort";
            this.buttonClosePort.Size = new System.Drawing.Size(122, 26);
            this.buttonClosePort.TabIndex = 3;
            this.buttonClosePort.Text = "Close port";
            this.buttonClosePort.UseVisualStyleBackColor = true;
            this.buttonClosePort.Click += new System.EventHandler(this.buttonClosePort_Click);
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.Location = new System.Drawing.Point(223, 24);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(122, 26);
            this.buttonOpenPort.TabIndex = 2;
            this.buttonOpenPort.Text = "Open port";
            this.buttonOpenPort.UseVisualStyleBackColor = true;
            this.buttonOpenPort.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(70, 24);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 26);
            this.comboBoxPort.TabIndex = 1;
            this.comboBoxPort.Click += new System.EventHandler(this.comboBoxPort_Click);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPort.Location = new System.Drawing.Point(18, 30);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(35, 16);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Port:";
            // 
            // groupBoxCommands
            // 
            this.groupBoxCommands.Controls.Add(this.buttonSend);
            this.groupBoxCommands.Controls.Add(this.labelReceivedData);
            this.groupBoxCommands.Controls.Add(this.textBoxReceivedData);
            this.groupBoxCommands.Controls.Add(this.textBoxCommand);
            this.groupBoxCommands.Controls.Add(this.labelCommand);
            this.groupBoxCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBoxCommands.Location = new System.Drawing.Point(12, 101);
            this.groupBoxCommands.Name = "groupBoxCommands";
            this.groupBoxCommands.Size = new System.Drawing.Size(1132, 61);
            this.groupBoxCommands.TabIndex = 5;
            this.groupBoxCommands.TabStop = false;
            this.groupBoxCommands.Text = "General commands:";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(497, 22);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(122, 26);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelReceivedData
            // 
            this.labelReceivedData.AutoSize = true;
            this.labelReceivedData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelReceivedData.Location = new System.Drawing.Point(625, 29);
            this.labelReceivedData.Name = "labelReceivedData";
            this.labelReceivedData.Size = new System.Drawing.Size(100, 16);
            this.labelReceivedData.TabIndex = 7;
            this.labelReceivedData.Text = "Received data:";
            // 
            // textBoxReceivedData
            // 
            this.textBoxReceivedData.Location = new System.Drawing.Point(731, 24);
            this.textBoxReceivedData.Name = "textBoxReceivedData";
            this.textBoxReceivedData.Size = new System.Drawing.Size(395, 24);
            this.textBoxReceivedData.TabIndex = 6;
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(97, 24);
            this.textBoxCommand.Multiline = true;
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(394, 24);
            this.textBoxCommand.TabIndex = 5;
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCommand.Location = new System.Drawing.Point(18, 29);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(73, 16);
            this.labelCommand.TabIndex = 4;
            this.labelCommand.Text = "Command:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1132, 233);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instance commands:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.buttonCompare);
            this.groupBox8.Controls.Add(this.buttonRead);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox8.Location = new System.Drawing.Point(6, 163);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(553, 57);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Reading image from flash:";
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(204, 23);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(135, 28);
            this.buttonCompare.TabIndex = 5;
            this.buttonCompare.Text = "Compare!";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(6, 23);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(135, 28);
            this.buttonRead.TabIndex = 4;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.buttonLowlevelInit);
            this.groupBox7.Controls.Add(this.buttonLowlevelSend);
            this.groupBox7.Controls.Add(this.buttonLowlevelBrowse);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox7.Location = new System.Drawing.Point(566, 33);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(553, 57);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sending lowlevel applet:";
            // 
            // buttonLowlevelInit
            // 
            this.buttonLowlevelInit.Location = new System.Drawing.Point(402, 23);
            this.buttonLowlevelInit.Name = "buttonLowlevelInit";
            this.buttonLowlevelInit.Size = new System.Drawing.Size(135, 28);
            this.buttonLowlevelInit.TabIndex = 6;
            this.buttonLowlevelInit.Text = "Run applet";
            this.buttonLowlevelInit.UseVisualStyleBackColor = true;
            this.buttonLowlevelInit.Click += new System.EventHandler(this.buttonLowlevelInit_Click);
            // 
            // buttonLowlevelSend
            // 
            this.buttonLowlevelSend.Location = new System.Drawing.Point(204, 23);
            this.buttonLowlevelSend.Name = "buttonLowlevelSend";
            this.buttonLowlevelSend.Size = new System.Drawing.Size(135, 28);
            this.buttonLowlevelSend.TabIndex = 5;
            this.buttonLowlevelSend.Text = "Send applet file";
            this.buttonLowlevelSend.UseVisualStyleBackColor = true;
            this.buttonLowlevelSend.Click += new System.EventHandler(this.buttonLowlevelSend_Click);
            // 
            // buttonLowlevelBrowse
            // 
            this.buttonLowlevelBrowse.Location = new System.Drawing.Point(6, 23);
            this.buttonLowlevelBrowse.Name = "buttonLowlevelBrowse";
            this.buttonLowlevelBrowse.Size = new System.Drawing.Size(135, 28);
            this.buttonLowlevelBrowse.TabIndex = 4;
            this.buttonLowlevelBrowse.Text = "Browse...";
            this.buttonLowlevelBrowse.UseVisualStyleBackColor = true;
            this.buttonLowlevelBrowse.Click += new System.EventHandler(this.buttonLowlevelBrowse_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonGPNVMSet);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox6.Location = new System.Drawing.Point(565, 163);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(553, 57);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Setting GPNVM bits";
            // 
            // buttonGPNVMSet
            // 
            this.buttonGPNVMSet.Location = new System.Drawing.Point(6, 23);
            this.buttonGPNVMSet.Name = "buttonGPNVMSet";
            this.buttonGPNVMSet.Size = new System.Drawing.Size(135, 28);
            this.buttonGPNVMSet.TabIndex = 4;
            this.buttonGPNVMSet.Text = "Set!";
            this.buttonGPNVMSet.UseVisualStyleBackColor = true;
            this.buttonGPNVMSet.Click += new System.EventHandler(this.buttonGPNVMSet_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonSendImage);
            this.groupBox5.Controls.Add(this.buttonBrowseImage);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox5.Location = new System.Drawing.Point(565, 100);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(553, 57);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sending image to flash:";
            // 
            // buttonSendImage
            // 
            this.buttonSendImage.Location = new System.Drawing.Point(204, 23);
            this.buttonSendImage.Name = "buttonSendImage";
            this.buttonSendImage.Size = new System.Drawing.Size(135, 28);
            this.buttonSendImage.TabIndex = 5;
            this.buttonSendImage.Text = "Send image";
            this.buttonSendImage.UseVisualStyleBackColor = true;
            this.buttonSendImage.Click += new System.EventHandler(this.buttonSendImage_Click);
            // 
            // buttonBrowseImage
            // 
            this.buttonBrowseImage.Location = new System.Drawing.Point(6, 23);
            this.buttonBrowseImage.Name = "buttonBrowseImage";
            this.buttonBrowseImage.Size = new System.Drawing.Size(135, 28);
            this.buttonBrowseImage.TabIndex = 4;
            this.buttonBrowseImage.Text = "Browse...";
            this.buttonBrowseImage.UseVisualStyleBackColor = true;
            this.buttonBrowseImage.Click += new System.EventHandler(this.buttonBrowseImage_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonInitApplet);
            this.groupBox4.Controls.Add(this.buttonSendAppletData);
            this.groupBox4.Controls.Add(this.buttonBrowse);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox4.Location = new System.Drawing.Point(6, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(553, 57);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sending flash applet:";
            // 
            // buttonInitApplet
            // 
            this.buttonInitApplet.Location = new System.Drawing.Point(402, 23);
            this.buttonInitApplet.Name = "buttonInitApplet";
            this.buttonInitApplet.Size = new System.Drawing.Size(135, 28);
            this.buttonInitApplet.TabIndex = 6;
            this.buttonInitApplet.Text = "Init applet";
            this.buttonInitApplet.UseVisualStyleBackColor = true;
            this.buttonInitApplet.Click += new System.EventHandler(this.buttonInitApplet_Click);
            // 
            // buttonSendAppletData
            // 
            this.buttonSendAppletData.Location = new System.Drawing.Point(204, 23);
            this.buttonSendAppletData.Name = "buttonSendAppletData";
            this.buttonSendAppletData.Size = new System.Drawing.Size(135, 28);
            this.buttonSendAppletData.TabIndex = 5;
            this.buttonSendAppletData.Text = "Send applet file";
            this.buttonSendAppletData.UseVisualStyleBackColor = true;
            this.buttonSendAppletData.Click += new System.EventHandler(this.buttonSendAppletData_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(6, 23);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(135, 28);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonReadChipID);
            this.groupBox2.Controls.Add(this.buttonChangeToBinary);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.Location = new System.Drawing.Point(6, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 57);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Initialization:";
            // 
            // buttonReadChipID
            // 
            this.buttonReadChipID.Location = new System.Drawing.Point(204, 23);
            this.buttonReadChipID.Name = "buttonReadChipID";
            this.buttonReadChipID.Size = new System.Drawing.Size(135, 28);
            this.buttonReadChipID.TabIndex = 4;
            this.buttonReadChipID.Text = "Read chip ID";
            this.buttonReadChipID.UseVisualStyleBackColor = true;
            this.buttonReadChipID.Click += new System.EventHandler(this.buttonReadChipID_Click);
            // 
            // buttonChangeToBinary
            // 
            this.buttonChangeToBinary.Location = new System.Drawing.Point(6, 23);
            this.buttonChangeToBinary.Name = "buttonChangeToBinary";
            this.buttonChangeToBinary.Size = new System.Drawing.Size(135, 28);
            this.buttonChangeToBinary.TabIndex = 3;
            this.buttonChangeToBinary.Text = "Change to binary";
            this.buttonChangeToBinary.UseVisualStyleBackColor = true;
            this.buttonChangeToBinary.Click += new System.EventHandler(this.buttonChangeToBinary_Click);
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Bin files (*.bin)|*.bin|All files (*.*)|*.*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chip ID address: 0x";
            // 
            // textBoxChipIDAddress
            // 
            this.textBoxChipIDAddress.Location = new System.Drawing.Point(153, 28);
            this.textBoxChipIDAddress.Name = "textBoxChipIDAddress";
            this.textBoxChipIDAddress.Size = new System.Drawing.Size(122, 24);
            this.textBoxChipIDAddress.TabIndex = 7;
            this.textBoxChipIDAddress.Text = "400E0740";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Expected Chip ID:";
            // 
            // textBoxExpectedChipID
            // 
            this.textBoxExpectedChipID.Location = new System.Drawing.Point(153, 59);
            this.textBoxExpectedChipID.Name = "textBoxExpectedChipID";
            this.textBoxExpectedChipID.Size = new System.Drawing.Size(122, 24);
            this.textBoxExpectedChipID.TabIndex = 9;
            this.textBoxExpectedChipID.Text = "289b09e0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(562, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Applet address:";
            // 
            // textBoxAppletAddress
            // 
            this.textBoxAppletAddress.Location = new System.Drawing.Point(691, 28);
            this.textBoxAppletAddress.Name = "textBoxAppletAddress";
            this.textBoxAppletAddress.Size = new System.Drawing.Size(122, 24);
            this.textBoxAppletAddress.TabIndex = 11;
            this.textBoxAppletAddress.Text = "20000800";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(562, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mailbox address:";
            // 
            // textBoxMailboxAddress
            // 
            this.textBoxMailboxAddress.Location = new System.Drawing.Point(691, 59);
            this.textBoxMailboxAddress.Name = "textBoxMailboxAddress";
            this.textBoxMailboxAddress.Size = new System.Drawing.Size(122, 24);
            this.textBoxMailboxAddress.TabIndex = 13;
            this.textBoxMailboxAddress.Text = "20000840";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(562, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "ARGV0 address:";
            // 
            // textBoxARGV0Address
            // 
            this.textBoxARGV0Address.Location = new System.Drawing.Point(691, 115);
            this.textBoxARGV0Address.Name = "textBoxARGV0Address";
            this.textBoxARGV0Address.Size = new System.Drawing.Size(122, 24);
            this.textBoxARGV0Address.TabIndex = 15;
            this.textBoxARGV0Address.Text = "20000848";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(562, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "ARGV1 address:";
            // 
            // textBoxARGV1Address
            // 
            this.textBoxARGV1Address.Location = new System.Drawing.Point(691, 145);
            this.textBoxARGV1Address.Name = "textBoxARGV1Address";
            this.textBoxARGV1Address.Size = new System.Drawing.Size(122, 24);
            this.textBoxARGV1Address.TabIndex = 17;
            this.textBoxARGV1Address.Text = "2000084C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(563, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Status address:";
            // 
            // textBoxStatusAddress
            // 
            this.textBoxStatusAddress.Location = new System.Drawing.Point(692, 86);
            this.textBoxStatusAddress.Name = "textBoxStatusAddress";
            this.textBoxStatusAddress.Size = new System.Drawing.Size(122, 24);
            this.textBoxStatusAddress.TabIndex = 19;
            this.textBoxStatusAddress.Text = "20000844";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(562, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "ARGV2 address:";
            // 
            // textBoxARGV2Address
            // 
            this.textBoxARGV2Address.Location = new System.Drawing.Point(691, 175);
            this.textBoxARGV2Address.Name = "textBoxARGV2Address";
            this.textBoxARGV2Address.Size = new System.Drawing.Size(122, 24);
            this.textBoxARGV2Address.TabIndex = 21;
            this.textBoxARGV2Address.Text = "20000850";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(831, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Buffer size:";
            // 
            // textBoxBufferSize
            // 
            this.textBoxBufferSize.Location = new System.Drawing.Point(960, 28);
            this.textBoxBufferSize.Name = "textBoxBufferSize";
            this.textBoxBufferSize.ReadOnly = true;
            this.textBoxBufferSize.Size = new System.Drawing.Size(122, 24);
            this.textBoxBufferSize.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(831, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Buffer address:";
            // 
            // textBoxBufferAddress
            // 
            this.textBoxBufferAddress.Location = new System.Drawing.Point(960, 59);
            this.textBoxBufferAddress.Name = "textBoxBufferAddress";
            this.textBoxBufferAddress.ReadOnly = true;
            this.textBoxBufferAddress.Size = new System.Drawing.Size(122, 24);
            this.textBoxBufferAddress.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(9, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Communication type:";
            // 
            // textBoxCommunicationType
            // 
            this.textBoxCommunicationType.Location = new System.Drawing.Point(153, 89);
            this.textBoxCommunicationType.Name = "textBoxCommunicationType";
            this.textBoxCommunicationType.Size = new System.Drawing.Size(122, 24);
            this.textBoxCommunicationType.TabIndex = 27;
            this.textBoxCommunicationType.Text = "00000001";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(831, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "# bytes wrote:";
            // 
            // textBoxNumberOfBytesWrote
            // 
            this.textBoxNumberOfBytesWrote.Location = new System.Drawing.Point(960, 86);
            this.textBoxNumberOfBytesWrote.Name = "textBoxNumberOfBytesWrote";
            this.textBoxNumberOfBytesWrote.ReadOnly = true;
            this.textBoxNumberOfBytesWrote.Size = new System.Drawing.Size(122, 24);
            this.textBoxNumberOfBytesWrote.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label17.Location = new System.Drawing.Point(281, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(157, 16);
            this.label17.TabIndex = 40;
            this.label17.Text = "Lowlevel app ARGV0 val";
            // 
            // textBoxLowlevelArgv0Val
            // 
            this.textBoxLowlevelArgv0Val.Location = new System.Drawing.Point(437, 28);
            this.textBoxLowlevelArgv0Val.Name = "textBoxLowlevelArgv0Val";
            this.textBoxLowlevelArgv0Val.Size = new System.Drawing.Size(122, 24);
            this.textBoxLowlevelArgv0Val.TabIndex = 41;
            this.textBoxLowlevelArgv0Val.Text = "00000001";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label18.Location = new System.Drawing.Point(281, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(157, 16);
            this.label18.TabIndex = 42;
            this.label18.Text = "Lowlevel app ARGV1 val";
            // 
            // textBoxLowlevelArgv1Val
            // 
            this.textBoxLowlevelArgv1Val.Location = new System.Drawing.Point(437, 59);
            this.textBoxLowlevelArgv1Val.Name = "textBoxLowlevelArgv1Val";
            this.textBoxLowlevelArgv1Val.Size = new System.Drawing.Size(122, 24);
            this.textBoxLowlevelArgv1Val.TabIndex = 43;
            this.textBoxLowlevelArgv1Val.Text = "00000001";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label19.Location = new System.Drawing.Point(281, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(157, 16);
            this.label19.TabIndex = 44;
            this.label19.Text = "Lowlevel app ARGV2 val";
            // 
            // textBoxLowlevelArgv2Val
            // 
            this.textBoxLowlevelArgv2Val.Location = new System.Drawing.Point(437, 92);
            this.textBoxLowlevelArgv2Val.Name = "textBoxLowlevelArgv2Val";
            this.textBoxLowlevelArgv2Val.Size = new System.Drawing.Size(122, 24);
            this.textBoxLowlevelArgv2Val.TabIndex = 45;
            this.textBoxLowlevelArgv2Val.Text = "00000000";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label20.Location = new System.Drawing.Point(281, 126);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(157, 16);
            this.label20.TabIndex = 46;
            this.label20.Text = "Lowlevel app ARGV3 val";
            // 
            // textBoxLowlevelArgv3Val
            // 
            this.textBoxLowlevelArgv3Val.Location = new System.Drawing.Point(437, 121);
            this.textBoxLowlevelArgv3Val.Name = "textBoxLowlevelArgv3Val";
            this.textBoxLowlevelArgv3Val.Size = new System.Drawing.Size(122, 24);
            this.textBoxLowlevelArgv3Val.TabIndex = 47;
            this.textBoxLowlevelArgv3Val.Text = "00000000";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label21.Location = new System.Drawing.Point(281, 153);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(157, 16);
            this.label21.TabIndex = 48;
            this.label21.Text = "Lowlevel app ARGV4 val";
            // 
            // textBoxLowlevelArgv4Val
            // 
            this.textBoxLowlevelArgv4Val.Location = new System.Drawing.Point(437, 148);
            this.textBoxLowlevelArgv4Val.Name = "textBoxLowlevelArgv4Val";
            this.textBoxLowlevelArgv4Val.Size = new System.Drawing.Size(122, 24);
            this.textBoxLowlevelArgv4Val.TabIndex = 49;
            this.textBoxLowlevelArgv4Val.Text = "00000000";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label23.Location = new System.Drawing.Point(563, 208);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(109, 16);
            this.label23.TabIndex = 50;
            this.label23.Text = "ARGV3 address:";
            // 
            // textBoxARGV3Address
            // 
            this.textBoxARGV3Address.Location = new System.Drawing.Point(692, 203);
            this.textBoxARGV3Address.Name = "textBoxARGV3Address";
            this.textBoxARGV3Address.Size = new System.Drawing.Size(122, 24);
            this.textBoxARGV3Address.TabIndex = 51;
            this.textBoxARGV3Address.Text = "20000854";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label22.Location = new System.Drawing.Point(563, 238);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(109, 16);
            this.label22.TabIndex = 52;
            this.label22.Text = "ARGV4 address:";
            // 
            // textBoxARGV4Address
            // 
            this.textBoxARGV4Address.Location = new System.Drawing.Point(692, 233);
            this.textBoxARGV4Address.Name = "textBoxARGV4Address";
            this.textBoxARGV4Address.Size = new System.Drawing.Size(122, 24);
            this.textBoxARGV4Address.TabIndex = 53;
            this.textBoxARGV4Address.Text = "20000858";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxARGV4Address);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.textBoxARGV3Address);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.textBoxLowlevelArgv4Val);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.textBoxLowlevelArgv3Val);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.textBoxLowlevelArgv2Val);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.textBoxLowlevelArgv1Val);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.textBoxLowlevelArgv0Val);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.textBoxNumberOfBytesWrote);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBoxCommunicationType);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBoxBufferAddress);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxBufferSize);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBoxARGV2Address);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxStatusAddress);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxARGV1Address);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxARGV0Address);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxMailboxAddress);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxAppletAddress);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxExpectedChipID);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxChipIDAddress);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox3.Location = new System.Drawing.Point(12, 407);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1132, 336);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Constants and parameters:";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 755);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCommands);
            this.Controls.Add(this.groupBoxCommunication);
            this.Name = "main";
            this.Text = "FW Upgrader";
            this.groupBoxCommunication.ResumeLayout(false);
            this.groupBoxCommunication.PerformLayout();
            this.groupBoxCommands.ResumeLayout(false);
            this.groupBoxCommands.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCommunication;
        private System.Windows.Forms.Button buttonClosePort;
        private System.Windows.Forms.Button buttonOpenPort;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.GroupBox groupBoxCommands;
        private System.Windows.Forms.Label labelReceivedData;
        private System.Windows.Forms.TextBox textBoxReceivedData;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonChangeToBinary;
        private System.Windows.Forms.Button buttonReadChipID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSendAppletData;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonInitApplet;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonSendImage;
        private System.Windows.Forms.Button buttonBrowseImage;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonGPNVMSet;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonLowlevelInit;
        private System.Windows.Forms.Button buttonLowlevelSend;
        private System.Windows.Forms.Button buttonLowlevelBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxChipIDAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxExpectedChipID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAppletAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMailboxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxARGV0Address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxARGV1Address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxStatusAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxARGV2Address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxBufferSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxBufferAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxCommunicationType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxNumberOfBytesWrote;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxLowlevelArgv0Val;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxLowlevelArgv1Val;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxLowlevelArgv2Val;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxLowlevelArgv3Val;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxLowlevelArgv4Val;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxARGV3Address;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxARGV4Address;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Label labelStatus;
    }
}

