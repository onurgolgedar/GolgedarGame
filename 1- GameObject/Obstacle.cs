using GolgedarEngine;

namespace GolgedarServer.GameObjects
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
