using System;

namespace OverLoad
{
    class OverLoad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static float InputFloat()
        {
            return InputFloat("値を入力してください");
        }
        static float InputFloat(string message)
        {
            Console.WriteLine(message);
            float i = float.Parse(Console.ReadLine());
            return i;
        }
        static float InputFloat(string message, float max)
        {
            return InputFloat(message, 1, max);
        }
        static float InputFloat(string message, float max, string errorMessage)
        {
            return InputFloat(message, 1, max, errorMessage);
        }
        static float InputFloat(string message, float min, float max)
        {
            return InputFloat(message, min, max, "入力エラー");
        }
        static float InputFloat(string message, float min, float max,string errorMessage)
        {
            float i;
            while (true)
            {
                i = InputFloat($"{ message}\n範囲は{ min}から{ max}");
                if (i >= min && i < max)
                { //値は適正
                    break;
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
            }
            return i;
        }
    }
}
