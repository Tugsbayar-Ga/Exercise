static class WelcomeScreen
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
}