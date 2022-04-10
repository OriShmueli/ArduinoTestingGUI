using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace ArduinoTestingGUI
{
    
    class SerialPortConnection
    {
        
        public static SerialPort SerialPort = new SerialPort();

        public void InitializeSerialPort()
        {
            //serialPort = new SerialPort(currentPort, baundRate, parity, dataBits, stopBits);
            SerialPort.PortName = CurrentPort; 
            SerialPort.BaudRate = BaudRate; 
            SerialPort.Parity = Parity;
            SerialPort.StopBits = StopBits;
            SerialPort.Handshake = HandShake;
            SerialPort.DataBits = DataBits;
        }

        public bool Connect()
        {
            InitializeSerialPort();
            SerialPort.Open();
            
            try
            {
                //SerialPort.Write("OFF");
                //MessageBox.Show("Connected to port. PortName: " + serialPort.PortName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Disconnect()
        {
            try
            {
                SerialPort.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error in disconnecting: " + ex.Data);
            }
            
        }

        public string[] GetPortsNames()
        {
            string[] ports = SerialPort.GetPortNames();
            return ports;
        }

        public void SendData(string text)
        {
            
            try
            {
                SerialPort.Write(text + "\n");
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("pleas connect to a port. err: " + ex.Data);
                
            }
            
        }

        public void GetData()
        {
            SerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            GetReceivedData = sp.ReadExisting();
        }

        public string GetReceivedData { get; set; }

        private string[] _data;
        public string MultiData(int num)
        {
            _data = SerialPort.ReadLine().Split(',');
            string a =_data[num];
            return a;
        }
        
        public  string CurrentPort { get; set; } //COMS
        public  int BaudRate { get; set; } //9600...
        public  Parity Parity { get; set; } //none
        public  int DataBits { get; set; } //use 8
        public  StopBits StopBits {get; set;} //one
        public  Handshake HandShake{ get; set; } //0, 1, 2, 3
    }
}
