using System;
using Raylib_cs;
using static Raylib_cs.Raylib;
using EilexFramework;

namespace ProjectStealth
{
    public static class Program
    {
        public static void Main()
        {
            Game.CreateWindow(1200, 800, "Eilex Game");

            while(!WindowShouldClose())
            {
                BeginDrawing();
                ClearBackground(Color.RAYWHITE);
                
                EndDrawing();
            }
        }
    }
}