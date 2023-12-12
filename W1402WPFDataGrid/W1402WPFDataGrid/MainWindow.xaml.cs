using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace W1402WPFDataGrid;

public partial class MainWindow : Window
{
    //protected List<GundamModel> GundamList = new List<GundamModel>();
    protected GundamViewModel viewModel = new GundamViewModel();
    
    public MainWindow() {
        InitializeComponent();
        Grid.ItemsSource = viewModel.GundamList;

        this.DataContext = viewModel;

        viewModel.GundamList.Add(new GundamModel("건담", "RX-78-2", "연방군"));
        viewModel.GundamList.Add(new GundamModel("자쿠II", "MS-06", "지온군"));
    }

    public void OnAdd(object sender, RoutedEventArgs e)
    {
        Gundam g = new Gundam();
        if (g.ShowDialog() != true) {
            return;
        }

        viewModel.GundamList.Add(new GundamModel(g.MSName, g.MSModel, g.MSParty));
        //Grid.Items.Refresh();
    }

    //private void OnSelected(object sender, RoutedEventArgs e)
    //{
    //    GundamModel g = (GundamModel)Grid.SelectedItem;

    //    //BitmapImage b = new BitmapImage(new Uri($"images/{g.Name}.png",
    //    //    UriKind.RelativeOrAbsolute));
    //    //Image.Source = b;

    //    viewModel.Select(g);
    //}
}
