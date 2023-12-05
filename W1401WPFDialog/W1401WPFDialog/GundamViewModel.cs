using System.ComponentModel;

namespace W1401WPFDialog;

public class GundamViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

	private string _gundamList = "";

	public string GundamList
	{
		get { return _gundamList; }
		set { _gundamList = value; }
	}

	public void Add(GundamModel model)
	{
		_gundamList = $"{model.Party}의 {model.Model} "
            + $"{model.Name}{(HasJongsung(model.Name) ? "이" : "가")} "
            + "추가되었습니다.\n"
            + _gundamList;
        OnPropertyChanged(nameof(GundamList));
	}

    protected void OnPropertyChanged(string propName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }

    public bool HasJongsung(string str)
    {
        if (str.Length < 1)
            return true;
        char last = str[str.Length - 1];
        return (last - 44032) % 28 != 0 ? true : false;
    }
}
