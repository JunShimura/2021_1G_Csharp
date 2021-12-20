using System;
using System.Collections.Generic;
using System.Text;

namespace StaticSample
{
    static class TestClass2
    {
        public static int a = 0;
        //public TestClass2(int a)    //コンストラクターは要らないので定義できない
        //{
        //    this.a = a;
        //}
        static public int GetAAA()
        {
            int ans = a * a * a;
            return ans;
        }
    }
}
