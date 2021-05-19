using System;

namespace For99
{
    class For99
    {
        static void Main(string[] args)
        {
            for (var n = 1; n <= 9; n++)
            {
                for (var i = 1; i <= 9; i++)
                {
                    Console.Write($"{(n * i).ToString("d2")} ");
                }
                Console.WriteLine();
            }
        }
    }
}
