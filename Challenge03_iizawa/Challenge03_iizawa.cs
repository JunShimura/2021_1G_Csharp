using System;

namespace Challenge2_2
{
    class Challenge03_iizawa
    {
        static void Main(string[] args)
        {
            {
                int maxNumber = 7;
                int maxCount = 5040;
                int Count = 20;
                int cou = 0;
                int anCount = 0;
                int newNumber = 0;
                int[] newAns = new int[Count];
                string[] Number = { " I", " O", " T", " J", " L", " S", " Z" };
                string[,] tex = new string[maxCount, Number.Length];
                string[,] answer = new string[Count, Number.Length];

                Random rand = new Random();

                for (var i = 0; i < maxCount; i++)
                {
                    for (var j = 0; j < Number.Length; j++)
                    {
                        tex[i, j] = Number[j];
                    }

                    var m = false;
                    while (!m)
                    {

                        for (var j = 0; j < Number.Length - 1; j++)
                        {
                            newNumber = rand.Next(j, Number.Length);

                            var b = tex[i, j];
                            tex[i, j] = tex[i, newNumber];
                            tex[i, newNumber] = b;
                        }

                        var a = 0;
                        for (; a < i; a++)
                        {
                            var j = 0;
                            for (; j < Number.Length; j++)
                            {
                                if (tex[i, j] != tex[a, j])
                                {
                                    break;
                                }
                            }
                            if (j == Number.Length)
                            {
                                break;
                            }
                        }
                        if (a == i)
                        {
                            m = true;
                        }
                    }


                }

                for (var i = 0; i < Count; i++)
                {

                    int j = 0;
                    int anNumber = rand.Next(0, 5039);
                    newAns[i] = anNumber;

                    if (i >= 1)
                    {

                        for (var h = 0; h < i; h++)
                        {
                            if (newAns[h] != anNumber)
                            {
                                continue;
                            }
                            else
                            {
                                i -= 1;
                                cou = 1;
                                break;
                            }
                        }


                    }

                    if (cou < 1)
                    {
                        for (; j < Number.Length; j++)
                        {
                            Console.Write($"{answer[i, j] = tex[anNumber, j]}");
                        }
                        Console.WriteLine();
                    }
                    cou = 0;

                }
            }
        }
    }
}
