using SFML.Window;

namespace GolgedarClient
{
    public class Client : GolgedarEngine.Client
    {
        public override void Loop()
        {
            if (Game.CheckKey(Keyboard.Key.W))
                Send('K', 'W');

            if (Game.CheckKey(Keyboard.Key.A))
                Send('K', 'A');

            if (Game.CheckKey(Keyboard.Key.S))
                Send('K', 'S');

            if (Game.CheckKey(Keyboard.Key.D))
                Send('K', 'D');

            if (Game.IsKeyPressed(Keyboard.Key.Q))
                Send('Q');
        }
    }
}
