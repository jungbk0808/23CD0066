﻿using System.Collections.ObjectModel;
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

    private void Select(GundamModel? gundam)
    {
        if (gundam == null)
            return;
        _gundamImage = $"images/{gundam.Name}.png";
        OnPropertyChanged(nameof(GundamImage));
    }

    private GundamModel? _gundamSelected = null;
    public GundamModel? GundamSelected
    {
        get { return _gundamSelected; }
        set
        {
            if (_gundamSelected == value)
                return;
            _gundamSelected = value;
            Select(value);
            
        }
    }

    protected void OnPropertyChanged(string propName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
