using Newtonsoft.Json;
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
    public class PhotoAlbumManager
    {
        private static DateTime _todayDate = DateTime.Now;

        /// <summary>
        /// 通过每月获取每日对应的数据
        /// </summary>
        /// <returns></returns>
        public static async Task<PhotoAlbum_GettingStarted> GetPhotolistByMonth()
        {
            string todayDate = _todayDate.ToString("yyyy-MM-dd");

            string api = string.Format("http://v3.wufazhuce.com:8000/api/hp/bymonth/{0}%2000:00:00?channel=wdj&version=4.0.2&uuid=ffffffff-a90e-706a-63f7-ccf973aae5ee&platform=android", todayDate);

            //要访问网页的api，肯定要一个httpClient
            HttpClient http = new HttpClient();

            //通过get请求，异步获取的方式，获得响应的值
            HttpResponseMessage response = await http.GetAsync(api);

            //同样是通过异步的方式，从响应的内容中，序列化到字符串的形式，到这里我们就获得了api那里拿来的json数据了。
            string resultJson = await response.Content.ReadAsStringAsync();

            ////我们用DataContractJsonSerializer作为反序列化的工具
            //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(PhotoAlbum_GettingStarted));

            ////???
            //MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(resultJson));

            //PhotoAlbum_GettingStarted data = (PhotoAlbum_GettingStarted)serializer.ReadObject(ms);

            var data = FromJson(resultJson);

            return data;
        }

        public static async Task<PhotoAlbum_GettingStarted> GetPhotolistByLastMonth(string date)
        {
            

            string api = string.Format("http://v3.wufazhuce.com:8000/api/hp/bymonth/{0}%2000:00:00?channel=wdj&version=4.0.2&uuid=ffffffff-a90e-706a-63f7-ccf973aae5ee&platform=android", date);

            //要访问网页的api，肯定要一个httpClient
            HttpClient http = new HttpClient();

            //通过get请求，异步获取的方式，获得响应的值
            HttpResponseMessage response = await http.GetAsync(api);

            //同样是通过异步的方式，从响应的内容中，序列化到字符串的形式，到这里我们就获得了api那里拿来的json数据了。
            string resultJson = await response.Content.ReadAsStringAsync();

            ////我们用DataContractJsonSerializer作为反序列化的工具
            //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(PhotoAlbum_GettingStarted));

            ////???
            //MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(resultJson));

            //PhotoAlbum_GettingStarted data = (PhotoAlbum_GettingStarted)serializer.ReadObject(ms);

            var data = FromJson(resultJson);

            return data;
        }

        public static PhotoAlbum_GettingStarted FromJson(string json)
        {
            return JsonConvert.DeserializeObject<PhotoAlbum_GettingStarted>(json, Converter.Settings);
        }

        //public static class Serialize
        //{
        //    public static string ToJson(this PhotoAlbum_GettingStarted self) => JsonConvert.SerializeObject(self, Converter.Settings);
        //}

        public class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }

    //[DataContract]
    //public class PhotoAlbum_GettingStarted
    //{
    //    [DataMember]
    //    public List<PhotoAlbum_Datum> Data { get; set; }
    //    [DataMember]
    //    public long Res { get; set; }
    //}

    //[DataContract]
    //public class PhotoAlbum_Datum
    //{
    //    [DataMember]
    //    public string HpMakettime { get; set; }
    //    [DataMember]
    //    public long Praisenum { get; set; }
    //    [DataMember]
    //    public string HpAuthor { get; set; }
    //    [DataMember]
    //    public long Commentnum { get; set; }
    //    [DataMember]
    //    public string AuthorId { get; set; }
    //    [DataMember]
    //    public string ContentBgcolor { get; set; }
    //    [DataMember]
    //    public string HpImgOriginalUrl { get; set; }
    //    [DataMember]
    //    public string HpContent { get; set; }
    //    [DataMember]
    //    public string HpImgUrl { get; set; }
    //    [DataMember]
    //    public string ImageFrom { get; set; }
    //    [DataMember]
    //    public string HpcontentId { get; set; }
    //    [DataMember]
    //    public string HpTitle { get; set; }
    //    [DataMember]
    //    public string ImageAuthors { get; set; }
    //    [DataMember]
    //    public string LastUpdateDate { get; set; }
    //    [DataMember]
    //    public string IpadUrl { get; set; }
    //    [DataMember]
    //    public string Maketime { get; set; }
    //    [DataMember]
    //    public string TextAuthors { get; set; }
    //    [DataMember]
    //    public long Sharenum { get; set; }
    //    [DataMember]
    //    public PhotoAlbum_ShareList ShareList { get; set; }
    //    [DataMember]
    //    public string TemplateCategory { get; set; }
    //    [DataMember]
    //    public string WbImgUrl { get; set; }
    //    [DataMember]
    //    public string TextFrom { get; set; }
    //    [DataMember]
    //    public string WebUrl { get; set; }
    //}

    //[DataContract]
    //public class PhotoAlbum_ShareList
    //{
    //    [DataMember]
    //    public Qq Weibo { get; set; }
    //    [DataMember]
    //    public Qq Qq { get; set; }
    //    [DataMember]
    //    public Qq Wx { get; set; }
    //    [DataMember]
    //    public Qq WxTimeline { get; set; }
    //}

    //[DataContract]
    //public class PhotoAlbum_Qq
    //{
    //    [DataMember]
    //    public string Desc { get; set; }
    //    [DataMember]
    //    public string Link { get; set; }
    //    [DataMember]
    //    public string Audio { get; set; }
    //    [DataMember]
    //    public string ImgUrl { get; set; }
    //    [DataMember]
    //    public string Title { get; set; }
    //}

    public partial class PhotoAlbum_GettingStarted
    {
        [JsonProperty("data")]
        public List<PhotoAlbum_Datum> Data { get; set; }

        [JsonProperty("res")]
        public long Res { get; set; }
    }

    public partial class PhotoAlbum_Datum
    {
        [JsonProperty("hp_makettime")]
        public string HpMakettime { get; set; }

        [JsonProperty("praisenum")]
        public long Praisenum { get; set; }

        [JsonProperty("hp_author")]
        public string HpAuthor { get; set; }

        [JsonProperty("commentnum")]
        public long Commentnum { get; set; }

        [JsonProperty("author_id")]
        public string AuthorId { get; set; }

        [JsonProperty("content_bgcolor")]
        public string ContentBgcolor { get; set; }

        [JsonProperty("hp_img_original_url")]
        public string HpImgOriginalUrl { get; set; }

        [JsonProperty("hp_content")]
        public string HpContent { get; set; }

        [JsonProperty("hp_img_url")]
        public string HpImgUrl { get; set; }

        [JsonProperty("image_from")]
        public string ImageFrom { get; set; }

        [JsonProperty("hpcontent_id")]
        public string HpcontentId { get; set; }

        [JsonProperty("hp_title")]
        public string HpTitle { get; set; }

        [JsonProperty("image_authors")]
        public string ImageAuthors { get; set; }

        [JsonProperty("last_update_date")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("ipad_url")]
        public string IpadUrl { get; set; }

        [JsonProperty("maketime")]
        public string Maketime { get; set; }

        [JsonProperty("text_authors")]
        public string TextAuthors { get; set; }

        [JsonProperty("sharenum")]
        public long Sharenum { get; set; }

        [JsonProperty("share_list")]
        public PhotoAlbum_ShareList ShareList { get; set; }

        [JsonProperty("template_category")]
        public string TemplateCategory { get; set; }

        [JsonProperty("wb_img_url")]
        public string WbImgUrl { get; set; }

        [JsonProperty("text_from")]
        public string TextFrom { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }
    }

    public partial class PhotoAlbum_ShareList
    {
        [JsonProperty("weibo")]
        public Qq Weibo { get; set; }

        [JsonProperty("qq")]
        public Qq Qq { get; set; }

        [JsonProperty("wx")]
        public Qq Wx { get; set; }

        [JsonProperty("wx_timeline")]
        public Qq WxTimeline { get; set; }
    }

    public partial class PhotoAlbum_Qq
    {
        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("audio")]
        public string Audio { get; set; }

        [JsonProperty("imgUrl")]
        public string ImgUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    
    
       
 
}
