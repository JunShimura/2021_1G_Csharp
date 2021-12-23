using System;

namespace InheritanceSampleSuraSura
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("しむら", 25);
            Student[] student1 = {
                new Student("anbo", 18, 10000),
                new Student("iizawa", 19, 10001)
            };
            Worker worker1 = new Worker("seki", 22);
            student1[0].SelfIntroduction();    //基底クラスのメンバ関数を呼び出せる
            Person.SelfIntroduction(worker1);
            ElementarySchoolStudent iwamatsu
                = new ElementarySchoolStudent("いわまつ",8,4,2);
            iwamatsu.SelfIntroduction();
        }
    }
}
