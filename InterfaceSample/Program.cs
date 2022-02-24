using System;
using System.Collections.Generic;

namespace InterfaceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            RectAngle rectAngle1= new RectAngle(3, 5);
            RectAngle rectAngle2 = new RectAngle(3, 5);
            if (rectAngle1 == rectAngle2)   //同じインスタンスであるかを比較を内容比較に変えてある
            {
                Console.WriteLine("二つは同じ長方形");
            }
            else
            {
                Console.WriteLine("二つは違う長方形");
            }
            if (rectAngle1.Equals(rectAngle2))   //同じ内容であるかを比較
            {
                Console.WriteLine("二つは同じ長方形");
            }
            else
            {
                Console.WriteLine("二つは違う長方形");
            }

            #region
            /*            var test1 = rectAngle1.GetSurface();
                        ISurface surface1 = rectAngle1;
                        var test2 = surface1.GetSurface();
                        Console.WriteLine($"surface1の面積は{test2}");
                        ICircumference circumference1 = rectAngle1;
                        var test3 = circumference1.GetCircumference();
                        Console.WriteLine($"circumference1の周囲の長さは{test3}");
                        IBounds bounds1 = rectAngle1;
                        float w, h;
                        bounds1.GetBounds(out w,out h);
                        Console.WriteLine($"bounds1の高さは{h}、幅は{w}");*/
            #endregion
        }
    }
}
