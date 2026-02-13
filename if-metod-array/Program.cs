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

    Game.PlayGame(target);
}
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Thanks for playing Door Streak!");
Console.ResetColor();
Thread.Sleep(800);

