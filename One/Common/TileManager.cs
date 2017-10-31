using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.UI.Notifications;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Data.Xml.Dom;

namespace One.Common
{
    public class TileManager
    {
        public TileContent SetContent(string imageuri,string text,string author)
        {
            TileContent content = new TileContent()
            {
                Visual = new TileVisual()
                {
                    Branding = TileBranding.NameAndLogo,
                    //TileSmall = new TileBinding()
                    //{
                    //    Content = new TileBindingContentAdaptive()
                    //    {
                    //        //TextStacking = TileTextStacking.Center,
                    //        //Children =
                    //        //{
                    //        //new AdaptiveText() { Text = "Small" }
                    //        //}
                    //    }
                    //},

                    TileMedium = new TileBinding()
                    {
                        Content = new TileBindingContentAdaptive()
                        {
                            TextStacking = TileTextStacking.Center,

                            PeekImage = new TilePeekImage()
                            {
                                Source = imageuri
                            },

                            Children =
                            {
                                new AdaptiveText()
                                {
                                    Text = text,
                                    HintAlign=AdaptiveTextAlign.Left,
                                    HintWrap=true
                                },

                                 new AdaptiveText()
                                 {
                                    Text = author,
                                    HintAlign=AdaptiveTextAlign.Left,
                                    HintWrap=true
                                 }
                            }
                        }
                    },

                    TileWide = new TileBinding()
                    {
                        Content = new TileBindingContentAdaptive()
                        {
                            TextStacking = TileTextStacking.Center,
                            PeekImage = new TilePeekImage()
                            {
                                Source = imageuri
                            },
                            Children =
                            {
                                new AdaptiveText()
                                {
                                    Text = text,
                                    HintAlign=AdaptiveTextAlign.Left,
                                    HintWrap=true
                                },

                                 new AdaptiveText()
                                 {
                                    Text = author,
                                    HintAlign=AdaptiveTextAlign.Left,
                                    HintWrap=true
                                 }
                            }
                        }
                    },

                    TileLarge = new TileBinding()
                    {

                        Content = new TileBindingContentAdaptive()
                        {
                            TextStacking = TileTextStacking.Center,

                            PeekImage = new TilePeekImage()
                            {
                                Source = imageuri
                            },
                            Children =
                            {
                                new AdaptiveText()
                                {
                                    Text = text,
                                    HintAlign=AdaptiveTextAlign.Left,
                                    HintWrap=true
                                    
                                },

                                 new AdaptiveText()
                                 {
                                    Text = author,
                                    HintAlign=AdaptiveTextAlign.Left,
                                    HintWrap=true
                                 }
                            }
                        }
                    }
                }
            };

            return content;
        }
        


        public void SendATile(TileContent tileContent)
        {
            var xmlDocument= tileContent.GetXml();

            TileNotification tileNotification = new TileNotification(xmlDocument);

            TileUpdater tileUpdater = TileUpdateManager.CreateTileUpdaterForApplication();
            tileUpdater.Update(tileNotification);

        }

    }
}
