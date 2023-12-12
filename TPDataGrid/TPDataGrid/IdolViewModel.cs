using System.Collections.ObjectModel;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TPDataGrid;

public class IdolViewModel
{
    private ObservableCollection<Idol> _idolList = new ObservableCollection<Idol>();

    public ObservableCollection<Idol> IdolList
    {
        get { return _idolList; }
    }

    public void Add(Idol idol)
    {
        _idolList.Add(idol);
    }

    public ImageSource GetImageSource(Idol idol)
    {
        return new BitmapImage(new Uri($"images/{idol.Group}_{idol.Name}.png", 
            UriKind.RelativeOrAbsolute));
    }
}