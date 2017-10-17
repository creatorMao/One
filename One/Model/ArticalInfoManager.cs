using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace One.Model
{
    public class ArticalInfoManager
    {
        /// <summary>
        /// 通过每日的id获取每日对应的数据
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Article_RootObject>> GetArticleInfoByItemId(string item_id)
        {

            string api = string.Format("http://v3.wufazhuce.com:8000/api/essay/{0}?channel=wdj&source=summary&source_id=9245&version=4.0.2&uuid=ffffffff-a90e-706a-63f7-ccf973aae5ee&platform=android", item_id);

            //要访问网页的api，肯定要一个httpClient
            HttpClient http = new HttpClient();

            //通过get请求，异步获取的方式，获得响应的值
            HttpResponseMessage response = await http.GetAsync(api);

            //同样是通过异步的方式，从响应的内容中，序列化到字符串的形式，到这里我们就获得了api那里拿来的json数据了。
            string resultJson = await response.Content.ReadAsStringAsync();

            //我们用DataContractJsonSerializer作为反序列化的工具
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Article_RootObject));

            //???
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(resultJson));

            Article_RootObject data = (Article_RootObject)serializer.ReadObject(ms);

            List<Article_RootObject> list = new List<Article_RootObject>();

            list.Add(data);

            return list;
        }
    }

    [DataContract]
    public class Article_Author
    {
        [DataMember]
        public string user_id { get; set; }
        [DataMember]
        public string user_name { get; set; }
        [DataMember]
        public string desc { get; set; }
        [DataMember]
        public string wb_name { get; set; }
        [DataMember]
        public string is_settled { get; set; }
        [DataMember]
        public string settled_type { get; set; }
        [DataMember]
        public string summary { get; set; }
        [DataMember]
        public string fans_total { get; set; }
        [DataMember]
        public string web_url { get; set; }
    }

    [DataContract]
    public class Article_AuthorList
    {
        [DataMember]
        public string user_id { get; set; }
        [DataMember]
        public string user_name { get; set; }
        [DataMember]
        public string desc { get; set; }
        [DataMember]
        public string wb_name { get; set; }
        [DataMember]
        public string is_settled { get; set; }
        [DataMember]
        public string settled_type { get; set; }
        [DataMember]
        public string summary { get; set; }
        [DataMember]
        public string fans_total { get; set; }
        [DataMember]
        public string web_url { get; set; }
    }


    [DataContract]
    public class Article_Wx
    {
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string desc { get; set; }
        [DataMember]
        public string link { get; set; }
        [DataMember]
        public string imgUrl { get; set; }
        [DataMember]
        public string audio { get; set; }
    }

    [DataContract]
    public class Article_WxTimeline
    {
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string desc { get; set; }
        [DataMember]
        public string link { get; set; }
        [DataMember]
        public string imgUrl { get; set; }
        [DataMember]
        public string audio { get; set; }
    }

    [DataContract]
    public class Article_Weibo
    {
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string desc { get; set; }
        [DataMember]
        public string link { get; set; }
        [DataMember]
        public string imgUrl { get; set; }
        [DataMember]
        public string audio { get; set; }
    }

    [DataContract]
    public class Article_Qq
    {
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string desc { get; set; }
        [DataMember]
        public string link { get; set; }
        [DataMember]
        public string imgUrl { get; set; }
        [DataMember]
        public string audio { get; set; }
    }

    [DataContract]
    public class Article_ShareList
    {
        [DataMember]
        public Wx wx { get; set; }
        [DataMember]
        public WxTimeline wx_timeline { get; set; }
        [DataMember]
        public Weibo weibo { get; set; }
        [DataMember]
        public Qq qq { get; set; }
    }

    [DataContract]
    public class Article_Data
    {
        [DataMember]
        public string content_id { get; set; }
        [DataMember]
        public string hp_title { get; set; }
        [DataMember]
        public string sub_title { get; set; }
        [DataMember]
        public string hp_author { get; set; }
        [DataMember]
        public string auth_it { get; set; }
        [DataMember]
        public string hp_author_introduce { get; set; }
        [DataMember]
        public string hp_content { get; set; }
        [DataMember]
        public string hp_makettime { get; set; }
        [DataMember]
        public string hide_flag { get; set; }
        [DataMember]
        public string wb_name { get; set; }
        [DataMember]
        public string wb_img_url { get; set; }
        [DataMember]
        public string last_update_date { get; set; }
        [DataMember]
        public string web_url { get; set; }
        [DataMember]
        public string guide_word { get; set; }
        [DataMember]
        public string audio { get; set; }
        [DataMember]
        public string anchor { get; set; }
        [DataMember]
        public string editor_email { get; set; }
        [DataMember]
        public string top_media_type { get; set; }
        [DataMember]
        public string top_media_file { get; set; }
        [DataMember]
        public string top_media_image { get; set; }
        [DataMember]
        public string start_video { get; set; }
        [DataMember]
        public string copyright { get; set; }
        [DataMember]
        public string audio_duration { get; set; }
        [DataMember]
        public string cover { get; set; }
        [DataMember]
        public List<Article_Author> author { get; set; }
        [DataMember]
        public string maketime { get; set; }
        [DataMember]
        public List<Article_AuthorList> author_list { get; set; }
        [DataMember]
        public string next_id { get; set; }
        [DataMember]
        public string previous_id { get; set; }
        [DataMember]
        public List<object> tag_list { get; set; }
        [DataMember]
        public Article_ShareList share_list { get; set; }
        [DataMember]
        public int praisenum { get; set; }
        [DataMember]
        public int sharenum { get; set; }
        [DataMember]
        public int commentnum { get; set; }
    }

    [DataContract]
    public class Article_RootObject
    {
        [DataMember]
        public int res { get; set; }
        [DataMember]
        public Article_Data data { get; set; }
    }
}
