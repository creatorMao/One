using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace One.Model
{
    public class AppSetting
    {
        public async Task<StorageFolder> GetDownloadFolder()
        {
            StorageFolder folder = await KnownFolders.PicturesLibrary.CreateFolderAsync("ONE", CreationCollisionOption.OpenIfExists);
            return folder;
        }
    }
}
