using GolgedarEngine;
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
        public static StreamReader reader;
        public static StreamWriter writer;
        NetworkStream stream;

        public Client() : base(canCollide: false)
        {
            client = new TcpClient()
            {
                SendTimeout = 10000
            };
            client.Connect(new IPEndPoint(IPAddress.Parse(SERVER_HOST), SERVER_PORT));

            stream = client.GetStream();
            reader = new(stream, Encoding.UTF8);
            writer = new(stream, Encoding.UTF8);
        }

        public override void Draw()
        {

        }
        public override void Loop()
        {
        }
    }
}