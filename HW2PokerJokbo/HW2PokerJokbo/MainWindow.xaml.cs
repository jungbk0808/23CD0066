using System.Windows;

namespace HW2PokerJokbo
{
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
