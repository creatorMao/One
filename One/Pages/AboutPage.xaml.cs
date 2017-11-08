using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace One.Pages
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class AboutPage : Page
    {
        public AboutPage()
        {
            this.InitializeComponent();


            //绑定软件版本
            Package package = Package.Current;
            Version.Text = package.Id.Version.Major.ToString() + "." + package.Id.Version.Minor.ToString() + "." + package.Id.Version.Build.ToString() + "." + package.Id.Version.Revision.ToString();

        }

        /// <summary>
        /// 打开软件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OpenApp(object sender, RoutedEventArgs e)
        {
            var a=await Launcher.LaunchUriAsync(new Uri("ms-windows-store://pdp/?productid=9n9s9lsrpc7q"));
        }


        /// <summary>
        /// 点击跳到评论页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void RateApp(object sender, RoutedEventArgs e)
        {
            var a = await Launcher.LaunchUriAsync(new Uri("ms-windows-store://review/?productid=9p1530zqcmp6"));
        }


        /// <summary>
        /// Email 给我
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void EmailToMe(object sender, RoutedEventArgs e)
        {
            //email接收者
            EmailRecipient emailRecipient1 = new EmailRecipient("zwmao@outlook.com");
            EmailRecipient emailRecipient2 = new EmailRecipient("845447380@qq.com");
            //一封email
            EmailMessage emailMessage = new EmailMessage();
            //给邮件添加接收者，可以添加多个
            emailMessage.To.Add(emailRecipient1);
            emailMessage.To.Add(emailRecipient2);

            //
            await EmailManager.ShowComposeNewEmailAsync(emailMessage);
        }



        /// <summary>
        /// 捐助
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DonateMe(object sender, RoutedEventArgs e)
        {
            if (ZhifubaoAccount.Visibility == Visibility.Visible)
            {
                ZhifubaoAccount.Visibility = Visibility.Collapsed;
            }
            else
            {
                ZhifubaoAccount.Visibility = Visibility.Visible;
            }
            
        }
    }
}
