using GolgedarEngine;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace GolgedarGame.GameObjects
{
    class Player : GameObject
    {
        readonly RectangleShape healthBar_outline;
        readonly RectangleShape healthBar_back;
        readonly RectangleShape healthBar_fill;
        Vector2f previousPosition;

        public int MaxHealth { get => maxHealth; set { maxHealth = value; if (Health == 0) Health = value; } }
        public int Health { get; set; }
        public uint Weight => 50;

        public Player() : base("Player.png")
        {
            MaxHealth = 100;

            healthBar_outline = new RectangleShape();
            healthBar_outline.Size = new Vector2f(100, 20);
            healthBar_outline.FillColor = Color.Black;

            healthBar_back = new RectangleShape(healthBar_outline);
            healthBar_back.Size += new Vector2f(-6, -6);
            healthBar_back.FillColor = Color.White;

            healthBar_fill = new RectangleShape(healthBar_back);
            healthBar_fill.FillColor = Color.Red;

            previousPosition = Position;
        }

        public override void Draw()
        {
            DrawSelf();

            healthBar_outline.Position = Sprite.Position + new Vector2f(-50, -60);

            healthBar_back.Position = healthBar_outline.Position + new Vector2f(3, 3);
            healthBar_fill.Position = healthBar_back.Position;

            Game.Window.Draw(healthBar_outline);
            Game.Window.Draw(healthBar_fill);
        }
        public override void Loop()
        {
            previousPosition = Position;
            Vector2f speed = new Vector2f();

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
            {
                gameObject.Position += new Vector2f(4, 4);
            }
        }

        private int maxHealth;
    }
}