using System;

namespace StaticSample
{
    class StaticSampleMain
    {
        static int sA = 5;
        static void Main(string[] args)
        {
            int a = 5;  // int型のインスタンス、a
            // TestClass1型のインスタンス、testClass1
            //TestClass1 testClass1A = new TestClass1(a);
            //TestClass1 testClass1B = new TestClass1(a);
            TestClass2.a = 3;
            int ans = TestClass2.GetAAA();
        }
    }
}
