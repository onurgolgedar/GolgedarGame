using GolgedarEngine;
using GolgedarGame.GameObjects;

namespace GolgedarGame
{
   public class RoomModel : RoomData
   {
      public const string FIRST_ROOM = "First Room";
      public const string SECOND_ROOM = "Second Room";

      public RoomModel() : base()
      {
      }

      public override void Load(string roomName)
      {
         Instances_SortedByDepth.Clear();
         Instances_SortedByCreation.Clear();

         switch (roomName)
         {
            case FIRST_ROOM:
               PutInstance(new Player(), Vectors.Create(20, 20), -10);
               PutInstance(new Wall(), Vectors.Create(100, 100), 0);
               PutInstance(new Wall(), Vectors.Create(200, 100), 0);
               PutInstance(new Wall(), Vectors.Create(300, 100), 0);
               break;
         }
      }
   }
}