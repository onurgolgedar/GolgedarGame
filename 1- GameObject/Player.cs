using GolgedarEngine;
using SFML.System;

namespace GolgedarGame.GameObjects
{
    class Player : GameObject
    {
        Vector2f previousPosition;

        public Player() : base("Player.png")
        {
        }

        public override void Draw()
        {
            DrawSelf();
        }
        public override void Loop()
        {
            previousPosition = Position;
        }

        public override void Collision(GameObject gameObject)
        {
            if (gameObject is Wall)
                Position = previousPosition;
        }
    }
}