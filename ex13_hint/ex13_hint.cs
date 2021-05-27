using System;

namespace ex13
{
    class ex13
    {
        static void Main(string[] args)
        {
            //　難易度の設定
            const int max = 10;   //乱数の最大値
            const int maxTime = 3; //解答できる回数

            //  乱数で正解を設定
            Random rand = new Random();    // 乱数生成オブジェクトを生成
            var answer = rand.Next(1, max); //　乱数が入る
            //回答を入力
            for (int i = 0; i < maxTime; i++)
            {
                Console.WriteLine("いくつでしょうか？");
                var inputNum = int.Parse(Console.ReadLine());
                if (inputNum == answer)
                {
                    Console.WriteLine("当たり！");
                    break;
                }
            }
            Console.WriteLine($"答えは{answer}でした");
        }
    }
}

