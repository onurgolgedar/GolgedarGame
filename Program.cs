using GolgedarEngine;
using System;

namespace GolgedarGame
{
   static class Program
   {
      [STAThread]
      static void Main()
      {
         const string GAME_NAME = "Lufulus Online";

         Global.HandleNvidiaProfile(GAME_NAME, "lufulusonline.exe");
         Global.LoadSprites(Resource.IMAGES);

         RoomData roomData = new RoomModel();
         Game game = new Game(GAME_NAME, roomData);

         game.LoadRoom(RoomModel.FIRST_ROOM);
         game.Run();
      }
   }
}