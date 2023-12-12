using System.Collections.ObjectModel;

namespace W1402WPFDataGrid;

public class GundamViewModel
{
    private ObservableCollection<GundamModel> _gundamList = new ObservableCollection<GundamModel>();

    public ObservableCollection<GundamModel> GundamList
    {
        get { return _gundamList; }
    }

    public void Add(GundamModel model)
    {
        _gundamList.Add(model);
    }
}
