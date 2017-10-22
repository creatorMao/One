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
    public static class OnelistManager
    {
        //private static string today = DateTime.Now.ToString("yyyy-MM-dd");

        private static DateTime _DateTime = DateTime.Now;


        /// <summary>
        /// 通过每日的id获取每日对应的数据
        /// </summary>
        /// <returns></returns>
        public static async Task<RootObject> GetTodayOnelist()
        {
            Idlist idlist= await IdlistManager.GetIdlist();

            string api = string.Format("http://v3.wufazhuce.com:8000/api/onelist/{0}/0?channel=wdj&version=4.0.2&uuid=ffffffff-a90e-706a-63f7-ccf973aae5ee&platform=android",idlist.data[0].ToString());

            //要访问网页的api，肯定要一个httpClient
            HttpClient http = new HttpClient();

            //通过get请求，异步获取的方式，获得响应的值
            HttpResponseMessage response = await http.GetAsync(api);

            //同样是通过异步的方式，从响应的内容中，序列化到字符串的形式，到这里我们就获得了api那里拿来的json数据了。
            string resultJson = await response.Content.ReadAsStringAsync();

            //我们用DataContractJsonSerializer作为反序列化的工具
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(RootObject));

            //???
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(resultJson));

            RootObject data = (RootObject)serializer.ReadObject(ms);

            return data;
        }

        /// <summary>
        /// 获最近10天的对应的数据
        /// </summary>
        /// <returns></returns>
        public static async Task<List<RootObject>> GetLatelyOnelist()
        {
            Idlist idlist = await IdlistManager.GetIdlist();

            List<RootObject> result = new List<RootObject>();

            for(int i=0;i<idlist.data.Count;i++)
            {
                string api = string.Format("http://v3.wufazhuce.com:8000/api/onelist/{0}/0?channel=wdj&version=4.0.2&uuid=ffffffff-a90e-706a-63f7-ccf973aae5ee&platform=android", idlist.data[i].ToString());

                //要访问网页的api，肯定要一个httpClient
                HttpClient http = new HttpClient();

                //通过get请求，异步获取的方式，获得响应的值
                HttpResponseMessage response = await http.GetAsync(api);

                //同样是通过异步的方式，从响应的内容中，序列化到字符串的形式，到这里我们就获得了api那里拿来的json数据了。
                string resultJson = await response.Content.ReadAsStringAsync();

                //我们用DataContractJsonSerializer作为反序列化的工具
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(RootObject));

                //???
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(resultJson));

                RootObject data = (RootObject)serializer.ReadObject(ms);

                result.Add(data);
            }
            return result;

        }


        /// <summary>
        /// 官方的只能获取过去10天 但是给了每天的接口。
        /// </summary>
        /// <returns></returns>
        public static async Task<List<RootObject>> GetAppointedOnelist()
        {
            int last10day = _DateTime.Day - 10;



            List<RootObject> result = new List<RootObject>();

            for (int i = 0; i < 10; i++)
            {
                string api = string.Format("http://v3.wufazhuce.com:8000/api/hp/bymonth/2017-10-{0}%2000:00:00?channel=wdj&version=4.0.2&uuid=ffffffff-a90e-706a-63f7-ccf973aae5ee&platform=android", last10day);

                //要访问网页的api，肯定要一个httpClient
                HttpClient http = new HttpClient();

                //通过get请求，异步获取的方式，获得响应的值
                HttpResponseMessage response = await http.GetAsync(api);

                //同样是通过异步的方式，从响应的内容中，序列化到字符串的形式，到这里我们就获得了api那里拿来的json数据了。
                string resultJson = await response.Content.ReadAsStringAsync();

                //我们用DataContractJsonSerializer作为反序列化的工具
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(RootObject));

                //???
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(resultJson));

                RootObject data = (RootObject)serializer.ReadObject(ms);

                result.Add(data);

                



            }
            return result;

        }

    }


    [DataContract]
    public class Icons
    {
        [DataMember]
        public string day { get; set; }
        [DataMember]
        public string night { get; set; }
    }

    [DataContract]
    public class Weather
    {
        [DataMember]
        public string city_name { get; set; }
        [DataMember]
        public string date { get; set; }
        [DataMember]
        public string temperature { get; set; }
        [DataMember]
        public string humidity { get; set; }
        [DataMember]
        public string climate { get; set; }
        [DataMember]
        public string wind_direction { get; set; }
        [DataMember]
        public string hurricane { get; set; }
        [DataMember]
        public Icons icons { get; set; }
    }

    [DataContract]
    public class Author
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
    public class ShareInfo
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
    public class Wx
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
    public class WxTimeline
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
    public class Weibo
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
    public class Qq
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
    public class ShareList
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
    public class ContentList
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
        public object audio_platform { get; set; }
        [DataMember]
        public string start_video { get; set; }
        [DataMember]
        public int has_reading { get; set; }
        [DataMember]
        public object volume { get; set; }
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
        public object movie_story_id { get; set; }
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
        [DataMember]
        public string orientation { get; set; }
        [DataMember]
        public string music_name { get; set; }
        [DataMember]
        public string audio_author { get; set; }
        [DataMember]
        public string audio_album { get; set; }
        [DataMember]
        public string cover { get; set; }
        [DataMember]
        public string bg_color { get; set; }
    }

    [DataContract]
    public class List
    {
        [DataMember]
        public string content_type { get; set; }
        [DataMember]
        public string content_id { get; set; }
        [DataMember]
        public string title { get; set; }
    }

    [DataContract]
    public class Menu
    {
        [DataMember]
        public string vol { get; set; }
        [DataMember]
        public List<List> list { get; set; }
    }

    [DataContract]
    public class Data
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public Weather weather { get; set; }
        [DataMember]
        public string date { get; set; }
        [DataMember]
        public List<ContentList> content_list { get; set; }
        [DataMember]
        public Menu menu { get; set; }
    }

    [DataContract]
    public class RootObject
    {
        [DataMember]
        public int res { get; set; }
        [DataMember]
        public Data data { get; set; }
    }
}
