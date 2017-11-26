using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace One.Common
{
    public static class TitleBarHelper
    {

        /// <summary>
        /// 自定义标题栏
        /// </summary>
        public static void CustomTitileBar()
        {

            var titleBar = CoreApplication.GetCurrentView().TitleBar;
            titleBar.ExtendViewIntoTitleBar = true;

        }

        

        //三个按键样式设置
        public static void SetTitleBarButtonStyleByColor(Color color)
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
            view.TitleBar.ButtonForegroundColor = color;

            //悬浮
            view.TitleBar.ButtonHoverBackgroundColor = Colors.DarkGray;
            view.TitleBar.ButtonHoverForegroundColor = color;

            //按下
            view.TitleBar.ButtonPressedBackgroundColor = Colors.DarkGray;
            view.TitleBar.ButtonPressedForegroundColor = color;

            //inactive 不是当前窗口，我觉得不常用
            view.TitleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
            view.TitleBar.ButtonInactiveForegroundColor = color;

        }

        public static void ShowOrHideHamburgerButton(bool isShow)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            MainPage mainPage = (MainPage)rootFrame.Content;
            
            mainPage.ShowOrHideHamburgerButton(isShow);
           

            
        }

    }
}
