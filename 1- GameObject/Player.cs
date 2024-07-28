using GolgedarEngine;
using SFML.System;
using SFML.Window;
using System.Threading.Tasks;

namespace GolgedarGame.GameObjects
{
    class Player : GameObject
    {
        Vector2f previousPosition;

        public Player() : base("Player.png")
        {
        }

        public override void Draw()
        {
            DrawSelf();
        }
        public override void Loop()
        {
            previousPosition = Position;

            if (Game.IsKeyPressed(Keyboard.Key.W))
            {
                Task.Run(async () =>
                {
                    await Client.writer.WriteLineAsync("W");
                    Move(Vector.Create(0, -100));
                    Client.writer.Flush();
                });
            }
        }

        public override void Collision(GameObject gameObject)
        {
            if (gameObject is Wall)
                Position = previousPosition;
        }
    }
}