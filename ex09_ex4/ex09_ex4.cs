using System;

namespace ex09_ex4
{
    class ex09_ex4
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var com = rand.Next(0, 3);
            Console.WriteLine("★じゃんけんゲーム★\n手を入力してね\n(0=ぐう、1=ちょき、2=ぱあ)");
            var player = int.Parse(Console.ReadLine());
            Console.WriteLine($"私は{com}、あなたは{player}");
            //ここで勝ち負けの判定を行いメッセージを出力
            var judge = (com - player + 3) % 3;
            string[] message = { "あいこです", "あなたの勝ちです", "あなたの負けです" };
            Console.WriteLine(message[judge]);

        }
    }
}

