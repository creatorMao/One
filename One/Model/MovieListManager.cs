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
    public static class MovieListManager
    {
        /// <summary>
        /// 通过每日的id获取每日对应的数据
        /// </summary>
        /// <returns></returns>
        public static async Task<Movie_RootObject> GetRecentMovielist()
        {
            Idlist idlist = await IdlistManager.GetIdlist();

            string api = string.Format("http://v3.wufazhuce.com:8000/api/channel/movie/more/0?channel=wdj&version=4.0.2&uuid=ffffffff-a90e-706a-63f7-ccf973aae5ee&platform=android");

            //要访问网页的api，肯定要一个httpClient
            HttpClient http = new HttpClient();

            //通过get请求，异步获取的方式，获得响应的值
            HttpResponseMessage response = await http.GetAsync(api);

            //同样是通过异步的方式，从响应的内容中，序列化到字符串的形式，到这里我们就获得了api那里拿来的json数据了。
            string resultJson = await response.Content.ReadAsStringAsync();

            //我们用DataContractJsonSerializer作为反序列化的工具
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Movie_RootObject));

            //???
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(resultJson));

            Movie_RootObject data = (Movie_RootObject)serializer.ReadObject(ms);

            return data;
        }
    }

    [DataContract]
    public class Movie_Author
    {
        [DataMember]
        public string user_id { get; set; }
        [DataMember]
        public string user_name { get; set; }
        [DataMember]
        public string web_url { get; set; }
        [DataMember]
        public string summary { get; set; }
        [DataMember]
        public string desc { get; set; }
        [DataMember]
        public string is_settled { get; set; }
        [DataMember]
        public string settled_type { get; set; }
        [DataMember]
        public string fans_total { get; set; }
        [DataMember]
        public string wb_name { get; set; }
    }

    [DataContract]
    public class Movie_ShareInfo
    {
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string image { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string content { get; set; }
    }

    [DataContract]
    public class Movie_Wx
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
    public class Movie_WxTimeline
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
    public class Movie_Weibo
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
    public class Movie_Qq
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
    public class Movie_ShareList
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
    public class Datum
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string category { get; set; }
        [DataMember]
        public int display_category { get; set; }
        [DataMember]
        public string item_id { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string forward { get; set; }
        [DataMember]
        public string img_url { get; set; }
        [DataMember]
        public int like_count { get; set; }
        [DataMember]
        public string post_date { get; set; }
        [DataMember]
        public string last_update_date { get; set; }
        [DataMember]
        public Author author { get; set; }
        [DataMember]
        public string video_url { get; set; }
        [DataMember]
        public string audio_url { get; set; }
        [DataMember]
        public int audio_platform { get; set; }
        [DataMember]
        public string start_video { get; set; }
        [DataMember]
        public int has_reading { get; set; }
        [DataMember]
        public int volume { get; set; }
        [DataMember]
        public string pic_info { get; set; }
        [DataMember]
        public string words_info { get; set; }
        [DataMember]
        public string subtitle { get; set; }
        [DataMember]
        public int number { get; set; }
        [DataMember]
        public int serial_id { get; set; }
        [DataMember]
        public List<object> serial_list { get; set; }
        [DataMember]
        public string movie_story_id { get; set; }
        [DataMember]
        public int ad_id { get; set; }
        [DataMember]
        public int ad_type { get; set; }
        [DataMember]
        public string ad_pvurl { get; set; }
        [DataMember]
        public string ad_linkurl { get; set; }
        [DataMember]
        public string ad_makettime { get; set; }
        [DataMember]
        public string ad_closetime { get; set; }
        [DataMember]
        public string ad_share_cnt { get; set; }
        [DataMember]
        public string ad_pvurl_vendor { get; set; }
        [DataMember]
        public string content_id { get; set; }
        [DataMember]
        public string content_type { get; set; }
        [DataMember]
        public string content_bgcolor { get; set; }
        [DataMember]
        public string share_url { get; set; }
        [DataMember]
        public ShareInfo share_info { get; set; }
        [DataMember]
        public ShareList share_list { get; set; }
        [DataMember]
        public List<object> tag_list { get; set; }
    }

    [DataContract]
    public class Movie_RootObject
    {
        [DataMember]
        public int res { get; set; }
        [DataMember]
        public List<Datum> data { get; set; }
    }
}
