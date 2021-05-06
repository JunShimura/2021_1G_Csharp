using System;

namespace ex05
{
    class ex05
    {
        static void Main(string[] args)
        {
            Console.Write("金額を入力:");
            var money = int.Parse(Console.ReadLine());
            var m10000 = money / 10000;
            if (m10000 > 0) {
                Console.WriteLine($"1万円札：{m10000}枚");
            }
            money %= 10000;
            var m5000 = money / 5000;
            if (m5000 > 0) {
                Console.WriteLine($"5千円札：{m5000}枚");
            }

            money %= 5000;
            var m1000 = money / 1000;
            if (m1000 > 0) {
                Console.WriteLine($"千円札：{m1000}枚");
            }

            money %= 1000;
            var m500 = money / 500;
            if (m500 > 0) {
                Console.WriteLine($"五百円玉：{m500}枚");
            }
            money %= 500;
            var m100 = money / 100;
            if (m100 >0) {
                Console.WriteLine($"百円玉：{m100}枚");
            }
            money %= 100;
            var m50 = money / 50;
            if (m50 > 0) {
                Console.WriteLine($"五十円玉：{m50}枚");
            }
            money %= 50;
            var m10 = money / 10;
            if (m10 > 0) {
                Console.WriteLine($"十円玉：{m10}枚");
            }
            money %= 10;
            var m5 = money / 5;
            if (m5 > 0) {
                Console.WriteLine($"五円玉：{m5}枚");
            }
            money %= 5;
            var m1 = money;
            if (m1 > 0) {
                Console.WriteLine($"一円玉：{m1}枚");
            }
        }
    }
}
