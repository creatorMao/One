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
    public class MovieInfoManager
    {
        /// <summary>
        /// 通过每日的id获取每日对应的数据
        /// </summary>
        /// <returns></returns>
        public static async Task<List<MovieInfo_RootObject>> GetMovieInfoByItemId(string item_id)
        {

            string api = string.Format("http://v3.wufazhuce.com:8000/api/movie/detail/{0}?channel=wdj&source=channel_movie&source_id=9240&version=4.0.2&uuid=ffffffff-a90e-706a-63f7-ccf973aae5ee&platform=android", item_id);

            //要访问网页的api，肯定要一个httpClient
            HttpClient http = new HttpClient();

            //通过get请求，异步获取的方式，获得响应的值
            HttpResponseMessage response = await http.GetAsync(api);

            //同样是通过异步的方式，从响应的内容中，序列化到字符串的形式，到这里我们就获得了api那里拿来的json数据了。
            string resultJson = await response.Content.ReadAsStringAsync();

            //我们用DataContractJsonSerializer作为反序列化的工具
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(MovieInfo_RootObject));

            //???
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(resultJson));

            MovieInfo_RootObject data = (MovieInfo_RootObject)serializer.ReadObject(ms);

            List<MovieInfo_RootObject> list = new List<MovieInfo_RootObject>();

            list.Add(data);

            return list;
        }
    }


    [DataContract]
    public class MovieInfo_Wx
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
    public class MovieInfo_WxTimeline
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
    public class MovieInfo_Weibo
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
    public class MovieInfo_Qq
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
    public class MovieInfo_ShareList
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
    public class MovieInfo_Data
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string indexcover { get; set; }
        [DataMember]
        public string detailcover { get; set; }
        [DataMember]
        public string video { get; set; }
        [DataMember]
        public string verse { get; set; }
        [DataMember]
        public string verse_en { get; set; }
        [DataMember]
        public object score { get; set; }
        [DataMember]
        public string revisedscore { get; set; }
        [DataMember]
        public string review { get; set; }
        [DataMember]
        public string keywords { get; set; }
        [DataMember]
        public string movie_id { get; set; }
        [DataMember]
        public string info { get; set; }
        [DataMember]
        public string officialstory { get; set; }
        [DataMember]
        public string hide_flag { get; set; }
        [DataMember]
        public string charge_edt { get; set; }
        [DataMember]
        public string web_url { get; set; }
        [DataMember]
        public int praisenum { get; set; }
        [DataMember]
        public string sort { get; set; }
        [DataMember]
        public string releasetime { get; set; }
        [DataMember]
        public string scoretime { get; set; }
        [DataMember]
        public string maketime { get; set; }
        [DataMember]
        public string last_update_date { get; set; }
        [DataMember]
        public string read_num { get; set; }
        [DataMember]
        public string directors { get; set; }
        [DataMember]
        public string editor_email { get; set; }
        [DataMember]
        public string related { get; set; }
        [DataMember]
        public string directors_id { get; set; }
        [DataMember]
        public string start_video { get; set; }
        [DataMember]
        public string media_type { get; set; }
        [DataMember]
        public string poster { get; set; }
        [DataMember]
        public List<string> photo { get; set; }
        [DataMember]
        public string next_id { get; set; }
        [DataMember]
        public string previous_id { get; set; }
        [DataMember]
        public List<object> tag_list { get; set; }
        [DataMember]
        public MovieInfo_ShareList share_list { get; set; }
        [DataMember]
        public int sharenum { get; set; }
        [DataMember]
        public int commentnum { get; set; }
        [DataMember]
        public int servertime { get; set; }
    }

    [DataContract]
    public class MovieInfo_RootObject
    {
        [DataMember]
        public int res { get; set; }
        [DataMember]
        public MovieInfo_Data data { get; set; }
    }
}
