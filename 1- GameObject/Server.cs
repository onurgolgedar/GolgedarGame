using GolgedarEngine;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using GolgedarGame.GameObjects;

namespace GolgedarGame
{
    class Server : GameObject
    {
        public const int SERVER_PORT = 64198;

        TcpListener listener;
        List<TcpClient> clients;

        public Server() : base(canCollide: false)
        {
            clients = new List<TcpClient>();

            listener = new TcpListener(new IPEndPoint(IPAddress.Any, SERVER_PORT));
            listener.Start();

            Console.WriteLine($"The server has been started.");

            Listen();
        }

        private async void Listen()
        {
            while (true)
            {
                TcpClient tcpClient = await listener.AcceptTcpClientAsync();

                string ip = (tcpClient.Client.RemoteEndPoint as IPEndPoint).Address.ToString();

                Console.WriteLine($"A user has been connected {ip}");
                _ = HandleClientAsync(tcpClient);
            }
        }

        private async Task HandleClientAsync(TcpClient client)
        {
            using (client)
            {
                string ip = (client.Client.RemoteEndPoint as IPEndPoint).Address.ToString();

                NetworkStream stream = client.GetStream();
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                StreamWriter writer = new StreamWriter(stream, Encoding.UTF8);

                while (true)
                {
                    string message = await reader.ReadLineAsync();
                    if (message == null)
                    {
                        Console.WriteLine($"{ip}: null");
                        continue;
                    }

                    bool isRequestProcessed = false;

                    if (message == "W")
                    {
                        foreach (GameObject gameObject in Game.ActiveGame.ActiveRoom.Instances_SortedByCreation.Values)
                        {
                            Player player = gameObject as Player;
                            if (player == null)
                                continue;

                            if (player.IP == ip)
                            {
                                gameObject.Move(Vector.Create(0, -100));
                                isRequestProcessed = true;
                                break;
                            }
                        }
                    }

                    if (!isRequestProcessed)
                    {
                        Player player = new Player();
                        player.Position = new SFML.System.Vector2f(100, 100);
                        player.Depth = 0;
                        player.IP = ip;
                        Game.ActiveRoom.Instances_SortedByDepth.Add(player);
                        Game.ActiveRoom.Instances_SortedByCreation.TryAdd(Game.ActiveRoom.Instances_SortedByCreation.Count, player);
                    }

                    Console.WriteLine($"{ip}: {message}");
                }
            }
        }

        public override void Draw()
        {

        }
        public override void Loop()
        {

        }
    }
}