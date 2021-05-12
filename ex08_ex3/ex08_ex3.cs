using System;

namespace ex08_ex3
{
    class ex08_ex3
    {
        static void Main(string[] args)
        {
            Console.Write("身長を入力(cm):");
            var tall = double.Parse(Console.ReadLine());
            Console.Write("年収を入力(万円):");
            var income = double.Parse(Console.ReadLine());
            if (tall >= 180 && income >= 1000)
            {   //身長が180cm以上 かつ 収入が1000万円以上
                Console.WriteLine("大好き！");
            }
            else if (tall < 180 && income < 1000)
            {   //身長が180cm未満 かつ 収入が1000万円未満
                Console.WriteLine("論外ね");
            }
            else
            {   //その他
                Console.WriteLine("おしい");
            }
        }
    }
}
