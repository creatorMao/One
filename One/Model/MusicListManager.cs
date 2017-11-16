using Newtonsoft.Json;
using One.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One.Model
{

    public static class MusicListManager
    {
        
    }


    //以下是每月音乐的相关类

    public class Music_GettingStarted
    {
        [JsonProperty("data")]
        public List<Music_Datum> Data { get; set; }

        [JsonProperty("res")]
        public long Res { get; set; }

        
    }

    public class Music_Datum
    {
        [JsonProperty("album")]
        public string Album { get; set; }

        [JsonProperty("author")]
        public Music_Author Author { get; set; }

        [JsonProperty("author_list")]
        public List<Music_Author> AuthorList { get; set; }

        [JsonProperty("cover")]
        public string Cover { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("music_id")]
        public string MusicId { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("start_video")]
        public string StartVideo { get; set; }

        [JsonProperty("story_title")]
        public string StoryTitle { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class Music_Author
    {
        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("fans_total")]
        public string FansTotal { get; set; }

        [JsonProperty("is_settled")]
        public string IsSettled { get; set; }

        [JsonProperty("settled_type")]
        public string SettledType { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("wb_name")]
        public string WbName { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }
    }

}
