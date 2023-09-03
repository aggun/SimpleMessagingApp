using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SimpleMessagingApp.Data.Dto;

namespace SimpleMessagingApp.Business
{
    public class ServerUtility
    {
        public static async Task Listen(ClientRequest clientRequest)
        {
            await StartServerAsync(clientRequest);
        }

        static async Task StartServerAsync(ClientRequest clientRequest)
        {
            IPAddress ipAddress = IPAddress.Parse(clientRequest.IpAdress);

            var listener = new TcpListener(ipAddress, clientRequest.Port);
            try
            {
                listener.Start();
                Console.WriteLine($"Server started on port {clientRequest.Port}");

                while (true)
                {
                    TcpClient client = await listener.AcceptTcpClientAsync();
                    _ = HandleClientAsync(client);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static async Task HandleClientAsync(TcpClient client)
        {
            string clientIP = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
            Console.WriteLine($"Connected to client at {clientIP}");

            using (NetworkStream stream = client.GetStream())
            {
                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    string data = System.Text.Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    Console.WriteLine($"Received: {data}");
                }
            }

            client.Close();
            client.Dispose();
            Console.WriteLine($"Client at {clientIP} disconnected");
        }
    }
}