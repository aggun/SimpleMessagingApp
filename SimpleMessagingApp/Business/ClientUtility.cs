using SimpleMessagingApp.Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SimpleMessagingApp.Business
{
    public static class ClientUtility
    {
        public static async Task SendMessage(ClientRequest clientRequest)
        {
            await StartClientAsync(clientRequest);
        }

        static async Task StartClientAsync(ClientRequest clientRequest)
        {
            TcpClient client = new TcpClient();

            try
            {
                await client.ConnectAsync(clientRequest.IpAdress, clientRequest.Port);
                Console.WriteLine($"Connected to server at {clientRequest.IpAdress}:{clientRequest.Port}");

                using NetworkStream stream = client.GetStream();

                byte[] data = Encoding.UTF8.GetBytes(clientRequest.Message);
                await stream.WriteAsync(data, 0, data.Length);

                Console.WriteLine($"Sent: {clientRequest.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}