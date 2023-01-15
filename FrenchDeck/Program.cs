class FrenchDeckProgram
{
    static void Main()
    {
        FrenchDeck deck = new FrenchDeck();
        Console.WriteLine("French Deck:");
        deck.PrintDeck();
        Console.WriteLine("Random Card:");
        Card randomCard = deck.RandomCard();
        randomCard.PrintCard();
    }
}