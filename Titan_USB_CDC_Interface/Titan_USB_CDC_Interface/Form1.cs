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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Titan_USB_CDC_Interface
{
    public partial class Form1 : Form
    {
        string[] ports;
        private SerialPort mySerialPort;
        TextBox[] text_box_drive = new TextBox[10];
        TextBox[] text_box_freq = new TextBox[10];
        TextBox[] text_box_steps = new TextBox[10];
        ComboBox[] cb_move_type = new ComboBox[10];


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
            int i,k;
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
            text_box_drive[0] = textBoxCBDrive00;
            text_box_drive[1] = textBoxCBDrive01;
            text_box_drive[2] = textBoxCBDrive02;
            text_box_drive[3] = textBoxCBDrive03;
            text_box_drive[4] = textBoxCBDrive04;
            text_box_drive[5] = textBoxCBDrive05;
            text_box_drive[6] = textBoxCBDrive06;
            text_box_drive[7] = textBoxCBDrive07;
            text_box_drive[8] = textBoxCBDrive08;
            text_box_drive[9] = textBoxCBDrive09;
            text_box_freq[0] = textBoxCBFreq00;
            text_box_freq[1] = textBoxCBFreq01;
            text_box_freq[2] = textBoxCBFreq02;
            text_box_freq[3] = textBoxCBFreq03;
            text_box_freq[4] = textBoxCBFreq04;
            text_box_freq[5] = textBoxCBFreq05;
            text_box_freq[6] = textBoxCBFreq06;
            text_box_freq[7] = textBoxCBFreq07;
            text_box_freq[8] = textBoxCBFreq08;
            text_box_freq[9] = textBoxCBFreq09;
            text_box_steps[0] = textBoxCBClockCycleTarget00;
            text_box_steps[1] = textBoxCBClockCycleTarget01;
            text_box_steps[2] = textBoxCBClockCycleTarget02;
            text_box_steps[3] = textBoxCBClockCycleTarget03;
            text_box_steps[4] = textBoxCBClockCycleTarget04;
            text_box_steps[5] = textBoxCBClockCycleTarget05;
            text_box_steps[6] = textBoxCBClockCycleTarget06;
            text_box_steps[7] = textBoxCBClockCycleTarget07;
            text_box_steps[8] = textBoxCBClockCycleTarget08;
            text_box_steps[9] = textBoxCBClockCycleTarget09;
            cb_move_type[0] = comboBoxCBMoveType00;
            cb_move_type[1] = comboBoxCBMoveType01;
            cb_move_type[2] = comboBoxCBMoveType02;
            cb_move_type[3] = comboBoxCBMoveType03;
            cb_move_type[4] = comboBoxCBMoveType04;
            cb_move_type[5] = comboBoxCBMoveType05;
            cb_move_type[6] = comboBoxCBMoveType06;
            cb_move_type[7] = comboBoxCBMoveType07;
            cb_move_type[8] = comboBoxCBMoveType08;
            cb_move_type[9] = comboBoxCBMoveType09;
            const int MAX_MOVE_TYPES = 8;

            ComboBoxItem[] combo_box_item = new ComboBoxItem[MAX_MOVE_TYPES];
            for(i=0; i < MAX_MOVE_TYPES; i++)
            {
                combo_box_item[i] = new ComboBoxItem();
            }
            combo_box_item[0].Text = "MOVE_TYPE_CLOCK_COUNT_NO_OUTPUT";
            combo_box_item[0].Value = "0";
            combo_box_item[1].Text = "MOVE_TYPE_CLOCK_COUNT_STOP";
            combo_box_item[1].Value = "1";
            combo_box_item[2].Text = "MOVE_TYPE_HOME";
            combo_box_item[2].Value = "2";
            combo_box_item[3].Text = "MOVE_TYPE_HOME_HOMING_BACK_OFF";
            combo_box_item[3].Value = "3";
            combo_box_item[4].Text = "MOVE_TYPE_CONTINUOUS_FWD";
            combo_box_item[4].Value = "4";
            combo_box_item[5].Text = "MOVE_TYPE_CONTINUOUS_REV";
            combo_box_item[5].Value = "5";
            combo_box_item[6].Text = "MOVE_TYPE_CLOCK_COUNT_FWD";
            combo_box_item[6].Value = "6";
            combo_box_item[7].Text = "MOVE_TYPE_CLOCK_COUNT_REV";
            combo_box_item[7].Value = "7";

            for (i=0;i<10;i++)
            {
                cb_move_type[i].Items.Clear();
                for (k = 0; k < combo_box_item.Count(); k++)
                {
                    cb_move_type[i].Items.Add(combo_box_item[k]);
                }
//                cb_move_type[i].Items.Add("0 - MOVE_TYPE_CLOCK_COUNT_NO_OUTPUT");
//                cb_move_type[i].Items.Add("1 - MOVE_TYPE_HOME");
//                cb_move_type[i].Items.Add("2 - MOVE_TYPE_CONTINUOUS_FWD");
//                cb_move_type[i].Items.Add("3 - MOVE_TYPE_CONTINUOUS_REV");
//                cb_move_type[i].Items.Add("4 - MOVE_TYPE_CLOCK_COUNT_FWD");
//                cb_move_type[i].Items.Add("5 - MOVE_TYPE_CLOCK_COUNT_REV");
            }
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public override string ToString() => Text; // Ensures the display text is shown in the ComboBox
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
            byte_data[pos] = 0;
            pos++;
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
            numberString = numberString.PadLeft(padded_width, '0');
            byte[] byte_array = Encoding.ASCII.GetBytes(numberString);
            Array.Copy(byte_array, 0, byte_data, offset, byte_array.Length);
            pos = offset + byte_array.Length;
            byte_data[pos] = 0;
            pos++;
            return pos;
        }
        public int WriteMsgHeaderIntoByteArray(byte[] byte_data,int offset, int move_count, int cycle_start)
        {
            int pos = offset;
            byte_data[pos++]   = 64;
            byte_data[pos++] = 64;
            byte_data[pos++] = 64;
            pos = CopyIntIntoByteArray(byte_data, pos, move_count, 2);
            pos = CopyIntIntoByteArray(byte_data, pos, cycle_start, 1);
            return pos;
        }

        public int WriteMsgMoveIntoByteArray(byte[] byte_data, int offset, int drive, int type, int frequency, int clock_cycle_target)
        {
            int pos = offset;
            pos = CopyIntIntoByteArray(byte_data, pos, drive, 1);
            pos = CopyIntIntoByteArray(byte_data, pos, type, 1);
            pos = CopyIntIntoByteArray(byte_data, pos, frequency, 6);
            pos = CopyIntIntoByteArray(byte_data, pos, clock_cycle_target, 6);
            return pos;
        }

        private void ZeroByteArray(byte[] byte_array)
        {
            int i;
            for(i=0; i<byte_array.Length;i++)
            {
                byte_array[i] = 0;
            }
        }


        private int CopyTextBoxIntoBuffer(byte[] byte_array, int the_offset, TextBox theTxtBox)
        {
            int pos = the_offset;
            string the_text = theTxtBox.Text;
            byte[] txt_byte_array = System.Text.Encoding.UTF8.GetBytes(the_text);
            Array.Copy(txt_byte_array, 0, byte_array, pos, txt_byte_array.Length);
            pos += txt_byte_array.Length;
            return pos;
        }
        private int CopyTextBoxIntoBufferAsOneByteInt(byte[] byte_array, int the_offset, TextBox theTxtBox)
        {
            int pos = the_offset;
            string the_text = theTxtBox.Text;
            int the_number = int.Parse(the_text);
            char a_char = (char)the_number;
            byte_array[pos++] = ((byte)a_char);
            byte_array[pos++] = 0;
            return pos;
        }


        private void buttonSend_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[500];
            int offset = 0;
            int i = 0;
            int drive, move_type, freq, cycle_count,move_count,cycle_start;
            ZeroByteArray(bytes);
            move_count = int.Parse(textBoxMoveCount.Text);
            cycle_start = int.Parse(textBoxCycleStart.Text);
            offset = WriteMsgHeaderIntoByteArray(bytes, offset, move_count, cycle_start);
            for(i=0;i<move_count;i++)
            {
                drive = int.Parse(text_box_drive[i].Text);
                freq = int.Parse(text_box_freq[i].Text);
                cycle_count = int.Parse(text_box_steps[i].Text);
                move_type = int.Parse(((ComboBoxItem)(cb_move_type[i].SelectedItem)).Value);
                offset = WriteMsgMoveIntoByteArray(bytes, offset, drive, move_type, freq, cycle_count);
            }
            
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

        private void btnRefreshPortList_Click(object sender, EventArgs e)
        {
            string[] ports = GetPortList();
            comboBoxSerialPort.Items.Clear();
            foreach (string port in ports)
            {
                comboBoxSerialPort.Items.Add(port);
            }

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
