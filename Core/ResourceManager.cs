using System;
using System.Collections.Generic;
using Raylib_cs;
using EilexFramework.GameStates;

namespace EilexFramework
{
    public class ResourceManager
    {
        private GameState _OwningState;
        private List<GameObject> _ObjectsInScene = new List<GameObject>();
        
        public ResourceManager(GameState owningState)
        {
            _OwningState = owningState;
        }

        public void AddObjectToScene(GameObject go) => _ObjectsInScene.Add(go);
        public void RemoveObjectFromScene(GameObject go) => _ObjectsInScene.Remove(go);

        public void Update(float dt)
        {
            foreach(var go in _ObjectsInScene)
                go.Update(dt);
        } 

        public void Draw()
        {
            foreach(var go in _ObjectsInScene)
                go.Draw();
        }


    }
}