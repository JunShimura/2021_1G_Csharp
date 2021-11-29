using System;

namespace Space1
{
    class Class1
    {
        public static void test()
        {
            Console.WriteLine("Space1.Class1.test() called");
        }
    }
}

namespace Space1
{
    class Class2
    {
        public static void test()
        {
            Console.WriteLine("Space1.Class2.test() called");
        }
    }
}

namespace ConsoleApplication21
{
    class Class1
    {
        static void Main(string[] args)
        {
            Space1.Class1.test();
            Space1.Class2.test();
        }
    }
}
