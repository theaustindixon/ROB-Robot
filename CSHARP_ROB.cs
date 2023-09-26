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
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create the serial port with basic settings
            SerialPort mySerialPort = new SerialPort("COM4", 9600);

            mySerialPort.Open();
            string myInput = "1";
            mySerialPort.Write(myInput);
            mySerialPort.Close();
        }
      


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create the serial port with basic settings
            SerialPort mySerialPort = new SerialPort("COM4", 9600);

            mySerialPort.Open();
            string myInput = "5";
            mySerialPort.Write(myInput);
            mySerialPort.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Create the serial port with basic settings
            SerialPort mySerialPort = new SerialPort("COM4", 9600);

            mySerialPort.Open();
            string myInput = "4";
            mySerialPort.Write(myInput);
            mySerialPort.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Create the serial port with basic settings
            SerialPort mySerialPort = new SerialPort("COM4", 9600);

            mySerialPort.Open();
            string myInput = "6";
            mySerialPort.Write(myInput);
            mySerialPort.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Create the serial port with basic settings
            SerialPort mySerialPort = new SerialPort("COM4", 9600);

            mySerialPort.Open();
            string myInput = "3";
            mySerialPort.Write(myInput);
            mySerialPort.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Create the serial port with basic settings
            SerialPort mySerialPort = new SerialPort("COM4", 9600);

            mySerialPort.Open();
            string myInput = "7";
            mySerialPort.Write(myInput);
            mySerialPort.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Create the serial port with basic settings
            SerialPort mySerialPort = new SerialPort("COM4", 9600);

            mySerialPort.Open();
            string myInput = "8";
            mySerialPort.Write(myInput);
            mySerialPort.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create the serial port with basic settings
            SerialPort mySerialPort = new SerialPort("COM4", 9600);

            mySerialPort.Open();
            string myInput = "2";
            mySerialPort.Write(myInput);
            mySerialPort.Close();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter Key Pressed ");
            }
            // Create the serial port with basic settings
            SerialPort mySerialPort = new SerialPort("COM4", 9600);

            mySerialPort.Open();
            string myInput = "6";
            mySerialPort.Write(myInput);
            mySerialPort.Close();
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter Key Pressed ");

                // Create the serial port with basic settings
                SerialPort mySerialPort = new SerialPort("COM4", 9600);

                mySerialPort.Open();
                string myInput = "6";
                mySerialPort.Write(myInput);
                mySerialPort.Close();
            }
        }

        private void True(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
    }

