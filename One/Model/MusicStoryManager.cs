using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One.Model
{
    class MusicStoryManager
    {

    }



    //以下是音乐相关故事的类

    public partial class Music_Story_GettingStarted
    {
        [JsonProperty("data")]
        public Music_Story_Data Data { get; set; }

        [JsonProperty("res")]
        public long Res { get; set; }
    }

    public partial class Music_Story_Data
    {
        [JsonProperty("album")]
        public string Album { get; set; }

        [JsonProperty("anchor")]
        public string Anchor { get; set; }

        [JsonProperty("audio")]
        public string Audio { get; set; }

        [JsonProperty("audio_duration")]
        public string AudioDuration { get; set; }

        [JsonProperty("author")]
        public Music_Story_Author Author { get; set; }

        [JsonProperty("author_list")]
        public List<Music_Story_Author> AuthorList { get; set; }

        [JsonProperty("charge_edt")]
        public string ChargeEdt { get; set; }

        [JsonProperty("commentnum")]
        public long Commentnum { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("cover")]
        public string Cover { get; set; }

        [JsonProperty("editor_email")]
        public string EditorEmail { get; set; }

        [JsonProperty("feeds_cover")]
        public string FeedsCover { get; set; }

        [JsonProperty("hide_flag")]
        public string HideFlag { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("isfirst")]
        public string Isfirst { get; set; }

        [JsonProperty("last_update_date")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("lyric")]
        public string Lyric { get; set; }

        [JsonProperty("maketime")]
        public string Maketime { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("music_id")]
        public string MusicId { get; set; }

        [JsonProperty("next_id")]
        public long NextId { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("praisenum")]
        public long Praisenum { get; set; }

        [JsonProperty("previous_id")]
        public string PreviousId { get; set; }

        [JsonProperty("read_num")]
        public string ReadNum { get; set; }

        [JsonProperty("related_musics")]
        public string RelatedMusics { get; set; }

        [JsonProperty("related_to")]
        public string RelatedTo { get; set; }

        [JsonProperty("share_list")]
        public Music_Story_ShareList ShareList { get; set; }

        [JsonProperty("sharenum")]
        public long Sharenum { get; set; }

        [JsonProperty("sort")]
        public string Sort { get; set; }

        [JsonProperty("start_video")]
        public string StartVideo { get; set; }

        [JsonProperty("story")]
        public string Story { get; set; }

        [JsonProperty("story_author")]
        public Music_Story_Author StoryAuthor { get; set; }

        [JsonProperty("story_summary")]
        public string StorySummary { get; set; }

        [JsonProperty("story_title")]
        public string StoryTitle { get; set; }

        [JsonProperty("tag_list")]
        public List<object> TagList { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }
    }

    public partial class Music_Story_ShareList
    {
        [JsonProperty("qq")]
        public Music_Story_Qq Qq { get; set; }

        [JsonProperty("weibo")]
        public Music_Story_Qq Weibo { get; set; }

        [JsonProperty("wx")]
        public Music_Story_Qq Wx { get; set; }

        [JsonProperty("wx_timeline")]
        public Music_Story_Qq WxTimeline { get; set; }
    }

    public partial class Music_Story_Qq
    {
        [JsonProperty("audio")]
        public string Audio { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("imgUrl")]
        public string ImgUrl { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public partial class Music_Story_Author
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
