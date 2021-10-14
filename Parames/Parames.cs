using System;
using System.Linq;

namespace Parames
{
    class Parames
    {
        static void Main(string[] args)
        {

        }
        static void UsingParam()
        {
            var a = InputNumber("aを入力");
            var b = InputNumber("bを入力");
            var c = InputNumber("cを入力");
            var ans = GetGCM(a, b, c);  //　paramsが在るので許容される、無いとエラー
            Console.WriteLine($"GCM={ans}");

        }
        static void NonParam()
        {
            int[] table = new int[5];
            for(int i = 0; i < table.Length; i++)
            {
                table[i] = InputNumber($"({i}/{table.Length})番目の数を入力");
            }
            var ans = GetGCM(table);    //　paramsの有無は関係ない
            Console.WriteLine($"GCM={ans}");
        }
        static int GetGCM(params　int[] a)
        {
            var div = 1;
            var gcm = 1;
            for (div = 1; div < a.Max() / 2; div++)
            {
                var i = 0;
                for (; i < a.Length; i++)
                {
                    if (a[i] % div != 0)
                    {
                        break;
                    }
                }
                if (i < a.Length)
                {   //　いずれかが割り切れない
                    continue;
                }
                gcm = div;
            }
            return gcm;
        }

        /*
        static int GetGCM(int [] a)
        {
            var div = 1;
            var gcm = 1;
            for(div = 1; div < a.Max() / 2; div++)
            {
                var i=0;
                for(; i < a.Length; i++)
                {
                    if (a[i] % div != 0)
                    {
                        break;
                    }
                }
                if(i< a.Length)
                {   //　いずれかが割り切れない
                    continue;
                }
                gcm = div;
            }
            return gcm;
        }
        */

        static int InputNumber(string message)
        {
            Console.WriteLine(message);
            int i = int.Parse(Console.ReadLine());
            return i;
        }

        static float InputFloat(string message = "値を入力してください")
        {
            Console.WriteLine(message);
            float i = float.Parse(Console.ReadLine());
            return i;
        }

        static float InputFloat(float max, string message = "値を入力してください", string errorMessage = "入力エラー")
        {
            return InputFloat(max, 1, message, errorMessage);
        }
        static float InputFloat(
            float max,  //必ず指定するのでオプション無し
            float min = 1,
            string message = "値を入力してください",
            string errorMessage = "入力エラー")
        {
            float i;
            while (true)
            {
                i = InputFloat($"{ message}\n範囲は{ min}から{ max}");
                if (i >= min && i < max)
                { //値は適正
                    break;
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
            }
            return i;
        }
    }
}
