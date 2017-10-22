using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;

using Microsoft.Toolkit.Uwp.Notifications;
using System.IO;

namespace One.Model
{
    public class ToastHelper
    {
        public static ToastNotification ShowAToast(string title, string content, string filePath)
        {
            ToastContent toastContent = new ToastContent()
            {
                Visual = new ToastVisual()
                {
                    BindingGeneric = new ToastBindingGeneric()
                    {
                        Children =
                        {
                            new AdaptiveText()
                            {
                                Text = title
                            },

                            new AdaptiveText()
                            {
                                Text = content
                            },
                        },

                        //AppLogoOverride = new ToastGenericAppLogo()
                        //{
                        //    Source = "ms-appx:///Assets/Icon/ic_done_white_48dp.png",
                        //    HintCrop = ToastGenericAppLogoCrop.Default
                        //},

                        HeroImage = new ToastGenericHeroImage()
                        {
                            Source = filePath,
                            AlternateText = Path.GetFileName(filePath)
                        }
                    }
                },

                //Actions = new ToastActionsCustom()
                //{
                //    Buttons =
                //    {
                //        new ToastButton("打开图片","233")
                //        {
                //            ActivationType=ToastActivationType.Background,
                //        }
                //    }
                //},

                //Launch ="25"
            };

            return new ToastNotification(toastContent.GetXml());
        }

        public static ToastNotification ShowAToast(string title, string content)
        {
            ToastContent toastContent = new ToastContent()
            {
                Visual = new ToastVisual()
                {
                    BindingGeneric = new ToastBindingGeneric()
                    {
                        Children =
                        {
                            new AdaptiveText()
                            {
                                Text = title
                            },

                            new AdaptiveText()
                            {
                                Text = content
                            },
                        },

                        //AppLogoOverride = new ToastGenericAppLogo()
                        //{
                        //    Source = "ms-appx:///Assets/Icon/ic_done_white_48dp.png",
                        //    HintCrop = ToastGenericAppLogoCrop.Default
                        //},

                        //HeroImage = new ToastGenericHeroImage()
                        //{
                        //    Source = filePath,
                        //    AlternateText = Path.GetFileName(filePath)
                        //}
                    }
                },

                //Actions = new ToastActionsCustom()
                //{
                //    Buttons =
                //    {
                //        new ToastButton("打开图片","233")
                //        {
                //            ActivationType=ToastActivationType.Background,
                //        }
                //    }
                //},

                //Launch ="25"
            };

            return new ToastNotification(toastContent.GetXml());
        }
    }
}
