using System;

namespace MethodSample
{
    class EX18_hint
    {
        static void Main(string[] args)
        {
            HelloWorldJapanese();
            HelloWorldEnglish();
            HelloWorldBelorussiya();
            return; //省略されている
        }
        static void HelloWorldEnglish()
        {
            Console.WriteLine("Hello World!");
        }
        static void HelloWorldJapanese()
        {
            Console.WriteLine("こんにちは世界!");
        }
        static void HelloWorldBelorussiya()
        {
            Console.WriteLine("Прывітанне Сусвет!");
        }
    }
}
