using One.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace One.Pages
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class SettingPage : Page
    {

        public SettingPage()
        {
            this.InitializeComponent();

            JudgeIsAlreadySeted();

        }


        private void SetNewFolder(object sender, RoutedEventArgs e)
        {
            var folderPicker = new FolderPicker();
            //设置建议位置
            folderPicker.SuggestedStartLocation = PickerLocationId.Desktop;
            folderPicker.FileTypeFilter.Add("*");

            PickAFolder(folderPicker);


        }

        public async void PickAFolder(FolderPicker folderPicker)
        {
            StorageFolder storageFolder = await folderPicker.PickSingleFolderAsync();
            if (storageFolder != null)
            {
                // Application now has read/write access to all contents in the picked folder  
                //应用程序 现在拥有 对选购中的文件夹中的所有内容 的读和写的权力
                // (including other sub-folder contents)
                //包括其中的子文件夹

                Windows.Storage.AccessCache.StorageApplicationPermissions.FutureAccessList.AddOrReplace("PickedFolderToken", storageFolder);

                Folder.Text = storageFolder.Path;
                AppSettings.SetSetting("DefaultDownloadPath", storageFolder.Path);
            }
            
        }

        private void OpenFolder(object sender, PointerRoutedEventArgs e)
        {

        }


        public void JudgeIsAlreadySeted()
        {
            var localSettings = AppSettings.localSettings;


            //保存路径  因为其它界面需要下载功能，所以在mainpage里就把判断做了 这里只有取一下值就好了
            Folder.Text = AppSettings.GetSetting("DefaultDownloadPath").ToString();

            //判断语言
            if (localSettings.Values.ContainsKey("Language"))
            {
                LanguageSwitchComboBox.Items.Add("中文");
                LanguageSwitchComboBox.Items.Add("英文");
                LanguageSwitchComboBox.SelectedIndex =(int)AppSettings.GetSetting("Language");
            }
            else
            {
                AppSettings.SetSetting("Language", 0);
                LanguageSwitchComboBox.Items.Add("中文");
                LanguageSwitchComboBox.Items.Add("英文");
                LanguageSwitchComboBox.SelectedIndex = 0;
            }


            //判断语言
            if (localSettings.Values.ContainsKey("Theme"))
            {
                ThemeToggleSwitch.IsOn = (bool)AppSettings.GetSetting("Theme");
            }
            else
            {
                AppSettings.SetSetting("Theme",false);
                ThemeToggleSwitch.IsOn = false;
            }

            //判断通知
            if (localSettings.Values.ContainsKey("Toast"))
            {
                IsToastToggleSwitch.IsOn = (bool)AppSettings.GetSetting("Toast");
            }
            else
            {
                AppSettings.SetSetting("Toast", true);
                IsToastToggleSwitch.IsOn = true;
            }


            //判断动态磁贴
            if (localSettings.Values.ContainsKey("Tile"))
            {
                IsTileToggleSwitch.IsOn =(bool)AppSettings.GetSetting("Tile");
            }
            else
            {
                AppSettings.SetSetting("Tile", true);
                IsTileToggleSwitch.IsOn = true;
            }



        }


        private void SettingToggled(object sender, RoutedEventArgs e)
        {
            var toggleSwitch = sender as ToggleSwitch;

            switch (toggleSwitch.Name)
            {
                case "IsTileToggleSwitch":
                    if (toggleSwitch.IsOn)
                    {

                    }
                    else
                    {

                    }
                    AppSettings.SetSetting("Tile", toggleSwitch.IsOn);
                    break;
                case "IsToastToggleSwitch":
                    if (toggleSwitch.IsOn)
                    {

                    }
                    else
                    {

                    }
                    AppSettings.SetSetting("Toast", toggleSwitch.IsOn);
                    break;
                case "ThemeToggleSwitch":
                    if (toggleSwitch.IsOn)
                    {

                    }
                    else
                    {

                    }
                    AppSettings.SetSetting("Theme", toggleSwitch.IsOn);
                    break;
            }
        }


        private void LanguageSwitchComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            if (comboBox.SelectedValue.ToString() == "中文")
            {
                AppSettings.SetSetting("Language", 0);
            }
            else
            {
                AppSettings.SetSetting("Language", 1);
            }
        }
    }
}
