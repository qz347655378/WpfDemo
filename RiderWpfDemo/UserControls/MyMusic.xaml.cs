using RiderWpfDemo.Pages;
using System.Windows;
using System.Windows.Controls;

namespace RiderWpfDemo.UserControls
{
    /// <summary>
    /// MyMusic.xaml 的交互逻辑
    /// </summary>
    public partial class MyMusic : UserControl
    {
        public MyMusic()
        {
            InitializeComponent();
            MyFrame.Content = new MyCollection();
        }

        private void MyCollectionButton_OnChecked(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new MyCollection();
        }

        private void MyRadioStationButton_OnClick(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new MyRadioStation();
        }
    }
}
