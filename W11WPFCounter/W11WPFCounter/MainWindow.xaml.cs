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

namespace W11WPFCounter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected int Count = 0;
        public MainWindow()
        {
            InitializeComponent();
            TxtCount.Text = Count.ToString();
        }

        private void OnAdd(object sender, RoutedEventArgs e)
        {
            TxtCount.Text = $"{++Count}";
        }

        private void OnSub(object sender, RoutedEventArgs e)
        {
            if (Count > 0)
            {
                TxtCount.Text = $"{--Count}";
            }
        }
    }
}
