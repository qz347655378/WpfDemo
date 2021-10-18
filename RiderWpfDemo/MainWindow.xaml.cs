using System.Collections;
using System.Windows;
using System.Windows.Controls;
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

        private void Add_OnClick(object sender, RoutedEventArgs e)
        {
            var btn = sender;
            var item = new TabItem { IsSelected = true, Header = "新增tab", Style = FindResource("TabItemStyle1") as Style, Margin = new Thickness(left: -90, 0, 0, 0) };
            Control.Items.Remove(sender);

            //Control.Items.Add(item);
            //Control.Items.Add(sender);
            //var list = Control.Items;
            //var newList = new SortedList();

            //foreach (var obj in list)
            //{
            //    if (obj is TabItem o)
            //    {
            //        newList.Add(o.TabIndex, o);
            //    }
            //}





        }
    }
}