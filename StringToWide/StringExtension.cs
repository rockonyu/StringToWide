using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StringToWide {
    public static class StringExtension {
        #region 簡繁互轉
        internal const int LOCALE_SYSTEM_DEFAULT = 0x0800;
        internal const int LCMAP_SIMPLIFIED_CHINESE = 0x02000000;
        internal const int LCMAP_TRADITIONAL_CHINESE = 0x04000000;

        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int LCMapString(int Locale, int dwMapFlags, string lpSrcStr, int cchSrc, [Out] string lpDestStr, int cchDest);

        public static string ToSimplified(this string source) {
            if (source != null) {
                String target = new String(' ', source.Length);
                int ret = LCMapString(LOCALE_SYSTEM_DEFAULT, LCMAP_SIMPLIFIED_CHINESE, source, source.Length, target, source.Length);
                return target;
            } else {
                return source;
            }
        }

        public static string ToTraditional(this string source) {
            if (source != null) {
                String target = new String(' ', source.Length);
                int ret = LCMapString(LOCALE_SYSTEM_DEFAULT, LCMAP_TRADITIONAL_CHINESE, source, source.Length, target, source.Length);
                return target;
            } else {
                return source;
            }
        }
        #endregion

        #region 半形符號轉全形的函數
        /// <summary>
        /// 半形符號轉全形的函數
        /// </summary>
        /// <param name="input">任意字元串</param>
        /// <returns>全形字元串</returns>
        /// <remarks>
        /// 全形空格為12288，半形空格為32
        /// 其他字元半形(33-126)與全形(65281-65374)的對應關係是：均相差65248
        /// </remarks>
        public static string ToWide(this string input) {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++) {
                if (c[i] == 32) {
                    c[i] = (char)12288;
                } else if (32 < c[i] && c[i] < 127) {
                    c[i] = (char)(c[i] + 65248);
                }
            }
            return new string(c);
        }
        #endregion

        #region 全形符號轉半形的函數
        /// <summary>
        /// 全形符號轉半形的函數
        /// </summary>
        /// <param name="input">任意字元串</param>
        /// <returns>半形字元串</returns>
        public static string ToNarrow(this string input) {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++) {
                if (c[i] == 12288) {
                    c[i] = (char)32;
                } else if (65280 < c[i] && c[i] < 65375) {
                    c[i] = (char)(c[i] - 65248);
                }
            }
            return new string(c);
        }
        #endregion
    }
}
