using System;
using System.Collections.Generic;
using System.Linq;

namespace NewGuidSasmple
{
    class NewGuidSample
    {
        static void Main(string[] args)
        {
            char[] tetrimino = { 'I', 'O', 'S', 'Z', 'J', 'L', 'T' };
            /*
            Random random = new Random();
            char[] randomMino = tetrimino.OrderBy(i => random.Next(tetrimino.Length)).ToArray();  //　randomMinoに昇順に並べて書き出す
            */
            char[] randomMino = tetrimino.OrderBy(i=>Guid.NewGuid()).ToArray();
            Console.WriteLine(randomMino);
        }
    }
}
