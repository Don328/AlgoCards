// See https://aka.ms/new-console-template for more information

namespace AlgoCards
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var deck = new List<Card>();

            for (int i = 0; i < 54; i++)
            {
                deck.Add(new Card((CardValueIndex)i));
            }

            Console.WriteLine("Deck count:");
            Console.WriteLine(deck.Count());
            Console.WriteLine();

            foreach (var card in deck)
            {
                Console.WriteLine($"index: {card.Index} | Suit: {card.Suit} [{card.SuitColor}]| Rank: {card.Rank} | {card.ToString()}");
                Console.WriteLine();

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
