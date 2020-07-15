using GolgedarEngine;
using GolgedarGame.GameObjects;
using System.Collections.Immutable;

namespace GolgedarGame
{
   public class RoomModel : RoomData
   {
      public const string FIRST_ROOM = "First Room";
      public const string SECOND_ROOM = "Second Room";

      public RoomModel() : base()
      {
      }

      public override ImmutableList<string> GetRooms()
      {
         return ImmutableList.Create(FIRST_ROOM,
                                     SECOND_ROOM);
      }
      public override void SetDesign(string roomName)
      {
         switch (roomName)
         {
            case FIRST_ROOM:
               PutInstance(new MainControl(), depth: -1000);
               PutInstance(new Player(), Vector.Create(20, 20));
               PutInstance(new Wall(), Vector.Create(100, 100), 50);
               PutInstance(new Wall(), Vector.Create(180, 100), 50);
               PutInstance(new Wall(), Vector.Create(260, 100), 50);
               PutInstance(new Wall(), Vector.Create(340, 100), 50);
               PutInstance(new Wall(), Vector.Create(340, 180), 50);
               PutInstance(new Wall(), Vector.Create(340, 260), 50);
               break;

            case SECOND_ROOM:
               PutInstance(new MainControl(), depth: -1000);
               PutInstance(new Player(), Vector.Create(100, 100));
               PutInstance(new Wall(), Vector.Create(500, 500), 50);
               PutInstance(new Wall(), Vector.Create(580, 500), 50);
               break;
         }
      }
   }
}