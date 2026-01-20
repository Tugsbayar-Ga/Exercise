while (true)//---MAIN-MENU-LOOP---------------
{
Console.Clear();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("=== Emilia STREAK ===");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Choose a challenge:");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("1) 10 Emilia (Easy)");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("2) 15 Emilia (Medium)");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("3) 30 Emilia (Insane)");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("Q) Exit");
Console.ResetColor();
Console.Write("\nYour choice: ");

ConsoleKeyInfo menuKey = Console.ReadKey();
Console.WriteLine();

int target;

if (menuKey.Key == ConsoleKey.D1) target = 10;
else if (menuKey.Key == ConsoleKey.D2) target = 15;
else if (menuKey.Key == ConsoleKey.D3) target = 30;
else if (menuKey.Key == ConsoleKey.Q) break;
else continue; //fick den från C#.progdocs!!

// Jag vill lägga 2 spicifica key ena ger 90% förr chans den andra samma 50% de är inte sinlyga men går fram tillbaka i startet.

PlayGame(target);
}
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Thanks for playing Door Streak!");
Console.ResetColor();
Thread.Sleep(800);

static void PlayGame(int target)
{
// Game variables
int streak = 0;
int record = 0;
int attempts = 0;

List<string> history = new List<string>();
Random random = new Random();

//-----------------------GAME-LOOP-----------------------------------------
while (true)
{
Console.Clear();

int doorsLeft = target - streak;
double possoble = Math.Pow(0.5, doorsLeft) * 100; //sökte den
double streakChance = Math.Pow(0.5, streak) * 100;  //sökte den

//------------------Top-Stats----------------
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"=== DOOR STREAK ({target}) ===");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"Attempts: {attempts}");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Current Streak Emilia: {streak}");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Record: {record}");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Doors Left: {doorsLeft}");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Chance to finish run: {possoble:F10}%");
Console.WriteLine($"Chance this streak exists: {streakChance:F6}%");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("Next door chance always: 50%");
Console.WriteLine("--------------------------------");

Console.ResetColor();
Console.WriteLine("Choose door 1 or 2 (Q = quit run)");
Console.Write("> ");

ConsoleKeyInfo key = Console.ReadKey();
Console.WriteLine();

//-------------------Quit-run------------------------------
if (key.Key == ConsoleKey.Q)
break;

int choice;
try{
choice = Convert.ToInt32(key.KeyChar.ToString());
}

catch{ continue; }

if (choice != 1 && choice != 2)
continue;

//----------------------DOOR-CHECK-------------------------------
int correctDoor = random.Next(1, 3);
attempts++;

bool win = choice == correctDoor;

if (win) 
{
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("YOU FOUND GOLD!");
streak++;
history.Add("Win");
}

else
{
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"EMPTY! Gold was behind door {correctDoor}");
streak = 0;
history.Add("Loss");
}

record = Math.Max(record, streak);

Console.ResetColor();

//------------------Win-condition-Impossible---------------------
if (streak == target)
{
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"\nYOU BEAT THE {target} DOOR CHALLENGE!");
Console.ResetColor();
Console.ReadKey();
break;
}

Console.WriteLine("Press any key for next door...");
Console.ReadKey();
}

//----------------------RUN-SUMMARY----------------------------
Console.Clear();

int wins = 0, losses = 0;
foreach (var r in history)
{

if (r == "Win") wins++;

else losses++;
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"=== RUN SUMMARY ({target}) ===");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Guess right: {wins}");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Guess wrong: {losses}");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Best Emilia Streak: {record}");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"Attempts: {attempts}");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("\nPress any key to return to menu...");

Console.ResetColor();
Console.ReadKey();
}