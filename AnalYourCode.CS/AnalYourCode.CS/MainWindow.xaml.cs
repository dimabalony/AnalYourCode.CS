using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnalYourCode.CS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void ButtonChangeWS_Click(object sender, RoutedEventArgs e)
        {
            string mystr = ButtonChangeWS.Content.ToString();
            if (ButtonChangeWS.Content.ToString() == "")
            {
                this.WindowState = WindowState.Maximized;
                ButtonChangeWS.Content = "";
                topPanel.Height += 6;
                Rect_PushWhenMaximized_1.Width = 6;
                Rect_PushWhenMaximized_2.Height = 6;
                //ButtonSettings.Margin = new Thickness(0, 0, 0, 4);
            }
            else if (ButtonChangeWS.Content.ToString() == "")
            {
                this.WindowState = WindowState.Normal;
                ButtonChangeWS.Content = "";
                topPanel.Height -= 6;
                Rect_PushWhenMaximized_1.Width = 0;
                Rect_PushWhenMaximized_2.Height = 0;
            }
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonHelp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonOpenFile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonAnalyze_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SecurityWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void panelChangeLanguage_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TopPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState != WindowState.Maximized) { this.DragMove(); }
        }

        private void sidePanel_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void ButtonSwitchView_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
