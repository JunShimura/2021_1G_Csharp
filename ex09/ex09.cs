using System;

namespace ex09
{
    class ex09
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
            string message = null;
            switch (judge)
            {
                case 0:
                    message = "あいこです";
                    break;
                case 1:
                    message = "あなたの勝ちです";
                    break;
                case 2:
                    message = "あなたの負けです";
                    break;
                default:
                    break;
            }
            Console.WriteLine(message);

        }
    }
}
