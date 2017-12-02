using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One.Common
{
    public static class RemoveHtmlTagHelper
    {
        public static string RemoveHtmlTag(string html)
        {

            //通过正则表达式  将api里的html中的标签去掉

            //默认去掉所有的html标签，写在标签里的段与段之间的间隔就没有了，所以给每个段落人工加上一个回车。算是曲线救国把。
            //有些段落加了fr-pspace-a0的类，有些没加  判断一下
            if (html.Contains("<p class=\"fr-pspace-a0\">"))
            {
                html = html.Replace("<p class=\"fr-pspace-a0\">", "\n");
            }
            else
            {
                html = html.Replace("</p>", "\n");
            }


            string strText = System.Text.RegularExpressions.Regex.Replace(html, "<[^>]+>", "");
            strText = System.Text.RegularExpressions.Regex.Replace(strText, "&[^;]+;", "");

            return strText;

        }
    }
}
