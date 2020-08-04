using GolgedarEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace GolgedarGame
{
   class BlackWall : GameObject
   {
      bool draw = true;

      public BlackWall () : base("Wall.png")
      {

      }

      public override void Draw()
      {
         if (draw)
            DrawSelf();
      }

      public override void Loop()
      {
         if (Game.IsKeyPressed(SFML.Window.Keyboard.Key.End))
         {
            draw = false;
         }
      }
   }
}
