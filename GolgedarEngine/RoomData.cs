using SFML.System;
using System.Collections.Generic;

namespace GolgedarEngine
{
   public abstract class RoomData
   {
      protected RoomData()
      {
      }

      internal abstract SortedList<short, GameObject> GetInstances(string roomName);
      internal void PutInstance(GameObject gameObject, Vector2f position = new Vector2f(), short depth = 0)
      {
         Instances.Add(depth, gameObject);
         gameObject.SetPosition(position);
      }

      internal SortedList<short, GameObject> Instances { get; set; } = new SortedList<short, GameObject>();
   }
}