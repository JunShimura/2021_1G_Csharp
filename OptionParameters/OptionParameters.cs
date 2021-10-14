using System;

namespace OptionParameters
{
    class OptionParameters
    {
        static void Main(string[] args)
        {
            var height = InputFloat(2.8f,0.1f,"身長(m)を入力してください");
            var weight = InputFloat(600,"体重(kg)を入力してください");
            var bmi = weight / (height * height);  // BMIを算出
            Console.WriteLine($"BMI = {bmi:f2}");  //計算の結果を文字列で表示
            if (bmi < 18.5)
            {
                Console.WriteLine("低体重(痩せ型)");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("普通体重");
            }
            else if (bmi < 30)
            {
                Console.WriteLine("肥満(1度)");
            }
            else if (bmi < 35)
            {
                Console.WriteLine("肥満(2度)");
            }
            else if (bmi < 40)
            {
                Console.WriteLine("肥満(3度)");
            }
            else
            {
                Console.WriteLine("肥満(4度)");
            }

        }

        static float InputFloat(string message　= "値を入力してください")
        {
            Console.WriteLine(message);
            float i = float.Parse(Console.ReadLine());
            return i;
        }

        static float InputFloat(float max, string message = "値を入力してください",  string errorMessage = "入力エラー")
        {
            return InputFloat(max, 1, message,  errorMessage);
        }
/*      意味がないので定義しない（エラーチェックする値の指定がないので入力エラーの判定ができない）
 *      static float InputFloat(string message,  string errorMessage)
        {

        }
*/
        static float InputFloat(
            float max,  //必ず指定するのでオプション無し
            float min=1,
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
