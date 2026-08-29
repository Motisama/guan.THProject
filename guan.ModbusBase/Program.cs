using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//引入命名空间
using System.IO.Ports;
using System.Threading;

namespace guan.ModbusBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SerialPort port1 = new SerialPort();

            //设置属性96n81
            port1.PortName = "COM3";
            port1.BaudRate= 9600;
            port1.Parity = Parity.None;
            port1.DataBits = 8;
            port1.StopBits = StopBits.One;

            //打开串口
            port1.Open();

            //拼接报文
            List<byte> sendBytes=new List<byte>();
            sendBytes.Add(0x01);
            sendBytes.Add(0x03);
            sendBytes.Add(0x00);
            sendBytes.Add(0x00);
            sendBytes.Add(0x00);
            sendBytes.Add(0x02);

            //crc校验
            sendBytes.Add(0xc4); 
            sendBytes.Add(0x0b);

            //发送报文
            port1.Write(sendBytes.ToArray(),0,sendBytes.Count);

            //接收报文
            Thread.Sleep(100);//需要一定延时

            byte[] receiveBytes = null;

           //验证+发送+接收
            if (receiveBytes[0] == 0x01)
            {
                double humidity;
                double temperature;
                while (true)
                {
                    //重复发送+接收
                    Thread.Sleep(1000);//1秒循环
                    port1.Write(sendBytes.ToArray(), 0, sendBytes.Count);
                    Thread.Sleep(100);//需要一定延时
                    receiveBytes = new byte[port1.BytesToRead];
                    port1.Read(receiveBytes, 0, receiveBytes.Length);

                    //重复解读
                    humidity = (receiveBytes[3] * 256 + receiveBytes[4]) / 10.0;
                    temperature = (receiveBytes[5] * 256 + receiveBytes[6]) / 10.0;
                    Console.WriteLine($"温度：{temperature}℃   湿度：{humidity}％");
                }
            }
        }
    }
}
