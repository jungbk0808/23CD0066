using System.ComponentModel;
using static HW2PokerJokbo.CardModel.Card;

namespace HW2PokerJokbo;

public class CardViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private CardModel Card = new CardModel();

    private string[] _cardResource;
    private string _jokbo;

    public CardViewModel()
    {
        _cardResource = new string[Card.Cards.Length];
        _jokbo = "";
        //GetResourceName();
        //OnPropertyChanged(nameof(CardResource));
    }
    public string[] CardResource
    {
        get { return _cardResource; }
    }

    public string Jokbo
    {
        get { return _jokbo; }
    }

    public void Shuffle()
    {
        Card.Shuffle();
        GetResourceName();
        GetJokbo();
        OnPropertyChanged(nameof(CardResource));
        OnPropertyChanged(nameof(Jokbo));
    }

    private void GetResourceName()
    {
        for (int i = 0; i < _cardResource.Length; i++)
        {
            _cardResource[i] = GetCardName(Card.Cards[i]);
        }
    }

    private string GetCardName(CardModel.Card c)
    {
        if (c.num < 0)
            return "Images/black_joker.png";

        //--------------------------------------------
        // ace, jack, queen, king이 아닐 땐 숫자 들어가기
        // jack, queen, king일 때 suit 뒤에 2 붙이기
        //--------------------------------------------

        if (c.rank == Rank.ace)
            return string.Format("Images/{0}_of_{1}.png", c.rank, c.suit);
        else if ((int)c.rank < 10)
            return string.Format("Images/{0}_of_{1}.png", (int)c.rank + 1, c.suit);
        else
            return string.Format("Images/{0}_of_{1}2.png", c.rank, c.suit);

    }

    private void GetJokbo()
    {
        _jokbo = Card.Jokbo;
    }

    private void OnPropertyChanged(string propName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
