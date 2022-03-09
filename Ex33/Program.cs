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
            TestEx33();
        }
        static void TestEx33()
        {
            Console.WriteLine("TestEx33");
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

            const int N_TEST_PATTERN = 4; 
            RectAngle[,] rectAngles =new RectAngle[N_TEST_PATTERN, 2]
                {
                    {
                        new RectAngle(5,1),new RectAngle(3,2)
                    },
                    {
                        new RectAngle(5,1),new RectAngle(2,3)
                    },
                    {
                        new RectAngle(1,5),new RectAngle(3,2)
                    },
                    {
                        new RectAngle(1,5),new RectAngle(2,3)
                    },
                };
            for(var i = 0; i < N_TEST_PATTERN; i++)
            {
                var outString =
                    $"RectAngle{rectAngles[i, 0].ToString()}"
                    + $"RectAngle{ rectAngles[i, 1].ToString()}"
                    + $"=RectAngle{(rectAngles[i, 0] + rectAngles[i, 1]).ToString()}";
                Console.WriteLine(outString);
            }
        }
    }
}
