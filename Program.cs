using System;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace ProjectStealth
{
    public static class Program
    {
        public static void Main()
        {
            int windowWidth = 1200;
            int windowHeight = 800;

            InitWindow(windowWidth, windowHeight, "Hello World");

            while(!WindowShouldClose())
            {
                BeginDrawing();
                ClearBackground(Color.RAYWHITE);
                DrawText("Hello World", windowWidth / 2, windowHeight / 2, 24, Color.BLACK);
                EndDrawing();
            }
        }
    }
}