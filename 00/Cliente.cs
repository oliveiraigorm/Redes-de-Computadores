using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace Client
{
    class Program
    {
        const int PORT_NO = 12345;
        const string SERVER_IP = "oliveiraigorm.ddns.net";
        static void Main(string[] args)
        {
            //---data to send to the server---
            string textToSend = @"C:\Users\Aluno\Desktop\file.txt";
			

            //---create a TCPClient object at the IP and port no.---
            TcpClient client = new TcpClient(SERVER_IP, PORT_NO);
            NetworkStream nwStream = client.GetStream();
            byte[] bytesToSend = System.IO.File.ReadAllBytes(textToSend);

            //---send the text---
            Console.WriteLine("Enviando : " + textToSend);
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);
        }
    }
}
