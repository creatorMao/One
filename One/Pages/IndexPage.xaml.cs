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
        List<RootObject> receiveData= null;

        public IndexPage()
        {
            this.InitializeComponent();
            receiveData = new List<RootObject>();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            receiveData = (List<RootObject>)e.Parameter;
        }

        /// <summary>
        /// 点击首页item 进入每个item的详细页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemListview_ItemClick(object sender, ItemClickEventArgs e)
        {

            ItemListview.Visibility = Visibility.Collapsed;
            ItemDetailsPannel.Visibility = Visibility.Visible;

            RootObject rootObject = (RootObject)e.ClickedItem;

            DetailsImage.Source = new BitmapImage(new Uri(rootObject.data.content_list[0].img_url));
            VolumeText.Text = rootObject.data.content_list[0].volume.ToString();
            WordsText.Text = rootObject.data.content_list[0].forward + " by " + rootObject.data.content_list[0].words_info;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ItemListview.Visibility = Visibility.Visible;
            ItemDetailsPannel.Visibility = Visibility.Collapsed;
        }

    }
}
