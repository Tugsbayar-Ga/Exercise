
public class Game
{
public static void PlayGame(int target)
{
    // Variables
    int streak = 0;
    int record = 0;
    int attempts = 0;
    double luckyChance = 0.5; // Default 50%

    List<string> history = new List<string>();
    Random random = new Random();

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"=== DOOR STREAK ({target}) ===");
    Console.ResetColor();
    Console.WriteLine("\nDo you want to play? (Y = Yes / Q = Quit)");
    Console.Write("> ");

    //-----------------------Game loop-----------------------------------------
    while (true)
{
    ConsoleKeyInfo startKey = Console.ReadKey(intercept: true);
    Console.WriteLine();

    if (startKey.Key == ConsoleKey.Y)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Are you sure? (Y = Confirm / Q = Quit)");
        Console.ResetColor();
        Console.Write("> ");
        ConsoleKeyInfo confirmKey = Console.ReadKey(intercept: true);
        Console.WriteLine();

        if (confirmKey.Key == ConsoleKey.Y)
            break; // Start game
        else if (confirmKey.Key == ConsoleKey.Q)
            return; // Back to menu
        else
        {
            Console.WriteLine("\nDo you want to play? (Y = Yes / Q = Quit)");
            Console.Write("> ");
        }
    }
    else if (startKey.Key == ConsoleKey.Q)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Are you sure? (Y = Confirm / N = Go back)");
        Console.ResetColor();
        Console.Write("> ");
        ConsoleKeyInfo quitConfirm = Console.ReadKey(intercept: true);
        Console.WriteLine();

        if (quitConfirm.Key == ConsoleKey.Y)
            return; // Back to main menu
        else
        {
            Console.WriteLine("\nDo you want to play? (Y = Yes / Q = Quit)");
            Console.Write("> ");
        }
    }
    else
    {
        Console.Write("> ");
    }
}

//-----------------------Game loop-----------------------------------------
while (true)
{
    Console.Clear();

    int doorsLeft = target - streak;
    double possible = Math.Pow(luckyChance, doorsLeft) * 100;
    double streakChance = Math.Pow(luckyChance, streak) * 100;

    //------------------------Stats----------------------
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"=== DOOR STREAK ({target}) ===");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Attempts: {attempts}");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Current Streak Glas ögon manen Emilia: {streak}");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"Record: {record}");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Doors Left: {doorsLeft}");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Chance to finish run: {possible:F10}%");
    Console.WriteLine($"Chance this streak exists: {streakChance:F6}%");
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine($"Next door chance always: {luckyChance * 100:F0}%");
    Console.WriteLine("--------------------------------");

    Console.ResetColor();
    Console.WriteLine("Choose door 1 or 2 (Q = quit run)");
    Console.Write("> ");

    ConsoleKeyInfo key = Console.ReadKey(intercept: true);
    Console.WriteLine();

    //-----------------------Quit run------------------------------
    if (key.Key == ConsoleKey.Q)
        break;

    //-------------------Hidden Lucky Keys (no hints shown)----------
    if (key.Key == ConsoleKey.L)
    {
        luckyChance = 0.9;
        continue;
    }
    if (key.Key == ConsoleKey.K)
    {
        luckyChance = 0.5;
        continue;
    }
    if (key.Key == ConsoleKey.T)
    {
        luckyChance = 1.0;
        continue;
    }

    //------------------------Only 1 or 2--------------------------
    int choice;
    try
    {
        choice = Convert.ToInt32(key.KeyChar.ToString());
    }
    catch { continue; }

    if (choice != 1 && choice != 2)
        continue;

    //------------------------DOOR CHECK-------------------------------
    attempts++;

    bool win = random.NextDouble() < luckyChance;
    int correctDoor = win ? choice : (choice == 1 ? 2 : 1);

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

    //--------------------Win Condition---------------------
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

//----------------------End stats----------------------------
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
Console.ResetColor();

//-------------------Play again or quit after run--------------------
Console.WriteLine("\nPlay again? (Y = Yes / Q = Quit)");
Console.Write("> ");

while (true)
{
ConsoleKeyInfo againKey = Console.ReadKey(intercept: true);
Console.WriteLine();

if (againKey.Key == ConsoleKey.Y)
{
// Restart same target
    PlayGame(target); 
    return;
}
else if (againKey.Key == ConsoleKey.Q){
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Are you sure? (Y = Confirm / N = Go back)");
    Console.ResetColor();
    Console.Write("> ");
    ConsoleKeyInfo finalConfirm = Console.ReadKey(intercept: true);
    Console.WriteLine();

// Back to main
    if (finalConfirm.Key == ConsoleKey.Y)
        return; 
    else
    {
        Console.WriteLine("\nPlay again? (Y = Yes / Q = Quit)");
        Console.Write("> "); 
    } 
}
else
{
    Console.Write("> ");Console.Clear();
}
}}}