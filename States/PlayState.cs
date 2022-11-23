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
            Sprite sprite = new Sprite("TestImage.png");
            ResManager.AddObjectToScene(sprite);
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