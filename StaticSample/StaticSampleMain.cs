using System;

namespace StaticSample
{
    class StaticSampleMain
    {
        static int sA = 5;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 5;  // int型のインスタンス、a
            // TestClass1型のインスタンス、testClass1
            TestClass1 testClass1A = new TestClass1(a);
            TestClass1 testClass1B = new TestClass1(a);
        }
    }
}
