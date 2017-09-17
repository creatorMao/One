using One.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace One
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<NavMenuItem> navMenuList = null;

        public MainPage()
        {
            this.InitializeComponent();
            CustomTitileBar();

            navMenuList = NavMenuManager.CreateNavMenuList();

        }

        /// <summary>
        /// 自定义标题栏
        /// </summary>
        public void CustomTitileBar()
        {
            
            var titleBar = CoreApplication.GetCurrentView().TitleBar;
            titleBar.ExtendViewIntoTitleBar = true;
            
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
                RootFrame.Navigate(currentNavMenuItem.NavigatePage);
;            }

            RootSplitView.IsPaneOpen = false;
            Mask.Visibility = Visibility.Collapsed;

        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            RootSplitView.IsPaneOpen = !RootSplitView.IsPaneOpen;
            Mask.Visibility = Visibility.Visible;
        }

        private void Mask_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Mask.Visibility = Visibility.Collapsed;
            RootSplitView.IsPaneOpen = false;
        }
    }
}
