using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class Prompt : UserControl
    {

        private Popup _popup = null;

        public Prompt()
        {
            this.InitializeComponent();

            this.Width = Window.Current.Bounds.Width;
            this.Height = Window.Current.Bounds.Height;

            _popup = new Popup();
        }

        public async void Show(string content)
        {
            PromptContent.Text = content;
            _popup.Child = this;
            _popup.IsOpen = true;

            await Task.Delay(1000);
            _popup.IsOpen = false;
        }


    }
}
