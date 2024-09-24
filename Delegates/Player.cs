namespace Delegates;

internal class Player
{
    public int Points { get; private set; }

    public async Task AddPoints(int points)
    {
        Points += points;
        Console.WriteLine($"Player earned {points} points with his hard-work. Total points: {Points}");
        await Task.Delay(1000);

        if (Points >= 100)
        {
            Console.WriteLine($"Congrats! You've just achieved something!");
        }
    }
}