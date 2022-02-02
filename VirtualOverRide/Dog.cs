using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualOverRide
{
    class Dog : Animal
    {
        public Dog(string voice, DateTime lifeSpan, DateTime bd, string n, float w = 0, float h = 0, float d = 0, float weight = 0) : base(voice, lifeSpan, bd, n, w, h, d, weight)
        {
        }
        public override string Speak()
        {
            var result = string.Empty;
            for(var i = 0; i < birthday.Month; i++)
            {
                result += this.voice;
            }
            return $"{result}と鳴く";
        }
    }
}

