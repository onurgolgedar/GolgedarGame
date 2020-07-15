using GolgedarEngine;
using SFML.Window;

namespace GolgedarGame
{
   class MainControl : GameObject
   {
      public MainControl() : base()
      {
      }

      public override void Draw()
      {

      }
      public override void Loop()
      {
         if (Game.IsKeyPressed(Keyboard.Key.Enter) && Game.CheckKey(Keyboard.Key.LAlt))
         {
            if (Game.IsFullScreen)
               Game.SetWindow(1920, 1080);
            else
               Game.SetWindow();
         }
         else if (Game.IsKeyPressed(Keyboard.Key.Right))
            Game.LoadNextRoom();
         else if (Game.IsKeyPressed(Keyboard.Key.Left))
            Game.LoadPreviousRoom();
      }
   }
}