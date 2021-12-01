// See https://aka.ms/new-console-template for more information

namespace AlgoCards
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var deck = GetSortedDeck();
            DisplayDeck(deck);
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

        private static List<Card> GetSortedDeck()
        {
            var deck = new List<Card>();

            for (int i = 0; i < 54; i++)
            {
                deck.Add(new Card((CardValueIndex)i));
            }
            
            return deck;
        }
    }
}
