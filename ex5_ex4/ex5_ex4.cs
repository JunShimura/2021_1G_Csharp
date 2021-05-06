using System;

namespace ex5_ex4
{
    class ex5_ex4
    {
        static void Main(string[] args)
        {
            int n;
            string message = "";
            Console.Write("金額を入力:");
            var money = int.Parse(Console.ReadLine());
            n = money / 10000;
            if (n > 0)
            {
                message +=$"1万円札：{n}枚\n";
            }
            money %= 10000;
            if (money > 0)
            {
                n = money / 5000;
                if (n > 0)
                {
                    message += $"5千円札：{n}枚\n";
                }
                money %= 5000;
                if (money > 0)
                {
                    n = money / 1000;
                    if (n > 0)
                    {
                        message += $"千円札：{n}枚\n";
                    }
                    money %= 1000;
                    if (money > 0)
                    {
                        n = money / 500;
                        if (n > 0)
                        {
                            message += $"五百円玉：{n}枚\n";
                        }
                        money %= 500;
                        if (money > 0)
                        {
                            n = money / 100;
                            if (n > 0)
                            {
                                message += $"百円玉：{n}枚\n";
                            }
                            money %= 100;
                            if (money > 0)
                            {
                                n = money / 50;
                                if (n > 0)
                                {
                                    message += $"五十円玉：{n}枚\n";
                                }
                                money %= 50;
                                if (money > 0)
                                {
                                    n = money / 10;
                                    if (n > 0)
                                    {
                                        message += $"十円玉：{n}枚\n";
                                    }
                                    money %= 10;
                                    if (money > 0)
                                    {
                                        n = money / 5;
                                        if (n > 0)
                                        {
                                            message += $"五円玉：{n}枚\n";
                                        }
                                        money %= 5;
                                        if (money > 0)
                                        {
                                            n = money;
                                            if (n > 0)
                                            {
                                                message += $"一円玉：{n}枚";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(message);
        }
    }
}

