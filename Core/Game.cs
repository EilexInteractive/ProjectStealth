using System;
using Raylib_cs;
using static Raylib_cs.Raylib;
using EilexFramework.GameStates;
using EilexGame;

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

        // Game States
        private static GameState _ActiveState = new PlayState();

        
        public static void CreateWindow(int windowWidth, int windowHeight, string title, bool fullscreen = false)
        {
            // Setup window properties
            WindowWidth = windowWidth;
            WindowHeight = windowHeight;
            WindowTitle = title;
            FullScreen = fullscreen;


            // Create the window with the update properties
            InitWindow(WindowWidth, WindowHeight, WindowTitle);

           



            // Toggle fullscren if needed
            if(FullScreen)
            {
                ToggleFullscreen();
            }

             _ActiveState.OnEnter();
        }

        public static void Update()
        {
            float dt = GetFrameTime();              // Get delta time
            
            while(IsRunning)
            {

                if(_ActiveState != null)
                {
                    _ActiveState.Update(dt);
                } else 
                {
                    IsRunning = false;
                }

                BeginDrawing();
                ClearBackground(Color.RAYWHITE);
                if(_ActiveState != null)
                {
                    _ActiveState.Draw();
                } else 
                {
                    IsRunning = false;
                }
                EndDrawing();

                // Debug close game btn
                if(IsKeyPressed(KeyboardKey.KEY_ESCAPE))
                    IsRunning = false;
            }

            
        }

        public static void SetGameState(GameState state)
        {
            if(state != null)
            {
                if(_ActiveState != null)
                    _ActiveState.OnExit();

                _ActiveState = state;
                _ActiveState.OnEnter();
            }
        }

    }
}