using GolgedarEngine;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;

namespace GolgedarGame.GameObjects
{
   class Player : GameObject
   {
      public Player() : base("Player.png")
      {
      }

      public override void Draw()
      {
         DrawSelf();
      }
      public override void Loop()
      {
         Vector2f speed = new Vector2f(0, 0);

         if (Game.CheckKey(Keyboard.Key.W))
            speed += 200 * Vectors.Up;
         if (Game.CheckKey(Keyboard.Key.A))
            speed += 200 * Vectors.Left;
         if (Game.CheckKey(Keyboard.Key.S))
            speed += 200 * Vectors.Down;
         if (Game.CheckKey(Keyboard.Key.D))
            speed += 200 * Vectors.Right;

         Move(speed);

         if (speed != new Vector2f(0, 0))
            Sprite.Rotation = (float)(Global.ToDegrees(Math.Atan2(speed.Y, speed.X)));
      }
   }
}