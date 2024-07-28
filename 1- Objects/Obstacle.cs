using GolgedarEngine;

namespace GolgedarServer

{
    class Obstacle : GameObject
    {
        public Obstacle() : base(Resources.SPRITE_OBSTACLE)
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
