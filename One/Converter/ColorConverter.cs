using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace One.Converter
{
    public class ColorConverter
    {
        /// <summary>
        /// 将16进制的颜色转为成Color类型
        /// </summary>
        /// <param name="stringColor"></param>
        /// <returns></returns>
        public Color StringToColor(string stringColor)
        {
            string src = stringColor;
            //因为有些颜色是rgb模式的，没有透明度
            if (src.Length == 7)
            {
                return Color.FromArgb(255,
                    Byte.Parse(src.Substring(1, 2), System.Globalization.NumberStyles.HexNumber),
                    Byte.Parse(src.Substring(3, 2), System.Globalization.NumberStyles.HexNumber),
                    Byte.Parse(src.Substring(5, 2), System.Globalization.NumberStyles.HexNumber));
            }
            //argb
            else if(src.Length==9)
            {
                return Color.FromArgb(
                    Byte.Parse(src.Substring(1, 2), System.Globalization.NumberStyles.HexNumber),
                    Byte.Parse(src.Substring(3, 2), System.Globalization.NumberStyles.HexNumber),
                    Byte.Parse(src.Substring(5, 2), System.Globalization.NumberStyles.HexNumber),
                    Byte.Parse(src.Substring(7, 2), System.Globalization.NumberStyles.HexNumber));
            }
            throw new ArgumentException("Cannot parse the color");

        }
    }
}
