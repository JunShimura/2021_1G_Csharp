using System;

namespace ex09_ex3
{
    class ex09_ex3
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var cpu = rand.Next(0, 3);
            Console.WriteLine("★じゃんけんゲーム★\n手を入力してね\n(0=グー、1=チョキ、2=パー)");
            var player = int.Parse(Console.ReadLine());
            Console.WriteLine($"私は{cpu}、あなたは{player}");
            //ここで勝ち負けの判定を行いメッセージを出力
            if (cpu == player)
            {
                Console.WriteLine("あいこです");
            }
            else if ((cpu - player + 3) % 3 == 1)
            {
                Console.WriteLine("あなたの勝ちです");
            }
            else
            {
                Console.WriteLine("あなたの負けです");
            }
        }
    }
}
