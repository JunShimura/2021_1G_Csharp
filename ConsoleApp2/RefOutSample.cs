using System;

namespace ConsoleApp2
{
    class RefOutSample
    {
        static void Main(string[] args)
        {
            //　サイコロを振って10マスが円周状に並んでいるときにサイコロで駒を進めるプログラム
            const int glid = 10;    // マスの数
            const int sai = 6;  //サイコロの面数
            const int turn = 10; // サイコロを振る数
            var position = 0; //　今いる場所
            Random random = new Random();
            for(var i = 0; i < turn; i++)
            {
                var r = random.Next(sai) + 1;   //　サイコロを振ると1からsaiの値が入る
                var result = Circulate(ref position, r, glid);
                Console.WriteLine($"サイコロの目は{r}、場所が{position}、一周したかは{result}");
            }
        }

        /// <summary>
        /// 指定された値に特定の値を加えて丸める　元5に対してb=7,c=10ならば2になる、一周するとtrue　
        /// </summary>
        /// <param name="a">変更したい変数</param>
        /// <param name="b">加える数</param>
        /// <param name="c">丸める数</param>
        /// <returns></returns>
        static bool Circulate(ref int a, int b, int c)
        {
            bool result;
            var o = a;
            a = (a + b) % c;
            result = a < o;
            return result;
        }
    }
}
