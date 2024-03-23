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
using System.Net.Http;
using System.Security.Permissions;
using System.IO;
using System.Runtime.CompilerServices;

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
//            mySerialPort.BaudRate = 12000000;
            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;

            // Set the read/write timeouts
            mySerialPort.ReadTimeout = 3500;
            mySerialPort.WriteTimeout = 3500;
            mySerialPort.WriteBufferSize = 5000;

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
        public void SendData(byte[] theData)
        {
            if (mySerialPort.IsOpen)
            {
                mySerialPort.Write(theData,0,theData.Length);
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


        public int CopyULongIntoByteArray(byte[] byte_data, int offset, ulong int_data, int padded_width)
        {
            int pos = offset;
            int pad_count;
            string numberString = int_data.ToString(); // Convert integer to string
            pad_count = padded_width - numberString.Length;
            //            if (pad_count > 0)
            //            {
            //                numberString = numberString.PadLeft(pad_count, '0');
            //            }
            numberString = numberString.PadLeft(padded_width, '0');
            byte[] byte_array = Encoding.ASCII.GetBytes(numberString);
            Array.Copy(byte_array, 0, byte_data, offset, byte_array.Length);
            pos = offset + byte_array.Length;
            return pos;
        }

        /*
#define MOVE_TYPE_CLOCK_COUNT_NO_OUTPUT     0
#define MOVE_TYPE_CONTINUOUS_FWD            1
#define MOVE_TYPE_CONTINUOUS_REV            2
#define MOVE_TYPE_CLOCK_COUNT_FWD           3
#define MOVE_TYPE_CLOCK_COUNT_REV           4
*/
        public int CopyIntIntoByteArray(byte[] byte_data,int offset,int int_data,int padded_width)
        {
            int pos = offset;
            int pad_count;
            string numberString = int_data.ToString(); // Convert integer to string
            pad_count = padded_width - numberString.Length;
//            if (pad_count > 0)
//            {
//                numberString = numberString.PadLeft(pad_count, '0');
//            }
            numberString = numberString.PadLeft(padded_width, '0');
            byte[] byte_array = Encoding.ASCII.GetBytes(numberString);
            Array.Copy(byte_array, 0, byte_data, offset, byte_array.Length);
            pos = offset + byte_array.Length;
            return pos;
        }
        public int WriteMsgHeaderIntoByteArray(byte[] byte_data,int offset,int action, int msg_length, int move_count, int cycle_start)
        {
            int pos = offset;
            byte_data[pos++]   = 64;
            byte_data[pos++] = 64;
            byte_data[pos++] = 64;
            pos = CopyIntIntoByteArray(byte_data, pos, action,2);
            pos = CopyULongIntoByteArray(byte_data, pos, 12254123,20);
            byte_data[pos++] = GetBitPatternFromInt(action, 2);
            byte_data[pos++] = GetBitPatternFromInt(action, 1);
            byte_data[pos++] = 0;
            byte_data[pos++] = 0;
            byte_data[pos++] = GetBitPatternFromInt(msg_length, 1);
            byte_data[pos++] = GetBitPatternFromInt(msg_length, 2);
            byte_data[pos++] = 0;
            byte_data[pos++] = 0;
            byte_data[pos++] = GetBitPatternFromInt(move_count, 1);
            byte_data[pos++] = GetBitPatternFromInt(move_count, 2);
            byte_data[pos++] = 0;
            byte_data[pos++] = 0;
            byte_data[pos++] = GetBitPatternFromInt(cycle_start, 1);
            byte_data[pos++] = GetBitPatternFromInt(cycle_start, 2);
            byte_data[pos++] = 0;
            byte_data[pos++] = 0;
            return pos;
        }

        public int WriteMsgMoveIntoByteArray(byte[] byte_data, int offset, int action, int msg_length, int move_count, int cycle_start)
        {
            int pos = offset;
            byte_data[pos++] = 64;
            byte_data[pos++] = 64;
            byte_data[pos++] = 64;
            byte_data[pos++] = GetBitPatternFromInt(action, 1);
            byte_data[pos++] = GetBitPatternFromInt(msg_length, 1);
            byte_data[pos++] = GetBitPatternFromInt(move_count, 1);
            byte_data[pos++] = GetBitPatternFromInt(cycle_start, 1);
            return pos;
        }

        public byte GetBitPatternFromInt(int m_int, int the_byte)
        {
            byte the_bits = 0;
            int bit_shift = (the_byte - 1) * 8;
            the_bits = ((byte)((m_int >> bit_shift) & 0xFF));
            return the_bits;
        }
        public byte GetBitPatternFromULong(ulong u_long, int the_byte)
        {
            byte the_bits = 0;
            int bit_shift = (the_byte - 1) * 8;
            the_bits = ((byte)((u_long >> bit_shift) & 0xFF));
            return the_bits;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string theData;
            int i;
            byte[] bytes = new byte[1000];
            int offset = 0;
            offset = WriteMsgHeaderIntoByteArray(bytes, offset, 1, 2, 3, 4);
            offset = WriteMsgMoveIntoByteArray(bytes, offset, 11, 12, 13, 14);

            /*
            for (i = 0; i < 90; i++)
            {
                theData += "a";
            }
*/
            //            theData = textBoxCommand.Text;
            //            SendData(theData);
            SendData(bytes);
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

        private void BtnD1Rev_Click(object sender, EventArgs e)
        {

        }

        private void MoveForwardStart_00()
        {

        }
        private void MoveForwardStart_01()
        {

            ExecuteMoveCommand("@@@M" + txtBoxDI_01.Text + "F" + textBoxFreqDI_01.Text);
        }
        private void MoveForwardStart_02()
        {

            ExecuteMoveCommand("@@@M" + txtBoxDI_02.Text + "F" + textBoxFreqDI_02.Text);
        }
        private void MoveForwardStart_03()
        {

            ExecuteMoveCommand("@@@M" + txtBoxDI_03.Text + "F" + textBoxFreqDI_03.Text);
        }
        private void MoveForwardStart_04()
        {

            ExecuteMoveCommand("@@@M" + txtBoxDI_04.Text + "F" + textBoxFreqDI_04.Text);
        }
        private void MoveForwardStart_05()
        {

            ExecuteMoveCommand("@@@M" + txtBoxDI_05.Text + "F" + textBoxFreqDI_05.Text);
        }
        private void MoveForwardStart()
        {

            ExecuteMoveCommand("@@@M"+txtBoxDI_00.Text+"F" + textBoxFreqDI_00.Text);
        }

        private void MoveForwardStop()
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_00.Text);
        }
        private void MoveForwardStop_00()
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_00.Text);
        }
        private void MoveForwardStop_01()
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_01.Text);
        }
        private void MoveForwardStop_02()
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_02.Text);
        }
        private void MoveForwardStop_03()
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_03.Text);
        }
        private void MoveForwardStop_04()
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_04.Text);
        }
        private void MoveForwardStop_05()
        {
        }

        private void MoveReverseStart()
        {
            ExecuteMoveCommand("@@@M"+txtBoxDI_00.Text+"R" + textBoxFreqDI_00.Text);
        }

        private void MoveReverseStart_00()
        {
            ExecuteMoveCommand("@@@M" + txtBoxDI_00.Text + "R" + textBoxFreqDI_00.Text);
        }
        private void MoveReverseStart_01()
        {
            ExecuteMoveCommand("@@@M" + txtBoxDI_01.Text + "R" + textBoxFreqDI_01.Text);
        }
        private void MoveReverseStart_02()
        {
            ExecuteMoveCommand("@@@M" + txtBoxDI_02.Text + "R" + textBoxFreqDI_02.Text);
        }
        private void MoveReverseStart_03()
        {
            ExecuteMoveCommand("@@@M" + txtBoxDI_03.Text + "R" + textBoxFreqDI_03.Text);
        }
        private void MoveReverseStart_04()
        {
            ExecuteMoveCommand("@@@M" + txtBoxDI_04.Text + "R" + textBoxFreqDI_04.Text);
        }
        private void MoveReverseStart_05()
        {
            ExecuteMoveCommand("@@@M" + txtBoxDI_05.Text + "R" + textBoxFreqDI_05.Text);
        }

        private void textBoxFreq_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MoveReverseStop()
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_00.Text);
        }
        private void MoveReverseStop_00()
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_00.Text);
        }
        private void MoveReverseStop_01()
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_01.Text);
        }
        private void MoveReverseStop_02()
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_02.Text);
        }
        private void MoveReverseStop_03()
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_03.Text);
        }
        private void MoveReverseStop_04()
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_04.Text);
        }

        private void btnXFwd_MouseDown(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@M" + txtBoxDI_00.Text + "F" + textBoxFreqDI_00.Text);
        }

        private void btnYFwd_MouseDown(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@M" + txtBoxDI_01.Text + "F" + textBoxFreqDI_01.Text);

        }

        private void btnAFwd_MouseDown(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@M" + txtBoxDI_03.Text + "F" + textBoxFreqDI_03.Text);

        }

        private void btnCFwd_MouseDown(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@M" + txtBoxDI_04.Text + "F" + textBoxFreqDI_04.Text);

        }

        private void btnWFFwd_MouseDown(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@M" + txtBoxDI_05.Text + "F" + textBoxFreqDI_05.Text);

        }

        private void btnXFwd_MouseUp(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_00.Text);
        }

        private void btnYFwd_MouseUp(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_01.Text);

        }

        private void btnZFwd_MouseUp(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_02.Text);

        }

        private void btnAFwd_MouseUp(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_03.Text);

        }

        private void btnCFwd_MouseUp(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_04.Text);

        }

        private void btnWFFwd_MouseUp(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_05.Text);

        }

        private void btnXRev_MouseDown(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@M" + txtBoxDI_00.Text + "R" + textBoxFreqDI_00.Text);
        }

        private void btnYRev_MouseDown(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@M" + txtBoxDI_01.Text + "R" + textBoxFreqDI_01.Text);

        }

        private void btnZRev_MouseDown(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@M" + txtBoxDI_02.Text + "R" + textBoxFreqDI_02.Text);

        }

        private void btnARev_MouseDown(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@M" + txtBoxDI_03.Text + "R" + textBoxFreqDI_03.Text);

        }

        private void btnCRev_MouseDown(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@M" + txtBoxDI_04.Text + "R" + textBoxFreqDI_04.Text);

        }

        private void btnWFRev_MouseDown(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@M" + txtBoxDI_05.Text + "R" + textBoxFreqDI_05.Text);

        }

        private void btnXRev_MouseUp(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_00.Text);

        }

        private void btnYRev_MouseUp(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_01.Text);

        }

        private void btnZRev_MouseUp(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_02.Text);

        }

        private void btnARev_MouseUp(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_03.Text);

        }

        private void btnCRev_MouseUp(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_04.Text);

        }

        private void btnWFRev_MouseUp(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@S" + txtBoxDI_05.Text);

        }

        private void btnXHome_Click(object sender, EventArgs e)
        {
            ExecuteMoveCommand("@@@H00");

        }

        private void btnYHome_Click(object sender, EventArgs e)
        {
            ExecuteMoveCommand("@@@H01");

        }

        private void btnZHome_Click(object sender, EventArgs e)
        {
            ExecuteMoveCommand("@@@H02");

        }

        private void btnAHome_Click(object sender, EventArgs e)
        {
            ExecuteMoveCommand("@@@H03");

        }

        private void btnCHome_Click(object sender, EventArgs e)
        {
            ExecuteMoveCommand("@@@H04");

        }

        private void btnZFwd_MouseDown(object sender, MouseEventArgs e)
        {
            ExecuteMoveCommand("@@@M" + txtBoxDI_02.Text + "F" + textBoxFreqDI_02.Text);

        }

        private void ExecuteMoveCommand(string moveCommand)
        {
            string theData;
            theData = textBoxCommand.Text;
//            SendData(moveCommand);
            listBoxReceived.Items.Add("\r\n"+moveCommand);
            if (listBoxReceived.Items.Count > 12)
            {
                listBoxReceived.Items.RemoveAt(1);
            }
        }
    }
}
