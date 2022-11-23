using System;
using System.Collections.Generic;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace EilexGame
{
    public class GameObject
    {
        #region Game Object Details
        public string ObjectName = "GameObject";
        protected string _ObjectID = "";
        public string ObjectID { get => _ObjectID;}

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

        }

        public void Update()
        {
            
        }

        #endregion
    }
}