using One.Common;
using One.UC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.System;
using Windows.UI.Notifications;
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

            LoadDefaultSetting();

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


        /// <summary>
        /// 点击设置界面的地址 打开文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFolder(object sender, PointerRoutedEventArgs e)
        {
            GetFolder();
        }

        public async void GetFolder()
        {
            var path = AppSettings.GetSetting("DefaultDownloadPath").ToString();
            StorageFolder folder = await StorageFolder.GetFolderFromPathAsync(path);
            await Launcher.LaunchFolderAsync(folder);
        }


        public void LoadDefaultSetting()
        {
            var localSettings = AppSettings.localSettings;


            //保存路径
            Folder.Text = AppSettings.GetSetting("DefaultDownloadPath").ToString();


            if ((string)AppSettings.GetSetting("Language") == "zh-CN")
            {
                //语言选择框
                LanguageSwitchComboBox.Items.Add("中文");
                LanguageSwitchComboBox.Items.Add("英文");
                LanguageSwitchComboBox.SelectedIndex = 0;
            }
            else if((string)AppSettings.GetSetting("Language") == "en-US")
            {
                //语言选择框
                LanguageSwitchComboBox.Items.Add("Chinese");
                LanguageSwitchComboBox.Items.Add("English");
                LanguageSwitchComboBox.SelectedIndex = 1;
            }
            
            


            //主题
            ThemeToggleSwitch.IsOn = (bool)AppSettings.GetSetting("Theme");

            
            //是否通知
            IsToastToggleSwitch.IsOn = (bool)AppSettings.GetSetting("Toast");


            //是否动态磁贴
            IsTileToggleSwitch.IsOn =(bool)AppSettings.GetSetting("Tile");



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
                        TileUpdater tileUpdater = TileUpdateManager.CreateTileUpdaterForApplication();
                        tileUpdater.Clear();
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
            if (comboBox.SelectedValue != null)
            {
                switch (comboBox.SelectedValue.ToString())
                {
                    case "中文":
                    case "Chinese":
                        AppSettings.SetSetting("Language", "zh-CN");
                        break;
                    case "英文":
                    case "English":
                        AppSettings.SetSetting("Language", "en-US");
                        break;

                }
            }
            
           
        }


        /// <summary>
        /// 恢复默认设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReStoreDefaultSetting(object sender, RoutedEventArgs e)
        {

            AppSettings.SetSetting("DefaultDownloadPath", "C:\\Users\\maozw\\Pictures\\ONE");

            LanguageSwitchComboBox.Items.Clear();
            AppSettings.SetSetting("Language", "zh-CN");

            AppSettings.SetSetting("Theme", true);

            AppSettings.SetSetting("Toast", true);


            AppSettings.SetSetting("Tile", true);

            AppSettings.RemoveSetting("20171110update");


            //重新加载一次默认设置
            LoadDefaultSetting();


        }
    }
}
