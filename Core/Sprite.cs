using System;
using System.Collections.Generic;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace EilexFramework 
{
    
    public class Sprite : GameObject
    {
        protected string _SpritePath;
        protected Texture2D _Texture;
        public Color Tint;

        public Sprite(string spritePath) : base("Sprite")
        {
            _Texture = LoadTexture(spritePath);
        }

        public void ChangeSprite(string spritePath) => _Texture = LoadTexture(spritePath);

        public override void Draw()
        {
            base.Draw();
            DrawTextureEx(_Texture, GlobalPosition.GetSysVec(), Rotation, Scale, Tint);
        }
    }
}