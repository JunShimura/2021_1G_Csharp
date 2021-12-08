using System;
using System.Collections.Generic;
using System.Text;

namespace Ex28
{
    class CraneTurtle
    {
        private int legsA;  // 動物Aの脚の数
        private int legsB;  // 動物Bの脚の数
        private int _heads = 0;  // 全部の頭の数
        public int heads  // 全部の頭の数へのアクセサ
        {
            get
            {
                return _heads;
            }
            set
            {
                if (_heads != value)
                {
                    _heads = value;
                    GetHeads();
                }
            }
        }
        private int _legs = 0;// 全部の脚の数
        public int legs    // 全部の脚の数へのアクセサ
        {
            get
            {
                return _legs;
            }
            set
            {
                if (_legs != value)
                {
                    _legs = value;
                    GetHeads();
                }
                _legs = value;
            }
        }
        private float _headsA = 0;
        public float headsA
        {  // 動物Aの頭数（計算で求められる）
            get
            {
                return _headsA;
            }
            private set
            {
                _headsA = value;
            }
        }
        private float _headsB = 0;
        public float headsB  // 動物Bの頭数（計算で求められる）
        {
            get
            {
                return _headsB;
            }
            private set
            {
                _headsB = value;
            }
        }

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
            _heads = h;
            _legs = l;
            GetHeads();
        }
        void GetHeads()
        {
            // 動物Aの頭数と動物Aの頭数を求める
            _headsB = (_legs - _heads * legsA) / (legsB - legsA);
            _headsA = _heads - _headsB;
        }
    }
}
