﻿using System;

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
                Console.WriteLine("1.長方形");
                var s = "";
                for (var j = 1; j <= width; j++) //行ごとの幅
                {
                    s += char1;
                }
                for (var i = 1; i <= height; i++) //高さ
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("2.よこ縞");
                var s0 = "";
                for (var j = 1; j <= width; j++) //行ごとの幅
                {
                    s0 += char1;
                }
                var s1 = "";
                for (var j = 1; j <= width; j++) //行ごとの幅
                {
                    s1 += char2;
                }
                for (var i = 1; i <= height; i++) //高さ
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(s0);
                    }
                    else
                    {
                        Console.WriteLine(s1);
                    }
                }
                Console.WriteLine("3.縦縞");
                s = "";
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
                for (var i = 1; i <= height; i++) //高さ
                {
                        Console.WriteLine(s);
                }
                /*
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
                */
            }
            else
            {
                Console.WriteLine("入力エラー"); //入力エラー
            }
        }
    }
}

