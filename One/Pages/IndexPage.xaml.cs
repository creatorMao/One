using One.Common;
using One.Converter;
using One.Model;
using One.UC;
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




        private double _lastPosition = 0;


        bool isAwait = true;


        private PhotoAlbum_Datum photoAlbum_Datum = new PhotoAlbum_Datum();



        public IndexPage()
        {
            this.InitializeComponent();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);


            _photoMonthList = e.Parameter as ObservableCollection<PhotoAlbum_Datum>;




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
            string imageName = photoAlbum_Datum.HpcontentId+".jpg";
            string imageUri = photoAlbum_Datum.HpImgUrl;
            DownloadImageManager downloadImageManager = new DownloadImageManager();
            
            await downloadImageManager.SaveImage(imageName, imageUri);
            
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

            //当用户设置为不提示的时候  就不提示233
            if ((bool)AppSettings.GetSetting("Toast"))
            {
                //ToastNotification toast = ToastHelper.ShowAToast("已经复制", shareLinkString);
                //ToastNotificationManager.CreateToastNotifier().Show(toast);
                PopupNotice popupNotice = new PopupNotice("已经复制到剪贴板");
                popupNotice.ShowAPopup();
            }
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
            DataTransferManager dataTransferManager = DataTransferManager.GetForCurrentView();
            dataTransferManager.DataRequested += IndexPage_DataRequested;
            DataTransferManager.ShowShareUI();
        }

        void IndexPage_DataRequested(DataTransferManager sender, DataRequestedEventArgs args)
        {

            string shareLinkString = photoAlbum_Datum.ShareList.Weibo.link;


            DataPackage dataPackage = new DataPackage();
            dataPackage.SetWebLink(new Uri(shareLinkString));
            dataPackage.SetBitmap(RandomAccessStreamReference.CreateFromUri((new Uri(photoAlbum_Datum.HpImgUrl))));
            dataPackage.Properties.Title = photoAlbum_Datum.HpTitle;
            dataPackage.Properties.Description = "ONE for Windows10";

            DataRequest request = args.Request;
            request.Data = dataPackage;

            
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
            var time = _photoMonthList[_photoMonthList.Count - 1].HpMakettime;
            DateTime dt = DateTime.Parse(time);

            dt = dt.AddMonths(-1);

            PhotoAlbum_GettingStarted data1 = new PhotoAlbum_GettingStarted();
            isAwait = !isAwait;
            data1 = await PhotoAlbumManager.GetPhotolistByLastMonth(dt.ToString("yyyy-MM-dd"));
            isAwait = !isAwait;
            data1.Data.ForEach(p => _photoMonthList.Add(p));

        }

        /// <summary>
        /// 暂时每张照片的额info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowImageInfo(object sender, RoutedEventArgs e)
        {

            ImageInfoPageMask.Visibility = Visibility.Visible;
            ImageInfoPage.Visibility = Visibility.Visible;


            ImageIinfo_Image.Source = new BitmapImage(new Uri(photoAlbum_Datum.HpImgUrl));
            ImageIinfo_Author.Text = photoAlbum_Datum.HpAuthor + "&" + photoAlbum_Datum.ImageAuthors + "作品";
            ImageIinfo_Time.Text = photoAlbum_Datum.HpMakettime;
            ImageIinfo_Uri.Text = photoAlbum_Datum.WebUrl;


        }

        private void ImageInfoPage_PointerPressed(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            ImageInfoPageMask.Visibility = Visibility.Collapsed;
            ImageInfoPage.Visibility = Visibility.Collapsed;
        }
    }
}
