using System;
using System.Linq;
using System.Collections.Generic;

namespace Challenge02_ex3
{
    class Challenge02_ex3
    {
        const int waveCount = 1000;
        static void Main(string[] args)
        {
            char[] tetrimino = { 'I', 'O', 'S', 'Z', 'J', 'L', 'T' };      //元
            char[][] wave = new char[waveCount][];  //ジャグ配列

            Random random = new Random();

            for (var i = 0; i < waveCount; i++)
            {
                wave[i] = new char[tetrimino.Length];
                char[] ramdomMino = new char[tetrimino.Length];
                while (true)
                {
                    //　元からコピー
                    Array.Copy(tetrimino, ramdomMino,ramdomMino.Length);
                    //　1パターンを作る
                    for (var j = 0; j < tetrimino.Length - 1; j++)
                    {
                        var source = random.Next(j, tetrimino.Length);    //入れ替える相手の指標
                        //　交換
                        var temp = ramdomMino[j];
                        ramdomMino[j] = ramdomMino[source];
                        ramdomMino[source] = temp;
                    }
                    // wave[0,*]～wave[i-1,*]で重複が在るか確認、重複があった場合はランダムのやり直し
                    if (!wave.Contains(ramdomMino))
                    {
                        break;
                    }
                }
                wave[i] = new char[tetrimino.Length];
                Array.Copy(ramdomMino, wave[i],  ramdomMino.Length);
                Console.Write($"\n{(i + 1).ToString("00")}番目{new String(wave[i])}");
            }
        }
    }
}
