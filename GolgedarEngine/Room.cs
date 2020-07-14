using System.Collections.Generic;

namespace GolgedarEngine
{
   public class Room
   {
      internal SortedList<short, GameObject> Instances { get; set; }
      public string RoomName { get; }

      public Room (string roomName, RoomData roomData)
      {
         Instances = roomData.GetInstances(roomName);
         RoomName = roomName;
      }
   }
}