﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InteractiveInput
{
    public class InteractiveInput
    {
        /// <summary>
        /// 質問を表示し文字列を入力
        /// </summary>
        /// <param name="message">質問</param>
        /// <returns>入力された文字列</returns>
        public static string InputString(string message = "値を入力してください")
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        /// <summary>
        /// 32bit小数を入力
        /// </summary>
        /// <param name="message"></param>
        /// <returns>入力された小数</returns>
        public static float InputFloat(string message = "値を入力してください")
        {
            //Console.WriteLine(message);
            float i;
            while (true)
            {
                if (float.TryParse(InputString(message), out i))
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

        /// <summary>
        /// 32bit小数を入力、１以上、指定最大値未満で正常な整数を入力するまで繰り返す
        /// </summary>
        /// <param name="max"></param>
        /// <param name="message"></param>
        /// <param name="errorMessage"></param>
        /// <returns>入力された小数</returns>
        public static float InputFloat(float max, string message, string errorMessage = "入力エラー")
        {
            return InputFloat(max, 1, message, errorMessage);
        }

        /// <summary>
        /// 32bit小数を入力、指定最小値以上、指定最大値未満で正常な整数を入力するまで繰り返す
        /// </summary>
        /// <param name="max">最大値</param>
        /// <param name="min">最小値</param>
        /// <param name="message">質問として表示する文字列</param>
        /// <param name="errorMessage">範囲エラー時に表示する文字列</param>
        /// <returns></returns>
        public static float InputFloat(
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

        /// <summary>
        /// 文字列を指定された色でConsoleへ出力
        /// </summary>
        /// <param name="s">文字列</param>
        /// <param name="c">色</param>
        public static void OutputColoredText(string s, ConsoleColor c)
        {
            Console.ForegroundColor = c;
            Console.WriteLine(s);
            Console.ResetColor();
        }

    }
}

