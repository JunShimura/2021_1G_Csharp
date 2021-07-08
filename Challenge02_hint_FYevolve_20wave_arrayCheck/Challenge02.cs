using System;

namespace Challenge02 {
    class Challenge02
    {
        const int waveCount = 1000;
        static void Main(string[] args)
        {
            char[] tetrimino = { 'I', 'O', 'S', 'Z', 'J', 'L', 'T' };      //元
            char[,] wave = new char[waveCount, tetrimino.Length];

            Random random = new Random();

            for (var i = 0; i < waveCount; i++)
            {
                bool sucess = false;
                while (!sucess)
                {
                    //　元からコピー
                    for (var j = 0; j < tetrimino.Length; j++)
                    {
                        wave[i, j] = tetrimino[j];
                    }
                    //　1パターンを作る
                    for (var j = 0; j < tetrimino.Length - 1; j++)
                    {
                        var source = random.Next(j , tetrimino.Length);    //入れ替える相手の指標
                                                                              //　交換
                        var temp = wave[i, j];
                        wave[i, j] = wave[i, source];
                        wave[i, source] = temp;
                    }
                    // wave[0,*]～wave[i-1,*]で重複が在るか確認、重複があった場合はランダムのやり直し
                    var k = 0;
                    for (; k < i; k++)
                    {
                        var j = 0;
                        for (; j < tetrimino.Length; j++)
                        {
                            if (wave[i, j] != wave[k, j])
                            {
                                break;
                            }
                        }
                        if (j == tetrimino.Length)
                        {   // 同じ要素を発見
                            break;
                        }
                    }
                    if (k == i)
                    {   //　同じ要素がない
                        sucess = true;
                    }
                }
                Console.Write($"\n{(i + 1).ToString("00")}番目");
                for (var j = 0; j < tetrimino.Length; j++)
                {
                    Console.Write(wave[i, j].ToString());
                }
            }
        }
    }
}
