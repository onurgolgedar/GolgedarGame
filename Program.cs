using GolgedarEngine;
using System;
using System.Diagnostics;
using System.IO;

namespace GolgedarGame
{
    static class Program
    {
        const string GAME_NAME = "Lufulus Online";

        [STAThread]
        static void Main()
        {
            Global.HandleNvidiaProfile(GAME_NAME);
            Global.LoadSprites(Resources.IMAGES);

            RoomData roomData = new RoomModel();
            Game game = new Game(GAME_NAME, roomData);

            game.LoadRoom(RoomModel.FIRST_ROOM);
            game.Run();
        }
    }
}