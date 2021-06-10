using System;

namespace Ex15_ex4
{
    class Ex15_ex4
    {
        static void Main(string[] args)
        {
            string [] words0to19 =
                {
                    "zero", "one",  "two",  "three",    "four", "five", "six",  "seven",    "eight",    "nine",
                    "ten",  "eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"
                };
            string[] words20to90 =
                { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            string[] words = new string[100]; 
            for(var i = 0; i < words0to19.Length; i++)
            {
                words[i] = words0to19[i];
            }
            for (var i = words0to19.Length; i < words.Length; i++)
            {
                int ten = i / 10; //10の位
                int one = i % 10; //１の位
                words[i] = words20to90[ten - 2];
                if (one != 0)
                {
                    words[i] += ("-" + words0to19[one]);
                }
           }
            Console.Write("数を入力：");
            var inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber >= 0 && inputNumber <= 99)
            {
                Console.WriteLine(words[inputNumber]);
            }
            else
            {
                Console.WriteLine("入力エラー");
            }
        }
    }
}
