using GolgedarEngine;
using SFML.Graphics;
using SFML.System;

namespace GolgedarGame.GameObjects
{
   class Character : GameObject, IPusher
   {
      readonly RectangleShape healthBar_outline;
      readonly RectangleShape healthBar_back;
      readonly RectangleShape healthBar_fill;

      public int MaxHealth { get => maxHealth; set { maxHealth = value; if (Health == 0) Health = value; } }
      public int Health { get; set; }
      public uint Weight => 10;

      public Character() : base("Player.png")
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
         Vector2f previousPosition = Position;
      }

      public override void Collision(GameObject gameObject)
      {
      }

      private int maxHealth;
   }
}