using System;

namespace ex08_ex2
{
    class ex08_ex2
    {
        static void Main(string[] args)
        {
            Console.Write("身長を入力(cm):");
            var tall = double.Parse(Console.ReadLine());
            Console.Write("年収を入力(万円):");
            var income = double.Parse(Console.ReadLine());
            if (tall < 180)
            {   //身長が180cm未満
                if (income < 1000)
                {   //収入が1000万円未満
                    Console.WriteLine("論外ね");
                }
                else
                {   //収入が1000万円以上
                    Console.WriteLine("おしい");
                }
            }
            else
            {   //身長が180cm以上
                if (income<1000)
                {   //収入が1000万円未満
                    Console.WriteLine("おしい");
                }
                else
                {   //収入が1000万円以上
                    Console.WriteLine("大好き");
                }
            }
        }
    }
}
