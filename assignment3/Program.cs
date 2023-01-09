using System.Threading.Channels;

int allowedchances = 5;
int guessingValue= 0;


Random rand = new Random();
int guessNumber = rand.Next(1, 101);
Console.WriteLine(guessNumber);

for (int i = 0; i <= allowedchances; i++)
{
    Console.WriteLine("Enter the guess value: ");
    guessingValue = Convert.ToInt32(Console.ReadLine());
    int Chances = (allowedchances-1) - i;
    Console.WriteLine($"remaining chances left {Chances}");
    if (Chances == 0)
    {
        Console.WriteLine("You Lost");
    }
    if (guessingValue == guessNumber)
    {
        Console.WriteLine("Your guess was correct!");
        break;
    }
    if (guessingValue > guessNumber)
    {
        Console.WriteLine("Your guess was too high");
    }
    else
        Console.WriteLine("Your guess was too low");
}
Console.WriteLine($"The answer was {guessNumber}");
