﻿public class Card
{
    public string Rank { get; set; }
    public string Suit { get; set; }
    public Card(string rank, string suit)
    {
        Rank = rank;
        Suit = suit;
    }
    public void PrintCard()
    {
        Console.WriteLine($"the rank is {Rank} and suit is {Suit}");
    }
}
