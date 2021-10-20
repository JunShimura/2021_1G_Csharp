using System;

namespace Ex23
{
    class Ex23
    {
        const int headMin = 0;        // 頭の数の最小値
        const int headMax = 1000;  // 頭の数の最大値 
        const int legMin = 0;           // 脚の数の最小値
        const int legMax = 1000;     // 脚の数の最大値 

        static void Main(string[] args)
        {
            while (true)
            {
                var heads = InputNumber(headMax, headMin, "頭の数を入力してください");
                var legs = InputNumber(legMax, legMin, "脚の数を入力してください");
                var turtle = (float)legs / 2 - heads;
                var crane = (float)heads - turtle;
                Console.WriteLine($"鶴の数{crane}.亀の数{turtle}");
                if (turtle>=0 && crane >= 0 && turtle==Math.Floor(turtle ) && crane==Math.Floor(crane))
                {
                    break;
                }
                Console.WriteLine("入力エラーです、再度、頭と脚の数を入力してください");
            }
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
