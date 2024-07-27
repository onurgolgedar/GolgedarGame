using GolgedarEngine;
using Microsoft.VisualBasic.Devices;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GolgedarGame
{
    class Client : GameObject
    {
        public const int SERVER_PORT = 64198;
        public const string SERVER_HOST = "127.0.0.1";

        TcpClient client;
        StreamReader reader;
        StreamWriter writer;
        NetworkStream stream;

        public Client() : base(canCollide: false)
        {
            client = new TcpClient(new IPEndPoint(IPAddress.Parse(SERVER_HOST), SERVER_PORT))
            {
                SendTimeout = 10000
            };

            stream = client.GetStream();
            reader = new(stream, Encoding.UTF8);
            writer = new(stream, Encoding.UTF8);
        }

        public override void Draw()
        {

        }
        public override void Loop()
        {
            if (Game.IsKeyPressed(SFML.Window.Keyboard.Key.Enter))
            {
                Task.Run(async () =>
                {
                    await writer.WriteLineAsync("Selam");
                    writer.Flush();
                });
            }
        }
    }
}