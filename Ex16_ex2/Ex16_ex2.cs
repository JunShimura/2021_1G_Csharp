using System;

namespace Ex16_ex2
{
    class Ex16_ex2
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
            var maxId = 0;
            var minId = 0;
            var sum = table[0];
            for (int i = 1; i < table.Length; i++)
            {
                if (table[maxId] < table[i])
                {   //もっと大きい値があった場合、最大値を更新
                    maxId = i;
                }
                else if (table[minId] > table[i])
                {   //もっと小さい値があった場合、最小値を更新
                    minId = i;
                }
                sum += table[i];
            }
            sw.Stop();

            Console.WriteLine($"最大値＝{table[maxId]}\n最小値={table[minId]}\n平均={(double)sum / table.Length}");
            Console.WriteLine("■処理Aにかかった時間");
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($"　{ts}");
            Console.WriteLine($"　{ts.Hours}時間 {ts.Minutes}分 {ts.Seconds}秒 {ts.Milliseconds}ミリ秒");
            Console.WriteLine($"　{sw.ElapsedMilliseconds}ミリ秒");


        }
    }
}
