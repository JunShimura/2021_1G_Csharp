using System;

namespace Ex16_hint
{
    class Ex16_hint
    {
        const int tableSize = 10;
        static void Main(string[] args)
        {
            Random random = new Random();   //Randomを使いたい場合は必要
            int[] table = new int[tableSize];
            for(int i = 0; i < table.Length; i++)
            {
                Console.Write($"数値を入力,{i+1}個目：");
                //table[i] = int.Parse(Console.ReadLine());   //入力する場合
                table[i] = random.Next(-100, 100);  //Randomを使う場合
                Console.WriteLine(table[i]);
            }
        }
    }
}
