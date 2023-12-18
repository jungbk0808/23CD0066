using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace W1502WPFCanvas;

public partial class MainWindow : Window
{
    private CanvasViewModel viewModel = new CanvasViewModel(); 

    private Boolean IsMoving = false;
    public MainWindow()
    {
        InitializeComponent();
        this.DataContext = viewModel;
    }

    private void OnMouseDown(object sender, MouseButtonEventArgs e)
    {
        IsMoving = true;
    }
    private void OnMouseUp(object sender, MouseButtonEventArgs e)
    {
        IsMoving = false;
    }

    private void OnMouseMove(object sender, MouseEventArgs e)
    {
        if (!IsMoving)
            return;

        viewModel.SetPos(e.GetPosition(this));
    }
}