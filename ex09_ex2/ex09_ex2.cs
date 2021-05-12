using System;

namespace ex09_ex2
{
    class ex09_ex2
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var cpu = rand.Next(0, 3);
            Console.WriteLine("★じゃんけんゲーム★\n手を入力してね\n(0=グー、1=チョキ、2=パー)");
            var player = int.Parse(Console.ReadLine());
            Console.WriteLine($"私は{cpu}、あなたは{player}");
            //ここで勝ち負けの判定を行いメッセージを出力
            if(cpu == 0)
            {   //　cpuがぐう
                if (player == 0)
                {   //プレイヤーがぐう
                    Console.WriteLine("あいこです");
                }
                else if(player == 1)
                {   //プレイヤーがちょき
                    Console.WriteLine("あなたの負け");
                }
                else if (player == 2)
                {   //プレイヤーがぱあ
                    Console.WriteLine("あなたの勝ち");
                }
            }
            else if (cpu == 1)
            {   //　cpuがちょき
                if (player == 0)
                {   //プレイヤーがぐう
                    Console.WriteLine("あなたの勝ち");
                }
                else if (player == 1)
                {   //プレイヤーがちょき
                    Console.WriteLine("あいこです");
                }
                else if (player == 2)
                {   //プレイヤーがぱあ
                    Console.WriteLine("あなたの負け");
                }
            }
            if (cpu == 2)
            {   //　cpuがぱあ
                if (player == 0)
                {   //プレイヤーがぐう
                    Console.WriteLine("あなたの負け");
                }
                else if (player == 1)
                {   //プレイヤーがちょき
                    Console.WriteLine("あなたの勝ち");
                }
                else if (player == 2)
                {   //プレイヤーがぱあ
                    Console.WriteLine("あいこです");
                }
            }
        }
    }
}
