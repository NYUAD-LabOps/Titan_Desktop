using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Titan_USB_CDC_Interface
{
    public partial class Form1 : Form
    {
        string[] ports;
        private SerialPort mySerialPort;


        public string[] GetPortList()
        {
            ports = SerialPort.GetPortNames();
            return ports;
        }

        public void InitializeSerialPort(string thePort)
        {
            mySerialPort = new SerialPort(thePort);

            // Configure your serial port (Baud rate, Parity, Stop bits, Data bits)
            mySerialPort.BaudRate = 12000000;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;

            // Set the read/write timeouts
            mySerialPort.ReadTimeout = 500;
            mySerialPort.WriteTimeout = 500;

            // Subscribe to the DataReceived event
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            // Open the serial port
            mySerialPort.Open();
        }

        public void DataReceivedHandler(
                            object sender,
                            SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = "\r\n" + sp.ReadExisting();
            listBoxReceived.Invoke((MethodInvoker)delegate
            {
                // Safe to update the TextBox here
                listBoxReceived.Text += indata;
            });

        }
        public void SendData(string theData)
        {
            if (mySerialPort.IsOpen)
            {
                mySerialPort.Write(theData);
            }
        }

        public void SerialPortDisconnect()
        {
            if (mySerialPort.IsOpen)
            {
                mySerialPort.Close();
            }

        }


        public Form1()
        {
            InitializeComponent();
            listBoxReceived.Text = "startup";
            // Set KeyPreview property to true to catch the key events at form level
            this.KeyPreview = true;

            // Subscribe to the PreviewKeyDown event of the form or control
            this.PreviewKeyDown += new PreviewKeyDownEventHandler(ArrowPreviewKeyDown);
            

            // Subscribe to the KeyDown event of the form
            this.KeyDown += new KeyEventHandler(KeyIsDown);
            this.KeyUp += new KeyEventHandler(KeyIsUp);
            commandHasFocus = false;
            freqHasFocus = false;
            bmpHasFocus = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = GetPortList();
            foreach (string port in ports)
            {
                comboBoxSerialPort.Items.Add(port);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string thePort = comboBoxSerialPort.Text;
            InitializeSerialPort(thePort);
            radioButtonConStatus.Checked = true;
            radioButtonConStatus.Text = "Connected to " + thePort;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string theData;
            theData = textBoxCommand.Text;
            SendData(theData);
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            SerialPortDisconnect();
            radioButtonConStatus.Checked = false;
            radioButtonConStatus.Text = "Disconnected";
        }

        private void buttonForward_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForwardStart();

        }

        private void buttonForward_MouseUp(object sender, MouseEventArgs e)
        {
            MoveForwardStop();

        }

        private void buttonReverse_MouseDown(object sender, MouseEventArgs e)
        {
            MoveReverseStart();

        }

        private void buttonReverse_MouseUp(object sender, MouseEventArgs e)
        {
            MoveReverseStop();

        }

        private void ArrowPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Check if an arrow key is pressed, and if yes, set IsInputKey to true
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                    e.IsInputKey = true;
                    break;
            }
        }

        int upKeyDown = 0;
        int downKeyDown = 0;
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            string txtToAdd = "" ;
            if (commandHasFocus || freqHasFocus || bmpHasFocus) return;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (upKeyDown == 0)
                    {
                        MoveForwardStart();
                        upKeyDown = 1;
                    }
                    break;
                case Keys.Down:
                    if (downKeyDown == 0)
                    {
                        MoveReverseStart();
                        downKeyDown = 1;
                    }
                    break;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            string txtToAdd = "";
            if (commandHasFocus || freqHasFocus || bmpHasFocus) return;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (upKeyDown == 1)
                    {
                        MoveForwardStop();
                        upKeyDown = 0;
                    }
                    break;
                case Keys.Down:
                    if (downKeyDown == 1)
                    {
                        MoveReverseStop();
                        downKeyDown = 0;
                    }
                    break;
            }
        }
        bool commandHasFocus,freqHasFocus,bmpHasFocus;
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void CommandLostFocus(object sender, EventArgs e)
        {
            commandHasFocus = false;
        }

        private void CommandGainedFocus(object sender, EventArgs e)
        {
            commandHasFocus = true;
        }

        private void buttonSetFreq_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ExecuteMoveCommand("@@@H00");
        }



        private void FreqHasFocus(object sender, EventArgs e)
        {
            freqHasFocus = true;
        }

        private void FreqLostFocus(object sender, EventArgs e)
        {
            freqHasFocus = false;
        }

        private void BmpHasFocus(object sender, EventArgs e)
        {
            bmpHasFocus = true;
        }

        private void BmpLostFocus(object sender, EventArgs e)
        {
            bmpHasFocus = false;
        }

        private void btnD1Fwd_Click(object sender, EventArgs e)
        {

        }

        private void btnD1Rev_Click(object sender, EventArgs e)
        {

        }

        private void MoveForwardStart()
        {

            ExecuteMoveCommand("@@@M"+textBoxDriveIndex.Text+"F" + textBoxFreq.Text);
        }

        private void MoveForwardStop()
        {
            ExecuteMoveCommand("@@@S" + textBoxDriveIndex.Text);
        }

        private void MoveReverseStart()
        {
            ExecuteMoveCommand("@@@M"+textBoxDriveIndex.Text+"R" + textBoxFreq.Text);
        }

        private void textBoxFreq_TextChanged(object sender, EventArgs e)
        {

        }

        private void MoveReverseStop()
        {
            ExecuteMoveCommand("@@@S" + textBoxDriveIndex.Text);
        }
        private void ExecuteMoveCommand(string moveCommand)
        {
            string theData;
            theData = textBoxCommand.Text;
            SendData(moveCommand);
            listBoxReceived.Items.Add("\r\n"+moveCommand);
            if (listBoxReceived.Items.Count > 12)
            {
                listBoxReceived.Items.RemoveAt(1);
            }
        }
    }
}
