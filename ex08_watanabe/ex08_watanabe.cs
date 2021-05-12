using System;

namespace ex08_watanabe
{
    class ex08_watanabe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("年収を入力してください(万単位)");
            var money = int.Parse(Console.ReadLine());
            Console.WriteLine("身長を入力してください(cm単位)");
            var height = int.Parse(Console.ReadLine());
            if (money >= 1000)
            {
                if (height >= 180)
                {
                    Console.WriteLine("大好き!");
                }
                else
                {
                    Console.WriteLine("おしい");
                }
            }
            else //if (money < 1000)
            {
                if (height < 180)
                {
                    Console.WriteLine("論外");
                }
                else
                {
                    Console.WriteLine("おしい");
                }
            }
        }
    }
}
