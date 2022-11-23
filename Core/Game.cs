using System;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace EilexFramework
{
    public static class Game
    {
        // Window Size
        public static int WindowWidth = 1200;
        public static int WindowHeight = 800;
        public static string WindowTitle = "Eilex Game";                    // Name of the window
        public static bool FullScreen = false;                               // If full screen mode or not
        public static bool IsRunning = true;                                // If the game is running

        
        public static void CreateWindow(int windowWidth, int windowHeight, string title, bool fullscreen = false)
        {
            WindowWidth = windowWidth;
            WindowHeight = windowHeight;
            WindowTitle = title;
            FullScreen = fullscreen;

            InitWindow(WindowWidth, WindowHeight, WindowTitle);

            if(FullScreen)
            {
                ToggleFullscreen();
            }
        }


    }
}