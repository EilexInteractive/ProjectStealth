using System;
using System.Collections.Generic;
using Raylib_cs;
using static Raylib_cs.Raylib;
using EilexFramework;

namespace EilexFramework
{
    public class GameObject
    {
        #region Game Object Details
        public string ObjectName = "GameObject";
        protected string _ObjectID = "";
        public string ObjectID { get => _ObjectID;}

        #endregion

        #region Transform

        public Vector2 LocalPosition = new Vector2();
        public Vector2 GlobalPosition = new Vector2();

        public float Scale = 1;
        public float Rotation = 0;

        #endregion

        public List<string> Tags = new List<string>(); 
        #region Object Hierarchy
        // Parent Reference
        protected GameObject _Parent;
        public GameObject Parent { get => _Parent;}

        // Children Reference
        protected List<GameObject> _Children = new List<GameObject>();
        public List<GameObject> Children { get => _Children; }


        #endregion

        #region Misc Properties

        public bool IsActive = true;
        protected ResourceManager _OwningResManager;

        #endregion

        #region Constructors

        public GameObject(ResourceManager res, string objectName = "GameObject")
        {
            ObjectName = objectName;
            _ObjectID = Globals.GenerateID();
            _OwningResManager = res;
        }

        #endregion

        #region Object Hierarchy Methods



        public void SetParent(GameObject go)
        {
            if(_Parent != null)
                _Parent.RemoveChild(this);

            _Parent = go;
            _Parent.AddChild(this);
        }

        public void AddChild(GameObject go)
        {
            if(_Children.Contains(go) == false)
                _Children.Add(go);
        }

        public void RemoveChild(GameObject go)
        {
            if(_Children.Contains(go))
                _Children.Remove(go);
        }

        #endregion
   
        #region Base Functions

        public virtual void Start()
        {
            if(!IsActive)
                return;
        }

            public virtual void Update(float dt)
        {
            if(!IsActive)
                return;

            UpdatePosition();
        }

        public virtual void Draw()
        {
            if(!IsActive)
                return;
        }

        public virtual void Destroy()
        {

        }

        #endregion

        #region Transform

        private void UpdatePosition()
        {
            if(_Parent != null)
            {
                GlobalPosition = _Parent.GlobalPosition + this.LocalPosition;
            } else 
            {
                GlobalPosition = LocalPosition;
            }
        }

        public void SetPosition(Vector2 pos) => LocalPosition = pos;
        public void SetPosition(float x, float y) => LocalPosition = new Vector2(x, y);
        #endregion
    }
}