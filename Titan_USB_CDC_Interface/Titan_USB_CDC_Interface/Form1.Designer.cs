
namespace Titan_USB_CDC_Interface
{
    partial class Form1
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSerialPort = new System.Windows.Forms.ComboBox();
            this.radioButtonConStatus = new System.Windows.Forms.RadioButton();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.btnXFwd = new System.Windows.Forms.Button();
            this.btnXRev = new System.Windows.Forms.Button();
            this.textBoxFreqDI_00 = new System.Windows.Forms.TextBox();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.btnXHome = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelCommand = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.listBoxReceived = new System.Windows.Forms.ListBox();
            this.txtBoxDI_00 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnYFwd = new System.Windows.Forms.Button();
            this.btnYRev = new System.Windows.Forms.Button();
            this.btnZFwd = new System.Windows.Forms.Button();
            this.btnZRev = new System.Windows.Forms.Button();
            this.btnAFwd = new System.Windows.Forms.Button();
            this.btnARev = new System.Windows.Forms.Button();
            this.btnCFwd = new System.Windows.Forms.Button();
            this.btnCRev = new System.Windows.Forms.Button();
            this.btnWFFwd = new System.Windows.Forms.Button();
            this.btnWFRev = new System.Windows.Forms.Button();
            this.txtBoxDI_01 = new System.Windows.Forms.TextBox();
            this.txtBoxDI_02 = new System.Windows.Forms.TextBox();
            this.txtBoxDI_03 = new System.Windows.Forms.TextBox();
            this.txtBoxDI_04 = new System.Windows.Forms.TextBox();
            this.txtBoxDI_05 = new System.Windows.Forms.TextBox();
            this.textBoxFreqDI_01 = new System.Windows.Forms.TextBox();
            this.textBoxFreqDI_02 = new System.Windows.Forms.TextBox();
            this.textBoxFreqDI_03 = new System.Windows.Forms.TextBox();
            this.textBoxFreqDI_04 = new System.Windows.Forms.TextBox();
            this.textBoxFreqDI_05 = new System.Windows.Forms.TextBox();
            this.groupBoxManualDrive = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCHome = new System.Windows.Forms.Button();
            this.btnAHome = new System.Windows.Forms.Button();
            this.btnZHome = new System.Windows.Forms.Button();
            this.btnYHome = new System.Windows.Forms.Button();
            this.groupBoxManualDrive.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(458, 15);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(152, 48);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.TabStop = false;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.FormattingEnabled = true;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(296, 15);
            this.comboBoxSerialPort.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Size = new System.Drawing.Size(156, 33);
            this.comboBoxSerialPort.TabIndex = 0;
            this.comboBoxSerialPort.TabStop = false;
            // 
            // radioButtonConStatus
            // 
            this.radioButtonConStatus.AutoSize = true;
            this.radioButtonConStatus.Location = new System.Drawing.Point(12, 12);
            this.radioButtonConStatus.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonConStatus.Name = "radioButtonConStatus";
            this.radioButtonConStatus.Size = new System.Drawing.Size(186, 29);
            this.radioButtonConStatus.TabIndex = 1;
            this.radioButtonConStatus.Text = "Not Connected";
            this.radioButtonConStatus.UseVisualStyleBackColor = true;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(616, 15);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(152, 48);
            this.buttonDisconnect.TabIndex = 4;
            this.buttonDisconnect.TabStop = false;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // btnXFwd
            // 
            this.btnXFwd.Location = new System.Drawing.Point(134, 147);
            this.btnXFwd.Margin = new System.Windows.Forms.Padding(4);
            this.btnXFwd.Name = "btnXFwd";
            this.btnXFwd.Size = new System.Drawing.Size(76, 73);
            this.btnXFwd.TabIndex = 6;
            this.btnXFwd.TabStop = false;
            this.btnXFwd.Text = "X+";
            this.btnXFwd.UseVisualStyleBackColor = true;
            this.btnXFwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnXFwd_MouseDown);
            this.btnXFwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnXFwd_MouseUp);
            // 
            // btnXRev
            // 
            this.btnXRev.Location = new System.Drawing.Point(134, 227);
            this.btnXRev.Margin = new System.Windows.Forms.Padding(4);
            this.btnXRev.Name = "btnXRev";
            this.btnXRev.Size = new System.Drawing.Size(76, 73);
            this.btnXRev.TabIndex = 5;
            this.btnXRev.TabStop = false;
            this.btnXRev.Text = "X-";
            this.btnXRev.UseVisualStyleBackColor = true;
            this.btnXRev.Click += new System.EventHandler(this.BtnD1Rev_Click);
            this.btnXRev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnXRev_MouseDown);
            this.btnXRev.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnXRev_MouseUp);
            // 
            // textBoxFreqDI_00
            // 
            this.textBoxFreqDI_00.Location = new System.Drawing.Point(134, 59);
            this.textBoxFreqDI_00.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFreqDI_00.Name = "textBoxFreqDI_00";
            this.textBoxFreqDI_00.Size = new System.Drawing.Size(76, 31);
            this.textBoxFreqDI_00.TabIndex = 7;
            this.textBoxFreqDI_00.TabStop = false;
            this.textBoxFreqDI_00.Text = "5000";
            this.textBoxFreqDI_00.TextChanged += new System.EventHandler(this.textBoxFreq_TextChanged);
            this.textBoxFreqDI_00.Enter += new System.EventHandler(this.FreqHasFocus);
            this.textBoxFreqDI_00.Leave += new System.EventHandler(this.FreqLostFocus);
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Location = new System.Drawing.Point(30, 59);
            this.labelFrequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(102, 25);
            this.labelFrequency.TabIndex = 8;
            this.labelFrequency.Text = "Freq (Hz)";
            // 
            // btnXHome
            // 
            this.btnXHome.Location = new System.Drawing.Point(134, 308);
            this.btnXHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnXHome.Name = "btnXHome";
            this.btnXHome.Size = new System.Drawing.Size(76, 73);
            this.btnXHome.TabIndex = 24;
            this.btnXHome.TabStop = false;
            this.btnXHome.Text = "Home X";
            this.btnXHome.UseVisualStyleBackColor = true;
            this.btnXHome.Click += new System.EventHandler(this.btnXHome_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 227);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Reverse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Forward";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(12, 138);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(196, 50);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.TabStop = false;
            this.buttonSend.Text = "Send Command";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Location = new System.Drawing.Point(12, 73);
            this.labelCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(115, 25);
            this.labelCommand.TabIndex = 2;
            this.labelCommand.Text = "Command:";
            this.labelCommand.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 729);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Titan Feedback";
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(12, 102);
            this.textBoxCommand.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(196, 31);
            this.textBoxCommand.TabIndex = 1;
            this.textBoxCommand.TabStop = false;
            this.textBoxCommand.Enter += new System.EventHandler(this.CommandGainedFocus);
            this.textBoxCommand.Leave += new System.EventHandler(this.CommandLostFocus);
            // 
            // listBoxReceived
            // 
            this.listBoxReceived.FormattingEnabled = true;
            this.listBoxReceived.ItemHeight = 25;
            this.listBoxReceived.Location = new System.Drawing.Point(12, 768);
            this.listBoxReceived.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxReceived.Name = "listBoxReceived";
            this.listBoxReceived.Size = new System.Drawing.Size(252, 404);
            this.listBoxReceived.TabIndex = 20;
            // 
            // txtBoxDI_00
            // 
            this.txtBoxDI_00.Location = new System.Drawing.Point(134, 97);
            this.txtBoxDI_00.Name = "txtBoxDI_00";
            this.txtBoxDI_00.Size = new System.Drawing.Size(76, 31);
            this.txtBoxDI_00.TabIndex = 30;
            this.txtBoxDI_00.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Index";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnYFwd
            // 
            this.btnYFwd.Location = new System.Drawing.Point(227, 147);
            this.btnYFwd.Margin = new System.Windows.Forms.Padding(4);
            this.btnYFwd.Name = "btnYFwd";
            this.btnYFwd.Size = new System.Drawing.Size(76, 73);
            this.btnYFwd.TabIndex = 33;
            this.btnYFwd.TabStop = false;
            this.btnYFwd.Text = "Y+";
            this.btnYFwd.UseVisualStyleBackColor = true;
            this.btnYFwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnYFwd_MouseDown);
            this.btnYFwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnYFwd_MouseUp);
            // 
            // btnYRev
            // 
            this.btnYRev.Location = new System.Drawing.Point(227, 227);
            this.btnYRev.Margin = new System.Windows.Forms.Padding(4);
            this.btnYRev.Name = "btnYRev";
            this.btnYRev.Size = new System.Drawing.Size(76, 73);
            this.btnYRev.TabIndex = 32;
            this.btnYRev.TabStop = false;
            this.btnYRev.Text = "Y-";
            this.btnYRev.UseVisualStyleBackColor = true;
            this.btnYRev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnYRev_MouseDown);
            this.btnYRev.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnYRev_MouseUp);
            // 
            // btnZFwd
            // 
            this.btnZFwd.Location = new System.Drawing.Point(321, 147);
            this.btnZFwd.Margin = new System.Windows.Forms.Padding(4);
            this.btnZFwd.Name = "btnZFwd";
            this.btnZFwd.Size = new System.Drawing.Size(76, 73);
            this.btnZFwd.TabIndex = 35;
            this.btnZFwd.TabStop = false;
            this.btnZFwd.Text = "Z+";
            this.btnZFwd.UseVisualStyleBackColor = true;
            this.btnZFwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZFwd_MouseDown);
            this.btnZFwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZFwd_MouseUp);
            // 
            // btnZRev
            // 
            this.btnZRev.Location = new System.Drawing.Point(321, 227);
            this.btnZRev.Margin = new System.Windows.Forms.Padding(4);
            this.btnZRev.Name = "btnZRev";
            this.btnZRev.Size = new System.Drawing.Size(76, 73);
            this.btnZRev.TabIndex = 34;
            this.btnZRev.TabStop = false;
            this.btnZRev.Text = "Z-";
            this.btnZRev.UseVisualStyleBackColor = true;
            this.btnZRev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZRev_MouseDown);
            this.btnZRev.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZRev_MouseUp);
            // 
            // btnAFwd
            // 
            this.btnAFwd.Location = new System.Drawing.Point(415, 147);
            this.btnAFwd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAFwd.Name = "btnAFwd";
            this.btnAFwd.Size = new System.Drawing.Size(76, 73);
            this.btnAFwd.TabIndex = 37;
            this.btnAFwd.TabStop = false;
            this.btnAFwd.Text = "A+";
            this.btnAFwd.UseVisualStyleBackColor = true;
            this.btnAFwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAFwd_MouseDown);
            this.btnAFwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAFwd_MouseUp);
            // 
            // btnARev
            // 
            this.btnARev.Location = new System.Drawing.Point(415, 227);
            this.btnARev.Margin = new System.Windows.Forms.Padding(4);
            this.btnARev.Name = "btnARev";
            this.btnARev.Size = new System.Drawing.Size(76, 73);
            this.btnARev.TabIndex = 36;
            this.btnARev.TabStop = false;
            this.btnARev.Text = "A-";
            this.btnARev.UseVisualStyleBackColor = true;
            this.btnARev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnARev_MouseDown);
            this.btnARev.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnARev_MouseUp);
            // 
            // btnCFwd
            // 
            this.btnCFwd.Location = new System.Drawing.Point(509, 147);
            this.btnCFwd.Margin = new System.Windows.Forms.Padding(4);
            this.btnCFwd.Name = "btnCFwd";
            this.btnCFwd.Size = new System.Drawing.Size(76, 73);
            this.btnCFwd.TabIndex = 39;
            this.btnCFwd.TabStop = false;
            this.btnCFwd.Text = "C+";
            this.btnCFwd.UseVisualStyleBackColor = true;
            this.btnCFwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCFwd_MouseDown);
            this.btnCFwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCFwd_MouseUp);
            // 
            // btnCRev
            // 
            this.btnCRev.Location = new System.Drawing.Point(509, 227);
            this.btnCRev.Margin = new System.Windows.Forms.Padding(4);
            this.btnCRev.Name = "btnCRev";
            this.btnCRev.Size = new System.Drawing.Size(76, 73);
            this.btnCRev.TabIndex = 38;
            this.btnCRev.TabStop = false;
            this.btnCRev.Text = "C-";
            this.btnCRev.UseVisualStyleBackColor = true;
            this.btnCRev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCRev_MouseDown);
            this.btnCRev.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCRev_MouseUp);
            // 
            // btnWFFwd
            // 
            this.btnWFFwd.Location = new System.Drawing.Point(602, 147);
            this.btnWFFwd.Margin = new System.Windows.Forms.Padding(4);
            this.btnWFFwd.Name = "btnWFFwd";
            this.btnWFFwd.Size = new System.Drawing.Size(76, 73);
            this.btnWFFwd.TabIndex = 41;
            this.btnWFFwd.TabStop = false;
            this.btnWFFwd.Text = "WF+";
            this.btnWFFwd.UseVisualStyleBackColor = true;
            this.btnWFFwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnWFFwd_MouseDown);
            this.btnWFFwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnWFFwd_MouseUp);
            // 
            // btnWFRev
            // 
            this.btnWFRev.Location = new System.Drawing.Point(602, 227);
            this.btnWFRev.Margin = new System.Windows.Forms.Padding(4);
            this.btnWFRev.Name = "btnWFRev";
            this.btnWFRev.Size = new System.Drawing.Size(76, 73);
            this.btnWFRev.TabIndex = 40;
            this.btnWFRev.TabStop = false;
            this.btnWFRev.Text = "WF-";
            this.btnWFRev.UseVisualStyleBackColor = true;
            this.btnWFRev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnWFRev_MouseDown);
            this.btnWFRev.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnWFRev_MouseUp);
            // 
            // txtBoxDI_01
            // 
            this.txtBoxDI_01.Location = new System.Drawing.Point(227, 97);
            this.txtBoxDI_01.Name = "txtBoxDI_01";
            this.txtBoxDI_01.Size = new System.Drawing.Size(78, 31);
            this.txtBoxDI_01.TabIndex = 42;
            this.txtBoxDI_01.Text = "01";
            // 
            // txtBoxDI_02
            // 
            this.txtBoxDI_02.Location = new System.Drawing.Point(321, 97);
            this.txtBoxDI_02.Name = "txtBoxDI_02";
            this.txtBoxDI_02.Size = new System.Drawing.Size(76, 31);
            this.txtBoxDI_02.TabIndex = 43;
            this.txtBoxDI_02.Text = "02";
            // 
            // txtBoxDI_03
            // 
            this.txtBoxDI_03.Location = new System.Drawing.Point(415, 97);
            this.txtBoxDI_03.Name = "txtBoxDI_03";
            this.txtBoxDI_03.Size = new System.Drawing.Size(76, 31);
            this.txtBoxDI_03.TabIndex = 44;
            this.txtBoxDI_03.Text = "03";
            // 
            // txtBoxDI_04
            // 
            this.txtBoxDI_04.Location = new System.Drawing.Point(509, 97);
            this.txtBoxDI_04.Name = "txtBoxDI_04";
            this.txtBoxDI_04.Size = new System.Drawing.Size(76, 31);
            this.txtBoxDI_04.TabIndex = 45;
            this.txtBoxDI_04.Text = "04";
            // 
            // txtBoxDI_05
            // 
            this.txtBoxDI_05.Location = new System.Drawing.Point(602, 97);
            this.txtBoxDI_05.Name = "txtBoxDI_05";
            this.txtBoxDI_05.Size = new System.Drawing.Size(76, 31);
            this.txtBoxDI_05.TabIndex = 46;
            this.txtBoxDI_05.Text = "05";
            // 
            // textBoxFreqDI_01
            // 
            this.textBoxFreqDI_01.Location = new System.Drawing.Point(227, 59);
            this.textBoxFreqDI_01.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFreqDI_01.Name = "textBoxFreqDI_01";
            this.textBoxFreqDI_01.Size = new System.Drawing.Size(76, 31);
            this.textBoxFreqDI_01.TabIndex = 47;
            this.textBoxFreqDI_01.TabStop = false;
            this.textBoxFreqDI_01.Text = "5000";
            // 
            // textBoxFreqDI_02
            // 
            this.textBoxFreqDI_02.Location = new System.Drawing.Point(321, 59);
            this.textBoxFreqDI_02.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFreqDI_02.Name = "textBoxFreqDI_02";
            this.textBoxFreqDI_02.Size = new System.Drawing.Size(76, 31);
            this.textBoxFreqDI_02.TabIndex = 48;
            this.textBoxFreqDI_02.TabStop = false;
            this.textBoxFreqDI_02.Text = "5000";
            // 
            // textBoxFreqDI_03
            // 
            this.textBoxFreqDI_03.Location = new System.Drawing.Point(415, 59);
            this.textBoxFreqDI_03.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFreqDI_03.Name = "textBoxFreqDI_03";
            this.textBoxFreqDI_03.Size = new System.Drawing.Size(76, 31);
            this.textBoxFreqDI_03.TabIndex = 49;
            this.textBoxFreqDI_03.TabStop = false;
            this.textBoxFreqDI_03.Text = "5000";
            // 
            // textBoxFreqDI_04
            // 
            this.textBoxFreqDI_04.Location = new System.Drawing.Point(509, 59);
            this.textBoxFreqDI_04.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFreqDI_04.Name = "textBoxFreqDI_04";
            this.textBoxFreqDI_04.Size = new System.Drawing.Size(76, 31);
            this.textBoxFreqDI_04.TabIndex = 50;
            this.textBoxFreqDI_04.TabStop = false;
            this.textBoxFreqDI_04.Text = "5000";
            // 
            // textBoxFreqDI_05
            // 
            this.textBoxFreqDI_05.Location = new System.Drawing.Point(602, 59);
            this.textBoxFreqDI_05.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFreqDI_05.Name = "textBoxFreqDI_05";
            this.textBoxFreqDI_05.Size = new System.Drawing.Size(76, 31);
            this.textBoxFreqDI_05.TabIndex = 51;
            this.textBoxFreqDI_05.TabStop = false;
            this.textBoxFreqDI_05.Text = "5000";
            // 
            // groupBoxManualDrive
            // 
            this.groupBoxManualDrive.Controls.Add(this.label6);
            this.groupBoxManualDrive.Controls.Add(this.btnZFwd);
            this.groupBoxManualDrive.Controls.Add(this.btnCHome);
            this.groupBoxManualDrive.Controls.Add(this.textBoxFreqDI_00);
            this.groupBoxManualDrive.Controls.Add(this.btnAHome);
            this.groupBoxManualDrive.Controls.Add(this.labelFrequency);
            this.groupBoxManualDrive.Controls.Add(this.btnZHome);
            this.groupBoxManualDrive.Controls.Add(this.btnXHome);
            this.groupBoxManualDrive.Controls.Add(this.btnYHome);
            this.groupBoxManualDrive.Controls.Add(this.label9);
            this.groupBoxManualDrive.Controls.Add(this.btnXRev);
            this.groupBoxManualDrive.Controls.Add(this.textBoxFreqDI_05);
            this.groupBoxManualDrive.Controls.Add(this.btnXFwd);
            this.groupBoxManualDrive.Controls.Add(this.textBoxFreqDI_04);
            this.groupBoxManualDrive.Controls.Add(this.label2);
            this.groupBoxManualDrive.Controls.Add(this.textBoxFreqDI_03);
            this.groupBoxManualDrive.Controls.Add(this.txtBoxDI_00);
            this.groupBoxManualDrive.Controls.Add(this.textBoxFreqDI_02);
            this.groupBoxManualDrive.Controls.Add(this.label4);
            this.groupBoxManualDrive.Controls.Add(this.textBoxFreqDI_01);
            this.groupBoxManualDrive.Controls.Add(this.btnYRev);
            this.groupBoxManualDrive.Controls.Add(this.txtBoxDI_05);
            this.groupBoxManualDrive.Controls.Add(this.btnYFwd);
            this.groupBoxManualDrive.Controls.Add(this.txtBoxDI_04);
            this.groupBoxManualDrive.Controls.Add(this.btnZRev);
            this.groupBoxManualDrive.Controls.Add(this.txtBoxDI_03);
            this.groupBoxManualDrive.Controls.Add(this.btnARev);
            this.groupBoxManualDrive.Controls.Add(this.txtBoxDI_02);
            this.groupBoxManualDrive.Controls.Add(this.btnAFwd);
            this.groupBoxManualDrive.Controls.Add(this.txtBoxDI_01);
            this.groupBoxManualDrive.Controls.Add(this.btnCRev);
            this.groupBoxManualDrive.Controls.Add(this.btnWFFwd);
            this.groupBoxManualDrive.Controls.Add(this.btnCFwd);
            this.groupBoxManualDrive.Controls.Add(this.btnWFRev);
            this.groupBoxManualDrive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxManualDrive.Location = new System.Drawing.Point(17, 241);
            this.groupBoxManualDrive.Name = "groupBoxManualDrive";
            this.groupBoxManualDrive.Size = new System.Drawing.Size(717, 407);
            this.groupBoxManualDrive.TabIndex = 52;
            this.groupBoxManualDrive.TabStop = false;
            this.groupBoxManualDrive.Text = "Manual Drive Move";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 57;
            this.label6.Text = "Home";
            // 
            // btnCHome
            // 
            this.btnCHome.Location = new System.Drawing.Point(509, 308);
            this.btnCHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnCHome.Name = "btnCHome";
            this.btnCHome.Size = new System.Drawing.Size(76, 73);
            this.btnCHome.TabIndex = 56;
            this.btnCHome.TabStop = false;
            this.btnCHome.Text = "Home C";
            this.btnCHome.UseVisualStyleBackColor = true;
            this.btnCHome.Click += new System.EventHandler(this.btnCHome_Click);
            // 
            // btnAHome
            // 
            this.btnAHome.Location = new System.Drawing.Point(415, 308);
            this.btnAHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnAHome.Name = "btnAHome";
            this.btnAHome.Size = new System.Drawing.Size(76, 73);
            this.btnAHome.TabIndex = 55;
            this.btnAHome.TabStop = false;
            this.btnAHome.Text = "Home A";
            this.btnAHome.UseVisualStyleBackColor = true;
            this.btnAHome.Click += new System.EventHandler(this.btnAHome_Click);
            // 
            // btnZHome
            // 
            this.btnZHome.Location = new System.Drawing.Point(321, 308);
            this.btnZHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnZHome.Name = "btnZHome";
            this.btnZHome.Size = new System.Drawing.Size(76, 73);
            this.btnZHome.TabIndex = 54;
            this.btnZHome.TabStop = false;
            this.btnZHome.Text = "Home Z";
            this.btnZHome.UseVisualStyleBackColor = true;
            this.btnZHome.Click += new System.EventHandler(this.btnZHome_Click);
            // 
            // btnYHome
            // 
            this.btnYHome.Location = new System.Drawing.Point(227, 308);
            this.btnYHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnYHome.Name = "btnYHome";
            this.btnYHome.Size = new System.Drawing.Size(76, 73);
            this.btnYHome.TabIndex = 53;
            this.btnYHome.TabStop = false;
            this.btnYHome.Text = "Home Y";
            this.btnYHome.UseVisualStyleBackColor = true;
            this.btnYHome.Click += new System.EventHandler(this.btnYHome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 1185);
            this.Controls.Add(this.groupBoxManualDrive);
            this.Controls.Add(this.listBoxReceived);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCommand);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.labelCommand);
            this.Controls.Add(this.comboBoxSerialPort);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonConStatus);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxManualDrive.ResumeLayout(false);
            this.groupBoxManualDrive.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSerialPort;
        private System.Windows.Forms.RadioButton radioButtonConStatus;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button btnXFwd;
        private System.Windows.Forms.Button btnXRev;
        private System.Windows.Forms.TextBox textBoxFreqDI_00;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.Button btnXHome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.ListBox listBoxReceived;
        private System.Windows.Forms.TextBox txtBoxDI_00;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnYFwd;
        private System.Windows.Forms.Button btnYRev;
        private System.Windows.Forms.Button btnZFwd;
        private System.Windows.Forms.Button btnZRev;
        private System.Windows.Forms.Button btnAFwd;
        private System.Windows.Forms.Button btnARev;
        private System.Windows.Forms.Button btnCFwd;
        private System.Windows.Forms.Button btnCRev;
        private System.Windows.Forms.Button btnWFFwd;
        private System.Windows.Forms.Button btnWFRev;
        private System.Windows.Forms.TextBox txtBoxDI_01;
        private System.Windows.Forms.TextBox txtBoxDI_02;
        private System.Windows.Forms.TextBox txtBoxDI_03;
        private System.Windows.Forms.TextBox txtBoxDI_04;
        private System.Windows.Forms.TextBox txtBoxDI_05;
        private System.Windows.Forms.TextBox textBoxFreqDI_01;
        private System.Windows.Forms.TextBox textBoxFreqDI_02;
        private System.Windows.Forms.TextBox textBoxFreqDI_03;
        private System.Windows.Forms.TextBox textBoxFreqDI_04;
        private System.Windows.Forms.TextBox textBoxFreqDI_05;
        private System.Windows.Forms.GroupBox groupBoxManualDrive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCHome;
        private System.Windows.Forms.Button btnAHome;
        private System.Windows.Forms.Button btnZHome;
        private System.Windows.Forms.Button btnYHome;
    }
}

