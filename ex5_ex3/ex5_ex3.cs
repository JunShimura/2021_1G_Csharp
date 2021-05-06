using System;

namespace ex5_ex3
{
    class ex5_ex3
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("金額を入力:");
            var money = int.Parse(Console.ReadLine());
            n = money / 10000;
            if (n > 0)
            {
                Console.WriteLine($"1万円札：{n}枚");
            }
            money %= 10000;
            if (money == 0)
            {
                return;
            }
            n = money / 5000;
            if (n > 0)
            {
                Console.WriteLine($"5千円札：{n}枚");
            }

            money %= 5000;
            if (money == 0)
            {
                return;
            }
            n = money / 1000;
            if (n > 0)
            {
                Console.WriteLine($"千円札：{n}枚");
            }

            money %= 1000;
            if (money == 0)
            {
                return;
            }
            n = money / 500;
            if (n > 0)
            {
                Console.WriteLine($"五百円玉：{n}枚");
            }
            money %= 500;
            if (money == 0)
            {
                return;
            }
            n = money / 100;
            if (n > 0)
            {
                Console.WriteLine($"百円玉：{n}枚");
            }
            money %= 100;
            if (money == 0)
            {
                return;
            }
            n = money / 50;
            if (n > 0)
            {
                Console.WriteLine($"五十円玉：{n}枚");
            }
            money %= 50;
            if (money == 0)
            {
                return;
            }
            n = money / 10;
            if (n > 0)
            {
                Console.WriteLine($"十円玉：{n}枚");
            }
            money %= 10;
            if (money == 0)
            {
                return;
            }
            n = money / 5;
            if (n > 0)
            {
                Console.WriteLine($"五円玉：{n}枚");
            }
            money %= 5;
            if (money == 0)
            {
                return;
            }
            n = money;
            if (n > 0)
            {
                Console.WriteLine($"一円玉：{n}枚");
            }
        }
    }
}
