using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge03_List
{
    class Challenge03_List
    {
        static char[] t = new char[] { 'I', 'O', 'S', 'Z', 'J', 'L', 'T' };
        static List<List<char>> minoPattern = new List<List<char>>();
        static int minoPatternId = 0;
        
        static void Main(string[] args)
        {
            //全部を用意すると5040個の配列を用意する
            var tl = new List<char>(t);
            for (int i0 = 0; i0 < t.Length; i0++)
            {   //先頭の文字を切り替えて処理する
                var l1 = new List<char>(tl); //残りの文字のリストでl1を作る
                l1.Remove(t[i0]);   //完成させる配列sに入れた文字をl1から取り除く                
                var s = new char[t.Length];
                s[0]=t[i0];   // 完成させる配列sの先頭に文字を入れる

                for (int i1 = 0; i1 < l1.Count; i1++)
                {　　//先頭の文字を切り替えて処理する
                    var l2 = new List<char>(l1); //残りの文字のリストl1からl2を作る
                    l2.Remove(l1[i1]);
                    s[1]=l1[i1]; // 完成させる配列sの先頭に文字を入れる　

                    for (int i2 = 0; i2 < l2.Count; i2++)
                    {
                        var l3 = new List<char>(l2);
                        l3.Remove(l2[i2]);
                        s[2]=l2[i2];

                        for (int i3 = 0; i3 < l3.Count; i3++)
                        {
                            var l4 = new List<char>(l3);
                            l4.Remove(l3[i3]);
                            s[3]=l3[i3];

                            for (int i4 = 0; i4 < l4.Count; i4++)
                            {
                                var l5 = new List<char>(l4);
                                l5.Remove(l4[i4]);
                                s[4]=l4[i4];
                                
                                for (int i5 = 0; i5 < l5.Count; i5++)
                                {
                                    var l6 = new List<char>(l5);
                                    l6.Remove(l5[i5]);
                                    s[5]= l5[i5];

                                    for (int i6 = 0; i6 < l6.Count; i6++)
                                    {
                                        s[6]=l6[i6];
                                        minoPattern.Add(s.ToList<char>());
                                        Console.WriteLine(s.ToArray<char>());
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //　全パターン作成が完了
            // 全パターンのインデックスをシャッフル
            int[] randomId = new int[20];
            randomId
                = Enumerable.Range(0, 5040)
                .OrderBy(i => Guid.NewGuid())
                .ToArray();
            for (var i = 0; i < 20; i++)
            {
                Console.Write($"\npattern#{i.ToString("00")}:{minoPattern[randomId[i]].ToArray<char>().ToString()}");
            }
        }
    }
}
