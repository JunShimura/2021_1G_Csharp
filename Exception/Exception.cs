using System;

class Exception
{
    static void Main(string[] args)
    {
        int a=0, b=0, c=0;
        try
        {
            a = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("数値ではありません");
        }
        catch (OverflowException)
        {
            Console.WriteLine("値が大きすぎます");
        }
        b = int.Parse(Console.ReadLine());
        try
        {
            c = a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("０除算が発生しました");
        }
        Console.WriteLine(c);
    }
}