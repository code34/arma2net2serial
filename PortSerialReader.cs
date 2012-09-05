using System;
using System.IO.Ports;
using Arma2Net.AddInProxy;

namespace PortSerialReader
{
    [AddIn("PortSerialRead")]
    public class PortSerialRead : AddIn
    {
        public override string Invoke(string args, int maxResultSize)
        {
        SerialPort _serialPort;

        _serialPort = new SerialPort();
        _serialPort.PortName = "COM17";
        _serialPort.ReadTimeout = 500;
        _serialPort.WriteTimeout = 500;

        _serialPort.Open();
        string _message = _serialPort.Realine();
        _serialPort.Close();
        return _message;
        }
    }
}