// See https://aka.ms/new-console-template for more information

namespace AlgoCards;
public static class Program
{
    public static void Main(string[] args)
    {
        Deck deck = new();

        if (args.Contains("--shuffled") ||
            args.Contains("-s"))
        {
            if (args.Contains("--no-jokers"))
            {
                deck = new Deck(DeckType.Shuffled);
                DisplayDeck(deck.NoJokers());
            }
            else
            {
                deck = new Deck(DeckType.Shuffled);
                DisplayDeck(deck.Cards);
            }

        }
        else if (args.Contains("--just-ten"))
        {
            string inputSuit = string.Empty;
            if (args[0] is not null)
            {
                inputSuit = args[0];
            }
            deck = new Deck(DeckType.Sorted);
            DisplayDeck(deck.JustTen(inputSuit));
        }
        else if (args.Contains("--one-suit"))
        {
            string inputSuit = string.Empty;
            if (args[0] is not null)
            {
                inputSuit = args[0];
            }
            deck = new Deck(DeckType.Sorted);
            DisplayDeck(deck.OneSuit(inputSuit));
        }
        else if (args.Contains("--no-jokers"))
        {
            deck = new Deck(DeckType.Sorted);
            DisplayDeck(deck.NoJokers().OrderBy(c => c.Index).ToList());
        }
        else
        {
            deck = new Deck(DeckType.Sorted);
            DisplayDeck(deck.Cards);
        }
    }

    private static void DisplayDeck(List<Card> deck)
    {
        foreach (var card in deck)
        {
            Console.WriteLine($"index: {card.Index} | Suit: {card.Suit} [{card.SuitColor}]| Rank: {card.Rank} | {card.ToString()}");
            Console.WriteLine();

        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Deck count:");
        Console.WriteLine(deck.Count());
        Console.WriteLine();
        Console.WriteLine();
    }

    internal static List<Card> GetSortedDeck()
    {
        var deck = new List<Card>();

        for (int i = 0; i < 54; i++)
        {
            deck.Add(new Card((CardValueIndex)i));
        }
        
        return deck;
    }

    internal static List<Card> GetShuffledDeck()
    {
        int deckSize = 54;
        var deck = new List<Card>();
        var table = new bool[deckSize];
        
        for(int i = 0; i < deckSize; i++)
        {
            table[i] = false;
        }

        while(deck.Count < deckSize)
        {
            var random = new Random();
            int value = random.Next(54);
            if (!table[value])
            {
                deck.Add(new Card((CardValueIndex)value));
                table[value] = true;
            }

            continue;
        }

        return deck;
    }
}
