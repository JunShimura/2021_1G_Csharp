using System;
using System.Collections.Generic;
using System.Text;
using EX33_hint;

namespace EX33
{
    class RectAngle : ISurface, ICircumference, IBounds
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
        public static bool operator ==(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return rectAngle1.width == rectAngle2.width
                && rectAngle1.height == rectAngle2.height
                || rectAngle1.width == rectAngle2.height
                && rectAngle1.height == rectAngle2.width;
        }
        public static bool operator !=(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return !(rectAngle1 == rectAngle2);
        }
        public static RectAngle operator +(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            #region ifPattern
            /*            RectAngle rectAngleVirtical;
                        if (rectAngle1.width > rectAngle2.width)
                        {
                            rectAngleVirtical = new RectAngle(rectAngle1.width, rectAngle1.height + rectAngle2.height);
                        }
                        else
                        {
                            rectAngleVirtical = new RectAngle(rectAngle2.width, rectAngle1.height + rectAngle2.height);
                        }*/
            #endregion
            #region triple
            /*            RectAngle rectAngleVirtical
                            = new RectAngle(
                                rectAngle1.width > rectAngle2.width ? rectAngle1.width : rectAngle2.width,
                                rectAngle1.height + rectAngle2.height);
                        RectAngle rectAngleHorizontal
                           = new RectAngle(
                               rectAngle1.width + rectAngle2.width,
                               rectAngle1.height > rectAngle2.height ? rectAngle1.height : rectAngle2.height);*/
            #endregion
            RectAngle rectAngleVirtical
                = new RectAngle(
                    MathF.Max(rectAngle1.width, rectAngle2.width),
                    rectAngle1.height + rectAngle2.height);
            RectAngle rectAngleHorizontal
                = new RectAngle(
                    rectAngle1.width + rectAngle2.width,
                    MathF.Max(rectAngle1.height, rectAngle2.height));
            #region ifResult
            /*            RectAngle result;
                        if (rectAngleVirtical.GetSurface() < rectAngleHorizontal.GetSurface())
                        {
                            result = rectAngleVirtical;
                        }
                        else
                        {
                            result = rectAngleHorizontal;
                        }
                        return result;*/
            #endregion
            return rectAngleVirtical.GetSurface() < rectAngleHorizontal.GetSurface()
                ? rectAngleVirtical : rectAngleHorizontal;

        }
    }
}
