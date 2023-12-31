﻿using System;
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

namespace W1201WPFCardDealer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CardViewModel vm = new CardViewModel();
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = vm;
        }

        private void OnDeal(object sender, RoutedEventArgs e)
        {
            vm.Shuffle();
        }
        
    }
}
