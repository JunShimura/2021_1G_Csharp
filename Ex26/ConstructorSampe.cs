using System;
using ConsoleUtility;

namespace ConstructorSampe
{
    class ConstructorSampeMain
    {
        static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle(5, 3.5f);
            Console.WriteLine($"面積は{triangle1.GetSurface()}");
            Triangle triangle2 = new Triangle(
                InteractiveInput.InputFloat("幅："),
                InteractiveInput.InputFloat("高さ："));
            Console.WriteLine($"面積は{triangle2.GetSurface()}");
        }
    }
}
