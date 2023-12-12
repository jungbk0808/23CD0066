using System.Windows;

namespace TPDataGrid;
public partial class IdolWindow : Window
{
	public string KName { get { return NickName.Text; } }
    public string KGroup { get { return Group.Text; } }
    public string KPosition { get { return Position.Text; } }

    public IdolWindow()
    {
        InitializeComponent();
        NickName.Focus();
    }

    public void OnOk(object sender, EventArgs e) {
        if (string.IsNullOrEmpty(NickName.Text)) {
            MessageBox.Show(
                "활동명을 입력하십시오.",
                "입력 부족",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
            return;
        }
        if (string.IsNullOrEmpty(Group.Text))
        {
            MessageBox.Show(
                "그룹을 입력하십시오.",
                "입력 부족",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
            return;
        }
        if (string.IsNullOrEmpty(Position.Text))
        {
            MessageBox.Show(
                "포지션을 입력하십시오.",
                "입력 부족",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
            return;
        }
        DialogResult = true;
    }

    public void OnCancel(object sender, EventArgs e)
    {
        DialogResult = false;
    }
}
