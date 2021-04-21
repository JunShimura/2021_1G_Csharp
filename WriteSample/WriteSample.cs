using System;

namespace WriteSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var tall = 167.5;
            var bmi = 22.5;
            Console.WriteLine("Hello World!");
            Console.WriteLine(bmi);
            Console.WriteLine("身長は"+tall+"、BMI=" + bmi);
            Console.WriteLine("身長は{0}、BMI={1}",tall,bmi);
            Console.WriteLine($"身長は{tall}、BMI={bmi}");



        }
    }
}
