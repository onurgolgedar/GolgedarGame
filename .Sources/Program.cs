using GolgedarEngine;
using System;

namespace GolgedarGame
{
   static class Program
   {
      [STAThread]
      static void Main()
      {
         Global.LoadSprites(Source.Images);
         RoomData roomData = new RoomModel();

         Game game = new Game();
         Global.HandleNvidiaProfile("GolgedarGame");

         Room firstRoom = new Room(RoomModel.FIRST_ROOM, roomData);

         game.ActiveRoom = firstRoom;
         game.Run();
      }
   }
}