using System;

namespace Challenge01_hint02
{
    class Challenge01_hint02
    {
        //　進化に必要な飴の数
        const int evolvable = 12;

        static void Main(string[] args)
        {
            Console.Write("ポッポは何匹？");
            var poppo = int.Parse(Console.ReadLine());
            Console.Write("飴は何個？");
            var candy = int.Parse(Console.ReadLine());
            var evolve = 0; // 進化した数
            var pegion = 0; // ピジョンの数

            while (true)
            {
                //最低限で1羽、進化できる条件を割り出す
                if (poppo > 0)
                {   //ポッポが1羽以上
                    //飴が12個以上、必要⇒以下の合計が12以上。消費する順番を考えて処理する
                    //持ってる飴の数,（居れば）ピジョンの数 ⇒飴に変える,ポッポ数 - 1⇒飴に変える
                    if ((candy + pegion + (poppo - 1)) >= evolvable)
                    {
                        poppo--;
                        if (candy >= evolvable)
                        {   // 飴が12個以上在った
                            candy -= evolvable;
                        }
                        else
                        {   // 飴が12個に満たない
                            var shortage = evolvable - candy;  // 不足分
                            candy = 0;
                            if (pegion >= shortage)
                            {   //　不足分がピジョンで足りる
                                pegion -= shortage;
                            }
                            else
                            {   // 不足分がピジョンだけでは足りない
                                shortage -= pegion; // 不足分からピジョンを引く
                                pegion = 0;
                                poppo -= shortage;
                            }
                        }
                        evolve++;
                        pegion++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {   //　ポッポが0
                    break;
                }
            }
            Console.WriteLine($"進化した数は{evolve}羽\n飴の残り={candy}\nポッポ={poppo}羽\nピジョン={pegion}羽");
        }
    }
}
