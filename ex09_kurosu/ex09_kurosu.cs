using System;

namespace ex09_kurosu
{
    class ex09_kurosu
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            var com = rand.Next(0, 3);
            Console.WriteLine("★じゃんけんゲーム★\n手を入力してね\n(0=ぐう、1=ちょき、2=ぱあ)");
            var player = int.Parse(Console.ReadLine());
            Console.WriteLine($"私は{com}、あなたは{player}");
            if (com == player)
            {
                Console.WriteLine("あいこ");
            }
            else if (com == 0)
            {
                if (player == 1)
                {
                    Console.WriteLine("あなたの負け");
                }
                else if (player == 2)
                {
                    Console.WriteLine("あなたの勝ち");
                }
            }
            else if (com == 1)
            {
                if (player == 0)
                {
                    Console.WriteLine("あなたの勝ち");
                }
                else if (player == 2)
                {
                    Console.WriteLine("あなたの負け");
                }
            }
            else if (com == 2)
            {
                if (player == 0)
                {
                    Console.WriteLine("あなたの負け");
                }
                else if (player == 1)
                {
                    Console.WriteLine("あなたの勝ち");
                }
            }
        }
    }
}
