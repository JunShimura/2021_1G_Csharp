using System;
using System.Collections.Generic;
using System.Text;

namespace Ex30
{
    class Student:Person
    {
        public readonly int id;
        public Student(int id, DateTime bd, string n, float w = 0, float h = 0, float d = 0):base(bd, n, w, h, d)
        {
            this.id = id;
        }
    }
}
