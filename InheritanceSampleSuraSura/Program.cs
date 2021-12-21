using System;

namespace InheritanceSampleSuraSura
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Student student1 = new Student();
            Student student2 = new Student();
            person1.name = "しむら";
            person1.age = 25;
            person2.name = "seki";
            person2.age = 22;
            student1.name = "anbo"; //基底クラスの値を参照している
            student1.age = 18;
            student1.Id = 10000;
            student1.name = "iizawa";
            student1.age = 19;
            student1.Id = 10001;
        }
    }
}
