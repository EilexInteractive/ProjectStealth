using System;
using System.Collections.Generic;
using EilexFramework;
using EilexFramework.GameStates;

namespace EilexGame
{
    public class PlayState : GameState
    {
        public PlayState() : base("PlayState")
        {
        }

        public override void Draw()
        {
            base.Draw();
        }
        public override void OnEnter()
        {
            Console.WriteLine("Hello World Please Enter");
        }

        public override void OnExit()
        {
            Console.WriteLine("Hello World Exit");
        }

        public override string ToString()
        {
            return _StateName;
        }

        public override void Update(float dt)
        {
            base.Update(dt);
        }
    }
}