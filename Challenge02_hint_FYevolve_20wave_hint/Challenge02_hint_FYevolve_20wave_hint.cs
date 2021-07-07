using System;

namespace Challenge02_hint_FYevolve_20wave_hint
{
    class Challenge02_hint_FYevolve_20wave_hint
    {
        const int waveCount = 20;
        static void Main(string[] args)
        {
            char[] tetrimino = { 'I', 'O', 'S', 'Z', 'J', 'L', 'T' };      //元
            char[,] wave = new char[waveCount, tetrimino.Length];

            Random random = new Random();

            for (var i = 0; i < waveCount; i++)
            {
                //　元からコピー
                for (var j = 0; j < tetrimino.Length; j++)
                {
                    wave[i, j] = tetrimino[j];
                }
                //　1パターンを作る
                for (var j = 0; j < tetrimino.Length - 1; j++)
                {
                    var source = random.Next(j + 1, tetrimino.Length);    //入れ替える相手の指標
                                                                          //　交換
                    var temp = wave[i, j];
                    wave[i, j] = wave[i, source];
                    wave[i, source] = temp;
                }
                // wave[0,*]～wave[i-1,*]で重複が在るか確認、重複があった場合はランダムのやり直し

                Console.Write($"\n{(i + 1).ToString("00")}番目");
                for (var j = 0; j < tetrimino.Length; j++)
                {
                    Console.Write(wave[i, j].ToString());
                }
            }
        }
    }
}

