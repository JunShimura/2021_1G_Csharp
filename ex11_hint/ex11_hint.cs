using System;

namespace ex11_hint
{
    class ex11_hint
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            for (var n = 1; n <= x; n++) //高さ
            {
                for (var i = 1; i <= x; i++) //行ごとの幅
                {
                    Console.Write("＊");
                }
                Console.WriteLine();
            }
        }
    }
}

