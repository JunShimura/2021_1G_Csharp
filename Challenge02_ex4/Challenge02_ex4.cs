using System;
using System.Linq;
using System.Collections.Generic;

namespace Challenge02_ex4
{
    class Challenge02_ex4
    {
        const int waveCount = 1000;
        static readonly char[] tetrimino = { 'I', 'O', 'S', 'Z', 'J', 'L', 'T' };      //元
        static void Main(string[] args)
        {
            char[][] wave = new char[waveCount][];  //ジャグ配列
            for (var i = 0; i < waveCount; i++)
            {
                char[] randomMino;
                while (true)
                {
                    randomMino = tetrimino.OrderBy(i => Guid.NewGuid()).ToArray(); //　1パターンを作る
                    if (!wave.Contains(randomMino))
                    {  //重複があった場合はランダムのやり直し
                        break;
                    }
                }
                wave[i] = new char[tetrimino.Length];
                Array.Copy(randomMino, wave[i], randomMino.Length);
                Console.Write($"\n{(i + 1).ToString("00")}番目{new String(wave[i])}");
            }
        }
    }
}
