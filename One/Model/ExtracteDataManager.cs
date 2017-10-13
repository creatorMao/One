using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One.Model
{
    /// <summary>
    /// 从《一个》每日数据api中提取想要的模块  比如one story，音乐，电影等
    /// </summary>
    public static class ExtracteDataManager
    {
        /// <summary>
        /// 根据每一个模块的display category不同，将数据分离出来
        /// 已知：
        /// one story:6
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<ContentList> ExtracteDataByShareUrl(List<RootObject> dataSource,string category)
        {
            List<ContentList> contentList = new List<ContentList>();
            foreach (var item in dataSource) //遍历数据源 这里是10天
            {
                foreach (var i in item.data.content_list)
                {
                    if (i.share_url.Substring(0,23+category.Length)=="http://m.wufazhuce.com/"+category)
                    {
                        contentList.Add(i);
                    }
                }
            }
            return contentList;
        }
    }
}
