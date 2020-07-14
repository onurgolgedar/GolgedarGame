using GolgedarEngine;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;

namespace GolgedarGame.GameObjects
{
   class Player : GameObject
   {
      readonly RectangleShape healthBar_outline;
      readonly RectangleShape healthBar_back;
      readonly RectangleShape healthBar_fill;

      public int MaxHealth { get => maxHealth; set { maxHealth = value; if (Health == 0) Health = value; } }
      public int Health { get; set; }

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
         Vector2f speed = new Vector2f(0, 0);

         if (Game.CheckKey(Keyboard.Key.W))
            speed += 200 * Vector.Up;
         if (Game.CheckKey(Keyboard.Key.A))
            speed += 200 * Vector.Left;
         if (Game.CheckKey(Keyboard.Key.S))
            speed += 200 * Vector.Down;
         if (Game.CheckKey(Keyboard.Key.D))
            speed += 200 * Vector.Right;

         Move(speed);

         if (speed != new Vector2f(0, 0))
            Sprite.Rotation = Vector.GetDirection(speed);
      }

      private int maxHealth;
   }
}