using System;
using EX33_hint;

namespace EX33
{
    class Program
    {
        static void Main(string[] args)
        {
            RectAngle rectAngle1 = new RectAngle(3, 5);
            RectAngle rectAngle2 = new RectAngle(2, 8);
            RectAngle rectAngle3 = new RectAngle(2, 4);
            if (rectAngle1 == rectAngle2)
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しい");
            }
            else
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しくない");
            }
            var rectAngle4 = rectAngle1 + rectAngle2;
            Console.WriteLine($"rectAngle1+rectAngle2=({rectAngle4.width},{rectAngle4.height})");
            var rectAngle5 = rectAngle1 + rectAngle3;
            Console.WriteLine($"rectAngle1+rectAngle3=({rectAngle5.width},{rectAngle5.height})");
        }
    }
}
