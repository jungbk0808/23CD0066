using System.Windows;

namespace W1401WPFDialog;

public partial class Gundam : Window
{
    public string MSName { get { return Name2.Text; } }
    public string MSModel { get { return Model.Text; } }
    public string MSParty => Party.Text;


    public Gundam()
    {
        InitializeComponent();
        Name2.Focus();
    }

    public void OnOk(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrEmpty(Name2.Text))
        {
            MessageBox.Show(
                "이름을 입력하십시오.",
                "입력 부족",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
            return;
        }
        if (string.IsNullOrEmpty(Model.Text))
        {
            MessageBox.Show(
                "모델을 입력하십시오.",
                "입력 부족",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
            return;
        }
        if (string.IsNullOrEmpty(Party.Text))
        {
            MessageBox.Show(
                "소속을 입력하십시오.",
                "입력 부족",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
            return;
        }
        DialogResult = true;
    }

    public void OnCancel(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
    }
}
