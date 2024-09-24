using Delegates_3;

Player player = new Player();
Party party = new Party();

player.AchievementUnlocked += OnAchievementUnlocked;
player.AchievementUnlocked += party.Cheering;

await player.AddPoints(30);
await player.AddPoints(40);
await player.AddPoints(35);

static void OnAchievementUnlocked(int points)
{
    Console.WriteLine($"Congrats from Delegates_2.Program.cs! You've just achieved something! You earned {points} points.");
}

Console.ReadLine();