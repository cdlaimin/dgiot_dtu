﻿using System.Windows.Forms;

namespace Dgiot_dtu
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.checkBoxReconnect = new System.Windows.Forms.CheckBox();
            this.checkBoxDisplayHex = new System.Windows.Forms.CheckBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxSerialPort = new System.Windows.Forms.GroupBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.labelSerialPort = new System.Windows.Forms.Label();
            this.comboBoxSerialPort = new System.Windows.Forms.ComboBox();
            this.textBoxBridgePort = new System.Windows.Forms.TextBox();
            this.textBoxMqttPubTopic = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxMqttSubTopic = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxMqttPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMqttUserName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.textToPayload = new System.Windows.Forms.TextBox();
            this.textBoxTcpClientLogin = new System.Windows.Forms.TextBox();
            this.textBoxMqttClientId = new System.Windows.Forms.TextBox();
            this.textBoxDgiotPort = new System.Windows.Forms.TextBox();
            this.textBoxUDPClientLogin = new System.Windows.Forms.TextBox();
            this.sendBridge = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBoxBridge = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.comboBoxCmdProdxy = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBoxDtuAddr = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxDgiotSever = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxOPCDACount = new System.Windows.Forms.TextBox();
            this.labelOPCDACount = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelOPCDAMonitor = new System.Windows.Forms.Label();
            this.textBoxOPCDAInterval = new System.Windows.Forms.TextBox();
            this.checkBoxOPCDA = new System.Windows.Forms.CheckBox();
            this.textBoxOPCDAHost = new System.Windows.Forms.TextBox();
            this.labelOPCDAHost = new System.Windows.Forms.Label();
            this.textBoxOpcIp = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxOPCUATopic = new System.Windows.Forms.TextBox();
            this.labelopcua = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxBACnetTopic = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxControlTopic = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxBridge = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBoxAccessTopic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.radioButtonMqttClient = new System.Windows.Forms.RadioButton();
            this.radioButtonTcpClient = new System.Windows.Forms.RadioButton();
            this.radioButtonUDPClient = new System.Windows.Forms.RadioButton();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.textBoxPLCTopic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxLogLevel = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.comboBoxLan = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.label_devcietree = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxCommonConfig = new System.Windows.Forms.GroupBox();
            this.buttonScan = new System.Windows.Forms.Button();
            this.groupBoxSerialPort.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxCommonConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(226, 188);
            this.buttonStartStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(80, 32);
            this.buttonStartStop.TabIndex = 4;
            this.buttonStartStop.Text = "Start";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.ButtonStartStopClick);
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(170)))), ((int)(((byte)(55)))));
            this.textBoxLog.Location = new System.Drawing.Point(4, 350);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(432, 378);
            this.textBoxLog.TabIndex = 9;
            this.textBoxLog.TextChanged += new System.EventHandler(this.textBoxLog_TextChanged);
            // 
            // checkBoxReconnect
            // 
            this.checkBoxReconnect.AutoSize = true;
            this.checkBoxReconnect.Location = new System.Drawing.Point(15, 194);
            this.checkBoxReconnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxReconnect.Name = "checkBoxReconnect";
            this.checkBoxReconnect.Size = new System.Drawing.Size(160, 22);
            this.checkBoxReconnect.TabIndex = 5;
            this.checkBoxReconnect.Text = "Auto Reconnect";
            this.checkBoxReconnect.UseVisualStyleBackColor = true;
            this.checkBoxReconnect.CheckedChanged += new System.EventHandler(this.CheckBoxReconnectCheckedChanged);
            // 
            // checkBoxDisplayHex
            // 
            this.checkBoxDisplayHex.AutoSize = true;
            this.checkBoxDisplayHex.Location = new System.Drawing.Point(459, 740);
            this.checkBoxDisplayHex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxDisplayHex.Name = "checkBoxDisplayHex";
            this.checkBoxDisplayHex.Size = new System.Drawing.Size(61, 22);
            this.checkBoxDisplayHex.TabIndex = 11;
            this.checkBoxDisplayHex.Text = "Hex";
            this.checkBoxDisplayHex.UseVisualStyleBackColor = true;
            this.checkBoxDisplayHex.CheckedChanged += new System.EventHandler(this.CheckBoxDisplayHexCheckedChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(606, 735);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(72, 32);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
            // 
            // groupBoxSerialPort
            // 
            this.groupBoxSerialPort.Controls.Add(this.comboBoxParity);
            this.groupBoxSerialPort.Controls.Add(this.label13);
            this.groupBoxSerialPort.Controls.Add(this.label5);
            this.groupBoxSerialPort.Controls.Add(this.label4);
            this.groupBoxSerialPort.Controls.Add(this.label1);
            this.groupBoxSerialPort.Controls.Add(this.comboBoxStopBits);
            this.groupBoxSerialPort.Controls.Add(this.comboBoxDataBits);
            this.groupBoxSerialPort.Controls.Add(this.comboBoxBaudRate);
            this.groupBoxSerialPort.Controls.Add(this.labelSerialPort);
            this.groupBoxSerialPort.Controls.Add(this.comboBoxSerialPort);
            this.groupBoxSerialPort.Location = new System.Drawing.Point(440, 26);
            this.groupBoxSerialPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSerialPort.Name = "groupBoxSerialPort";
            this.groupBoxSerialPort.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSerialPort.Size = new System.Drawing.Size(320, 166);
            this.groupBoxSerialPort.TabIndex = 13;
            this.groupBoxSerialPort.TabStop = false;
            this.groupBoxSerialPort.Text = "Serial Port Capture";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "NONE",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBoxParity.Location = new System.Drawing.Point(94, 88);
            this.comboBoxParity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(208, 26);
            this.comboBoxParity.TabIndex = 14;
            this.comboBoxParity.SelectedIndexChanged += new System.EventHandler(this.ComboBoxParity_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 88);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 18);
            this.label13.TabIndex = 13;
            this.label13.Text = "Parity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "stopBits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "dataBits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Baud Rate";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "1.5"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(96, 124);
            this.comboBoxStopBits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(60, 26);
            this.comboBoxStopBits.TabIndex = 11;
            this.comboBoxStopBits.SelectedIndexChanged += new System.EventHandler(this.ComboBoxStopBits_SelectedIndexChanged);
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(246, 124);
            this.comboBoxDataBits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(56, 26);
            this.comboBoxDataBits.TabIndex = 11;
            this.comboBoxDataBits.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDataBits_SelectedIndexChanged);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(93, 56);
            this.comboBoxBaudRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(210, 26);
            this.comboBoxBaudRate.TabIndex = 11;
            this.comboBoxBaudRate.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBaudRate_SelectedIndexChanged);
            // 
            // labelSerialPort
            // 
            this.labelSerialPort.AutoSize = true;
            this.labelSerialPort.Location = new System.Drawing.Point(9, 26);
            this.labelSerialPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSerialPort.Name = "labelSerialPort";
            this.labelSerialPort.Size = new System.Drawing.Size(44, 18);
            this.labelSerialPort.TabIndex = 10;
            this.labelSerialPort.Text = "Port";
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.FormattingEnabled = true;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(93, 22);
            this.comboBoxSerialPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Size = new System.Drawing.Size(210, 26);
            this.comboBoxSerialPort.TabIndex = 9;
            this.comboBoxSerialPort.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSerialPort_SelectedIndexChanged);
            // 
            // textBoxBridgePort
            // 
            this.textBoxBridgePort.Location = new System.Drawing.Point(201, 146);
            this.textBoxBridgePort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBridgePort.Name = "textBoxBridgePort";
            this.textBoxBridgePort.Size = new System.Drawing.Size(110, 28);
            this.textBoxBridgePort.TabIndex = 7;
            this.textBoxBridgePort.Text = "5080";
            this.textBoxBridgePort.TextChanged += new System.EventHandler(this.TextBoxBridgePort_TextChanged);
            // 
            // textBoxMqttPubTopic
            // 
            this.textBoxMqttPubTopic.Location = new System.Drawing.Point(120, 178);
            this.textBoxMqttPubTopic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMqttPubTopic.Name = "textBoxMqttPubTopic";
            this.textBoxMqttPubTopic.Size = new System.Drawing.Size(196, 28);
            this.textBoxMqttPubTopic.TabIndex = 22;
            this.textBoxMqttPubTopic.Text = "$dg/thing/{productId}/{deviceAddr}/properties/report";
            this.textBoxMqttPubTopic.TextChanged += new System.EventHandler(this.TextBoxMqttPubTopic_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 178);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 18);
            this.label12.TabIndex = 21;
            this.label12.Text = "PubTopic";
            // 
            // textBoxMqttSubTopic
            // 
            this.textBoxMqttSubTopic.Location = new System.Drawing.Point(122, 142);
            this.textBoxMqttSubTopic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMqttSubTopic.Name = "textBoxMqttSubTopic";
            this.textBoxMqttSubTopic.Size = new System.Drawing.Size(196, 28);
            this.textBoxMqttSubTopic.TabIndex = 20;
            this.textBoxMqttSubTopic.Text = "$dg/device/{productId}/{deviceAddr}/properties";
            this.textBoxMqttSubTopic.TextChanged += new System.EventHandler(this.TextBoxMqttSubTopic_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 144);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "SubTopic";
            // 
            // textBoxMqttPassword
            // 
            this.textBoxMqttPassword.Location = new System.Drawing.Point(122, 66);
            this.textBoxMqttPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMqttPassword.Name = "textBoxMqttPassword";
            this.textBoxMqttPassword.Size = new System.Drawing.Size(194, 28);
            this.textBoxMqttPassword.TabIndex = 18;
            this.textBoxMqttPassword.Text = "SzQ3MDU4ODMxNjQwNjYyNjkwOTg4";
            this.textBoxMqttPassword.TextChanged += new System.EventHandler(this.TextBoxMqttPassword_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "PassWord";
            // 
            // textBoxMqttUserName
            // 
            this.textBoxMqttUserName.Location = new System.Drawing.Point(122, 30);
            this.textBoxMqttUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMqttUserName.Name = "textBoxMqttUserName";
            this.textBoxMqttUserName.Size = new System.Drawing.Size(194, 28);
            this.textBoxMqttUserName.TabIndex = 16;
            this.textBoxMqttUserName.Text = "fa82a59201";
            this.textBoxMqttUserName.TextChanged += new System.EventHandler(this.TextBoxMqttUserName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "UserName";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel2.Location = new System.Drawing.Point(772, 674);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(62, 18);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "DG-IoT";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // textToPayload
            // 
            this.textToPayload.Location = new System.Drawing.Point(190, 736);
            this.textToPayload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textToPayload.Name = "textToPayload";
            this.textToPayload.Size = new System.Drawing.Size(252, 28);
            this.textToPayload.TabIndex = 14;
            this.textToPayload.Text = "12345678";
            this.textToPayload.TextChanged += new System.EventHandler(this.TextToPayload_TextChanged);
            // 
            // textBoxTcpClientLogin
            // 
            this.textBoxTcpClientLogin.Location = new System.Drawing.Point(118, 32);
            this.textBoxTcpClientLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTcpClientLogin.Name = "textBoxTcpClientLogin";
            this.textBoxTcpClientLogin.Size = new System.Drawing.Size(194, 28);
            this.textBoxTcpClientLogin.TabIndex = 12;
            this.textBoxTcpClientLogin.Text = "login";
            this.textBoxTcpClientLogin.TextChanged += new System.EventHandler(this.TextBoxTcpClientLogin_TextChanged);
            // 
            // textBoxMqttClientId
            // 
            this.textBoxMqttClientId.Location = new System.Drawing.Point(122, 106);
            this.textBoxMqttClientId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMqttClientId.Name = "textBoxMqttClientId";
            this.textBoxMqttClientId.Size = new System.Drawing.Size(194, 28);
            this.textBoxMqttClientId.TabIndex = 12;
            this.textBoxMqttClientId.Text = "devaddr";
            this.textBoxMqttClientId.TextChanged += new System.EventHandler(this.TextBoxMqttClientId_TextChanged);
            // 
            // textBoxDgiotPort
            // 
            this.textBoxDgiotPort.Location = new System.Drawing.Point(116, 69);
            this.textBoxDgiotPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDgiotPort.Name = "textBoxDgiotPort";
            this.textBoxDgiotPort.Size = new System.Drawing.Size(198, 28);
            this.textBoxDgiotPort.TabIndex = 7;
            this.textBoxDgiotPort.Text = "1883";
            this.textBoxDgiotPort.TextChanged += new System.EventHandler(this.TextBoxDgiotPort_TextChanged);
            // 
            // textBoxUDPClientLogin
            // 
            this.textBoxUDPClientLogin.Location = new System.Drawing.Point(111, 32);
            this.textBoxUDPClientLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUDPClientLogin.Name = "textBoxUDPClientLogin";
            this.textBoxUDPClientLogin.Size = new System.Drawing.Size(202, 28);
            this.textBoxUDPClientLogin.TabIndex = 12;
            this.textBoxUDPClientLogin.Text = "login";
            this.textBoxUDPClientLogin.TextChanged += new System.EventHandler(this.TextBoxUDPClientLogin_TextChanged);
            // 
            // sendBridge
            // 
            this.sendBridge.Location = new System.Drawing.Point(525, 736);
            this.sendBridge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendBridge.Name = "sendBridge";
            this.sendBridge.Size = new System.Drawing.Size(70, 32);
            this.sendBridge.TabIndex = 17;
            this.sendBridge.Text = "Send";
            this.sendBridge.UseVisualStyleBackColor = true;
            this.sendBridge.Click += new System.EventHandler(this.SendBridge_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBoxTcpClientLogin);
            this.groupBox2.Location = new System.Drawing.Point(856, 309);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(320, 80);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TCP Client Channel";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 32);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 18);
            this.label16.TabIndex = 13;
            this.label16.Text = "login";
            // 
            // checkBoxBridge
            // 
            this.checkBoxBridge.AutoSize = true;
            this.checkBoxBridge.Location = new System.Drawing.Point(15, 148);
            this.checkBoxBridge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxBridge.Name = "checkBoxBridge";
            this.checkBoxBridge.Size = new System.Drawing.Size(133, 22);
            this.checkBoxBridge.TabIndex = 23;
            this.checkBoxBridge.Text = "Bridge Port";
            this.checkBoxBridge.UseVisualStyleBackColor = true;
            this.checkBoxBridge.CheckedChanged += new System.EventHandler(this.CheckBoxBridge_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.comboBoxCmdProdxy);
            this.groupBox3.Controls.Add(this.textBoxMqttPubTopic);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.textBoxMqttClientId);
            this.groupBox3.Controls.Add(this.textBoxMqttSubTopic);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBoxMqttUserName);
            this.groupBox3.Controls.Add(this.textBoxMqttPassword);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(856, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(326, 258);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mqtt Client Channel";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(12, 213);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(89, 18);
            this.label29.TabIndex = 37;
            this.label29.Text = "cmd proxy";
            // 
            // comboBoxCmdProdxy
            // 
            this.comboBoxCmdProdxy.FormattingEnabled = true;
            this.comboBoxCmdProdxy.Items.AddRange(new object[] {
            "ffmpeg"});
            this.comboBoxCmdProdxy.Location = new System.Drawing.Point(122, 219);
            this.comboBoxCmdProdxy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCmdProdxy.Name = "comboBoxCmdProdxy";
            this.comboBoxCmdProdxy.Size = new System.Drawing.Size(194, 26);
            this.comboBoxCmdProdxy.TabIndex = 36;
            this.comboBoxCmdProdxy.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCmdProdxy_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 108);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 18);
            this.label20.TabIndex = 13;
            this.label20.Text = "Clientid";
            // 
            // comboBoxDtuAddr
            // 
            this.comboBoxDtuAddr.FormattingEnabled = true;
            this.comboBoxDtuAddr.Location = new System.Drawing.Point(116, 106);
            this.comboBoxDtuAddr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDtuAddr.Name = "comboBoxDtuAddr";
            this.comboBoxDtuAddr.Size = new System.Drawing.Size(196, 26);
            this.comboBoxDtuAddr.TabIndex = 15;
            this.comboBoxDtuAddr.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDtuAddr_SelectedIndexChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(14, 104);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(71, 18);
            this.label30.TabIndex = 39;
            this.label30.Text = "DtuAddr";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 72);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 18);
            this.label21.TabIndex = 8;
            this.label21.Text = "Port";
            // 
            // textBoxDgiotSever
            // 
            this.textBoxDgiotSever.Location = new System.Drawing.Point(116, 28);
            this.textBoxDgiotSever.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDgiotSever.Name = "textBoxDgiotSever";
            this.textBoxDgiotSever.Size = new System.Drawing.Size(198, 28);
            this.textBoxDgiotSever.TabIndex = 5;
            this.textBoxDgiotSever.Text = "pump.dgiotcloud.com";
            this.textBoxDgiotSever.TextChanged += new System.EventHandler(this.TextBoxDgiotSever_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 34);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 18);
            this.label22.TabIndex = 6;
            this.label22.Text = "Server";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxOPCDACount);
            this.groupBox4.Controls.Add(this.labelOPCDACount);
            this.groupBox4.Controls.Add(this.labelSecond);
            this.groupBox4.Controls.Add(this.labelOPCDAMonitor);
            this.groupBox4.Controls.Add(this.textBoxOPCDAInterval);
            this.groupBox4.Controls.Add(this.checkBoxOPCDA);
            this.groupBox4.Controls.Add(this.textBoxOPCDAHost);
            this.groupBox4.Controls.Add(this.labelOPCDAHost);
            this.groupBox4.Location = new System.Drawing.Point(441, 274);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(316, 112);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OPC_DA Capture";
            // 
            // textBoxOPCDACount
            // 
            this.textBoxOPCDACount.Location = new System.Drawing.Point(258, 70);
            this.textBoxOPCDACount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOPCDACount.Name = "textBoxOPCDACount";
            this.textBoxOPCDACount.Size = new System.Drawing.Size(38, 28);
            this.textBoxOPCDACount.TabIndex = 52;
            this.textBoxOPCDACount.Text = "30";
            this.textBoxOPCDACount.TextChanged += new System.EventHandler(this.TextBoxOPCDACount_TextChanged);
            // 
            // labelOPCDACount
            // 
            this.labelOPCDACount.AutoSize = true;
            this.labelOPCDACount.Location = new System.Drawing.Point(200, 75);
            this.labelOPCDACount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOPCDACount.Name = "labelOPCDACount";
            this.labelOPCDACount.Size = new System.Drawing.Size(53, 18);
            this.labelOPCDACount.TabIndex = 51;
            this.labelOPCDACount.Text = "Count";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Location = new System.Drawing.Point(148, 75);
            this.labelSecond.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(26, 18);
            this.labelSecond.TabIndex = 50;
            this.labelSecond.Text = "ms";
            this.labelSecond.Click += new System.EventHandler(this.labelSecond_Click);
            // 
            // labelOPCDAMonitor
            // 
            this.labelOPCDAMonitor.AutoSize = true;
            this.labelOPCDAMonitor.Location = new System.Drawing.Point(2, 74);
            this.labelOPCDAMonitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOPCDAMonitor.Name = "labelOPCDAMonitor";
            this.labelOPCDAMonitor.Size = new System.Drawing.Size(80, 18);
            this.labelOPCDAMonitor.TabIndex = 49;
            this.labelOPCDAMonitor.Text = "Interval";
            // 
            // textBoxOPCDAInterval
            // 
            this.textBoxOPCDAInterval.Location = new System.Drawing.Point(90, 69);
            this.textBoxOPCDAInterval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOPCDAInterval.Name = "textBoxOPCDAInterval";
            this.textBoxOPCDAInterval.Size = new System.Drawing.Size(42, 28);
            this.textBoxOPCDAInterval.TabIndex = 48;
            this.textBoxOPCDAInterval.Text = "3";
            this.textBoxOPCDAInterval.TextChanged += new System.EventHandler(this.TextBoxOPCDAInterval_TextChanged);
            // 
            // checkBoxOPCDA
            // 
            this.checkBoxOPCDA.AutoSize = true;
            this.checkBoxOPCDA.Location = new System.Drawing.Point(206, 33);
            this.checkBoxOPCDA.Name = "checkBoxOPCDA";
            this.checkBoxOPCDA.Size = new System.Drawing.Size(97, 22);
            this.checkBoxOPCDA.TabIndex = 47;
            this.checkBoxOPCDA.Text = "Monitor";
            this.checkBoxOPCDA.UseVisualStyleBackColor = true;
            this.checkBoxOPCDA.CheckedChanged += new System.EventHandler(this.CheckBoxOPCDA_CheckedChanged);
            // 
            // textBoxOPCDAHost
            // 
            this.textBoxOPCDAHost.Location = new System.Drawing.Point(54, 28);
            this.textBoxOPCDAHost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOPCDAHost.Name = "textBoxOPCDAHost";
            this.textBoxOPCDAHost.Size = new System.Drawing.Size(148, 28);
            this.textBoxOPCDAHost.TabIndex = 46;
            this.textBoxOPCDAHost.Text = "127.0.0.1";
            this.textBoxOPCDAHost.TextChanged += new System.EventHandler(this.TextBoxOPCDAHost_TextChanged);
            // 
            // labelOPCDAHost
            // 
            this.labelOPCDAHost.AutoSize = true;
            this.labelOPCDAHost.Location = new System.Drawing.Point(9, 33);
            this.labelOPCDAHost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOPCDAHost.Name = "labelOPCDAHost";
            this.labelOPCDAHost.Size = new System.Drawing.Size(44, 18);
            this.labelOPCDAHost.TabIndex = 7;
            this.labelOPCDAHost.Text = "Host";
            // 
            // textBoxOpcIp
            // 
            this.textBoxOpcIp.Location = new System.Drawing.Point(6, 0);
            this.textBoxOpcIp.Name = "textBoxOpcIp";
            this.textBoxOpcIp.Size = new System.Drawing.Size(100, 28);
            this.textBoxOpcIp.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxOPCUATopic);
            this.groupBox5.Controls.Add(this.labelopcua);
            this.groupBox5.Location = new System.Drawing.Point(440, 399);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(316, 68);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "OPC_UA Capture";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // textBoxOPCUATopic
            // 
            this.textBoxOPCUATopic.Location = new System.Drawing.Point(52, 26);
            this.textBoxOPCUATopic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOPCUATopic.Name = "textBoxOPCUATopic";
            this.textBoxOPCUATopic.ReadOnly = true;
            this.textBoxOPCUATopic.Size = new System.Drawing.Size(250, 28);
            this.textBoxOPCUATopic.TabIndex = 5;
            this.textBoxOPCUATopic.Text = "$dg/thing/{productId}/{deviceAddr}/properties/report";
            this.textBoxOPCUATopic.TextChanged += new System.EventHandler(this.TextBoxOPCUATopic_TextChanged);
            // 
            // labelopcua
            // 
            this.labelopcua.AutoSize = true;
            this.labelopcua.Location = new System.Drawing.Point(9, 28);
            this.labelopcua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelopcua.Name = "labelopcua";
            this.labelopcua.Size = new System.Drawing.Size(26, 18);
            this.labelopcua.TabIndex = 6;
            this.labelopcua.Text = "To";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxBACnetTopic);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Location = new System.Drawing.Point(440, 489);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(316, 63);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "BACnet Capture";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // textBoxBACnetTopic
            // 
            this.textBoxBACnetTopic.Location = new System.Drawing.Point(46, 26);
            this.textBoxBACnetTopic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBACnetTopic.Name = "textBoxBACnetTopic";
            this.textBoxBACnetTopic.ReadOnly = true;
            this.textBoxBACnetTopic.Size = new System.Drawing.Size(252, 28);
            this.textBoxBACnetTopic.TabIndex = 5;
            this.textBoxBACnetTopic.Text = "$dg/thing/{productId}/{deviceAddr}/properties/report";
            this.textBoxBACnetTopic.TextChanged += new System.EventHandler(this.TextBoxBACnetTopic_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 32);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 18);
            this.label23.TabIndex = 6;
            this.label23.Text = "To";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxControlTopic);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Location = new System.Drawing.Point(440, 574);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(316, 70);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Control Capture";
            // 
            // textBoxControlTopic
            // 
            this.textBoxControlTopic.Location = new System.Drawing.Point(50, 26);
            this.textBoxControlTopic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxControlTopic.Name = "textBoxControlTopic";
            this.textBoxControlTopic.ReadOnly = true;
            this.textBoxControlTopic.Size = new System.Drawing.Size(253, 28);
            this.textBoxControlTopic.TabIndex = 5;
            this.textBoxControlTopic.Text = "$dg/thing/{productId}/{deviceAddr}/properties/report";
            this.textBoxControlTopic.TextChanged += new System.EventHandler(this.TextBoxControlTopic_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "To";
            // 
            // comboBoxBridge
            // 
            this.comboBoxBridge.FormattingEnabled = true;
            this.comboBoxBridge.Items.AddRange(new object[] {
            "SerialPort,",
            "TcpServer,",
            "BACnet,",
            "OPCDA,",
            "OPCUA,",
            "MqttClient,",
            "MqttServer,",
            "TcpClient,",
            "TcpServer,",
            "UdpClient,",
            "UdpServer,",
            "PLC,",
            "Control,",
            "Access,",
            "SqlServer,",
            "\"Barcode_Printer\",",
            "\"Dgiot\""});
            this.comboBoxBridge.Location = new System.Drawing.Point(63, 736);
            this.comboBoxBridge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxBridge.Name = "comboBoxBridge";
            this.comboBoxBridge.Size = new System.Drawing.Size(112, 26);
            this.comboBoxBridge.TabIndex = 13;
            this.comboBoxBridge.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBridge_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 742);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "To";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBoxAccessTopic);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Location = new System.Drawing.Point(440, 656);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Size = new System.Drawing.Size(316, 64);
            this.groupBox8.TabIndex = 22;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Access Capture";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // textBoxAccessTopic
            // 
            this.textBoxAccessTopic.Location = new System.Drawing.Point(50, 26);
            this.textBoxAccessTopic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAccessTopic.Name = "textBoxAccessTopic";
            this.textBoxAccessTopic.ReadOnly = true;
            this.textBoxAccessTopic.Size = new System.Drawing.Size(253, 28);
            this.textBoxAccessTopic.TabIndex = 5;
            this.textBoxAccessTopic.Text = "$dg/thing/{productId}/{deviceAddr}/properties/report";
            this.textBoxAccessTopic.TextChanged += new System.EventHandler(this.TextBoxAccessTopic_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "To";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label15);
            this.groupBox10.Controls.Add(this.textBoxUDPClientLogin);
            this.groupBox10.Location = new System.Drawing.Point(858, 411);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox10.Size = new System.Drawing.Size(322, 69);
            this.groupBox10.TabIndex = 19;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "UDP Client Channel";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 38);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 18);
            this.label15.TabIndex = 13;
            this.label15.Text = "login";
            // 
            // radioButtonMqttClient
            // 
            this.radioButtonMqttClient.AutoSize = true;
            this.radioButtonMqttClient.Checked = true;
            this.radioButtonMqttClient.Location = new System.Drawing.Point(838, 117);
            this.radioButtonMqttClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMqttClient.Name = "radioButtonMqttClient";
            this.radioButtonMqttClient.Size = new System.Drawing.Size(21, 20);
            this.radioButtonMqttClient.TabIndex = 30;
            this.radioButtonMqttClient.TabStop = true;
            this.radioButtonMqttClient.UseVisualStyleBackColor = true;
            this.radioButtonMqttClient.CheckedChanged += new System.EventHandler(this.RadioButtonMqttClient_CheckedChanged);
            // 
            // radioButtonTcpClient
            // 
            this.radioButtonTcpClient.AutoSize = true;
            this.radioButtonTcpClient.Location = new System.Drawing.Point(830, 310);
            this.radioButtonTcpClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonTcpClient.Name = "radioButtonTcpClient";
            this.radioButtonTcpClient.Size = new System.Drawing.Size(21, 20);
            this.radioButtonTcpClient.TabIndex = 31;
            this.radioButtonTcpClient.UseVisualStyleBackColor = true;
            this.radioButtonTcpClient.CheckedChanged += new System.EventHandler(this.RadioButtonTcpClient_CheckedChanged);
            // 
            // radioButtonUDPClient
            // 
            this.radioButtonUDPClient.AutoSize = true;
            this.radioButtonUDPClient.Location = new System.Drawing.Point(830, 436);
            this.radioButtonUDPClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUDPClient.Name = "radioButtonUDPClient";
            this.radioButtonUDPClient.Size = new System.Drawing.Size(21, 20);
            this.radioButtonUDPClient.TabIndex = 32;
            this.radioButtonUDPClient.UseVisualStyleBackColor = true;
            this.radioButtonUDPClient.CheckedChanged += new System.EventHandler(this.RadioButtonUDPClient_CheckedChanged);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.textBoxPLCTopic);
            this.groupBox12.Controls.Add(this.label2);
            this.groupBox12.Location = new System.Drawing.Point(442, 195);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox12.Size = new System.Drawing.Size(316, 66);
            this.groupBox12.TabIndex = 19;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "PLC Capture";
            // 
            // textBoxPLCTopic
            // 
            this.textBoxPLCTopic.Location = new System.Drawing.Point(58, 22);
            this.textBoxPLCTopic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPLCTopic.Name = "textBoxPLCTopic";
            this.textBoxPLCTopic.ReadOnly = true;
            this.textBoxPLCTopic.Size = new System.Drawing.Size(246, 28);
            this.textBoxPLCTopic.TabIndex = 5;
            this.textBoxPLCTopic.Text = "$dg/thing/{productId}/{deviceAddr}/properties/report";
            this.textBoxPLCTopic.TextChanged += new System.EventHandler(this.TextBoxPLCTopic_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "To";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(766, -64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 768);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxLogLevel
            // 
            this.comboBoxLogLevel.FormattingEnabled = true;
            this.comboBoxLogLevel.Location = new System.Drawing.Point(878, 736);
            this.comboBoxLogLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxLogLevel.Name = "comboBoxLogLevel";
            this.comboBoxLogLevel.Size = new System.Drawing.Size(82, 26);
            this.comboBoxLogLevel.TabIndex = 36;
            this.comboBoxLogLevel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLogLevel_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(772, 742);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(89, 18);
            this.label32.TabIndex = 37;
            this.label32.Text = "Log Level";
            // 
            // comboBoxLan
            // 
            this.comboBoxLan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLan.FormattingEnabled = true;
            this.comboBoxLan.Location = new System.Drawing.Point(1068, 738);
            this.comboBoxLan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxLan.Name = "comboBoxLan";
            this.comboBoxLan.Size = new System.Drawing.Size(104, 26);
            this.comboBoxLan.TabIndex = 38;
            this.comboBoxLan.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLan_SelectedIndexChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(974, 742);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(80, 18);
            this.label33.TabIndex = 39;
            this.label33.Text = "Language";
            // 
            // treeView
            // 
            this.treeView.CheckBoxes = true;
            this.treeView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.treeView.LabelEdit = true;
            this.treeView.Location = new System.Drawing.Point(4, 36);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(428, 313);
            this.treeView.TabIndex = 0;
            this.treeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.AfterLabelEdit);
            this.treeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterCheck);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.NodeMouseDoubleClick);
            // 
            // label_devcietree
            // 
            this.label_devcietree.Location = new System.Drawing.Point(10, 4);
            this.label_devcietree.Name = "label_devcietree";
            this.label_devcietree.Size = new System.Drawing.Size(100, 22);
            this.label_devcietree.TabIndex = 41;
            this.label_devcietree.Text = "DeviceTree";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "(*.txt)|*.txt";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // groupBoxCommonConfig
            // 
            this.groupBoxCommonConfig.Controls.Add(this.comboBoxDtuAddr);
            this.groupBoxCommonConfig.Controls.Add(this.label22);
            this.groupBoxCommonConfig.Controls.Add(this.label30);
            this.groupBoxCommonConfig.Controls.Add(this.textBoxBridgePort);
            this.groupBoxCommonConfig.Controls.Add(this.textBoxDgiotSever);
            this.groupBoxCommonConfig.Controls.Add(this.label21);
            this.groupBoxCommonConfig.Controls.Add(this.textBoxDgiotPort);
            this.groupBoxCommonConfig.Controls.Add(this.checkBoxBridge);
            this.groupBoxCommonConfig.Controls.Add(this.buttonStartStop);
            this.groupBoxCommonConfig.Controls.Add(this.checkBoxReconnect);
            this.groupBoxCommonConfig.Location = new System.Drawing.Point(854, 492);
            this.groupBoxCommonConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCommonConfig.Name = "groupBoxCommonConfig";
            this.groupBoxCommonConfig.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCommonConfig.Size = new System.Drawing.Size(328, 236);
            this.groupBoxCommonConfig.TabIndex = 19;
            this.groupBoxCommonConfig.TabStop = false;
            this.groupBoxCommonConfig.Text = "Common Config";
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(686, 735);
            this.buttonScan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(80, 32);
            this.buttonScan.TabIndex = 40;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.ButtonScan_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(143)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(1204, 782);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.groupBoxCommonConfig);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBoxSerialPort);
            this.Controls.Add(this.comboBoxLan);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.radioButtonUDPClient);
            this.Controls.Add(this.radioButtonTcpClient);
            this.Controls.Add(this.radioButtonMqttClient);
            this.Controls.Add(this.label_devcietree);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.comboBoxLogLevel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxBridge);
            this.Controls.Add(this.checkBoxDisplayHex);
            this.Controls.Add(this.sendBridge);
            this.Controls.Add(this.textToPayload);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "dgiot_dtu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBoxSerialPort.ResumeLayout(false);
            this.groupBoxSerialPort.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxCommonConfig.ResumeLayout(false);
            this.groupBoxCommonConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TreeView treeView;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.CheckBox checkBoxReconnect;
        private System.Windows.Forms.CheckBox checkBoxDisplayHex;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBoxSerialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label labelSerialPort;
        private System.Windows.Forms.ComboBox comboBoxSerialPort;
        private System.Windows.Forms.TextBox textBoxBridgePort;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.TextBox textToPayload;
        private System.Windows.Forms.Button sendBridge;
        private System.Windows.Forms.TextBox textBoxMqttPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxMqttUserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMqttSubTopic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxMqttPubTopic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxTcpClientLogin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxMqttClientId;
        private System.Windows.Forms.TextBox textBoxDgiotPort;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox checkBoxBridge;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxOPCUATopic;
        private System.Windows.Forms.Label labelopcua;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxBACnetTopic;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxControlTopic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxBridge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBoxAccessTopic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxUDPClientLogin;
        private System.Windows.Forms.RadioButton radioButtonMqttClient;
        private System.Windows.Forms.RadioButton radioButtonTcpClient;
        private System.Windows.Forms.RadioButton radioButtonUDPClient;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox textBoxPLCTopic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox comboBoxCmdProdxy;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox comboBoxDtuAddr;
        private System.Windows.Forms.TextBox textBoxOpcIp;
        private System.Windows.Forms.TextBox textBoxDgiotSever;
        private System.Windows.Forms.ComboBox comboBoxLogLevel;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox comboBoxLan;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label_devcietree;
        private TextBox textBoxOPCDAHost;
        private Label labelOPCDAHost;
        private OpenFileDialog openFileDialog;
        private CheckBox checkBoxOPCDA;
        private Label labelSecond;
        private Label labelOPCDAMonitor;
        private TextBox textBoxOPCDAInterval;
        private GroupBox groupBoxCommonConfig;
        private Label labelOPCDACount;
        private TextBox textBoxOPCDACount;
        private Button buttonScan;
    }
}

