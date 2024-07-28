using GolgedarEngine;
using GolgedarServer.EngineAddOn;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace GolgedarServer.GameObjects
{
    class Player : ConnectedGameObject
    {
        Vector2f previousPosition;

        public Player(int connectionID) : base(connectionID, Resources.SPRITE_PLAYER)
        {
            PreviousPosition = Position;
        }

        public override void Draw()
        {
            DrawSelf();
        }
        public override void Loop()
        {
            PreviousPosition = Position;
        }

        public override void Collision(GameObject gameObject)
        {
            if (gameObject is Obstacle)
                Position = PreviousPosition;
        }

        public Vector2f PreviousPosition { get => previousPosition; set => previousPosition = value; }
    }
}