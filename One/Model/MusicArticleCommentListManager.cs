using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One.Model
{
    class MusicArticleCommentListManager
    {

    }


    public partial class MusicArticleComment_GettingStarted
    {
        [JsonProperty("data")]
        public MusicArticleComment_Data Data { get; set; }

        [JsonProperty("res")]
        public long Res { get; set; }
    }

    public partial class MusicArticleComment_Data
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("data")]
        public List<MusicArticleComment_Datum> PurpleData { get; set; }
    }

    public partial class MusicArticleComment_Datum
    {
        

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("del_flag")]
        public string DelFlag { get; set; }

        [JsonProperty("device_token")]
        public string DeviceToken { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("input_date")]
        public string InputDate { get; set; }

        [JsonProperty("praisenum")]
        public long Praisenum { get; set; }

        [JsonProperty("quote")]
        public string Quote { get; set; }

        [JsonProperty("reviewed")]
        public string Reviewed { get; set; }

        [JsonProperty("touser")]
        public MusicArticleComment_User Touser { get; set; }

        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public MusicArticleComment_User User { get; set; }

        [JsonProperty("user_info_id")]
        public string UserInfoId { get; set; }
    }

    public partial class MusicArticleComment_User
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }
    }
}
