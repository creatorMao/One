using One.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;


namespace One.Model
{
    /// <summary>
    /// 侧边栏按钮管理类
    /// </summary>
    public static class NavMenuManager
    {
        /// <summary>
        /// 创建导航菜单集合
        /// </summary>
        /// <returns>一个导航菜单集合</returns>
        public static List<NavMenuItem> CreateNavMenuList()
        {
            var list = new List<NavMenuItem>();
            list.Add(new NavMenuItem("一个", "0,117,117,17", "0,96,125,139", "Assets/icon/one.png", "Assets/icon/one-selected.png",typeof(IndexPage),true, "#e0e0e0"));
            list.Add(new NavMenuItem("文章", "0,117,117,17", "0,96,125,139", "Assets/icon/article.png", "Assets/icon/article-selected.png",typeof(ArticlePage),false,"#ffffff"));
            list.Add(new NavMenuItem("电影", "0,117,117,17", "0,96,125,139", "Assets/icon/movie.png", "Assets/icon/movie-selected.png",typeof(MoviePage),false,"#ffffff"));
            list.Add(new NavMenuItem("关于", "0,117,117,17", "0,96,125,139", "Assets/icon/about.png", "Assets/icon/about-selected.png",typeof(AboutPage),false, "#ffffff"));
            return list;
        }
    }

    /// <summary>
    /// 侧边栏菜单按钮类
    /// </summary>
    public class NavMenuItem : INotifyPropertyChanged
    {

        //双向绑定，用于更新矩形是否显示
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Brush defaultColor;
        public ImageSource defaultIconAddress;
        
        public string BackgroundColor { get; set; }

        /// <summary>
        /// 是否被选择
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 前景色
        /// </summary>
        public Brush _ForegroundColor;

        public Brush ForegroundColor
        {
            get
            {
                return _ForegroundColor;
            }
            set
            {
                _ForegroundColor = value;
                this.OnPropertyChanged("ForegroundColor");
            }
        }


        /// <summary>
        /// 被选后的前景色
        /// </summary>
        public Brush SelectedForegroundColor { get; set; }

        /// <summary>
        /// 图标地址
        /// </summary>
        public ImageSource _IconAddress;
        public ImageSource IconAddress
        {
            get
            {
                return _IconAddress;
            }
            set
            {
                _IconAddress = value;
                this.OnPropertyChanged("IconAddress");
            }
        }

        /// <summary>
        /// 被选后的图标地址
        /// </summary>
        public ImageSource SelectedIconAddress { get; set; }

        /// <summary>
        /// 跳转页面
        /// </summary>
        public Type NavigatePage { get; set; }

        /// <summary>
        /// 默认的构造函数（无参数）
        /// </summary>
        public NavMenuItem()
        {

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="foregroundColor">前景色</param>
        /// <param name="selectedForegroundColor">被选后的前景色</param>
        /// <param name="iconAddress">图标地址</param>
        /// <param name="selectedIconAddress">被选后的突变地址</param>
        public NavMenuItem(string title,string foregroundColor,string selectedForegroundColor,string iconAddress,string selectedIconAddress,Type navigatePage,bool isSelected,string backgroundColor)
        {
            Color color=Color.FromArgb(255, 117, 117, 117);
            Brush brush = new SolidColorBrush(color);
            this.ForegroundColor = brush;

            this.Title = title;

            Color color2 = Color.FromArgb(255, 96, 125, 139);
            Brush brush2 = new SolidColorBrush(color2);
            this.SelectedForegroundColor = brush2;

            string result = "ms-appx:///" + iconAddress.ToString();
            var bitmapImage = new BitmapImage(new Uri(result));
            this.IconAddress = bitmapImage;

            string result2 = "ms-appx:///" + selectedIconAddress.ToString();
            var bitmapImage2 = new BitmapImage(new Uri(result2));
            this.SelectedIconAddress = bitmapImage2;

            this.NavigatePage = navigatePage;

            this.IsSelected = isSelected;

            this.BackgroundColor = backgroundColor;

            this.defaultColor = brush;
            this.defaultIconAddress = bitmapImage;

        }

    }
}
