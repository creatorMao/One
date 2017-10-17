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
    public class MovieStoryManager
    {
        /// <summary>
        /// 通过每日的id获取每日对应的数据
        /// </summary>
        /// <returns></returns>
        public static async Task<List<MovieStory_RootObject>> GetMovieStoryByItemId(string item_id)
        {

            string api = string.Format("http://v3.wufazhuce.com:8000/api/movie/{0}/story/1/0", item_id);

            //要访问网页的api，肯定要一个httpClient
            HttpClient http = new HttpClient();

            //通过get请求，异步获取的方式，获得响应的值
            HttpResponseMessage response = await http.GetAsync(api);

            //同样是通过异步的方式，从响应的内容中，序列化到字符串的形式，到这里我们就获得了api那里拿来的json数据了。
            string resultJson = await response.Content.ReadAsStringAsync();

            //我们用DataContractJsonSerializer作为反序列化的工具
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(MovieStory_RootObject));

            //???
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(resultJson));

            MovieStory_RootObject data = (MovieStory_RootObject)serializer.ReadObject(ms);

            List<MovieStory_RootObject> list = new List<MovieStory_RootObject>();

            list.Add(data);

            return list;
        }
    }

    [DataContract]
    public class MovieStory_User
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
    public class MovieStory_AuthorList
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
    public class MovieStory_Datum
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string movie_id { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string content { get; set; }
        [DataMember]
        public string sort { get; set; }
        [DataMember]
        public int praisenum { get; set; }
        [DataMember]
        public string input_date { get; set; }
        [DataMember]
        public string story_type { get; set; }
        [DataMember]
        public string summary { get; set; }
        [DataMember]
        public string audio { get; set; }
        [DataMember]
        public string anchor { get; set; }
        [DataMember]
        public string copyright { get; set; }
        [DataMember]
        public string audio_duration { get; set; }
        [DataMember]
        public MovieStory_User user { get; set; }
        [DataMember]
        public string charge_edt { get; set; }
        [DataMember]
        public string editor_email { get; set; }
        [DataMember]
        public List<MovieStory_AuthorList> author_list { get; set; }
    }

    [DataContract]
    public class MovieStory_Data
    {
        [DataMember]
        public int count { get; set; }
        [DataMember]
        public List<MovieStory_Datum> data { get; set; }
    }

    [DataContract]
    public class MovieStory_RootObject
    {
        [DataMember]
        public int res { get; set; }
        [DataMember]
        public MovieStory_Data data { get; set; }
    }
}
