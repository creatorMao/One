using One.Model;
using One.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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



        public MainPage()
        {
            this.InitializeComponent();
            CustomTitileBar();

            SetTitleBar();

            navMenuList = NavMenuManager.CreateNavMenuList();

            PrepareData();

            

        }

        /// <summary>
        /// 自定义标题栏
        /// </summary>
        public void CustomTitileBar()
        {
            
            var titleBar = CoreApplication.GetCurrentView().TitleBar;
            titleBar.ExtendViewIntoTitleBar = true;
            
        }

        //三个按键样式设置
        public void SetTitleBar()
        {
            //获得当前视图
            var view = ApplicationView.GetForCurrentView();


            //active 当前窗口
            view.TitleBar.BackgroundColor = Colors.Transparent;
            view.TitleBar.ForegroundColor = Colors.Black;

            //inactive 不是当前窗口，我觉得不常用
            view.TitleBar.InactiveBackgroundColor = Colors.Transparent;
            view.TitleBar.InactiveForegroundColor = Colors.Black;

            //button

            //初始
            view.TitleBar.ButtonBackgroundColor = Colors.Transparent;
            view.TitleBar.ButtonForegroundColor = Colors.White;

            //悬浮
            view.TitleBar.ButtonHoverBackgroundColor = Colors.DarkGray;
            view.TitleBar.ButtonHoverForegroundColor = Colors.White;

            //按下
            view.TitleBar.ButtonPressedBackgroundColor = Colors.DarkGray;
            view.TitleBar.ButtonPressedForegroundColor = Colors.White;

            //inactive 不是当前窗口，我觉得不常用
            view.TitleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
            view.TitleBar.ButtonInactiveForegroundColor = Colors.White;

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
                        RootFrame.Navigate(currentNavMenuItem.NavigatePage);
                        HamburgerButtonFontIcon.Foreground = new SolidColorBrush(Colors.Black);
                        break;
                    case "文章":
                        RootFrame.Navigate(currentNavMenuItem.NavigatePage, onelistResultList);
                        HamburgerButtonFontIcon.Foreground = new SolidColorBrush(Colors.Black);
                        break;
                    case "电影":
                        RootFrame.Navigate(currentNavMenuItem.NavigatePage, onelistResultList);
                        HamburgerButtonFontIcon.Foreground = new SolidColorBrush(Colors.White);
                        break;
                    case "关于":
                        RootFrame.Navigate(currentNavMenuItem.NavigatePage);
                        HamburgerButtonFontIcon.Foreground = new SolidColorBrush(Colors.White);
                        break;
                    case "设置":
                        RootFrame.Navigate(currentNavMenuItem.NavigatePage);
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
            WaitPage.Visibility = Visibility.Visible;
            MainPageProgressRing.IsActive = true;
            //等待近10天数据
            onelistResultList = await OnelistManager.GetLatelyOnelist();

            WaitPage.Visibility = Visibility.Collapsed;
            MainPageProgressRing.IsActive = false;

            TodayDate.Text = onelistResultList[0].data.weather.date.Replace("-","/"); ;
            PlaceName.Text = onelistResultList[0].data.weather.city_name;
            AirName.Text = onelistResultList[0].data.weather.climate;
            TempName.Text = onelistResultList[0].data.weather.temperature+ "℃";


           

            RootFrame.Navigate(typeof(IndexPage),onelistResultList);

            //RootFrame.Navigate(typeof(AboutPage));

            //RootFrame.Navigate(typeof(IndexPage));


            //RootFrame.Navigate(typeof(MoviePage), onelistResultList);


        }


        /// <summary>
        /// 设置提示信息
        /// </summary>
        /// <param name="prompt"></param>
        public void SetPrompt(string prompt)
        {
            Prompt.Text = prompt;
        }




       
    }
}
