using System;
using ConsoleUtility;

namespace Ex28
{
    class Ex28
    {
        static void Main(string[] args)
        {
            CraneTurtle craneTurtle = new CraneTurtle(2, 4);    // Aは鶴の足=2,Bは亀の足=4
            craneTurtle.SetHeadsLegs(5, 16);
            Console.WriteLine($"鶴の数は{craneTurtle.headsA}"); //「鶴の数は2」なら正解
            Console.WriteLine($"亀の数は{craneTurtle.headsB}"); //「亀の数は3」なら正解
            craneTurtle.heads = 7;  //　頭の数を書き換えると答えも変わる
            Console.WriteLine($"鶴の数は{craneTurtle.headsA}"); //「鶴の数は6」なら正解
            Console.WriteLine($"亀の数は{craneTurtle.headsB}"); //「亀の数は1」なら正解
            craneTurtle.legs = 20;//　脚の数を書き換えると答えも変わる
            Console.WriteLine($"鶴の数は{craneTurtle.headsA}"); //「鶴の数は4」なら正解
            Console.WriteLine($"亀の数は{craneTurtle.headsB}"); //「亀の数は3」なら正解
            CraneTurtle craneTurtle2 = new CraneTurtle(10, 8);    // Aはイカの足=10,Bはタコの足=8
            craneTurtle2.SetHeadsLegs(3, 26);
            Console.WriteLine($"イカの数は{craneTurtle2.headsA}"); //「イカの数は1」なら正解
            Console.WriteLine($"タコの数は{craneTurtle2.headsB}"); //「タコの数は2」なら正解

        }
    }
}
