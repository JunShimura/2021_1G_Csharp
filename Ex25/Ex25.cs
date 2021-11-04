using System;

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

        // 汎用性のあるメソッド群

        static string InputString(string message = "値を入力してください")
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        /// <summary>
        /// floatの変数が自然数かを判別
        /// </summary>
        /// <param name="num">判別する変数</param>
        /// <returns>判定結果 自然数=true</returns>
        static bool IsNaturalNumber(float num)
        {
            return (num >= 0 && num == Math.Floor(num));
        }
        /// <summary>
        /// doubleの変数が自然数かを判別
        /// </summary>
        /// <param name="num">判別する変数</param>
        /// <returns>判定結果 自然数=true</returns>
        static bool IsNaturalNumber(double num)
        {
            return (num >= 0 && num == Math.Floor(num));
        }

        //入力用に作った汎用的関数

        /// <summary>
        /// 整数を入力、正常な整数を入力するまで繰り返す
        /// </summary>
        /// <param name="message">入力時に表示する文字列</param>
        /// <returns>入力された整数</returns>
        static int InputNumber(string message)
        {
            int i = 0;
            while (true)
            {
                if (int.TryParse(InputString(message), out i))
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
        /// 整数を入力、１～指定最大値未満で正常な整数を入力するまで繰り返す
        /// </summary>
        /// <param name="max">最大値</param>
        /// <param name="message">質問として表示する文字列</param>
        /// <param name="errorMessage">範囲エラー時に表示する文字列</param>
        /// <returns>入力された整数</returns>
        static int InputNumber(int max, string message = "値を入力してください", string errorMessage = "値が範囲外です")
        {
            return InputNumber(max, 1, message, errorMessage);
        }

        /// <summary>
        /// 整数を入力、指定最小値以上、指定最大値未満で正常な整数を入力するまで繰り返す
        /// </summary>
        /// <param name="max">最大値</param>
        /// <param name="min">最小値</param>
        /// <param name="message">質問として表示する文字列</param>
        /// <param name="errorMessage">範囲エラー時に表示する文字列</param>
        /// <returns>入力された整数</returns>
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

        /// <summary>
        /// 32bit小数を入力
        /// </summary>
        /// <param name="message"></param>
        /// <returns>入力された小数</returns>
        static float InputFloat(string message = "値を入力してください")
        {
            Console.WriteLine(message);
            float i;
            while (true)
            {
                if (float.TryParse(Console.ReadLine(), out i))
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
        static float InputFloat(float max, string message = "値を入力してください", string errorMessage = "入力エラー")
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

        /// <summary>
        /// 文字列を指定された色でConsoleへ出力
        /// </summary>
        /// <param name="s">文字列</param>
        /// <param name="c">色</param>
        static void OutputColoredText(string s, ConsoleColor c)
        {
            Console.ForegroundColor = c;
            Console.WriteLine(s);
            Console.ResetColor();
        }

    }
}
