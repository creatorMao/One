using One.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace One.Pages
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MoviePage : Page
    {
        List<RootObject> receiveData = null;

        List<ContentList> contentList = null;

        List<MovieInfo_RootObject> movieInfoList = null;


        List<MovieStory_RootObject> movieStoryList = null;

        ContentList clickedItem = null;

        public MoviePage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            receiveData = (List<RootObject>)e.Parameter;

            contentList = ExtracteDataManager.ExtracteDataByShareUrl(receiveData,"movie");
        }

        /// <summary>
        ///  MovieItem点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            MovieDetail.Visibility = Visibility.Visible;

            clickedItem = e.ClickedItem as ContentList;

            PrePare(clickedItem);

            


        }

        public async void PrePare(ContentList contentList)
        {
            string item_id = contentList.item_id;

            MovieInfoPageProcessRing.IsActive=true;
            movieInfoList = await MovieInfoManager.GetMovieInfoByItemId(item_id);
            //articleInfoList = await ArticalInfoManager.GetArticleInfoByItemId(item_id);

            movieStoryList = await MovieStoryManager.GetMovieStoryByItemId(item_id);
            //当数据全部准备好的时候，关闭等待
            MovieInfoPageProcessRing.IsActive = false;

            MovieInfoImage.Source = new BitmapImage(new Uri(movieInfoList[0].data.detailcover));
            MovieStory_Title.Text = movieStoryList[0].data.data[0].title;
            MovieStory_Author.Text = "文/"+movieStoryList[0].data.data[0].author_list[0].user_name;
            MovieStory_Content.Text = movieStoryList[0].data.data[0].content.Replace("<p>", "").Replace("</p>", "").Replace("<div class=\"one-img-container one-img-container-no-note\"></div>", ""); ; ;
        }



        private void OpenMovieInfomationPage(object sender, RoutedEventArgs e)
        {
            MovieInfoPage.Visibility = Visibility.Visible;

            MovieInfo_Title.Text = movieInfoList[0].data.title;
            MovieInfo_Image.Source = new BitmapImage(new Uri(movieInfoList[0].data.poster));
            MovieInfo_Director.Text = movieInfoList[0].data.info;
            MovieInfo_officialstory.Text = movieInfoList[0].data.officialstory;
            MovieInfo_Forward.Text = clickedItem.forward;
        }


        private void CloseMovieInfomationPage(object sender, RoutedEventArgs e)
        {
            MovieInfoPage.Visibility = Visibility.Collapsed;
        }
    }
}
