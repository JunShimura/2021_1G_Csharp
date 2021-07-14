using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderBySample
{
    class OrderBySample
    {
        static void Main(string[] args)
        {
            char[] tetrimino = { 'I', 'O', 'S', 'Z', 'J', 'L', 'T' };
            //Array.Sort(tetrimino);    //昇順に並べ替え
            // 昇順に並べ替えて配列に変換
            //IOrderedEnumerable< char> randomMinoIe = tetrimino.OrderBy( c => c);  //　randomMinoに昇順に並べて書き出す
            //char[] randomMino = randomMinoIe.ToArray();
            char[] randomMino = tetrimino.OrderBy( c => c).ToArray();  //　randomMinoに昇順に並べて書き出す


            Console.WriteLine(randomMino);

        }
    }
}
