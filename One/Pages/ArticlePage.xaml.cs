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


            Article_Title.Text = articleList[0].data.hp_title;
            Article_Author.Text = "文/"+articleList[0].data.author[0].user_name;
            Article_Content.Text = RemoveHtmlManager.RemoveHtmlTag(articleList[0].data.hp_content);
           
        }
    }
}
