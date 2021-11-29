using System;
using ConsoleUtility;

namespace ConstructorSampe
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Console.WriteLine($"体積は{box1.GetVolume()}、表面積は{box1.GetSurface()}");
            Box box2 = new Box(
                InteractiveInput.InputFloat("幅："),
                InteractiveInput.InputFloat("高さ："),
                InteractiveInput.InputFloat("奥行："));
            Console.WriteLine($"体積は{box2.GetVolume()}、表面積は{box2.GetSurface()}");
        }
    }
    class Box
    {
        float width;
        float height;
        float depth;
        public Box(float w,float h,float d)
        {
            this.width = w;
            this.height = h;
            this.depth = d;
        }
        public Box(float w=1)
        {
            this.width = w;
            this.height = w;
            this.depth = w;
        }
        public float GetVolume()
        {
            return width * height * depth;
        }
        public float GetSurface()
        {
            return (width * height + height * depth + depth * width) * 2;
        }
    }

}
