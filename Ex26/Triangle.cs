using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorSampe
{
    /// <summary>
    /// 三角形
    /// </summary>
    class Triangle
    {
        private float width;    //　幅
        private float height;   //　高さ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="w">幅</param>
        /// <param name="h">高さ</param>
        public Triangle(float w, float h)
        {
            this.width = w;
            this.height = h;
        }
        /// <summary>
        /// 面積を取得
        /// </summary>
        /// <returns>面積</returns>
        public float GetSurface()
        {
            return (width * height / 2);
        }
    }
}