using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverRide
{
    class Animal : Life
    {
        //protected string voice;
        readonly public string voice;
        public Animal(string voice,　DateTime lifeSpan, DateTime bd, string n, float w = 0, float h = 0, float d = 0,float weight=0) : base(lifeSpan,bd, n, w, h, d,weight)
        {
            this.voice = voice;
        }
        public virtual string Speak()
        {
            return $"{voice}と鳴く";
        }
    }
}
