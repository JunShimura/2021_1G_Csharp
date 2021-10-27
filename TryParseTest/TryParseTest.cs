using System;

namespace TryParseTest
{
    class TryParseTest
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            var s = Console.ReadLine();
            //　入力した文字列を変換する
            bool sucess = int.TryParse(s, out a);
            if (sucess)
            {
                Console.WriteLine($"変換できました、値は{a}");
            }
            else
            {
                Console.WriteLine($"変換できませんでした");
            }
            /*
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("数値ではありません");
            }
            catch (OverflowException)
            {
                Console.WriteLine("値が大きすぎます");
            }
            b = int.Parse(Console.ReadLine());
            try
            {
                c = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("０除算が発生しました");
            }
            Console.WriteLine(c);
            */
        }
    }
}
