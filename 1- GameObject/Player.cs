using GolgedarEngine;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace GolgedarGame.GameObjects
{
    class Player : GameObject
    {
        public string IP { get => ip; set => ip = value; }
        public Vector2f PreviousPosition { get => previousPosition; set => previousPosition = value; }

        public Player() : base("Player.png")
        {
            PreviousPosition = Position;
        }

        public override void Draw()
        {
            DrawSelf();
        }
        public override void Loop()
        {
            PreviousPosition = Position;

            Vector2f speed = new Vector2f();
            if (Game.CheckKey(Keyboard.Key.W))
                speed += 250 * Vector.Up;
            if (Game.CheckKey(Keyboard.Key.A))
                speed += 250 * Vector.Left;
            if (Game.CheckKey(Keyboard.Key.S))
                speed += 250 * Vector.Down;
            if (Game.CheckKey(Keyboard.Key.D))
                speed += 250 * Vector.Right;

            Move(speed);

            if (speed != new Vector2f(0, 0))
                Sprite.Rotation = (float)Vector.GetDirection(speed);
        }

        public override void Collision(GameObject gameObject)
        {
            if (gameObject is Wall)
                Position = PreviousPosition;
        }

        Vector2f previousPosition;
        string ip;
    }
}