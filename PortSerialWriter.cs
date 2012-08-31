using System;
using System.IO.Ports;
using Arma2Net.AddInProxy;

namespace PortSerialWriter
{
    [AddIn("PortSerialWrite")]
    public class PortSerialWrite : AddIn
    {
        public override string Invoke(string args, int maxResultSize)
        {
        SerialPort _serialPort;

        _serialPort = new SerialPort();
        _serialPort.PortName = "COM17";
        _serialPort.ReadTimeout = 500;
        _serialPort.WriteTimeout = 500;

        _serialPort.Open();
        _serialPort.WriteLine(args);
        _serialPort.Close();
        return args;
        }
    }
}