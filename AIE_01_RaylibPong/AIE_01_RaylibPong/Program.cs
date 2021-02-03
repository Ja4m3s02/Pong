using System;
using Raylib_cs;

namespace AIE_01_RaylibPong
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 450, "Pong");

            while(Raylib.WindowShouldClose())
            {
                //UPDATE Logic

                //DRAWING Logic
                Raylib.BeginDrawing();
                Raylib.EndDrawing();
                


            }

            Raylib.CloseWindow();
        }
    }
}
