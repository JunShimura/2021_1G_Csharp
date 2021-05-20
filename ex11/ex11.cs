using System;

namespace ex11
{
    class ex11
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            if (x >= 1 && x <= 20)
            {
                for (var n = 1; n <= x; n++) //高さ
                {
                    for (var i = 1; i <= n; i++) //行ごとの幅が何行目かと一致する
                    {
                        Console.Write("＊");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("入力エラー");
            }
        }
    }
}
