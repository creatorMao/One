using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One.Model
{
    public class XiaMi
    {


        private static String uu(String str)
        {
            int l = int.Parse(str.Substring(0, 1));
            str = str.Substring(1);
            int tn = str.Length;
            int ln = (int)Math.Floor((double)tn / (double)l);
            int r = tn % l;
            char[] tex = str.ToCharArray();
            String text ="";
            for (int i = 0; i <= ln; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    int n = j * ln + i;
                    if (j < r) n += j;
                    else n += r;
                    if (n < tex.Length)
                    {
                        text += tex[n];
                    }
                    else
                    {
                        break;
                    }
                }
            }
            text = text.Substring(0, text.LastIndexOf("null") + 4);
            try
            {
                var result=Encoding.UTF8.GetBytes(text);
                Encoding.Convert(Encoding.GetEncoding(text),Encoding.UTF8,result);
                //text = UrlDecoder.decode(text, "utf-8");
            }
            catch (Exception e)
            {
                
            }
            text = text.Replace("^", "0");
            //	text = text.replace("%", "|");
            //System.out.println(text);
            return text;
        }
    }
}
