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
using Windows.UI.Xaml.Media.Animation;
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


        List<Photo> imageList;


        DoubleAnimation doubleAnimationOpen = new DoubleAnimation()
        {
            To = 1,
            From = 0,
            Duration = new Duration(TimeSpan.FromSeconds(0.4)),
        };

        DoubleAnimation doubleAnimationClose = new DoubleAnimation()
        {
            To = 0,
            From = 1,
            Duration = new Duration(TimeSpan.FromSeconds(0.4)),
        };

        Storyboard storyboard = new Storyboard();

       





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

            
            imageList = new List<Photo>();



            //api 里detailcover有一张
            imageList.Add(new Photo(movieInfoList[0].data.detailcover));

            //api 里photo中有几张
            for (int i = 0; i < movieInfoList[0].data.photo.Count; i++)
            { 

                imageList.Add(new Photo(movieInfoList[0].data.photo[i]));
                
            }


            if (imageList.Count > 1)
            {
                FlipViewlistview.Visibility = Visibility.Visible;
                FlipViewlistview.ItemsSource = imageList;
                FlipViewlistview.SelectedIndex = 0;
            }
            else  //当图片的数据只有一条的时候，那么图片底部的listview就关闭，然后将选择的索引设置为-1  -1代表没有选
            {
                FlipViewlistview.Visibility = Visibility.Collapsed;
                FlipViewlistview.SelectedIndex = -1;
            }


            MovieInfoImageFlipView.ItemsSource = imageList;

            MovieInfoImageFlipView.SelectedIndex = 0;


            MovieStory_Title.Text = movieStoryList[0].data.data[0].title;
            MovieStory_Author.Text = "文/"+movieStoryList[0].data.data[0].author_list[0].user_name;
            MovieStory_Content.Text = RemoveHtmlManager.RemoveHtmlTag(movieStoryList[0].data.data[0].content);
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



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieInfoImageFlipView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FlipViewlistview.Visibility == Visibility.Visible)
            {
                FlipViewlistview.SelectedIndex = MovieInfoImageFlipView.SelectedIndex;
            }

        }


        private void FlipViewlistview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listview = sender as ListView;
            int index = listview.SelectedIndex;
            if (MovieInfoImageFlipView.SelectedIndex >= 0)
            {
                MovieInfoImageFlipView.SelectedIndex = index;
            }
            
            
        }

        private void Grid_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            storyboard.Stop();

            Storyboard.SetTarget(doubleAnimationOpen, DownLoadButton);
            Storyboard.SetTargetName(doubleAnimationOpen, "DownLoadButton");
            Storyboard.SetTargetProperty(doubleAnimationOpen, "Opacity");

            storyboard.Children.Clear();
            storyboard.Children.Add(doubleAnimationOpen);
            storyboard.Begin();

        }

        private void Grid_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            storyboard.Stop();

            Storyboard.SetTarget(doubleAnimationClose, DownLoadButton);
            Storyboard.SetTargetName(doubleAnimationClose, "DownLoadButton");
            Storyboard.SetTargetProperty(doubleAnimationClose, "Opacity");

            storyboard.Children.Clear();
            storyboard.Children.Add(doubleAnimationClose);
            storyboard.Begin();
        }




        private async void DownLoadButton_Click(object sender, RoutedEventArgs e)
        {
            int index = MovieInfoImageFlipView.SelectedIndex;
            string imageuri = imageList[index].imageurl;

            DownloadImageManager downloadImageManager = new DownloadImageManager();

            await downloadImageManager.SaveImage(clickedItem.item_id.ToString()+index.ToString()+".jpg",imageuri);
        }
    }
}
