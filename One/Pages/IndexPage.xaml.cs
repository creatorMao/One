using One.Converter;
using One.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.UI.Notifications;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;


// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace One.Pages
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class IndexPage : Page
    {

        private ObservableCollection<PhotoAlbum_Datum> _photoMonthList = null;


        private DateTime dateTime;


        private double _lastPosition = 0;


        bool isAwait = true;


        private PhotoAlbum_Datum photoAlbum_Datum = new PhotoAlbum_Datum();


        public IndexPage()
        {
            this.InitializeComponent();

            dateTime = DateTime.Now.AddMonths(-1);

            PreParePhotoList();

            


        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            

        }

      
        private async void PreParePhotoList()
        {
            PhotoAlbum_GettingStarted data =new PhotoAlbum_GettingStarted();
            _photoMonthList = new ObservableCollection<PhotoAlbum_Datum>();

            data = await PhotoAlbumManager.GetPhotolistByMonth();
            data.Data.ForEach(p => _photoMonthList.Add(p));
        }





        /// <summary>
        /// 点击首页item 进入每个item的详细页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemListview_ItemClick(object sender, ItemClickEventArgs e)
        {
            ItemDetailsPannel.Visibility = Visibility.Visible;

            photoAlbum_Datum = (PhotoAlbum_Datum)e.ClickedItem;

            DetailsImage.Source = new BitmapImage(new Uri(photoAlbum_Datum.HpImgUrl));
            VolumeText.Text = photoAlbum_Datum.HpTitle;
            WordsText.Text = photoAlbum_Datum.HpContent + " by " + photoAlbum_Datum.ImageAuthors;
            LikesCountTextBlock.Text = photoAlbum_Datum.Praisenum.ToString();

            ColorConverter colorConverter = new ColorConverter();
            Color color = colorConverter.StringToColor("#52948B");
            ContentContainer.Background = new SolidColorBrush(color);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ItemDetailsPannel.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// 点击保存图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImageDownloadButton_Click(object sender, RoutedEventArgs e)
        {

            X();


        }

        public async void X()
        {
            string imageName = photoAlbum_Datum.HpContent+".jpg";
            string imageUri = photoAlbum_Datum.HpImgUrl;
            DownloadImageManager downloadImageManager = new DownloadImageManager();
            //PromptManager promptManager = new PromptManager();
            //promptManager.SetPrompt("开始下载");
            await downloadImageManager.SaveImage(imageName, imageUri);
            //promptManager.SetPrompt("下载成功");
            

            //ImageSource imageSource = 
            //BitmapImage bitmapImage = new BitmapImage(new Uri());

            //DetailsImage.Source = new BitmapImage(new Uri());
        }

        private void OpenSharePage(object sender, RoutedEventArgs e)
        {
            SharePage.Visibility = Visibility.Visible;
        }


        /// <summary>
        /// 点击分享面版旁边的阴影 退出分享界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseSharePage(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            SharePage.Visibility = Visibility.Collapsed;
        }



        /// <summary>
        /// 点击复制连接按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyShare_link(object sender, RoutedEventArgs e)
        {
            string shareLinkString = photoAlbum_Datum.ShareList.Weibo.link;

            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText(shareLinkString);

            Clipboard.SetContent(dataPackage);

            ToastNotification toast=ToastHelper.ShowAToast("已经复制",shareLinkString);
            ToastNotificationManager.CreateToastNotifier().Show(toast);

        }


        /// <summary>
        /// 分享到微博
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShareToWeibo(object sender, RoutedEventArgs e)
        {

        }



        /// <summary>
        /// 调用系统的分享
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShareMore(object sender, RoutedEventArgs e)
        {
            DataTransferManager.GetForCurrentView().DataRequested += IndexPage_DataRequested;
            DataTransferManager.ShowShareUI();
        }

        void IndexPage_DataRequested(DataTransferManager sender, DataRequestedEventArgs args)
        {
            
            var deferral = args.Request.GetDeferral();


            string shareLinkString = photoAlbum_Datum.ShareList.Weibo.link;


            DataPackage dataPackage = new DataPackage();
            dataPackage.SetWebLink(new Uri(shareLinkString));
            dataPackage.SetBitmap(RandomAccessStreamReference.CreateFromUri((new Uri(photoAlbum_Datum.HpImgUrl))));



            args.Request.Data = dataPackage;

            args.Request.Data.Properties.Title = photoAlbum_Datum.HpTitle;
            args.Request.Data.Properties.Description = "ONE for Windows10";

            deferral.Complete();
        }



        /// <summary>
        /// 滚动条滚动事件 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemListContainerScrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            if (ItemListContainerScrollViewer.ExtentHeight - ItemListContainerScrollViewer.ViewportHeight == ItemListContainerScrollViewer.VerticalOffset && isAwait == true)
            {
                PreData();

            }
            _lastPosition = ItemListContainerScrollViewer.VerticalOffset;

        }

        private async void  PreData()
        {
            
            PhotoAlbum_GettingStarted data1 = new PhotoAlbum_GettingStarted();
            isAwait = !isAwait;
            data1 = await PhotoAlbumManager.GetPhotolistByLastMonth(dateTime.ToString("yyyy-MM-dd"));
            isAwait = !isAwait;
            dateTime =dateTime.AddMonths(-1);
            data1.Data.ForEach(p => _photoMonthList.Add(p));

        }

    

       
    }
}
