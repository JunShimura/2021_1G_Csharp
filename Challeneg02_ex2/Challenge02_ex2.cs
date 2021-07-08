using System;

namespace Challeneg02_ex2
{
    class Challenge02_ex2
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
                while (true)
                {
                    //　元からコピー
                    for (var j = 0; j < tetrimino.Length; j++)
                    {
                        wave[i][j] = tetrimino[j];
                    }
                    //　1パターンを作る
                    for (var j = 0; j < tetrimino.Length - 1; j++)
                    {
                        var source = random.Next(j, tetrimino.Length);    //入れ替える相手の指標
                        //　交換
                        var temp = wave[i][j];
                        wave[i][j] = wave[i][source];
                        wave[i][source] = temp;
                    }
                    // wave[0,*]～wave[i-1,*]で重複が在るか確認、重複があった場合はランダムのやり直し
                    var k = 0;
                    for (; k < i; k++)
                    {
                        if (wave[i].Equals(wave[k]))
                        {   // 同じ要素を発見
                            break;
                        }
                    }
                    if (k == i)
                    {   //　同じ要素がない
                        break;
                    }
                }
                Console.Write($"\n{(i + 1).ToString("00")}番目{new String(wave[i])}");
            }
        }
    }
}
