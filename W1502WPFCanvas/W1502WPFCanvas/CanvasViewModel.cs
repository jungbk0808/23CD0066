using System.ComponentModel;
using System.Windows;

namespace W1502WPFCanvas;

public class CanvasViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    //private double _posX;
    //public double PosX { get => _posX; }

    //private double _posY;
    //public double PosY { get => _posY; }

    private Point _pos;
    public Point Pos { get => _pos; }

    public CanvasViewModel()
    {
        //_posX = 200;
        //_posY = 200;
        _pos = new Point(200, 200);
    }

    public void SetPos(Point p)
    {
        //_posX = p.X;
        //_posY = p.Y;

        //OnPropertyChanged(nameof(PosX));
        //OnPropertyChanged(nameof(PosY));
        _pos = p;
        OnPropertyChanged(nameof(Pos));
    }

    private void OnPropertyChanged(string name)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
