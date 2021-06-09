using System;

namespace ex15_hint
{
    class Ex15_hint
    {
        static void Main(string[] args)
        {
            Console.Write("数を入力：");
            var inputNumber = int.Parse(Console.ReadLine());
            string[] words0to19 =
                {
                    "zero", "one",  "two",  "three",    "four", "five", "six",  "seven",    "eight",    "nine",
                    "ten",  "eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"
                };
            if(inputNumber>=0 && inputNumber <= 99)
            {
                Console.WriteLine(words0to19[inputNumber]);
            }
            else
            {
                Console.WriteLine("入力エラー");
            }
        }
    }
}
