using System;

namespace Ex21_hint
{
    class ex21_hint
    {

        static void Main(string[] args)
        {
            string s1 = InputString("名前を入力してください");
            int no = InputNumber("ほめ指数を入力してください");
            string s2 = Praise(s1, no);
            Console.WriteLine(s2);
        }
        static string Praise(string s, int praiseIndex)
        {
            //ここに処理を追加
            string answer = null;
            return answer;
        }
        static int InputNumber(string message)
        {
            Console.WriteLine(message);
            int i = int.Parse(Console.ReadLine());
            return i;
        }
        static string InputString(string message)
        {
            Console.WriteLine(message);
            var i = Console.ReadLine();
            return i;
        }

    }
}
