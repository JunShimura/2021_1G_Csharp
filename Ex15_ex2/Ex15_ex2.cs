using System;

namespace Ex15_ex2
{
    class Ex15_ex2
    {
        static void Main(string[] args)
        {
            Console.Write("数を入力：");
            var inputNumber = int.Parse(Console.ReadLine());
            string[] words0to99 =
                {
                    "zero", "one",  "two",  "three",    "four", "five", "six",  "seven",    "eight",    "nine",
                    "ten",  "eleven","twelve","thirteen","fourteen",
                    "fifteen","sixteen","seventeen","eighteen","nineteen",
                    "twenty","twenty-one","twenty-two","twenty-three","twenty-four",
                    "twenty-five","twenty-six","twenty-seven","twenty-eight","twenty-nine",
                    "thirty","thirty-one","thirty-two","thirty-three","thirty-four",
                    "thirty-five","thirty-six","thirty-seven","thirty-eight","thirty-nine",
                    "fourty","fourty-one","fourty-two","fourty-three","fourty-four",
                    "fourty-five","fourty-six","fourty-seven","fourty-eight","fourty-nine",
                    "fifty","fifty-one","fifty-two","fifty-three","fifty-four",
                    "fifty-five","fifty-six","fifty-seven","fifty-eight","fifty-nine",
                    "sixty","sixty-one","sixty-two","sixty-three","sixty-four",
                    "sixty-five","sixty-six","sixty-seven","sixty-eight","sixty-nine",
                     "seventy","seventy-one","seventy-two","seventy-three","seventy-four",
                    "seventy-five","seventy-six","seventy-seven","seventy-eight","seventy-nine",
                    "eighty","eighty-one","eighty-two","eighty-three","eighty-four",
                    "eighty-five","eighty-six","eighty-seven","eighty-eight","eighty-nine",
                    "ninety","ninety-one","ninety-two","ninety-three","ninety-four",
                    "ninety-five","ninety-six","ninety-seven","ninety-eight","ninety-nine"
                };
            if (inputNumber >= 0 && inputNumber <= 99)
            {
                Console.WriteLine(words0to99[inputNumber]);
            }
            else
            {
                Console.WriteLine("入力エラー");
            }
        }
    }
}
