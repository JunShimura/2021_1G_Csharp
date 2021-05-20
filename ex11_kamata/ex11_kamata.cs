using System;

namespace ex11_kamata
{
    class ex11_kamata
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1～20の数字を入力");//数字の入力
            int asterisk = int.Parse(Console.ReadLine());
            if (asterisk > 20)//asterriskが20以上ならば
            {
                Console.WriteLine("入力エラー");
                return;//「入力エラー」を表示
            }
            int i, j;
            for (i = 1; i <= asterisk; i++)
            {
                for (j = 1; j <= asterisk - i; j++)
                {
                    Console.Write("□");
                }
                for (j = 1; j <= i ; j++)
                {
                    Console.Write("■");
                }
                Console.Write("\n");

            }
        }
    }
}
