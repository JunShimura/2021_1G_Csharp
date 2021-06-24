using System;
using System.Collections;

namespace Ex19_ex5
{
    class Ex17_ex5
    {
        //設定
        const int tableSize = 10000;
        const int randomRangeMin = int.MinValue;
        const int randomRangeMax = int.MaxValue;
        /*     
                 const int tableSize = 10;
                const int randomRangeMin = -10;
                const int randomRangeMax = 10;
        */
        static void Main(string[] args)
        {
            int x = 100;
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
            Array.Sort(table, new ReverseComparer());

            //Array.Reverse(table);
            //Array.Sort(words, revComparer);

            sw.Stop();

            Console.WriteLine("整列後");
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine($"table[{i}]={table[i]}");
            }

            Console.WriteLine("■処理Aにかかった時間");
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($"　{ts}");
            Console.WriteLine($"　{ts.Hours}時間 {ts.Minutes}分 {ts.Seconds}秒 {ts.Milliseconds}ミリ秒");
            Console.WriteLine($"　{sw.ElapsedMilliseconds}ミリ秒");
        }
    }

    public class ReverseComparer : IComparer
    {
        // Call CaseInsensitiveComparer.Compare with the parameters reversed.
        public int Compare(Object x, Object y)
        {
            return (new CaseInsensitiveComparer()).Compare(y, x);
        }
    }
}
