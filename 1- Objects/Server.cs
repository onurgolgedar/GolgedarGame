using GolgedarEngine;
using SFML.Window;
using System.Collections.Generic;
using System.Linq;
using Vector = GolgedarEngine.Vector;

namespace GolgedarServer
{
    internal class Server : GolgedarEngine.Server
    {
        public override void Loop()
        {
            if (Game.CheckKey(Keyboard.Key.W))
            {
                Users.ForEach(user =>
                {
                    Player player = user.ConnectedObjects.FirstOrDefault() as Player;
                    if (player != null)
                    {
                        Send(user, 'P', player.Position.X);
                        Send(user, 'P', 231f);
                        Send(user, 'P', 231.8);
                        Send(user, 'P', '2');
                        Send(user, 'P', "selam");
                    }
                });
            }

            if (Game.CheckKey(Keyboard.Key.T))
            {
                Users.ForEach(user =>
                {
                    Send(user, 'T', new Obstacle());
                });
            }
        }

        public override void Process(User user, int code, string data, string typeName)
        {
            base.Process(user, code, data, typeName);
        }

        public override void Process(User user, int code, char data)
        {
            base.Process(user, code, data);

            Player player;
            switch (code)
            {
                case 'K':
                    switch (data)
                    {
                        case 'W':
                            player = user.ConnectedObjects.FirstOrDefault() as Player;
                            player?.Move(Vector.Create(0, -150));
                            break;

                        case 'A':
                            player = user.ConnectedObjects.FirstOrDefault() as Player;
                            player?.Move(Vector.Create(-150, 0));
                            break;

                        case 'S':
                            player = user.ConnectedObjects.FirstOrDefault() as Player;
                            player?.Move(Vector.Create(0, 150));
                            break;

                        case 'D':
                            player = user.ConnectedObjects.FirstOrDefault() as Player;
                            player?.Move(Vector.Create(150, 0));
                            break;
                    }
                    break;
            }
        }

        public override void Process(User user, int code, int data)
        {
            base.Process(user, code, data);

            Player player;
            switch (code)
            {
                case 'Y':
                    player = user.ConnectedObjects.FirstOrDefault() as Player;
                    player?.Move(Vector.Create(0, data));
                    break;
            }
        }

        public override void Process(User user, int code, float data)
        {
            base.Process(user, code, data);
        }

        public override void Process(User user, int code, double data)
        {
            base.Process(user, code, data);
        }

        public override void Process(User user, int code, string data)
        {
            base.Process(user, code, data);
        }

        public override void Process(User user, int code)
        {
            base.Process(user, code);
        }

        public override void Connected(User user)
        {
            base.Connected(user);

            Player player = new(user.ConnectionID);
            Game.RoomData.PutInstance(player, Vector.Create(100, 100));

            user.ConnectedObjects.Clear();
            user.ConnectedObjects.Add(player);
        }
    }
}
