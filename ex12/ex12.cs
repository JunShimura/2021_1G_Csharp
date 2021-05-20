using System;

namespace ex12
{
    class ex12
    {
        static void Main(string[] args)
        {
            var min = 1;
            var max = 20;
            var char1 = '■';
            var char2 = '□';
            Console.Write("幅：");
            var width = int.Parse(Console.ReadLine());
            Console.Write("高さ：");
            var height = int.Parse(Console.ReadLine());
            if (width >= min && width <= max && height >= min && height <= max)
            {
                Console.WriteLine("1.長方形");
                for (var i = 1; i <= height; i++) //高さ
                {
                    var s = "";
                    for (var j = 1; j <= width; j++) //行ごとの幅
                    {
                        s += char1;
                    }
                    Console.WriteLine(s);
                }
                Console.WriteLine("2.よこ縞");
                for (var i = 1; i <= height; i++) //高さ
                {
                    var s = "";
                    for (var j = 1; j <= width; j++) //行ごとの幅
                    {
                        if (i % 2 == 0)
                        {
                            s += char1;
                        }
                        else
                        {
                            s += char2;
                        }
                    }
                    Console.WriteLine(s);
                }
                Console.WriteLine("3.縦縞");
                for (var i = 1; i <= height; i++) //高さ
                {
                    var s = "";
                    for (var j = 1; j <= width; j++) //行ごとの幅
                    {
                        if (j % 2 == 0)
                        {
                            s += char1;
                        }
                        else
                        {
                            s += char2;
                        }
                    }
                    Console.WriteLine(s);
                }
                Console.WriteLine("4.中抜け");
                for (var i = 1; i <= height; i++) //高さ
                {
                    var s = "";
                    for (var j = 1; j <= width; j++) //行ごとの幅
                    {
                        if (i == 1 || i == height || j == 1 || j == width)
                        {
                            s += char1;
                        }
                        else
                        {
                            s += char2;
                        }
                    }
                    Console.WriteLine(s);
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
                    var s = "";
                    for (var j = 1; j <= width; j++) //行ごとの幅
                    {
                        if ((i + j) % 2 == 0)
                        {
                            s += char1;
                        }
                        else
                        {
                            s += char2;
                        }
                    }
                    Console.WriteLine(s);
                }
            }
            else
            {
                Console.WriteLine("入力エラー"); //入力エラー
            }
        }
    }
}
