using GolgedarEngine;

namespace GolgedarGame.GameObjects
{
    class Wall : GameObject
    {
        public Wall() : base("Wall.png")
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
