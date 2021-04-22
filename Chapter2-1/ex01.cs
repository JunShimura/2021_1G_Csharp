using System;

namespace Chapter2_1
{
    class ex01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("身長(m)を入力してください"); // 文字列を出す
            var height = double.Parse(Console.ReadLine());   // 文字列を入力しheightに変換し代入
            Console.WriteLine("体重(kg)を入力してください"); // 文字列を出す
            var weight = double.Parse(Console.ReadLine());   // 文字列を入力しweightに変換し代入
            var bmi = weight / (height * height);  // BMIを算出
            //var bmi = weight / height / height;  // BMIを算出
            Console.WriteLine($"BMI = {bmi}");  //計算の結果を文字列で表示
            Console.WriteLine($"BMI = {bmi:f2}");  //計算の結果を文字列で表示
        }
    }
}
