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
        readonly public float shorter;
        readonly public float longer;
        public RectAngle(float width = 0, float height = 0)
        {
            this.width = width;
            this.height = height;
            if (height < width)
            {
                shorter = height;
                longer = width;
            }
            else
            {
                shorter = width;
                longer = height;
            }
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

            //[短い辺で長い方][長い辺で短い方]<[長い辺で長い方][短い辺で短い方]のとき
            float[] l = new float[4];
            if (rectAngle1.longer > rectAngle2.longer)
            {
                l[0] = rectAngle1.longer;
                l[1] = rectAngle2.longer;

            }
            else
            {
                l[0] = rectAngle2.longer;
                l[1] = rectAngle1.longer;
            }
            if (rectAngle1.shorter > rectAngle2.shorter)
            {
                l[2] = rectAngle1.shorter;
                l[3] = rectAngle2.shorter;
            }
            else
            {
                l[2] = rectAngle2.shorter;
                l[3] = rectAngle1.shorter;
            }
            //[短い辺で長い方][長い辺で短い方]<[長い辺で長い方][短い辺で短い方]のとき
            return
                l[1]*l[2]<l[0]*l[3]
                ? new RectAngle(    // 長い辺を延長して繋げたもの
                    rectAngle1.longer + rectAngle2.longer,
                    l[2])
                : new RectAngle(
                    l[0],
                    rectAngle1.shorter + rectAngle2.shorter);
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
        }
        public override string ToString()
        {
            return $"({width.ToString()},{height.ToString()})";
        }
    }
}
