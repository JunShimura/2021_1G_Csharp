using System;
<<<<<<< HEAD
using ConsoleUtility;
using NumberUtility;

namespace InteractiveInputNameSpace
=======
using InteractiveInput;

namespace InteractiveInput_Test
>>>>>>> d9d847198202e3e4940240df6d9a3b2988f3e090
{
    class InteractiveInput_Test
    {
        static void Main(string[] args)
        {
            float f = InteractiveInput. InputFloat();
<<<<<<< HEAD
            ConsoleOut.OutputColoredText($"入力値は{f}",ConsoleColor.Yellow);
            f = InteractiveInput.InputFloat("文字列指定：値を入れてください");
            Console.WriteLine($"入力値は{f}");
            ConsoleOut.OutputColoredText(
                $"入力値が自然数かは{NumberCheck.IsNaturalNumber(f)}",
                ConsoleColor.DarkYellow);
=======
            Console.WriteLine($"入力値は{f}");
            f = InteractiveInput.InputFloat("文字列指定：値を入れてください");
            Console.WriteLine($"入力値は{f}");
>>>>>>> d9d847198202e3e4940240df6d9a3b2988f3e090
            f = InteractiveInput.InputFloat(1.5f, "指定文字列：値を入力");
            Console.WriteLine($"入力値は{f}");
            f = InteractiveInput.InputFloat(999.9f, -20);
            Console.WriteLine($"入力値は{f}");
        }
    }
}
