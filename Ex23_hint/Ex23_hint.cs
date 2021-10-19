using System;

namespace Ex23_hint
{
    class Ex23_hint
    {
        static void Main(string[] args)
        {
            var heads = InputNumber("頭の数を入力してください");
            var legs = InputNumber("脚の数を入力してください");
            var turtle = legs / 2 - heads;
            var crane = heads - turtle;
            Console.WriteLine($"鶴の数{crane}.亀の数{turtle}");
        }

        //入力用に作った汎用的関数
        static int InputNumber(string message)
        {
            Console.WriteLine(message);
            int i = int.Parse(Console.ReadLine());
            return i;
        }
        static int InputNumber(int max, string message = "値を入力してください", string errorMessage = "入力エラー")
        {
            return InputNumber(max, 1, message, errorMessage);
        }
        static int InputNumber(
            int max,  //必ず指定するのでオプション無し
            int min = 1,
            string message = "値を入力してください",
            string errorMessage = "入力エラー")
        {
            int i;
            while (true)
            {
                i = InputNumber($"{ message}\n範囲は{ min}から{ max}");
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

        static float InputFloat(string message = "値を入力してください")
        {
            Console.WriteLine(message);
            float i = float.Parse(Console.ReadLine());
            return i;
        }

        static float InputFloat(float max, string message = "値を入力してください", string errorMessage = "入力エラー")
        {
            return InputFloat(max, 1, message, errorMessage);
        }
        static float InputFloat(
            float max,  //必ず指定するのでオプション無し
            float min = 1,
            string message = "値を入力してください",
            string errorMessage = "入力エラー")
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
