using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Suit
{
    CLUBS,
    DIAMONDS,
    HEARTS,
    SPADES

}
public enum Rank
{
    TWO,
    THREE,
    FOUR,
    FIVE,
    SIX,
    SEVEN,
    EIGHT,
    NINE,
    TEN,
    JACK,
    QUEEN,
    KING,
    ACE
}
namespace Net_Learning_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var startingDeck = (from s in Suits().LogQuery("Suit Generation")
                               from r in Ranks().LogQuery("Rank Generation")
                                select new PlayingCard(r, s))
                                .LogQuery("Starting Deck")
                                .ToArray();

            foreach (var c in startingDeck)
            {
                Console.WriteLine(c);
            }

            var top = startingDeck.Take(26);
            var bottom = startingDeck.Skip(26);

            var shuffle = startingDeck;
            int amount = 0;
            do
            {
                //shuffle = shuffle.Skip(26).InterleaveSequenceWith(shuffle.Take(26));

                shuffle = shuffle.Skip(26).LogQuery("Upper Half").
                    InterleaveSequenceWith(shuffle.Take(26).LogQuery("Bottom Half")).LogQuery("Interleavin...").ToArray();

                Console.WriteLine("\n\n Shuffled! \n\n");
                foreach (var c in shuffle)
                {
                    Console.WriteLine(c);
                }
                amount++;
            } while (!shuffle.SequencesMatch(startingDeck));
            Console.WriteLine($"\n\n The amount of shuffles: {amount}.");
            Console.ReadKey();
        }

        static IEnumerable<Suit> Suits() => Enum.GetValues(typeof(Suit)) as IEnumerable<Suit>;

        static IEnumerable<Rank> Ranks() => Enum.GetValues(typeof(Suit)) as IEnumerable<Rank>;
    }
}
