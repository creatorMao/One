using One.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace One.Pages
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ArticlePage : Page
    {
        List<RootObject> receiveData = null;

        List<ContentList> contentList = null;

        List<Article_RootObject> articleList = null;

        public bool IsStop = false;

        public ArticlePage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            receiveData = (List<RootObject>)e.Parameter;

            contentList = ExtracteDataManager.ExtracteDataByShareUrl(receiveData, "article");
        }

        private void StoryListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Article_Detail.Visibility = Visibility.Visible;

            var clickedItem = e.ClickedItem as ContentList;

            string item_id = clickedItem.item_id;

            PrePare(item_id);
        }


        private async void PrePare(string item_id)
        {
            articleList = await ArticalInfoManager.GetArticleInfoByItemId(item_id);

            


            //因为现在的文章列表是我从api里搜集出来的，所以并不是每一篇文章都有音频
            if (articleList[0].data.audio!="")
            {
                ReaderContainer.Visibility = Visibility.Visible;
                ArticleInfo_Media.Source = new Uri(articleList[0].data.audio);
                ReaderName.Text = articleList[0].data.anchor;
                int timeSpan = int.Parse(articleList[0].data.audio_duration);
                int minutes = timeSpan / 60;
                int seconds = timeSpan % 60;
                ReadTimeSpan.Text = minutes.ToString() + ":" + seconds.ToString();
            }

            Article_Title.Text = articleList[0].data.hp_title;
            Article_Author.Text = "文/"+articleList[0].data.author[0].user_name;
            Article_Content.Text = RemoveHtmlManager.RemoveHtmlTag(articleList[0].data.hp_content);
           
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (IsStop == false)
            {
                ArticleInfo_Media.Play();
            }
            else
            {
                //第二次点击暂停
                ArticleInfo_Media.Pause();
            }
            IsStop = !IsStop;
            
        }
    }
}
