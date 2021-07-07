using System;

namespace Challenge02_hint_FYevolve
{
    class Challenge02_hint_FYevolve
    {
        static void Main(string[] args)
        {
            char[] tetrimino = { 'I', 'O', 'S', 'Z', 'J', 'L', 'T' };      //元
            Random random = new Random();

            for (var i = 0; i < tetrimino.Length-1; i++)
            {
                var source = random.Next(i+1, tetrimino.Length);    //入れ替える相手の指標
                //　交換
                var temp = tetrimino[i];    
                tetrimino[i] = tetrimino[source];
                tetrimino[source] = temp;
            }
            Console.WriteLine(tetrimino);
        }
    }
}
