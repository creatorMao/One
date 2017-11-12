using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.ApplicationModel.Email;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace One.UC
{
    public sealed partial class Tip : UserControl
    {
        private Popup _popup = null;

        public Tip()
        {
            this.InitializeComponent();
            _popup = new Popup();

            this.Width = Window.Current.Bounds.Width;
            this.Height = Window.Current.Bounds.Height;

            _popup.Child = this;
            this.Loaded += PopupInLoaded;

        }

        public void ShowTip()
        {
            _popup.IsOpen = true;
        }



        public void PopupInLoaded(object sender, RoutedEventArgs e)
        {
            this.TipIn.Begin();
        }






        private async void RateApp(object sender, RoutedEventArgs e)
        {
            var a = await Launcher.LaunchUriAsync(new Uri("ms-windows-store://review/?productid=9p1530zqcmp6"));
        }

        
        private void CloseTip(object sender, RoutedEventArgs e)
        {
            this.TipOut.Begin();
            this.TipOut.Completed += TipOutCompleted;
        }

        public void TipOutCompleted(object sender, object e)
        {
            _popup.IsOpen = false;
        }



        private void JoinQQ(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText("426862785");

            Clipboard.SetContent(dataPackage);

            PopupNotice popupNotice = new PopupNotice("已将群号复制到剪贴板");
            popupNotice.ShowAPopup();



        }


    }
}
