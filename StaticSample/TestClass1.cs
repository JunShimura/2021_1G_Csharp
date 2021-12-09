using System;
using System.Collections.Generic;
using System.Text;

namespace StaticSample
{
    class TestClass1
    {
        int a = 0;
        public TestClass1(int a)
        {
            this.a = a;
        }
        public int GetAAA()
        {
            int ans = a * a * a;
            return ans;
        }
    }
}
