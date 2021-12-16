using System;
using ConsoleUtility;

namespace Ex29
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();   //何も指定しないと1
            Console.WriteLine($"box1の表面積={box1.GetSurface()}");
            Console.WriteLine($"box1の体積={box1.GetVolume()}");
            Box box2 = new Box(2, 3, 5);   //寸法を指定
            Console.WriteLine($"box2の表面積={box2.GetSurface()}");
            Console.WriteLine($"box2の体積={box2.GetVolume()}");
            //newで作ってすぐに破棄⇒処理の無駄が多い
            Console.WriteLine($"box3の表面積={new Box(1, 3.5f, 2).GetSurface()}");
            Console.WriteLine($"box3の体積={new Box(1, 3.5f, 2).GetVolume()}");
            //staticのメソッドを呼び出すと無駄が無い
            Console.WriteLine($"box3の表面積={ Box.GetSurface(1, 3.5f, 2)}");
            Console.WriteLine($"box3の体積={Box.GetVolume(1, 3.5f, 2)}");
            Box box4 = new Box(
                InteractiveInput.InputFloat("幅を入力"),
                InteractiveInput.InputFloat("高さを入力"),
                InteractiveInput.InputFloat("奥行を入力"));
            Console.WriteLine($"box4の表面積={box4.GetSurface()}");
            Console.WriteLine($"box4の体積={box4.GetVolume()}");



        }
    }
}
