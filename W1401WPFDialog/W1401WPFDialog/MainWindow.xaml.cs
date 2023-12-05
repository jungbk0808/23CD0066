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

namespace W1401WPFDialog;

public partial class MainWindow : Window
{
    private GundamViewModel viewModel = new GundamViewModel();
    public MainWindow()
    {
        InitializeComponent();

        this.DataContext = viewModel;
    }

    public void OnAdd(object sender, RoutedEventArgs e)
    {
        Gundam g = new Gundam();
        if (g.ShowDialog() != true)
            return;

        viewModel.Add(new GundamModel(g.MSName, g.MSModel, g.MSParty));
    }
}
