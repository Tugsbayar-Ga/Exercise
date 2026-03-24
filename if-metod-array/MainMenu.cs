static class MainMenu
{
    public static void Show()
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  1)  Door Streak - Glasögonmannen Emilia");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  2)  Hero Battle - Fighting Game");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("  Q)  Exit");
            Console.ResetColor();
            Console.Write("\n  Your choice: ");

            var key = Console.ReadKey(intercept: true);
            Console.WriteLine();

            if (key.Key == ConsoleKey.D1)
                DoorStreakMenu.Show();
            else if (key.Key == ConsoleKey.D2)
                HeroBattle.run();
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