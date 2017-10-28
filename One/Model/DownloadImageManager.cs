using One.Common;
using One.UC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.BackgroundTransfer;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace One.Model
{
    public class DownloadImageManager
    {
        public async Task SaveImage(string imageName,string imageUri)
        {
            BackgroundDownloader backgroundDownload = new BackgroundDownloader();


            StorageFolder folder = await StorageFolder.GetFolderFromPathAsync(AppSettings.GetSetting("DefaultDownloadPath").ToString());

            StorageFile newFile = await folder.CreateFileAsync(imageName, CreationCollisionOption.OpenIfExists);

          
            Uri uri = new Uri(imageUri);


            //如果用户设置了没有提示的话 就不要这一步
            if ((bool)AppSettings.GetSetting("Toast"))
            {
                backgroundDownload.SuccessToastNotification = ToastHelper.ShowAToast("保存成功", folder.Path, newFile.Path);
            }


            DownloadOperation download= backgroundDownload.CreateDownload(uri, newFile);






            //Prompt prompt = new Prompt("正在下载!");
            //prompt.Show();
            PopupNotice popupNotice = new PopupNotice("正在后台下载......");
            popupNotice.ShowAPopup();
            await download.StartAsync();






        }
    }
}
