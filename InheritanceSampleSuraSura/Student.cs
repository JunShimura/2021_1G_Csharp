using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceSampleSuraSura
{
    class Student:Person
    {
        private int Id;  // 学籍番号
        public Student(string name, int age = 0, int Id=0 ):base(name,age)
        {
            this.Id = Id;
        }
        new public void  SelfIntroduction()
        {
            base.SelfIntroduction();
            Console.WriteLine($"学籍番号は{Id}です。");
        }
    }
}
