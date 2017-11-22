using One.Common;
using One.Model;
using One.Pages;
using One.UC;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Core;
using Windows.UI.Notifications;
using Windows.Globalization;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace One
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public List<RootObject> onelistResultList = null;


        private List<NavMenuItem> navMenuList = null;


        private ObservableCollection<PhotoAlbum_Datum> _photoMonthList = null;


  


        public MainPage()
        {
            TitleBarHelper.CustomTitileBar();
            TitleBarHelper.SetTitleBarButtonStyleByColor(Colors.Black);

            this.InitializeComponent();


            JudgeIsAlreadySeted();

            
            if (AppSettings.GetSetting("Language") == null)
            {
                navMenuList = NavMenuManager.CreateNavMenuList("zh-CN");
            }
            else
            {
                navMenuList = NavMenuManager.CreateNavMenuList((string)AppSettings.GetSetting("Language"));
            }
            

            PrepareData();

           
        }


        public void ShowTip()
        {
            Tip tip = new Tip();
            tip.ShowTip();
        }


        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var item in navMenuList)
            {
                item.ForegroundColor = item.defaultColor;
                item.IconAddress = item.defaultIconAddress;
            }

            var currentNavMenuItem = e.ClickedItem as NavMenuItem;

            currentNavMenuItem.IconAddress = currentNavMenuItem.SelectedIconAddress;
            currentNavMenuItem.ForegroundColor = currentNavMenuItem.SelectedForegroundColor;

            if (currentNavMenuItem.NavigatePage != null)
            {
                switch (currentNavMenuItem.Title)
                {
                    case "一个":
                    case "ONE":
                        TitleBarHelper.SetTitleBarButtonStyleByColor(Colors.Black);
                        RootFrame.Navigate(currentNavMenuItem.NavigatePage, _photoMonthList);
                        HamburgerButtonFontIcon.Foreground = new SolidColorBrush(Colors.Black);
                        break;
                    case "文章":
                    case "Article":
                        TitleBarHelper.SetTitleBarButtonStyleByColor(Colors.Black);
                        RootFrame.Navigate(currentNavMenuItem.NavigatePage, onelistResultList);
                        HamburgerButtonFontIcon.Foreground = new SolidColorBrush(Colors.Black);
                        break;
                    case "音乐":
                    case "Music":
                        TitleBarHelper.SetTitleBarButtonStyleByColor(Colors.Black);
                        RootFrame.Navigate(currentNavMenuItem.NavigatePage);
                        HamburgerButtonFontIcon.Foreground = new SolidColorBrush(Colors.Black);
                        break;
                    case "电影":
                    case "Movie":
                        TitleBarHelper.SetTitleBarButtonStyleByColor(Colors.Black);
                        RootFrame.Navigate(currentNavMenuItem.NavigatePage, onelistResultList);
                        HamburgerButtonFontIcon.Foreground = new SolidColorBrush(Colors.Black);
                        break;
                    case "关于":
                    case "About":
                        TitleBarHelper.SetTitleBarButtonStyleByColor(Colors.White);
                        RootFrame.Navigate(currentNavMenuItem.NavigatePage);
                        HamburgerButtonFontIcon.Foreground = new SolidColorBrush(Colors.White);
                        break;
                    case "设置":
                    case "Setting":
                        TitleBarHelper.SetTitleBarButtonStyleByColor(Colors.White);
                        RootFrame.Navigate(currentNavMenuItem.NavigatePage);
                        HamburgerButtonFontIcon.Foreground = new SolidColorBrush(Colors.White);
                        break;

                }
                
;           }

            RootSplitView.IsPaneOpen = false;
            Mask.Visibility = Visibility.Collapsed;
            HamburgerButton.Visibility = Visibility.Visible;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            RootSplitView.IsPaneOpen = !RootSplitView.IsPaneOpen;
            Mask.Visibility = Visibility.Visible;
            Storyboard storyboard = new Storyboard();
            DoubleAnimation animation = new DoubleAnimation
            {
                From = 0,
                To = 0.4,
                Duration = new Duration(TimeSpan.FromSeconds(0.3)),
            };

            Storyboard.SetTarget(animation,Mask);
            Storyboard.SetTargetName(animation,"Mask");
            Storyboard.SetTargetProperty(animation, "Opacity");

            

            storyboard.Children.Add(animation);
            storyboard.Begin();

            //遮罩
            //Mask.Visibility = Visibility.Visible;
            
            HamburgerButton.Visibility = Visibility.Collapsed;
        }

        private void Mask_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Mask.Visibility = Visibility.Collapsed;
            HamburgerButton.Visibility = Visibility.Visible;
            RootSplitView.IsPaneOpen = false;
        }

        public async void PrepareData()
        {
            //开启等待
            WaitPage.Visibility = Visibility.Visible;
            MainPageProgressRing.IsActive = true;
            HamburgerButton.Visibility = Visibility.Collapsed;
            //等待近10天数据
            onelistResultList = await OnelistManager.GetLatelyOnelist();

            PhotoAlbum_GettingStarted data = new PhotoAlbum_GettingStarted();
            _photoMonthList = new ObservableCollection<PhotoAlbum_Datum>();
            data = await PhotoAlbumManager.GetPhotolistByMonth();

            data.Data.ForEach(p => _photoMonthList.Add(p));

            PhotoAlbum_GettingStarted data1 = new PhotoAlbum_GettingStarted();
            if (data.Data.Count <= 12)
            {
                //当一个月是前几天的时候，list数量太少，所以要多加一个月显示
                var time = _photoMonthList[_photoMonthList.Count - 1].HpMakettime;
                DateTime dt = DateTime.Parse(time);

                dt = dt.AddMonths(-1);

                data1 = await PhotoAlbumManager.GetPhotolistByLastMonth(dt.ToString("yyyy-MM-dd"));

                data1.Data.ForEach(p => _photoMonthList.Add(p));
            }


            

            //结束等待
            WaitPage.Visibility = Visibility.Collapsed;
            MainPageProgressRing.IsActive = false;
            HamburgerButton.Visibility = Visibility.Visible;


            //当数据准备好后 更新一下数据 并且用户设置了磁贴更新的话
            if ((bool)AppSettings.GetSetting("Tile"))
            {
                UpdateTiles();
            }



            TodayDate.Text = onelistResultList[0].data.weather.date.Replace("-", "/"); ;
            if ((string)AppSettings.GetSetting("Language") == "en-US")
            {
                //官方api中 万年是地球和对流层 这里偷个懒
                PlaceName.Text = "Earth";
                AirName.Text = "Troposphere";
            }
            else
            {
                PlaceName.Text = onelistResultList[0].data.weather.city_name;
                AirName.Text = onelistResultList[0].data.weather.climate;
            }
            TempName.Text = onelistResultList[0].data.weather.temperature+ "℃";



            RootFrame.Navigate(typeof(IndexPage), _photoMonthList);
            //NavListview.SelectedIndex = 0;


            //进入应用第一屏 显示一些tips
            //判断是否是第一次进入应用 
            AppSettings.RemoveSetting("20171117update");
            if (AppSettings.GetSetting("20171119update") == null)
            {
                //负优化哈哈
                await Task.Delay(1500);
                ShowTip();
                AppSettings.SetSetting("20171119update", true);
            }



        }



        public async void JudgeIsAlreadySeted()
        {
            var localSettings = AppSettings.localSettings;


            //判断路径  不存在的时候进入
            if (!localSettings.Values.ContainsKey("DefaultDownloadPath"))
            {
                StorageFolder delaultDownloadFolder = await KnownFolders.PicturesLibrary.CreateFolderAsync("ONE", CreationCollisionOption.OpenIfExists);
                AppSettings.SetSetting("DefaultDownloadPath", delaultDownloadFolder.Path);
            }

            //判断语言 其实这个地方已经不需要判断了  因为语言的键值是在app.xaml.cs里首先就判断好了 哈哈哈
            if (!localSettings.Values.ContainsKey("Language"))
            {
                AppSettings.SetSetting("Language", "zh-CN");
            }


            //判断主题
            if (!localSettings.Values.ContainsKey("Theme"))
            {
                AppSettings.SetSetting("Theme", true);
            }

            //判断通知
            if (!localSettings.Values.ContainsKey("Toast"))
            {
                AppSettings.SetSetting("Toast", true);
            }


            //判断动态磁贴
            if (!localSettings.Values.ContainsKey("Tile"))
            {
                AppSettings.SetSetting("Tile", true);
            }



        }

        private void UpdateTiles()
        {
            TileManager tileManager = new TileManager();
            var content=tileManager.SetContent(_photoMonthList[0].HpImgOriginalUrl, _photoMonthList[0].HpContent, _photoMonthList[0].ImageAuthors);
            tileManager.SendATile(content);
        }

        public void ShowOrHideHamburgerButton(bool isShow)
        {
            if (isShow==true)
            {
                this.HamburgerButton.Visibility = Visibility.Visible;
            }
            else if(isShow == false)
            {
                this.HamburgerButton.Visibility = Visibility.Collapsed;
            }
            
        }
    }
}
