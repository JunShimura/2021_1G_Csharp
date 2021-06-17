using System;
using System.Linq;

namespace Ex16_ex3
{
    class Ex16_ex3
    {
        const int tableSize = 10000;
        static void Main(string[] args)
        {
            // Stopwatchクラス生成
            var sw = new System.Diagnostics.Stopwatch();
            Random random = new Random();   //Randomを使いたい場合は必要
            int[] table = new int[tableSize];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = random.Next(int.MinValue, int.MaxValue);  //Randomを使う場合
                Console.WriteLine($"table[{i}]={table[i]}");
            }

            sw.Start();

            //最大値,最小値を求める
            var max = table.Max();
            var min = table.Min();
            var average = table.Average();
            
            sw.Stop();

            Console.WriteLine($"最大値＝{max}\n最小値={min}\n平均={average}");
            Console.WriteLine("■処理Aにかかった時間");
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($"　{ts}");
            Console.WriteLine($"　{ts.Hours}時間 {ts.Minutes}分 {ts.Seconds}秒 {ts.Milliseconds}ミリ秒");
            Console.WriteLine($"　{sw.ElapsedMilliseconds}ミリ秒");


        }
    }
}
