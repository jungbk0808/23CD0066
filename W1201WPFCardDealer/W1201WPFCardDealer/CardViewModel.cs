using System;
using System.ComponentModel;

namespace W1201WPFCardDealer;

public class CardViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private CardModel Card = new CardModel();

	private string[] _cardResource;

	public CardViewModel()
	{
		_cardResource = new string[Card.Cards.Length];
	}
	public string[] CardResource
	{
		get { return _cardResource; }
	}

	public void Shuffle()
	{
		Card.Shuffle();
		GetResourceName();
        OnPropertyChanged(nameof(CardResource));
	}

	private void GetResourceName()
	{
        for (int i = 0; i < _cardResource.Length; i++)
        {
            _cardResource[i] = GetCardName(Card.Cards[i]);
        }
    }

    private string GetCardName(int c)
    {
        if (c < 0)
            return "Images/black_joker.png";

        string suit = "";
        switch (c / 13)
        {
            case 0: suit = "spades"; break;
            case 1: suit = "diamonds"; break;
            case 2: suit = "hearts"; break;
            case 3: suit = "clubs"; break;
        }

        string rank = "";
        switch (c % 13)
        {
            case 0: rank = "ace"; break;
            case int n when (n > 0 && n < 10):
                rank = (c % 13 + 1).ToString(); break;
            case 10: rank = "jack"; break;
            case 11: rank = "queen"; break;
            case 12: rank = "king"; break;
        }

        //--------------------------------------------
        // Jack, Queen, King일 때 suit 뒤에 2 붙이기
        //--------------------------------------------
        // 방법 0. Windows Forms 때처럼 rank switch 문에서 suit에 "2" 추가

        // 방법 1. Contains 사용
        //if (new int[] { 10, 11, 12 }.Contains(c % 13)) 

        // 방법 2. IndexOf(), FindIndex() 함수 사용해도 됨

        // 방법 3. Lambda Expression을 사용하여 c % 13 값이 10, 11, 12와 일치하는지 검사
        // { x | x는 정수, 0 < x < 3 } -> 람다 함수가 요런 애들이랑 비슷한 역할을 함
        if (Array.Exists(new int[] { 10, 11, 12 }, x => x == c % 13))
            return string.Format("Images/{0}_of_{1}2.png", rank, suit);
        else
            return string.Format("Images/{0}_of_{1}.png", rank, suit);
    }

    private void OnPropertyChanged(string propName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
