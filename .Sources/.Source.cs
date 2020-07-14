using System.Collections.Immutable;

namespace GolgedarGame
{
   class Source
   {
      public static ImmutableList<string> Images { get; } = ImmutableList.Create("Player.png",
                                                                                 "Wall.png");
   }
}