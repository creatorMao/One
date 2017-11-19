using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.Effects;
using Microsoft.Graphics.Canvas.UI;
using Microsoft.Graphics.Canvas.UI.Xaml;
using One.Common;
using One.Model;
using One.UC;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
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
    public sealed partial class MusicPage : Page
    {
        private ObservableCollection<Music_Datum> musicList = null;

        private ObservableCollection<MusicArticleComment_Datum> MusicArticleCommentList = null;

      


        Music_Datum lastclickItem = new Music_Datum();

        bool isPlayMusic = true;

        double detialPagelastPosition = 0;
        bool detialPageBackTopButtonIn = false;
        bool detialPageBackTopButtonOut = false;

        double listPagelastPosition = 0;
        bool listPageBackTopButtonIn = false;
        bool listPageBackTopButtonOut = false;


        public MusicPage()
        {
            this.InitializeComponent();
            musicList = new ObservableCollection<Music_Datum>();
            MusicArticleCommentList = new ObservableCollection<MusicArticleComment_Datum>();
           

            PrePareData();

        }


        public async void PrePareData()
        {

            string jsonString = await SerializeHelper.GetJsonStringFromWebApi("http://v3.wufazhuce.com:8000/api/music/bymonth/2017-11-13%2000:00:00?channel=wdj&version=4.0.2&uuid=ffffffff-a90e-706a-63f7-ccf973aae5ee&platform=android");
            var result = SerializeHelper.DeSerialize<Music_GettingStarted>(jsonString);


            result.Data.ForEach(p => musicList.Add(p));
        }

        private async void ItemListview_ItemClick(object sender, ItemClickEventArgs e)
        {


            Music_Datum clickItem = (Music_Datum)e.ClickedItem;
            int id = int.Parse(clickItem.Id);

            //因为毛玻璃的代码里 不能快速的点击
            if (lastclickItem != clickItem)
            {
                //点击进入音乐故事页面
                string api = String.Format("http://v3.wufazhuce.com:8000/api/music/detail/{0}?channel=wdj&version=4.0.2&uuid=ffffffff-a90e-706a-63f7-ccf973aae5ee&platform=android", id);
                string jsonString = await SerializeHelper.GetJsonStringFromWebApi(api);
                var result = SerializeHelper.DeSerialize<Music_Story_GettingStarted>(jsonString);
                //去除html tag
                Detail_Image.Source = new BitmapImage(new Uri(result.Data.Cover));
                Article_Title.Text = result.Data.StoryTitle;
                Article_Author.Text = "文 / " + result.Data.StoryAuthor.UserName;
                Article_Content.Text = RemoveHtmlTagHelper.RemoveHtmlTag(result.Data.Story);
                CoverImage.Source = new BitmapImage(new Uri(result.Data.Cover));


                //评论模块
                string commentApi = String.Format("http://v3.wufazhuce.com:8000/api/comment/praiseandtime/music/{0}/0?channel=wdj&version=4.0.2&uuid=ffffffff-a90e-706a-63f7-ccf973aae5ee&platform=android",id);
                string commentJsonString = await SerializeHelper.GetJsonStringFromWebApi(commentApi);
                var commentListResult = SerializeHelper.DeSerialize<MusicArticleComment_GettingStarted>(commentJsonString);
                //清空上一篇文章中的评论值
                MusicArticleCommentList.Clear();


                foreach (var item in commentListResult.Data.PurpleData)
                {
                    MusicArticleCommentList.Add(item);
                }




                //音乐api还没有找到  尴尬
                //string uriSource = String.Format("http://www.xiami.com/play?ids=/song/playlist/id/{0}/object_name/default/object_id/0#loaded", clickItem.MusicId);
                //MusicPlayer.Source = new Uri(uriSource);

                //点击每个music item 将播放器的设置为默认
                MusicPlayer.Stop();


            }

            lastclickItem = clickItem;
            ItemDetailsPannel.Visibility = Visibility.Visible;

        }




        #region   //这里是win2d的毛玻璃代码，网上复制的，看不懂，但能用，溜了溜了
        CanvasBitmap _bitmap;

        void Canvas_CreateResources(CanvasControl sender, CanvasCreateResourcesEventArgs args)
        {
            args.TrackAsyncAction(CreateResourcesAsync(sender).AsAsyncAction());
        }


        async Task CreateResourcesAsync(CanvasControl sender)
        {
            // give it a little bit delay to ensure the image is load, ideally you want to Image.ImageOpened event instead
            // await Task.Delay(400);

            using (var stream = new InMemoryRandomAccessStream())
            {
                // get the stream from the background image
                var target = new RenderTargetBitmap();
                await target.RenderAsync(this.Detail_Image);

                var pixelBuffer = await target.GetPixelsAsync();
                var pixels = pixelBuffer.ToArray();

                var encoder = await BitmapEncoder.CreateAsync(BitmapEncoder.BmpEncoderId, stream);
                encoder.SetPixelData(BitmapPixelFormat.Bgra8, BitmapAlphaMode.Straight, (uint)target.PixelWidth, (uint)target.PixelHeight, 96, 96, pixels);

                await encoder.FlushAsync();
                stream.Seek(0);

                // load the stream into our bitmap
                _bitmap = await CanvasBitmap.LoadAsync(sender, stream);
            }
        }

        void Canvas_Draw(CanvasControl sender, CanvasDrawEventArgs args)
        {


            var blur = new GaussianBlurEffect
            {
                BlurAmount = 45.0f, // increase this to make it more blurry or vise versa.
                                    //Optimization = EffectOptimization.Balanced, // default value
                                    //BorderMode = EffectBorderMode.Soft // default value
                Source = _bitmap
            };

            args.DrawingSession.DrawImage(blur, new Rect(0, 0, sender.ActualWidth, sender.ActualHeight),
                new Rect(0, 0, _bitmap.SizeInPixels.Width, _bitmap.SizeInPixels.Height), 0.9f);





        }

        #endregion

        /// <summary>
        /// 当图片加载完成的时候，再来win2d。毛玻璃
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Detail_Image_ImageOpened(object sender, RoutedEventArgs e)
        {
            Canvas.CreateResources += Canvas_CreateResources;
            Canvas.Draw += Canvas_Draw;
        }


        /// <summary>
        /// 播放按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayMusic(object sender, RoutedEventArgs e)
        {
            //api 还没有找到 提示一下用户
            PopupNotice popupNotice = new PopupNotice("当前音乐api还没适配好，所以目前音乐功能还在施工中.....bgm是b哥的.");
            popupNotice.ShowAPopup();


            if (isPlayMusic == true)
            {
                MachineIconIn.Begin();
                MusicPlayer.Play();
                PlayMusicButtonIcon.Source = new BitmapImage(new Uri("ms-appx:///Assets/icon/pause.png"));
            }
            else if (isPlayMusic == false)
            {
                MachineIconOut.Begin();
                //停止
                MusicPlayer.Pause();
                PlayMusicButtonIcon.Source = new BitmapImage(new Uri("ms-appx:///Assets/icon/play.png"));
            }
            isPlayMusic = !isPlayMusic;
        }

        
        private void ItemDetailsPannelScrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            #region 测试scrollviewer的各种高度
            //MaxHeightText.Text = ItemDetailsPannelScrollViewer.MaxHeight.ToString();
            //VerticalOffsetText.Text = ItemDetailsPannelScrollViewer.VerticalOffset.ToString();
            //HeightText.Text = ItemDetailsPannelScrollViewer.Height.ToString();
            //MinHeightText.Text = ItemDetailsPannelScrollViewer.MinHeight.ToString();
            //ActualHeightText.Text = ItemDetailsPannelScrollViewer.ActualHeight.ToString();
            //ExtentHeightText.Text = ItemDetailsPannelScrollViewer.ExtentHeight.ToString();
            //ScrollableHeightText.Text = ItemDetailsPannelScrollViewer.ScrollableHeight.ToString();
            //ViewportHeightText.Text = ItemDetailsPannelScrollViewer.ViewportHeight.ToString();
            #endregion

            ScrollViewer scrollViewer = sender as ScrollViewer;

            if ((scrollViewer.VerticalOffset>scrollViewer.ViewportHeight)&& detialPageBackTopButtonIn==false&& scrollViewer.VerticalOffset- detialPagelastPosition >= 10)  //
            {
                detialPageBackTopButtonIn = true;
                DetailPageBackTopButtonIn.Begin();

                detialPageBackTopButtonOut = false;

            }
            else if(scrollViewer.VerticalOffset< scrollViewer.ViewportHeight&& detialPageBackTopButtonOut== false&&scrollViewer.VerticalOffset - detialPagelastPosition <= -10)  //当滚动条滚动到 呈现的高度的位置时隐藏
            {
                detialPageBackTopButtonOut = true;
                DetailPageBackTopButtonOut.Begin();

                detialPageBackTopButtonIn = false;
            }

            detialPagelastPosition = scrollViewer.VerticalOffset;


        }

        private void DetailPageBackTopButton_Click(object sender, RoutedEventArgs e)
        {
            ItemDetailsPannelScrollViewer.ChangeView(null, 0, null);
        }


        private void ListPageBackTopButton_Click(object sender, RoutedEventArgs e)
        {
            ItemListContainerScrollViewer.ChangeView(null,0,null);
        }

        private void ItemListContainerScrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            ScrollViewer scrollViewer = sender as ScrollViewer;

            if ((scrollViewer.VerticalOffset > scrollViewer.ViewportHeight) && listPageBackTopButtonIn == false && scrollViewer.VerticalOffset - listPagelastPosition >= 10)  //
            {
                listPageBackTopButtonIn = true;
                ListPageBackTopButtonIn.Begin();

                listPageBackTopButtonOut = false;

            }
            else if (scrollViewer.VerticalOffset < scrollViewer.ViewportHeight && listPageBackTopButtonOut == false && scrollViewer.VerticalOffset - listPagelastPosition <= -10)  //当滚动条滚动到 呈现的高度的位置时隐藏
            {
                listPageBackTopButtonOut = true;
                ListPageBackTopButtonOut.Begin();

                listPageBackTopButtonIn = false;
            }

            listPagelastPosition = scrollViewer.VerticalOffset;
        }
    }
}
