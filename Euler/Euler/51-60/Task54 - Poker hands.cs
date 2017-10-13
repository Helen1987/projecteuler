using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    enum Combination { HighCard, Pair, ThreeOfKind, Straight, Flush, FullHouse2, FullHouse3, FourOfAKind, StraightFlush, RoyalFlash }

    enum Suit { H, C, S, D }

    enum CardValue { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }

    struct CombinationValue
    {
        public Combination Combination { get; private set; }
        public CardValue Value { get; private set; }

        public CombinationValue(Combination combination, CardValue value)
        {
            Combination = combination;
            Value = value;
        }
    }

    class Card
    {
        private static Dictionary<char, CardValue> cardMapper = new Dictionary<char, CardValue>()
        {
            { '1', CardValue.One },
            { '2', CardValue.Two },
            { '3', CardValue.Three },
            { '4', CardValue.Four },
            { '5', CardValue.Five },
            { '6', CardValue.Six },
            { '7', CardValue.Seven },
            { '8', CardValue.Eight },
            { '9', CardValue.Nine },
            { 'T', CardValue.Ten },
            { 'J', CardValue.Jack },
            { 'Q', CardValue.Queen },
            { 'K', CardValue.King },
            { 'A', CardValue.Ace }
        };

        public Suit Suit { get; private set; }
        public CardValue Value { get; private set; }

        public Card(string card)
        {
            Suit = (Suit)Enum.Parse(typeof(Suit), card[1].ToString());
            Value = cardMapper[card[0]];
        }
    }

    class Player : IComparable<Player>
    {
        private readonly Card[] _combination;
        private readonly Dictionary<CardValue, int> _counts = new Dictionary<CardValue, int>();

        public Player(string[] combinations)
        {
            _combination = combinations.Select(comb => new Card(comb)).OrderByDescending(card => card.Value).ToArray();
            foreach (Card card in _combination)
            {
                if (_counts.ContainsKey(card.Value))
                {
                    _counts[card.Value] += 1;
                }
                else
                {
                    _counts.Add(card.Value, 1);
                }
            }
        }

        public int CompareTo(Player other)
        {
            CombinationValue[] currentCombinations = GetCombinations().OrderByDescending(comb => comb.Combination).ThenByDescending(comb => comb.Value).ToArray();
            CombinationValue[] otherCombinations = other.GetCombinations().OrderByDescending(comb => comb.Combination).ThenByDescending(comb => comb.Value).ToArray();

            int length = Math.Max(currentCombinations.Length, otherCombinations.Length);

            for (int i = 0; i < length; ++i)
            {
                if (currentCombinations.Length < i)
                {
                    return -1;
                }
                if (otherCombinations.Length < i)
                {
                    return 1;
                }
                if (currentCombinations[i].Combination == otherCombinations[i].Combination)
                {
                    if (currentCombinations[i].Value == otherCombinations[i].Value)
                    {
                        continue;
                    }
                    return currentCombinations[i].Value.CompareTo(otherCombinations[i].Value);
                }
                return currentCombinations[i].Combination.CompareTo(otherCombinations[i].Combination);
            }
            return 0;
        }

        private bool AreInTheSameSuit()
        {
            Suit firstSuit = _combination[0].Suit;
            foreach (Card card in _combination)
            {
                if (card.Suit != firstSuit)
                {
                    return false;
                }
            }
            return true;
        }

        private IEnumerable<CombinationValue> GetCombinations()
        {
            if (AreInTheSameSuit())
            {
                if (_combination.Last().Value == CardValue.Ten && _combination.First().Value == CardValue.Ace)
                {
                    yield return new CombinationValue(Combination.RoyalFlash, CardValue.Ace);
                }
                else
                {
                    if (_combination.First().Value - _combination.Last().Value == 4)
                    {
                        yield return new CombinationValue(Combination.StraightFlush, _combination.First().Value);
                    }
                    else
                    {
                        yield return new CombinationValue(Combination.Flush, _combination.First().Value);
                    }
                }
            }
            else if (_combination.First().Value - _combination.Last().Value == 4)
            {
                yield return new CombinationValue(Combination.Straight, _combination.First().Value);
            }
            else{
                if (_counts.ContainsValue(3) && _counts.ContainsValue(2))
                {
                    var three = _counts.Where(comb => comb.Value == 3).First();
                    yield return new CombinationValue(Combination.FullHouse3, three.Key);

                    var pair = _counts.Where(comb => comb.Value == 2).First();
                    yield return new CombinationValue(Combination.FullHouse2, pair.Key);
                }
                else
                {
                    foreach (var sequence in _counts)
                    {
                        if (sequence.Value == 4)
                        {
                            yield return new CombinationValue(Combination.FourOfAKind, sequence.Key);
                        }
                        else if (sequence.Value == 3)
                        {
                            yield return new CombinationValue(Combination.ThreeOfKind, sequence.Key);
                        }
                        else if (sequence.Value == 2)
                        {
                            yield return new CombinationValue(Combination.Pair, sequence.Key);
                        }
                        else
                        {
                            yield return new CombinationValue(Combination.HighCard, sequence.Key);
                        }
                    }
                }
            }
        }
    }


    public class Task54
    {
        public int Run()
        {
            int player1Wins = 0;
            using (StreamReader reader = new StreamReader("data/p054_poker.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string cardsLine = reader.ReadLine();
                    string[] cards = cardsLine.Split(' ');

                    Player player1 = new Player(cards.Take(5).ToArray());
                    Player player2 = new Player(cards.Skip(5).ToArray());
                    if (player1.CompareTo(player2) > 0)
                    {
                        player1Wins++;
                    }
                }
            }
            return player1Wins;
        }
    }
}
