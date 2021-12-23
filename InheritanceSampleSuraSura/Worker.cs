using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceSampleSuraSura
{
    class Worker:Person
    {
        private int income;
        public Worker(string name, int age = 0,int income = 0) : base(name, age)
        {
            this.income = income;
        }
    }
}
