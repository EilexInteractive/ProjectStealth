using System;
using System.Collections.Generic;
using Raylib_cs;
using EilexFramework.GameStates;

public struct TextureDetails
{
    public string TexturePath;
    public Texture2D Texture;
}

namespace EilexFramework
{
    public class ResourceManager
    {
        private GameState _OwningState;
        private List<GameObject> _ObjectsInScene = new List<GameObject>();

        private List<TextureDetails> _LoadedTextures = new List<TextureDetails>();
        
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

        public Texture2D LoadTexture(string filePath)
        {
            // Loop through each texture that has been loaded
            foreach(var texture in _LoadedTextures)
            {
                // If the loaded texture has the same path than return that texture
                if(texture.TexturePath == filePath)
                    return texture.Texture;
            }

            // Create a new texture details as one doesnt exist
            TextureDetails newTexture = new TextureDetails
            {
                TexturePath = filePath,
                Texture = LoadTexture(filePath)
            };

            // Add the loaded texture
            _LoadedTextures.Add(newTexture);

            // Return the newly created texture
            return newTexture.Texture;
        }
    }
}