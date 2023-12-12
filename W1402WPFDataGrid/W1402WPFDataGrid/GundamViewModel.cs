using System.Collections.ObjectModel;
using System.ComponentModel;

namespace W1402WPFDataGrid;

public class GundamViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private ObservableCollection<GundamModel> _gundamList = new ObservableCollection<GundamModel>();

    public ObservableCollection<GundamModel> GundamList
    {
        get { return _gundamList; }
    }

    public void Add(GundamModel model)
    {
        _gundamList.Add(model);
    }

    private string _gundamImage = "";
    public string GundamImage { get { return _gundamImage; } }

    public void Select(GundamModel gundam)
    {
        _gundamImage = $"images/{gundam.Name}.png";
        OnPropertyChanged(nameof(GundamImage));
    }

    protected void OnPropertyChanged(string propName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
