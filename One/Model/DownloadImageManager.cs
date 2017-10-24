using One.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.BackgroundTransfer;
using Windows.Storage;

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

            backgroundDownload.SuccessToastNotification = ToastHelper.ShowAToast("保存成功", folder.Path, newFile.Path);

            DownloadOperation download= backgroundDownload.CreateDownload(uri, newFile);

            

            await download.StartAsync();






        }
    }
}
