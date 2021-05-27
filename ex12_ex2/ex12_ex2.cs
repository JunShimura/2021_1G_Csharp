using System;

namespace ex12_ex2
{
    class ex12_ex2
    {
        static void Main(string[] args)
        {
            //定数の宣言
            const int min = 1;
            const int max = 20;
            const char char1 = '■';
            const char char2 = '□';
            //変数への入力
            Console.Write("幅：");
            var width = int.Parse(Console.ReadLine());
            Console.Write("高さ：");
            var height = int.Parse(Console.ReadLine());
            if (width >= min && width <= max && height >= min && height <= max)
            {
                //素材の準備
                var border1 = "";   //char1の横線
                var border2 = "";   //char2の横線
                var dot1 = "";          //点線
                var dot2 = "";          //点線
                var edge = "";        //端
                for (var j = 1; j <= width; j++) //行ごとの幅
                {
                    border1 += char1;
                    border2 += char2;
                    if (j % 2 == 0)
                    {
                        dot1 += char1;
                        dot2 += char2;
                    }
                    else
                    {
                        dot1 += char2;
                        dot2 += char1;
                    }
                    if (j == 1 || j == width)
                    {
                        edge += char1;
                    }
                    else
                    {
                        edge += char2;
                    }
                }

                Console.WriteLine("1.長方形");
                for (var i = 1; i <= height; i++) //高さ
                {
                    Console.WriteLine(border1);
                }
                Console.WriteLine("2.よこ縞");

                for (var i = 1; i <= height; i++) //高さ
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(border1);
                    }
                    else
                    {
                        Console.WriteLine(border2);
                    }
                }
                Console.WriteLine("3.縦縞");
                for (var i = 1; i <= height; i++) //高さ
                {
                    Console.WriteLine(dot1);
                }

                Console.WriteLine("4.中抜け");
                for (var i = 1; i <= height; i++) //高さ
                {
                    if (i == 1 || i == height)
                    {
                        Console.WriteLine(border1);
                    }
                    else
                    {
                        Console.WriteLine(edge);
                    }
                }

                Console.WriteLine("5.直角三角形");
                for (var i = 1; i <= height; i++) //高さ
                {
                    var s = "";
                    float length = (float)i / height * width;
                    for (var j = 1; j <= length; j++) //行ごとの幅
                    {
                        s += char1;
                    }
                    Console.WriteLine(s);
                }

                Console.WriteLine("6.チェック");
                for (var i = 1; i <= height; i++) //高さ
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(dot1);
                    }
                    else
                    {
                        Console.WriteLine(dot2);
                    }
                }
            }
            else
            {
                Console.WriteLine("入力エラー"); //入力エラー
            }
        }
    }
}

