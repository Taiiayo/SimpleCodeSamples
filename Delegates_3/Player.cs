namespace Delegates_3;

internal class Player
{
    public int Points { get; private set; }

    public delegate void AchievementUnlockedHandler(int points);

    public event AchievementUnlockedHandler? AchievementUnlocked;
    public async Task AddPoints(int points)
    {
        Points += points;
        Console.WriteLine($"Player earned {points} points with his hard-work. Total points: {Points}");
        await Task.Delay(1000);

        if (Points >= 100)
        {
            AchievementUnlocked?.Invoke(Points);
        }
    }
}