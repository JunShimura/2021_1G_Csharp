using System;

namespace Ex16_hintRandomToMax
{
    class Ex16_hintRandomToMax
    {
        const int tableSize = 10000;
        static void Main(string[] args)
        {
            Random random = new Random();   //Randomを使いたい場合は必要
            int[] table = new int[tableSize];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = random.Next(int.MinValue, int.MaxValue);  //Randomを使う場合
                Console.WriteLine($"table[{i}]={table[i]}");
            }
            //最大値を求める
            //var max = int.MinValue; //変数maxにint型で表現できる最小値を入れる　https://docs.microsoft.com/ja-jp/dotnet/api/system.int32.minvalue?view=net-5.0
            var max = table[0];
            for (int i = 1; i < table.Length; i++)
            {
                if (max < table[i])
                {   //もっと大きい値があった場合、最大値を更新
                    max = table[i];
                }
            }
            Console.WriteLine($"最大値＝{max}");
        }
    }
}
