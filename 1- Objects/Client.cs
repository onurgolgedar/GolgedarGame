using GolgedarEngine;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace GolgedarClient
{
    public class Client : GolgedarEngine.Client
    {
        public override void Loop()
        {
            if (Game.CheckKey(Keyboard.Key.W))
                Send('K', 'W');

            if (Game.CheckKey(Keyboard.Key.A))
                Send('K', 'A');

            if (Game.CheckKey(Keyboard.Key.S))
                Send('K', 'S');

            if (Game.CheckKey(Keyboard.Key.D))
                Send('K', 'D');

            if (Game.IsKeyPressed(Keyboard.Key.Q))
                Send('Q');

            if (Game.IsKeyPressed(Keyboard.Key.Space))
                Send<List<string>>('T', ["", "2", "3"]);
        }

        public override void Process(int code, float data)
        {
            switch (code)
            {
                case 'P':
                    Console.WriteLine(data);
                    break;
            }
        }

        public override void Process(int code, string data, string typeName)
        {
            switch (code)
            {
                case 'T':
                    Console.WriteLine(data);
                    Console.WriteLine(typeName);
                    Console.WriteLine();
                    break;
            }
        }

        public override void Process(int code, string data)
        {
            switch (code)
            {
                case 'P':
                    Console.WriteLine(data);
                    break;
            }
        }

        public override void Process(int code, double data)
        {
            switch (code)
            {
                case 'P':
                    Console.WriteLine(data);
                    break;
            }
        }

        public override void Process(int code, char data)
        {
            switch (code)
            {
                case 'P':
                    Console.WriteLine(data);
                    break;
            }
        }

        public override void Process(int code, int data)
        {
            switch (code)
            {
                case 'P':
                    Console.WriteLine(data);
                    break;
            }
        }
    }
}