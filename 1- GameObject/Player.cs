using GolgedarEngine;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

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

            Vector2f speed = new();
            if (Game.CheckKey(Keyboard.Key.W))
                speed += 250 * Vector.Up;
            if (Game.CheckKey(Keyboard.Key.A))
                speed += 250 * Vector.Left;
            if (Game.CheckKey(Keyboard.Key.S))
                speed += 350 * Vector.Down;
            if (Game.CheckKey(Keyboard.Key.D))
                speed += 350 * Vector.Right;

            Move(speed);

            if (speed != new Vector2f(0, 0))
                Sprite.Rotation = (float)Vector.GetDirection(speed);
        }

        public override void Collision(GameObject gameObject)
        {
            if (gameObject is Wall)
                Position = previousPosition;
        }
    }
}