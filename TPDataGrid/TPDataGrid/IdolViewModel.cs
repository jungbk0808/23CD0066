using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TPDataGrid;

public class IdolViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    private ObservableCollection<Idol> _idolList = new ObservableCollection<Idol>();
    private string _idolImage = "";

    public ObservableCollection<Idol> IdolList
    {
        get => _idolList;
    }

    public string IdolImage
    {
        get => _idolImage;
    }

    private Idol? _idolSelected = null;
    public Idol? IdolSelected
    {
        get => _idolSelected;
        set
        {
            if (_idolSelected == value)
                return;
            _idolSelected = value;
            Select(value);
        }
    }

    public void Add(Idol idol)
    {
        _idolList.Add(idol);
    }

    private void Select(Idol idol)
    {
        if (idol == null)
            return;
        _idolImage = $"images/{idol.Group}_{idol.Name}.png";
        OnPropertyChanged(nameof(IdolImage));
    }
    
    protected void OnPropertyChanged(string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}