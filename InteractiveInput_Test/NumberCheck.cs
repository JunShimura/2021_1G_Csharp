using System;
using System.Collections.Generic;
using System.Text;

namespace NumberUtility
{
    /// <summary>
    /// 　数の確認
    /// </summary>
    class NumberCheck
    {
        /// <summary>
        /// floatの変数が自然数かを判別
        /// </summary>
        /// <param name="num">判別する変数</param>
        /// <returns>判定結果 自然数=true</returns>
        public static bool IsNaturalNumber(float num)
        {
            return (num >= 0 && num == Math.Floor(num));
        }
        /// <summary>
        /// doubleの変数が自然数かを判別
        /// </summary>
        /// <param name="num">判別する変数</param>
        /// <returns>判定結果 自然数=true</returns>
        public static bool IsNaturalNumber(double num)
        {
            return (num >= 0 && num == Math.Floor(num));
        }
    }
}
