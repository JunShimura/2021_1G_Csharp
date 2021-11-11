using System;

namespace ClassSample
{
    class ClassSampleMain
    {
        static void Main(string[] args)
        {
            ClassSampleA classSampeA = new ClassSampleA(3,8);    // インスタンス
            var a = classSampeA.Func();
            //classSampeA.a = 5; //エラーになる
            Console.WriteLine(a);
        }
    }
    class ClassSampleA   //　Classの宣言
    {
        int a;
        int b;
        public ClassSampleA(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Func()
        {
            return a + b;
        }
    }
}
