using System;

namespace DimentionSampleNew
{
    class DimentionSampleNew
    {
        static void Main(string[] args)
        {
            int[] coin = { 10000, 5000, 1000, 500, 100, 50, 10, 5, 3 };
            //金種をプログラムで追加したい場合
            //coin =  { 10000, 5000, 2000, 1000, 500, 100, 50, 10, 5, 1 };//エラー
            //new で新たに全部を作り直すとエラーにならない
            //coin =  new int[]{ 10000, 5000, 2000, 1000, 500, 100, 50, 10, 5, 1 };//正常

            Console.Write("何円にしますか：");
            var changeCoin = int.Parse(Console.ReadLine());
            int[] coin2 = new int[coin.Length + 1];
            int i = 0, j = 0;
            var copied = false;
            for (; i < coin2.Length; i++)
            {
                if (!copied && (i == coin.Length || coin[i] < changeCoin))
                {
                    coin2[i] = changeCoin;
                    copied = true;
                }
                else
                {
                    coin2[i] = coin[j];
                    j++;
                }
            }
            /*            int i;
                        for (i = 0; i < coin.Length; i++)
                        {
                            if (coin[i] > changeCoin)
                            {
                                coin2[i] = coin[i];
                            }
                            else
                            {
                                coin2[i] = changeCoin;
                                break;
                            }
                        }
                        if (i == coin.Length)
                        {   //最後まで見つからなかった
                            coin2[i] = changeCoin;
                        }
                        else
                        {
                            for (int k = i + 1; k < coin2.Length; k++)
                            {
                                coin2[k] = coin[k - 1];
                            }
                        }*/
        }
    }
}
