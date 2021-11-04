﻿using System;

namespace Ex25
{
    class Ex25
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
                int turtle;
                int crane;
                if (GetCraneTurtle(heads, legs, out crane, out turtle))
                {
                    Console.WriteLine($"鶴の数{crane}.亀の数{turtle}");
                    break;
                }
                Console.WriteLine("入力エラーです、再度、頭と脚の数を入力してください");
            }
        }

        //　鶴亀算用の関数
        /// <summary>
        /// 鶴亀算の計算をする
        /// </summary>
        /// <param name="heads">頭の数</param>
        /// <param name="legs">脚の数</param>
        /// <param name="crane">[出力]鶴の数</param>
        /// <param name="turtle">[出力]亀の数</param>
        /// <returns>答えが正常=true、異常=false</returns>
        static bool GetCraneTurtle(int heads, int legs, out int crane, out int turtle)
        {
            float fCrane = GetCrane(legs, heads);
            float fTurtle = GetTurtle(legs, heads);
            bool sucess = AnswerCheck(fCrane, fTurtle);
            crane = (int)fCrane;
            turtle = (int)fTurtle;
            return sucess;
        }

        static float GetTurtle(int legs, int heads)
        {
            return (float)legs / 2 - heads;
        }
        static float GetCrane(int legs, int heads)
        {
            return (float)heads - GetTurtle(legs, heads);
        }

        // 答えが正常か確認
        static bool AnswerCheck(float crane, float turtle)
        {
            return (IsNaturalNumber(turtle) && IsNaturalNumber(crane));
        }
        static bool IsNaturalNumber(float num)
        {
            return (num >= 0 && num == Math.Floor(num));
        }
        static bool IsNaturalNumber(double num)
        {
            return (num >= 0 && num == Math.Floor(num));
        }

        //入力用に作った汎用的関数
        static int InputNumber(string message)
        {
            Console.WriteLine(message);
            int i = 0;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out i))
                {
                    break;
                }
                else
                {
                    OutputColoredText("異常な入力です、もう一度、入力して下さい", ConsoleColor.Red);
                }
            }
            return i;
        }
        static int InputNumber(int max, string message = "値を入力してください", string errorMessage = "値が範囲外です")
        {
            return InputNumber(max, 1, message, errorMessage);
        }
        static int InputNumber(
            int max,  //必ず指定するのでオプション無し
            int min = 1,
            string message = "値を入力してください",
            string errorMessage = "値が範囲外です")
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
        static void OutputColoredText(string s, ConsoleColor c)
        {
            Console.ForegroundColor = c;
            Console.WriteLine(s);
            Console.ResetColor();
        }

    }
}
