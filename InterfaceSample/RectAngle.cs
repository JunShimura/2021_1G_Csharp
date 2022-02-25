using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSample
{
    class RectAngle : ISurface, ICircumference, IBounds, IEquatable<RectAngle>,IComparable<RectAngle>
    {
        readonly public float width;
        readonly public float height;
        public RectAngle(float width = 0, float height = 0)
        {
            this.width = width;
            this.height = height;
        }
        public float GetSurface()
        {
            return width * height;
        }
        public float GetCircumference()
        {
            return (width + height) * 2;
        }
        public void GetBounds(out float width, out float height)
        {
            width = this.width;
            height = this.height;
        }
        public bool Equals(RectAngle other)
        {
            return width == other.width && height == other.height
                || width == other.height && height == other.width;
        }
        public int CompareTo(RectAngle target)
        {
            var val = this.GetSurface() - target.GetSurface();
            var r=0;
            if (val > 0)
            {
                r = 1;
            }
            else if(r<0)
            {
                r = -1;
            }
            return r;
        }

        public static bool operator ==(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return rectAngle1.width == rectAngle2.width
                && rectAngle1.height == rectAngle2.height
                || rectAngle1.width == rectAngle2.height
                && rectAngle1.height == rectAngle2.width;
        }
        public static bool operator !=(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return !(rectAngle1.width == rectAngle2.width
                && rectAngle1.height == rectAngle2.height
                || rectAngle1.width == rectAngle2.height
                && rectAngle1.height == rectAngle2.width);
        }
    }
}
