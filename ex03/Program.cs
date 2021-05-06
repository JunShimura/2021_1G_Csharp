using System;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("頭の数を入力してください"); // 文字列を出す
            var heads = int.Parse(Console.ReadLine());   // 文字列を入力しheadsに変換し代入
            Console.WriteLine("脚の数を入力してください"); // 文字列を出す
            var legs = int.Parse(Console.ReadLine());   // 文字列を入力しlegsに変換し代入

        }
    }
}
