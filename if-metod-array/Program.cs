while (true) // App loop
{
Console.Clear();
Console.WriteLine("=== DOOR STREAK ===");
Console.WriteLine("Choose a challenge:");
Console.WriteLine("1) 10 doors (Easy)");
Console.WriteLine("2) 15 doors (Medium)");
Console.WriteLine("3) 30 doors (Insane)");
Console.WriteLine("Q) Exit");
Console.WriteLine("-------------------");
Console.Write("Your choice: ");

ConsoleKeyInfo menuKey = Console.ReadKey();
Console.WriteLine();

int target;

if (menuKey.Key == ConsoleKey.D1) target = 10;
else if (menuKey.Key == ConsoleKey.D2) target = 15;
else if (menuKey.Key == ConsoleKey.D3) target = 30;
else if (menuKey.Key == ConsoleKey.Q) break;
else continue;

PlayGame(target);
}

Console.WriteLine("\nThanks for playing Door Streak.");

static void PlayGame(int target)
{
int streak = 0;
int record = 0;
int attempts = 0;

List<string> history = new List<string>();
Random random = new Random();
bool quit = false;

while (!quit)
{
Console.Clear();

int doorsLeft = target - streak;
double runChance = Math.Pow(0.5, doorsLeft) * 100;

Console.WriteLine($"=== DOOR STREAK ({target}) ===");
Console.WriteLine($"Record: {record}");
Console.WriteLine($"Attempts: {attempts}");
Console.WriteLine($"Current Streak: {streak}");
Console.WriteLine($"Doors left: {doorsLeft}");
Console.WriteLine($"Next door chance: 50%");
Console.WriteLine($"Chance to finish run: {runChance:F10}%");
Console.WriteLine("--------------------------------");
Console.WriteLine("Choose door 1 or 2 (or press Q to quit run)");
Console.Write("> ");

ConsoleKeyInfo key = Console.ReadKey();
Console.WriteLine();

if (key.Key == ConsoleKey.Q)
break;

int choice;
try
{
choice = Convert.ToInt32(key.KeyChar.ToString());
}
catch
{
continue;
}

if (choice != 1 && choice != 2)
continue;

int correctDoor = random.Next(1, 3);
attempts++;

bool win = choice == correctDoor;

if (win)
{
streak++;
history.Add("Win");
Console.WriteLine("YOU FOUND GOLD!");
}
else
{
streak = 0;
history.Add("Loss");
Console.WriteLine($"EMPTY! Gold was behind door {correctDoor}");
}

record = Math.Max(record, streak);

if (streak == target)
{
Console.WriteLine($"\nYOU BEAT THE {target} DOOR CHALLENGE!");
Console.ReadKey();
quit = true;
}
else
{
Console.WriteLine("Press any key...");
Console.ReadKey();
}
}

// End of run stats
Console.Clear();
int wins = 0, losses = 0;
foreach (var r in history)
{
if (r == "Win") wins++;
else losses++;
}

Console.WriteLine($"=== RUN STATS ({target}) ===");
Console.WriteLine($"Attempts: {attempts}");
Console.WriteLine($"Wins: {wins}");
Console.WriteLine($"Losses: {losses}");
Console.WriteLine($"Best streak: {record}");
Console.WriteLine("----------------------------");
Console.WriteLine("Press any key to return to menu...");
Console.ReadKey();
}