using System;
using ConsoleUtility;
using NumberUtility;

namespace InteractiveInputNameSpace
{
    class InteractiveInput_Test
    {
        static void Main(string[] args)
        {
            float f = InteractiveInput. InputFloat();
            ConsoleOut.OutputColoredText($"入力値は{f}",ConsoleColor.Yellow);
            f = InteractiveInput.InputFloat("文字列指定：値を入れてください");
            Console.WriteLine($"入力値は{f}");
            ConsoleOut.OutputColoredText(
                $"入力値が自然数かは{NumberCheck.IsNaturalNumber(f)}",
                ConsoleColor.DarkYellow);
            f = InteractiveInput.InputFloat(1.5f, "指定文字列：値を入力");
            Console.WriteLine($"入力値は{f}");
            f = InteractiveInput.InputFloat(999.9f, -20);
            Console.WriteLine($"入力値は{f}");
        }
    }
}
