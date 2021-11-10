using System;
using InteractiveInput;

namespace InteractiveInput_Test
{
    class InteractiveInput_Test
    {
        static void Main(string[] args)
        {
            float f = InteractiveInput. InputFloat();
            Console.WriteLine($"入力値は{f}");
            f = InteractiveInput.InputFloat("文字列指定：値を入れてください");
            Console.WriteLine($"入力値は{f}");
            f = InteractiveInput.InputFloat(1.5f, "指定文字列：値を入力");
            Console.WriteLine($"入力値は{f}");
            f = InteractiveInput.InputFloat(999.9f, -20);
            Console.WriteLine($"入力値は{f}");
        }
    }
}
