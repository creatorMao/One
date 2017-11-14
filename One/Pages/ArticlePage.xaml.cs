using One.Common;
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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Imaging;
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


        //定义定时器
        public DispatcherTimer timer;

        public ArticlePage()
        {
            this.InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval =TimeSpan.FromSeconds(1);
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            receiveData = (List<RootObject>)e.Parameter;

            contentList = ExtracteDataManager.ExtracteDataByShareUrl(receiveData, "article");
        }


        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            timer.Stop();
        }

        private void StoryListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            

            Article_Detail.Visibility = Visibility.Visible;

            var clickedItem = e.ClickedItem as ContentList;

            string item_id = clickedItem.item_id;


            WaitArticleProgressRing.Visibility = Visibility.Visible;
            WaitArticleProgressRing.IsActive = true;
            //文章页面图片
            Article_Detail_Image.Source = new BitmapImage(new Uri(clickedItem.img_url));
            //具体的文章内容
            PrePare(item_id);

            //停止动画 和清空进度条
            std.Stop();
            ArticleInfo_ProgressBar.Value = 0;


            WaitArticleProgressRing.Visibility = Visibility.Collapsed;
            WaitArticleProgressRing.IsActive = false;


        }


        private async void PrePare(string item_id)
        {
            articleList = await ArticalInfoManager.GetArticleInfoByItemId(item_id);

            


            //因为现在的文章列表是我从api里搜集出来的，所以并不是每一篇文章都有音频
            if (articleList[0].data.audio != "")
            {
                ReaderContainer.Visibility = Visibility.Visible;
                ArticleInfo_Media.Source = new Uri(articleList[0].data.audio);
                ReaderName.Text = articleList[0].data.anchor;
                int timeSpan = int.Parse(articleList[0].data.audio_duration);
                int minutes = timeSpan / 60;
                int seconds = timeSpan % 60;
                ReadTimeSpan.Text = minutes.ToString() + ":" + seconds.ToString();
            }
            else
            {
                ArticleInfo_Media.Stop();
                timer.Stop();
                ReaderContainer.Visibility = Visibility.Collapsed;
            }
            IsStop = false;

            Article_Title.Text = articleList[0].data.hp_title;
            Article_Author.Text = "文/"+articleList[0].data.author[0].user_name;
            Article_Content.Text = RemoveHtmlTagHelper.RemoveHtmlTag(articleList[0].data.hp_content);
           
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (IsStop == false)
            {
                timer.Start();
                std.Begin();
                ArticleInfo_Media.Play();
            }
            else
            {
                //第二次点击暂停
                timer.Stop();
                std.Stop();
                ArticleInfo_Media.Pause();
            }
            IsStop = !IsStop;


        }



        public void Change(object sender, object e)
        {

            double totalSeconds = ArticleInfo_Media.NaturalDuration.TimeSpan.TotalSeconds;

            double currentSeconds = ArticleInfo_Media.Position.TotalSeconds;

            double progressBarValue = (currentSeconds * 100) / (1.0*totalSeconds);


            ArticleInfo_ProgressBar.Value = progressBarValue;

         
        }


        private async void Article_Detail_Image_DownLoadButton_Click(object sender, RoutedEventArgs e)
        {
            DownloadImageManager downloadImageManager = new DownloadImageManager();
            BitmapImage bitmapImage = (BitmapImage)Article_Detail_Image.Source;
            await downloadImageManager.SaveImage(articleList[0].data.hp_title, bitmapImage.UriSource.ToString());

            //测试按钮
            //ArticleInfo_Media.Position = TimeSpan.FromMinutes(28);

        }



        private void ArticleInfo_Media_MediaEnded(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            std.Stop();
            IsStop = false;
        }



        private void ArticleInfo_Media_MediaOpened(object sender, RoutedEventArgs e)
        {
            timer.Tick += Change;
        }



        private double _lastPosition = 0;
        bool isFirstDown = true;
        bool isFirstUp = true;
        private void ScrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            //鼠标滚轮向下 显示返回顶部图标  选10不选0的  照顾某些鼠标滚轮不灵了
            if (ItemListContainerScrollViewer.VerticalOffset - _lastPosition > 30)
            {
                isFirstUp = true;
                if (isFirstDown == true)
                {
                    BackTopButtonIn.Begin();
                }
                else
                {

                }
                isFirstDown = false;

                //BackTopButton.Visibility = Visibility.Visible;
            }
            else if (ItemListContainerScrollViewer.VerticalOffset - _lastPosition < -30)  //向上
            {
                isFirstDown = true;
                if (isFirstUp == true)
                {
                    BackTopButtonOut.Begin();
                }
                else
                {

                }
                isFirstUp = false;
                //BackTopButton.Visibility = Visibility.Collapsed;
            }

            _lastPosition = ItemListContainerScrollViewer.VerticalOffset;

        }



        private void BackTopButton_Click(object sender, RoutedEventArgs e)
        {
            //放回顶部
            ItemListContainerScrollViewer.ChangeView(null, 0, null);
        }
    }
}
