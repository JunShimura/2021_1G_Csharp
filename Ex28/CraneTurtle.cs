using System;
using System.Collections.Generic;
using System.Text;

namespace Ex28
{
    class CraneTurtle
    {
        private int legsA;  // 動物Aの脚の数
        private int legsB;  // 動物Bの脚の数
        private float _heads = 0;  // 全部の頭の数
        public float heads  // 全部の頭の数へのアクセサ
        {
            get
            {
                return _heads;
            }
            set
            {
                heads = value;
            }
        }
        private float _legs = 0;// 全部の脚の数
        public float legs    // 全部の脚の数へのアクセサ
        {
            get
            {
                return _legs;
            }
            set
            {
                if (legs != value)
                {
                    legs = value;
                    GetHeads();
                }
                legs = value;
            }
        }
        public int headsA;  // 動物Aの頭数（計算で求められる）
        public int headsB;  // 動物Bの頭数（計算で求められる）

        public CraneTurtle(int a, int b)
        {
            legsA = a;
            legsB = b;
        }
        public CraneTurtle(int a, int b, int h, int l)
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
        void GetHeads()
        {
            // 動物Aの頭数と動物Aの頭数を求める
        }
    }
}
