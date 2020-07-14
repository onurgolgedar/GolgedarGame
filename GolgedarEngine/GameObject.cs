using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace GolgedarEngine
{
   class GameObject
   {
      internal GameObject(Game game, string imageName)
      {
         Game = game;
         Sprite = new Sprite(Global.GetSprite(imageName));
      }

      internal virtual void Draw()
      {
      }
      internal virtual void Loop()
      {
      }

      public void Move(Vector2f displacement)
      {
         Sprite.Position += new Vector2f(displacement.X, displacement.Y) / 1000 * Game.DeltaTime;
      }
      public void SetPosition(Vector2f position)
      {
         Sprite.Position = new Vector2f(position.X, position.Y);
      }

      public Game Game { get; internal set; }
      public Sprite Sprite { get; internal set; }
   }
}