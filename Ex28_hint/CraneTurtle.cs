using System;
using System.Collections.Generic;
using System.Text;

namespace Ex28_hint
{
    class CraneTurtle
    {
        private int legsA;  // 動物Aの脚の数
        private int legsB;  // 動物Bの脚の数
        public float heads;  // 全部の頭の数
        public float legs;     // 全部の脚の数
        public int headsA;  // 動物Aの頭数（計算で求められる）
        public int headsB;  // 動物Bの頭数（計算で求められる）

        public CraneTurtle(int a,int b)
        {
            legsA = a;
            legsB = b;
        }
        public CraneTurtle(int a, int b, int h,int l)
        {
            legsA = a;
            legsB = b;
            heads = h;
            legs = l;
        }
        public void SetHeadsLegs(int h, int l)
        {
            heads = h;
            legs = l;
        }
    }
}
