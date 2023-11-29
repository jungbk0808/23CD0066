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

namespace W1303WPFMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ItemWhite.IsChecked = true;
            ItemWhite.IsEnabled = false;

            CommandBinding bind = new CommandBinding(ApplicationCommands.Open);
            bind.Executed += OpenDocument;
            CommandBindings.Add(bind);
        }

        private void OpenDocument(object sender, ExecutedRoutedEventArgs e)
        {
            //MessageBox.Show("파일 오픈");

            var dialog = new Microsoft.Win32.OpenFileDialog();
            //dialog.FileName = "사진"; // Default file name
            dialog.DefaultExt = ".jpg"; // Default file extension
            dialog.Filter = "Images (.png)|*.png"; // Filter files by extension

            // Show open file dialog box
            bool? result = dialog.ShowDialog();

            // Process open file dialog box results
            if (result != true)
                return;

            // Open document
            string filename = dialog.FileName;

            MessageBox.Show(filename);
        }

        private void SetRed(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("빨간색");
            BackPanel.Background = Brushes.Red;

            ItemRed.IsChecked = true;
            ItemGreen.IsChecked = false;
            ItemBlue.IsChecked = false;

            ItemWhite.IsChecked = false;
            ItemWhite.IsEnabled = true;
        }

        private void SetGreen(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            BackPanel.Background = brush;

            ItemRed.IsChecked = false;
            ItemGreen.IsChecked = true;
            ItemBlue.IsChecked = false;

            ItemWhite.IsChecked = false;
            ItemWhite.IsEnabled= true;
        }

        private void SetBlue(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Color.FromArgb(255, 0, 0, 255));
            BackPanel.Background = brush;

            ItemRed.IsChecked = false;
            ItemGreen.IsChecked = false;
            ItemBlue.IsChecked = true;

            ItemWhite.IsChecked = false;
            ItemWhite.IsEnabled= true;
        }

        private void SetWhite(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.White);
            BackPanel.Background = brush;

            ItemRed.IsChecked = false;
            ItemGreen.IsChecked = false;
            ItemBlue.IsChecked = false;

            ItemWhite.IsChecked = true;
            ItemWhite.IsEnabled = false;
        }
    }
}
