using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("幅(m)を入力してください"); // 文字列を出す
            var width = double.Parse(Console.ReadLine());   // 文字列を入力しwidthに変換し代入
            Console.WriteLine("奥行(m)を入力してください"); // 文字列を出す
            var depth = double.Parse(Console.ReadLine());   // 文字列を入力しdepthに変換し代入
            Console.WriteLine("高さ(m)を入力してください"); // 文字列を出す
            var height = double.Parse(Console.ReadLine());   // 文字列を入力しheightに変換し代入
            var surface = (width * height + width * depth + height * depth)*2;
            var volume = width * depth * height;
            Console.WriteLine($"表面積は{surface}㎡、体積は{volume}㎥");

        }
    }
}
