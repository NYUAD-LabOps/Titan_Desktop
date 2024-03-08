
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
            this.btnD1Fwd = new System.Windows.Forms.Button();
            this.btnD1Rev = new System.Windows.Forms.Button();
            this.textBoxFreq = new System.Windows.Forms.TextBox();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelCommand = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.listBoxReceived = new System.Windows.Forms.ListBox();
            this.textBoxDriveIndex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            // btnD1Fwd
            // 
            this.btnD1Fwd.Location = new System.Drawing.Point(122, 445);
            this.btnD1Fwd.Margin = new System.Windows.Forms.Padding(4);
            this.btnD1Fwd.Name = "btnD1Fwd";
            this.btnD1Fwd.Size = new System.Drawing.Size(76, 73);
            this.btnD1Fwd.TabIndex = 6;
            this.btnD1Fwd.TabStop = false;
            this.btnD1Fwd.Text = "/\\";
            this.btnD1Fwd.UseVisualStyleBackColor = true;
            this.btnD1Fwd.Click += new System.EventHandler(this.btnD1Fwd_Click);
            this.btnD1Fwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonForward_MouseDown);
            this.btnD1Fwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonForward_MouseUp);
            // 
            // btnD1Rev
            // 
            this.btnD1Rev.Location = new System.Drawing.Point(122, 525);
            this.btnD1Rev.Margin = new System.Windows.Forms.Padding(4);
            this.btnD1Rev.Name = "btnD1Rev";
            this.btnD1Rev.Size = new System.Drawing.Size(76, 73);
            this.btnD1Rev.TabIndex = 5;
            this.btnD1Rev.TabStop = false;
            this.btnD1Rev.Text = "\\/";
            this.btnD1Rev.UseVisualStyleBackColor = true;
            this.btnD1Rev.Click += new System.EventHandler(this.btnD1Rev_Click);
            this.btnD1Rev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonReverse_MouseDown);
            this.btnD1Rev.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReverse_MouseUp);
            // 
            // textBoxFreq
            // 
            this.textBoxFreq.Location = new System.Drawing.Point(28, 275);
            this.textBoxFreq.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFreq.Name = "textBoxFreq";
            this.textBoxFreq.Size = new System.Drawing.Size(172, 31);
            this.textBoxFreq.TabIndex = 7;
            this.textBoxFreq.TabStop = false;
            this.textBoxFreq.Text = "1000";
            this.textBoxFreq.TextChanged += new System.EventHandler(this.textBoxFreq_TextChanged);
            this.textBoxFreq.Enter += new System.EventHandler(this.FreqHasFocus);
            this.textBoxFreq.Leave += new System.EventHandler(this.FreqLostFocus);
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Location = new System.Drawing.Point(24, 246);
            this.labelFrequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(160, 25);
            this.labelFrequency.TabIndex = 8;
            this.labelFrequency.Text = "Frequency (Hz)";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(78, 627);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(120, 73);
            this.btnHome.TabIndex = 24;
            this.btnHome.TabStop = false;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 525);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Reverse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Move Drive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 464);
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
            // textBoxDriveIndex
            // 
            this.textBoxDriveIndex.Location = new System.Drawing.Point(29, 387);
            this.textBoxDriveIndex.Name = "textBoxDriveIndex";
            this.textBoxDriveIndex.Size = new System.Drawing.Size(168, 31);
            this.textBoxDriveIndex.TabIndex = 30;
            this.textBoxDriveIndex.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Drive Index";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 1185);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDriveIndex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxReceived);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnD1Fwd);
            this.Controls.Add(this.btnD1Rev);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCommand);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.textBoxFreq);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSerialPort;
        private System.Windows.Forms.RadioButton radioButtonConStatus;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button btnD1Fwd;
        private System.Windows.Forms.Button btnD1Rev;
        private System.Windows.Forms.TextBox textBoxFreq;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.ListBox listBoxReceived;
        private System.Windows.Forms.TextBox textBoxDriveIndex;
        private System.Windows.Forms.Label label4;
    }
}

