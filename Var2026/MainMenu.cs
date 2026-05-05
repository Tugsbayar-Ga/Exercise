public static class WelcomeScreen
{
    public static void Show()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
  ███████╗███╗   ███╗██╗██╗     ██╗ █████╗ 
  ██╔════╝████╗ ████║██║██║     ██║██╔══██╗
  █████╗  ██╔████╔██║██║██║     ██║███████║
  ██╔══╝  ██║╚██╔╝██║██║██║     ██║██╔══██║
  ███████╗██║ ╚═╝ ██║██║███████╗██║██║  ██║
  ╚══════╝╚═╝     ╚═╝╚═╝╚══════╝╚═╝╚═╝  ╚═╝
        ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("        Welcome to Emilia's Game Collection");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\n        Press any key to continue...");
        Console.ResetColor();
        Console.ReadKey();
    }

    public static void main()
    {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
  ╔══════════════════════════════════╗
  ║       EMILIA'S  ARCADE           ║
  ╚══════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n  Choose your game:\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("  1)  Door Streak - Glasögonmannen Emilia");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("  2)  Hero Battle - Fighting Game");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  3)  24/7 Roulette Simulator");
            Console.ResetColor();
        
            Console.WriteLine("  Q)  Exit");
            
            Console.Write("\n  Your choice: ");

            var key = Console.ReadKey(intercept: true);
            Console.WriteLine();

            if (key.Key == ConsoleKey.D1)
                DoorStreakMenu.Show();
            else if (key.Key == ConsoleKey.D2)
                HeroBattle.Run();
            else if (key.Key == ConsoleKey.Q)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n  Thanks for playing! See you next time, Emilia!");
                Console.ResetColor();
                Thread.Sleep(1000);
                return;
            }
        }
    }
}