using System.Windows;
using System.Windows.Controls;

namespace RiderWpfDemo.Pages
{
    /// <summary>
    /// MyCollection.xaml 的交互逻辑
    /// </summary>
    public partial class MyCollection : Page
    {
        public MyCollection()
        {
            InitializeComponent();
        }
    }


    public class CustomTextBox : TextBox
    {

        public string Placeholder
        {
            get => (string)GetValue(PlaceholderProperty);
            set => SetValue(PlaceholderProperty, value);
        }

        public static readonly DependencyProperty PlaceholderProperty = DependencyProperty.Register(nameof(Placeholder), typeof(string), typeof(CustomTextBox), new PropertyMetadata(null));

    }
}
