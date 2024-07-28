using System.Collections.Immutable;

namespace GolgedarClient
{
    class Resources
    {
        public const string SPRITE_PLAYER = "Player.png";
        public const string SPRITE_WALL = "Wall.png";

        public static readonly ImmutableList<string> IMAGES = [SPRITE_PLAYER, SPRITE_WALL];
    }
}