using System.Windows;
using System.Windows.Input;

namespace RiderWpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WindowClose_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MinWindow_OnClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void MaxWindow_OnClick(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                MaxWindow.ToolTip = "最大化";
                WindowState = WindowState.Normal;
            }
            else
            {
                MaxWindow.ToolTip = "还原";
                WindowState = WindowState.Maximized;
            }
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}