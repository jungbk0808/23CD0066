using System;
using System.Linq;

namespace HW2PokerJokbo;

class CardModel
{
    public struct Card
    {
        public enum Suit { spades, diamonds, hearts, clubs }
        public enum Rank { ace, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king }

        public Suit suit;
        public Rank rank;
        public int num;

        public Card(int num) {
            this.num = num;
            this.suit = (Suit)(num % 4);
            this.rank = (Rank)(num / 4);
        }
    }

    private Card[] _cards = new Card[5] { new Card(-1), new Card(-1), new Card(-1), new Card(-1), new Card(-1) };
    public Card[] Cards {
        get { return _cards; }
    }
    private string _jokbo = "";
    public string Jokbo {
        get { return _jokbo; }
    }

    public void Shuffle()
    {
        Random random = new Random();
        int[] num = new int[5] { -1, -1, -1, -1, -1 };
        for (int i = 0; i < num.Length; i++)
        {
            int n = 0;
            do
            {
                n = random.Next(52);
            } while (num.Contains(n));
            num[i] = n;
        }

        Array.Sort(num);

        for (int i = 0; i < num.Length; i++) {
            _cards[i] = new Card(num[i]);
        }

        checkJokbo();
    }

    private void checkJokbo() {
        bool allSuitEqual = _cards.All(x => x.suit == _cards[0].suit);
        bool IsStraight = true;
        for (int i = 1; i < _cards.Length; i++) {
            if (_cards[i - 1].num != _cards[i].num - 1) {
                IsStraight = false;
                break;
            }
        }

        if (allSuitEqual) { // flush 판별
            if (IsStraight && _cards[0].rank == Card.Rank.ace) {
                _jokbo = "back straight flush";
                return;
            }
            if (_cards[0].rank == Card.Rank.ace && _cards[1].rank == Card.Rank.ten) {
                _jokbo = "royal straight flush";
                return;
            }
            if (IsStraight) {
                _jokbo = "straight flush";
                return;
            }
            _jokbo = "flush";
            return;
        }
        // straight 판별
        if (_cards[0].rank == Card.Rank.ace) {
            if (IsStraight) {
                _jokbo = "back straight";
                return;
            }
            bool IsMountain = true;
            for (int i = 1; i < _cards.Length; i++) {
                if ((int)_cards[i].rank != (int)Card.Rank.nine + i) {
                    IsMountain = false;
                    break;
                }
            }
            if (IsMountain) {
                _jokbo = "mountain";
                return;
            }
        }
        else if (IsStraight) {
            _jokbo = "straight";
            return;
        }
        // pair 판별
        var rankCount = _cards.GroupBy(x => x.rank).ToDictionary(g => g.Key, g => g.Count());
        bool hasTriple = false;
        int twoCount = 0;
        foreach (var card in rankCount) {
            if (card.Value > 2) {
                if (card.Value == 4) {
                    _jokbo = "four card";
                    return;
                }
                hasTriple = true;
            } else if (card.Value == 2) {
                twoCount++;
            }
        }

        if (hasTriple) {
            if (twoCount == 1) {
                _jokbo = "full house";
                return;
            }
            _jokbo = "triple";
            return;
        }
        if (twoCount == 2) {
            _jokbo = "two pair";
            return;
        }
        if (twoCount == 1) {
            _jokbo = "one pair";
            return;
        }
        _jokbo = "top";
        return;
    }
}
