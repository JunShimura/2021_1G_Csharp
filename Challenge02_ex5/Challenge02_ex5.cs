using System;
using System.Linq;
using System.Collections.Generic;

namespace Challenge02_ex5
{
    class Challenge02_ex5
    {
        const int waveCount = 1000;
        static readonly string tetrimino =  "IOSZJLT" ;      //元
        static void Main(string[] args)
        {
            string[] wave = new string[waveCount];  //ジャグ配列
            for (var i = 0; i < waveCount; i++)
            {
                string randomMino;
                while (true)
                {
                    randomMino = new String(tetrimino.ToArray<char>().OrderBy(i => Guid.NewGuid()).ToArray<char>()); //　1パターンを作る
                    if (!wave.Contains(randomMino))
                    {  //重複があった場合はランダムのやり直し
                        break;
                    }
                }
                wave[i] = randomMino;
                Console.Write($"\n{(i + 1).ToString("00")}番目{wave[i]}");
            }
        }
    }
}
