using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One.Model
{
    public static class RemoveHtmlManager
    {
        public static string  RemoveHtmlTag(string html)
        {
           
                //通过正则表达式  将api里的html中的标签去掉

                string strText = System.Text.RegularExpressions.Regex.Replace(html, "<[^>]+>", "");
                strText = System.Text.RegularExpressions.Regex.Replace(strText, "&[^;]+;", "");

                return strText;
           
        }
    }
}
