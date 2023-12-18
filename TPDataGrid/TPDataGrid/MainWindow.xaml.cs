using System.Windows;

namespace TPDataGrid;

public partial class MainWindow : Window
{
    protected IdolViewModel viewModel = new IdolViewModel();
    public MainWindow()
    {
        InitializeComponent();
        Grid.ItemsSource = viewModel.IdolList;
        this.DataContext = viewModel;

        // TO DO: 하드코딩 지우기
        viewModel.IdolList.Add(new Idol("달", "우주", "기타"));
    }

    public void OnAdd(object sender, RoutedEventArgs e)
    {
        IdolWindow iw = new IdolWindow();
        if (iw.ShowDialog() != true) {
            return;
        }

        viewModel.IdolList.Add(new Idol(iw.KName, iw.KGroup, iw.KPosition));
    }

    //public void OnSelected(object sender, RoutedEventArgs e)
    //{
    //    viewModel.Select((Idol)Grid.SelectedItem);
    //}
}