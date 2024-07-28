using System.Collections.Immutable;

namespace GolgedarServer
{
    class Resources
    {
        public const string SPRITE_PLAYER = "Player.png";
        public const string SPRITE_OBSTACLE = "Obstacle.png";

        public static readonly ImmutableList<string> IMAGES = [SPRITE_PLAYER, SPRITE_OBSTACLE];
    }
}