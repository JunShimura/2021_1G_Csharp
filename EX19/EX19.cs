using System;

namespace EX19
{
    class EX19
    {
        static void Main(string[] args)
        {
            //string s1 = Console.ReadLine();
            //string s2 = Praise(s1);
            //Console.WriteLine(s2);
            Console.WriteLine(Praise(Console.ReadLine()));


        }
        static string Praise(string s)
        {
            //s ="うそじゃないです"+s + "さんかっこいい！";
            s = $"うそじゃないです{s}さんかっこいい！";
            return s;
        }
    }
}
