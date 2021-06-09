using System;

namespace DimentionSample
{
    class DimentionSample
    {
        static void Main(string[] args)
        {
            //　配列でとる
            const int numMember = 5;
            double[] tall= new double[numMember];
            //身長5人分を入力
            /*
            Console.Write("0番目の身長:");
            tall[0] = int.Parse(Console.ReadLine());
            Console.Write("1番目の身長:");
            tall[1] = int.Parse(Console.ReadLine());
            */
            for (var i = 0; i < numMember; i++)
            {
                Console.Write($"{i}番目の身長:");
                tall[i] = double.Parse(Console.ReadLine());
            }
        }
    }
}
