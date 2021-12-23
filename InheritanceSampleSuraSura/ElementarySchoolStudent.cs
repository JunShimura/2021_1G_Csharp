using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceSampleSuraSura
{
    class ElementarySchoolStudent:Student
    {
        int grade;
        public ElementarySchoolStudent(string name, int age = 0, int Id = 0,int grade=1) 
            :base(name, age, Id)
        {
            this.grade = grade;
        }
        new public void SelfIntroduction()
        {
            Console.WriteLine($"私のなまえは{name}です、ねんれいは{age}才です。");
            Console.WriteLine($"今、{grade}年生です。");
        }
    }
}
