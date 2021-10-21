using System;

class Exception
{
    static void Main(string[] args)
    {
        int a, b, c=0;

        a = int.Parse(Console.ReadLine());
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