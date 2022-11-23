using System;
using EilexFramework;

namespace EilexFramework.GameStates
{
    public abstract class GameState
    {
        protected string _StateName = "";
        public ResourceManager ResManager;

        public GameState(string stateName)
        {
            _StateName = stateName;
            ResManager = new ResourceManager(this);
        }

        public abstract void OnEnter();
        public abstract void OnExit();
        public virtual void Update(float dt)
        {
            ResManager.Update(dt);
        }

        public virtual void Draw()
        {
            ResManager.Draw();
        }

    }
}