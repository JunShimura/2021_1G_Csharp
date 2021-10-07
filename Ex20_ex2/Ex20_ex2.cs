using System;

namespace Ex20_ex2
{
    class Ex20_ex2
    {
        static void Main(string[] args)
        {
            float r = InputFloat("半径を入力してください");
            float h = InputFloat("高さを入力してください");
            Console.WriteLine($"底面積は{GetCircleSurface(r)},体積は{GetCylinderVolume(s, h)}");
        }
        static float GetCircleSurface(float radius)
        {  //半径から円の面積を求める
            float surface = 0;
            //　ここに処理を追加
            surface = (float)Math.PI * radius * radius;  //floatのキャストを追加
            return surface;
        }
        static float GetCylinderVolume(float surface, float height)
        {  //底面積と高さから円柱の体積を求める
            //float volume = (float)Math.PI * radius * radius * height;
            float volume = surface * height;
            return volume;
        }

        static int InputNumber(string message)
        {
            Console.WriteLine(message);
            int i = int.Parse(Console.ReadLine());
            return i;
        }
        static float InputFloat(string message)
        {
            Console.WriteLine(message);
            float i = float.Parse(Console.ReadLine());
            return i;
        }
    }
}
