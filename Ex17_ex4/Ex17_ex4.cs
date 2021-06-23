using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex17_ex4
{
    class Ex17_ex4
    {
        //設定
        const int tableSize = 100;
        const int randomRangeMin = int.MinValue;
        const int randomRangeMax = int.MaxValue;
        /*     
                 const int tableSize = 10;
                const int randomRangeMin = -10;
                const int randomRangeMax = 10;
        */
        static void Main(string[] args)
        {
            // Stopwatchクラス生成
            var sw = new System.Diagnostics.Stopwatch();
            Random random = new Random();   //Randomを使いたい場合は必要
            int[] table = new int[tableSize];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = random.Next(randomRangeMin, randomRangeMax);  //Randomを使う場合
                //table[i] = table.Length - i;

                Console.WriteLine($"table[{i}]={table[i]}");
            }

            sw.Start();
            
            /*
            foreach (var num in table.OrderByDescending(e => e))
            {
                Console.WriteLine(num);
            }
            */
            IEnumerable<int> outArray = table.OrderByDescending(e => e);

            sw.Stop();

            /*
             Console.WriteLine("整列後");
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine($"table[{i}]={table[i]}");
            }
            */
            foreach (var num in outArray)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("■処理Aにかかった時間");
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($"　{ts}");
            Console.WriteLine($"　{ts.Hours}時間 {ts.Minutes}分 {ts.Seconds}秒 {ts.Milliseconds}ミリ秒");
            Console.WriteLine($"　{sw.ElapsedMilliseconds}ミリ秒");
        }
    }
}
