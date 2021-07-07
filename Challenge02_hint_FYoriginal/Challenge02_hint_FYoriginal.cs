using System;

namespace Challenge02_hint_FYoriginal
{
    class Challenge02_hint_FYoriginal
    {
        static void Main(string[] args)
        {
            char[] tetrimino1 = { 'I', 'O', 'S', 'Z', 'J', 'L', 'T' };      //元
            char[] tetrimino2 = new char[tetrimino1.Length];    //ランダムにしたもの
            Random random = new Random();

            for (var i = 0; i < tetrimino1.Length; i++)
            {
                var source = random.Next(0,tetrimino1.Length-i);
                var counter = -1;
                var j =0;
                for(;j<tetrimino1.Length;j++)
                {
                    if (tetrimino1[j] != 'x')
                    {
                        counter++;
                        if (counter == source)
                        {
                            break;
                        }
                    }
                }
                tetrimino2[i] = tetrimino1[j];
                tetrimino1[j] = 'x';
            }
            Console.WriteLine(tetrimino2);
        }
    }
}
