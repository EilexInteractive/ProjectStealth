using System;
using System.Collections.Generic;

namespace EilexFramework
{
    public class Vector2
    {
        public float X;
        public float Y;

        /// <summary>
        /// Empty Vector Constructor (0, 0)
        /// </summary>
        public Vector2()
        {
            X = 0;
            Y = 0;
        }

        /// <summary>
        /// Float constructor
        /// </summary>
        /// <param name="x">float of X axis</param>
        /// <param name="y">float of Y axis</param>
        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Scale Constructor
        /// </summary>
        /// <param name="scale">Scale of X and Y axis</param>
        public Vector2(float scale)
        {
            X = scale;
            Y = scale;
        }

        /// <summary>
        /// Vector Copy Constructor
        /// </summary>
        /// <param name="vec">Vector of this vector</param>
        public Vector2(Vector2 vec)
        {
            X = vec.X;
            Y = vec.Y;
        }
        
        /// <summary>
        /// Adds the vector to this vector
        /// </summary>
        /// <param name="vec">Vector to add</param>
        public void Add(Vector2 vec)
        {
            this.X = this.X + vec.X;
            this.Y = this.Y + vec.Y;

        }

        /// <summary>
        /// Adds a scale to the vector
        /// </summary>
        /// <param name="scale">Scale amount to add to the vector</param>
        public void Add(float scale)
        {
            this.X = this.X + scale;
            this.Y = this.Y + scale;
        }

        /// <summary>
        /// Substract from this vector
        /// </summary>
        /// <param name="vec">Vector to subtract this by</param>
        public void Substract(Vector2 vec)
        {
            this.X = this.X - vec.X;
            this.Y = this.Y - vec.Y;
        }

        /// <summary>
        /// Substract this vector from the scale
        /// </summary>
        /// <param name="scale"></param>
        public void Substract(float scale)
        {
            this.X = this.X - scale;
            this.Y = this.Y - scale;
        }

        /// <summary>
        /// Divide this vector by a vector
        /// </summary>
        /// <param name="vec">Vector to divide by</param>
        public void Divide(Vector2 vec)
        {
            this.X = this.X / vec.X;
            this.Y = this.Y / vec.Y;
        }

        /// <summary>
        /// Divide this vector by a scale
        /// </summary>
        /// <param name="scale">Scale to divide by</param>
        public void Divide(float scale)
        {
            this.X = this.X / scale;
            this.Y = this.Y / scale;
        }

        /// <summary>
        /// Multiply this vector by a vector
        /// </summary>
        /// <param name="vec">Vector to multiple by</param>
        public void Multiply(Vector2 vec)
        {
            this.X = this.X * vec.X;
            this.Y = this.Y * vec.Y;
        }

        /// <summary>
        /// Multiply this vector by a scale
        /// </summary>
        /// <param name="scale">Scale to multiply by</param>
        public void Multiply(float scale)
        {
            this.X = this.X * scale;
            this.Y = this.Y * scale;
        }

        public float Magintude()
        {
            
            return System.MathF.Sqrt((X * X) + (Y * Y));
        }

        public void Normalize()
        {
            float mag = this.Magintude();
            this.X = this.X / mag;
            this.Y = this.Y / mag;
        }

        public Vector2 Normalized()
        {
            float mag = this.Magintude();
            return new Vector2
            {
                X = this.X / mag,
                Y = this.Y / mag
            };
        }

        public static float Dot(Vector2 a, Vector2 b)
        {
            return (a.X * b.X) + (a.Y * b.Y);
        }

        public static Vector2 Cross(Vector2 a, Vector2 b)
        {
            return new Vector2
            {
                X = a.X * b.Y,
                Y = a.X * b.Y,
            };
        }

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2
            {
                X = a.X + b.X,
                Y = a.Y + b.Y
            };
        }

        public static Vector2 operator +(Vector2 vec, float scale)
        {
            return new Vector2
            {
                X = vec.X + scale,
                Y = vec.Y + scale
            };
        }

        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2
            {
                X = a.X - b.X,
                Y = a.Y - b.Y
            };
        }

        public static Vector2 operator -(Vector2 vec, float scale)
        {
            return new Vector2
            {
                Y = vec.Y - scale,
                X = vec.X - scale
            };
        }

        public static Vector2 operator *(Vector2 a, Vector2 b)
        {
            return new Vector2
            {
                X = a.X * b.X,
                Y = a.Y * b.Y
            };
        }

        public static Vector2 operator *(Vector2 a, float scale)
        {
            return new Vector2
            {
                X = a.X * scale,
                Y = a.Y * scale
            };
        }

        public static Vector2 operator /(Vector2 a, Vector2 b)
        {
            return new Vector2
            {
                X = a.X / b.X,
                Y = a.Y / b.Y
            };
        }

        public static Vector2 operator /(Vector2 vec, float scale)
        {
            return new Vector2
            {
                X = vec.X / scale,
                Y = vec.Y / scale
            };
        }

        public static bool operator ==(Vector2 a, Vector2 b)
        {
            if (a.X == b.X && a.Y == b.Y)
                return true;

            return false;
        }

        public static bool operator !=(Vector2 a, Vector2 b)
        {
            if (a == b)
                return false;

            return true;
        }


        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;


            if(obj is Vector2)
            {
                Vector2 vec = (Vector2)obj;
                if (this == vec)
                    return true;

                return false;
            } else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"X: {this.X}, Y: {this.Y}";
        }

        public System.Numerics.Vector2 GetSysVec() => new System.Numerics.Vector2(X, Y);
    }
}
