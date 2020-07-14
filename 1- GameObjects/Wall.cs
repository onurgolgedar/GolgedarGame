using GolgedarEngine;

namespace GolgedarGame.GameObjects
{
   class Wall : GameObject
   {
      internal Wall() : base("Wall.png")
      {
      }

      public override void Draw()
      {
         DrawSelf();
      }
      public override void Loop()
      {
      }
   }
}
