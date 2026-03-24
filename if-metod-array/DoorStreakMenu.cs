static class DoorStreakMenu
{
    public static void Show()
    {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== Glasögonmannen Emilia STREAK ===");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Choose a challenge:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1) 10 Glasögonmannen Emilia (Easy)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2) 15 Glasögonmannen Emilia (Medium)");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("3) 30 Glasögonmannen Emilia (Insane)");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Q) Back to main menu");
            Console.ResetColor();
            Console.Write("\nYour choice: ");

            var key = Console.ReadKey(intercept: true);
            Console.WriteLine();

            if (key.Key == ConsoleKey.D1)      Game.PlayGame(10);
            else if (key.Key == ConsoleKey.D2) Game.PlayGame(15);
            else if (key.Key == ConsoleKey.D3) Game.PlayGame(30);
            else if (key.Key == ConsoleKey.Q)  return; // Tillbaka till MainMenu
        }
    }
}

    // Jag vill lägga 2 spicifica key ena ger 90% förr chans den andra samma 50% de är inte sinlyga men går fram tillbaka i startet.
// Det är väll bara för arv fungerar för class?

// Jag vill att innan while true, komemr finnas två val där vil du spela eller inte för y(yes) och n(no) och "fråga igens är du ja och nej fårgar men isleättel nej confirm " säker på engelska. om no så går det till avslutet  och slutet frågar igen och 3 är du säker samma sak will köra och avsluta, men y(yes) nångong då kör spelat som normalt