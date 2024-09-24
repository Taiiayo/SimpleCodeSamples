using Delegates_1;

Player player = new Player();

player.AchievementUnlocked += OnAchievementUnlocked;

await player.AddPoints(30);
await player.AddPoints(40);
await player.AddPoints(35);

static void OnAchievementUnlocked()
{
    Console.WriteLine($"Congrats from Delegates_1.Program.cs! You've just achieved something!");
}