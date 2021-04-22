using System;

namespace ex04
{
    class ex04
    {
        static void Main(string[] args)
        {
            Console.Write("金額を入力:");
            var money = int.Parse(Console.ReadLine());
            Console.WriteLine($"1万円札：{  money / 10000}枚");
            Console.WriteLine($"5千円札：{  money % 10000 / 5000}枚");
            Console.WriteLine($"千円札：{    money % 5000 / 1000}枚");
            Console.WriteLine($"五百円玉：{ money % 1000 / 500}枚");
            Console.WriteLine($"百円玉：{    money % 500 / 100}枚");
            Console.WriteLine($"五十円玉：{ money % 100 / 50}枚");
            Console.WriteLine($"十円玉：{    money % 50 / 10}枚");
            Console.WriteLine($"五円玉：{    money % 10 / 5}枚");
            Console.WriteLine($"一円玉：{    money % 5}枚");
        }
    }
}

