using GolgedarEngine;
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
            return [FIRST_ROOM, SECOND_ROOM];
        }
        public override void SetDesign(string roomName)
        {
            switch (roomName)
            {
                case FIRST_ROOM:
                    PutInstance(new Client());
                    break;

                case SECOND_ROOM:
                    break;
            }
        }
    }
}