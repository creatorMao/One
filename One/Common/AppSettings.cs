using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace One.Common
{
    public static class AppSettings
    {
        //获取当前应用的本地设置容器
        public static ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;



        public static void SetSetting(string name,object value)
        {
            localSettings.Values[name] = value;
        }



        public static object GetSetting(string name)
        {
            if (localSettings.Values.ContainsKey(name))
            {
                return localSettings.Values[name];
            }
            else
            {
                return null;
            }
        }

        public static void RemoveSetting(string name)
        {
            if (localSettings.Values.ContainsKey(name))
            {
                localSettings.Values.Remove(name);
            }
            else
            {
                //
            }
        }


        //public async static void DefaultSetting()
        //{
        //    //默认的下载地址
        //    StorageFolder delaultDownloadFolder = await KnownFolders.PicturesLibrary.CreateFolderAsync("ONE", CreationCollisionOption.OpenIfExists);
        //    SetSetting("DefaultDownloadPath", delaultDownloadFolder.Path);
        //}

    }
}
