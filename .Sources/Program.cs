using GolgedarEngine;
using System;

namespace GolgedarGame
{
   static class Program
   {
      [STAThread]
      static void Main()
      {
         const string GAME_NAME = "Heatless Fire RPG";

         Global.HandleNvidiaProfile(GAME_NAME, "golgedargame.exe");
         Global.LoadSprites(Source.IMAGES);

         RoomData roomData = new RoomModel();
         Game game = new Game(GAME_NAME, roomData);

         game.LoadRoom(RoomModel.FIRST_ROOM);
         game.Run();
      }
   }
}