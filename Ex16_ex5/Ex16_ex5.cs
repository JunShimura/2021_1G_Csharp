using System;
using System.Numerics;

namespace Ex16_ex5
{
    class Ex16_ex5
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
            int simdLegth = Vector<int>.Count;
            int myLast = table.Length - simdLegth;
            var vMax = new Vector<int>(int.MinValue);
            var vMin = new Vector<int>(int.MaxValue);
            for (var i = 0; i < myLast; i += simdLegth)
            {
                vMax = Vector.Max(vMax, new Vector<int>(table, i));
                vMin = Vector.Min(vMax, new Vector<int>(table, i));
            }
            var max = int.MinValue;
            var min = int.MaxValue;
            for (var i = 0; i < simdLegth; i++)
            {
                if(max < vMax[i])
                {
                    max = vMax[i];
                }
                if (min > vMin[i])
                {
                    min = vMin[i];
                }
            }
            for(var i = myLast; i < table.Length; i++)
            {
                if (max < table[i])
                {
                    max = table[i];
                }
                if (min > table[i])
                {
                    min = table[i];
                }
            }
            var sum = 0;
            for (int i = 1; i < table.Length; i++)
            {
                sum += table[i];
            }
            sw.Stop();

            Console.WriteLine($"最大値＝{max}\n最小値={min}\n平均={(double)sum / table.Length}");
            Console.WriteLine("■処理Aにかかった時間");
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($"　{ts}");
            Console.WriteLine($"　{ts.Hours}時間 {ts.Minutes}分 {ts.Seconds}秒 {ts.Milliseconds}ミリ秒");
            Console.WriteLine($"　{sw.ElapsedMilliseconds}ミリ秒");
        }
    }
}
