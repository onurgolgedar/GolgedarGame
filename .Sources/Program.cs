using GolgedarEngine;
using System;

namespace GolgedarGame
{
   static class Program
   {
      [STAThread]
      static void Main()
      {
         Global.LoadSprites(Source.IMAGES);
         RoomData roomData = new RoomModel();

         Game game = new Game("Heatless Fire RPG", roomData);
         Global.HandleNvidiaProfile("GolgedarGame");

         game.LoadRoom(RoomModel.FIRST_ROOM);
         game.Run();
      }
   }
}