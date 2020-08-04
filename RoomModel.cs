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
               PutInstance(new Character(), Vector.Create(200, 200));
               PutInstance(new Character(), Vector.Create(260, 200));
               PutInstance(new Character(), Vector.Create(320, 200));
               PutInstance(new Character(), Vector.Create(380, 200));
               PutInstance(new Character(), Vector.Create(420, 200));
               PutInstance(new Player(), Vector.Create(0, 0));

               PutInstance(new Wall(), Vector.Create(200, 100), 50);
               PutInstance(new Wall(), Vector.Create(305, 300), 50);
               PutInstance(new Wall(), Vector.Create(410, 500), 50);
               PutInstance(new Wall(), Vector.Create(515, 700), 50);
               PutInstance(new Wall(), Vector.Create(620, 900), 50);
               PutInstance(new Wall(), Vector.Create(725, 1100), 50);
               PutInstance(new Wall(), Vector.Create(830, 1300), 50);
               break;

            case SECOND_ROOM:
               PutInstance(new MainControl(), depth: -1000);
               PutInstance(new Player(), Vector.Create(100, 100));
               PutInstance(new BlackWall(), Vector.Create(500, 500), 50);
               break;
         }
      }
   }
}