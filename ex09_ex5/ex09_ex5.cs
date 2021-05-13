using System;

namespace ex09_ex5
{
    class ex09_ex5
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var cpu = rand.Next(0, 3);
            Console.WriteLine("★じゃんけんゲーム★\n手を入力してね\n(0=グー、1=チョキ、2=パー)");
            var player = int.Parse(Console.ReadLine());
            Console.WriteLine($"私は{cpu}、あなたは{player}");
            //ここで勝ち負けの判定を行いメッセージを出力
            switch (cpu)
            {
                case 0: //　cpuがぐう
                    switch (player)
                    {
                        case 0://プレイヤーがぐう
                            Console.WriteLine("あいこです");
                            break;
                        case 1:
                            //プレイヤーがちょき
                            Console.WriteLine("あなたの負け");
                            break;
                        case 2:
                            //プレイヤーがぱあ
                            Console.WriteLine("あなたの勝ち");
                            break;
                        default:
                            break;
                    }
                    break;
                case 1:    //　cpuがちょき
                    switch (player)
                    {
                        case 0://プレイヤーがぐう
                            Console.WriteLine("あなたの勝ち");
                            break;
                        case 1: //プレイヤーがちょき
                            Console.WriteLine("あいこです");
                            break;
                        case 2: //プレイヤーがぱあ
                            Console.WriteLine("あなたの負け");
                            break;
                        default:
                            break;
                    }
                    break;
                case 2://　cpuがぱあ
                    switch (player)
                    {
                        case 0://プレイヤーがぐう
                            Console.WriteLine("あなたの負け");
                            break;
                        case 1: //プレイヤーがちょき
                            Console.WriteLine("あなたの勝ち");
                            break;
                        case 2: //プレイヤーがぱあ
                            Console.WriteLine("あいこです");
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}

