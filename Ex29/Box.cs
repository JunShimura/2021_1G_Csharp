using System;
using System.Collections.Generic;
using System.Text;

namespace Ex29
{
    class Box
    {
        float width;
        float height;
        float depth;
        public float volume
        {
            get {
                return width * height * depth;
            }
        }
        public float surface
        {
            get
            {
                return (width * height + height * depth + depth * width) * 2;
            }
        }

        public Box(float w, float h, float d)
        {
            this.width = w;
            this.height = h;
            this.depth = d;
        }
        public Box(float w = 1)
        {
            this.width = w;
            this.height = w;
            this.depth = w;
        }
        public float GetVolume()
        {
            return width * height * depth;
        }
        public static float GetVolume(float w, float h, float d)
        {
            return w * h * d;
        }
        public float GetSurface()
        {
            return (width * height + height * depth + depth * width) * 2;
        }
        public static float GetSurface(float w, float h, float d)
        {
            return (w * h + h * d + d * w) * 2;
        }
    }
}
