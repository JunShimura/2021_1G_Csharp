using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualOverRide
{
    class Cat:Animal
    {
        public Cat(string voice,DateTime lifeSpan, DateTime bd, string n, float w = 0, float h = 0, float d = 0,float weight=0)
            : base(voice, lifeSpan, bd, n, w, h, d,weight)
        {

        }
    }
}
