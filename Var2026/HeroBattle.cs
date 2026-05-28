// Stridsspel mot fiender
static class HeroBattle
{
    // Kör hela stridsflödet
    public static void Run()
    {
        // Möjlighet att backa
        var ToMain = Console.ReadKey(intercept: true);
        if (ToMain.Key == ConsoleKey.Q)
        {
            WelcomeScreen.main();
            return;
        }
        
        // Hjältens startvärden
        int heroHp = 100;
        int heroStamina = 100;
        
        // Frågar antal fiender
        int numEnemies = AskForNumber("Hur många fiender vill du slåss mot? (1-10)", 1, 10);
        
        // Loop för varje fiende
        for (int i = 0; i < numEnemies; i++)
        {
            int enemyHp = 100;
            int round = 1;
            
            // Stridloop per fiende
            while (heroHp > 0 && enemyHp > 0)
            {
                // Visar aktuell status
                ShowStatus(heroHp, heroStamina, enemyHp, round, i + 1);
                Console.ReadLine();

                if (heroStamina <= 0)
                {
                    // Spelaren vilar, återfår stamina
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Du är för trött och vilar denna runda.");
                    heroStamina = 100;
                }
                else
                {
                    Console.Clear(); 
                    // Väljer antal attacker
                    int attacks = AskForNumber("Hur många attacker vill du göra? (1-5)", 1, 5);
                    
                    // Utför valda attacker
                    for (int j = 0; j < attacks; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        HeroAttack(ref enemyHp, ref heroStamina, i + 1);
                        
                        // Avbryter om stamina slut
                        if (heroStamina <= 0 || enemyHp <= 0) break;
                        Console.ResetColor();
                    }
                }

                Console.WriteLine("--------------------");
                EnemyAttack(ref heroHp, i + 1);
                
                // Värden aldrig under noll
                heroHp = Math.Max(heroHp, 0);
                heroStamina = Math.Max(heroStamina, 0);
                enemyHp = Math.Max(enemyHp, 0);

                // Fortsätter till nästa runda
                if (heroHp > 0 && enemyHp > 0)
                {
                    Console.WriteLine("Tryck Enter för nästa runda");
                    Console.ReadLine();
                }
                round++;
            }

            if (heroHp <= 0)
            {
                // Spelaren dog, spelet slutar
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Du dog! Spelet är slut!");
                break;
            }
            else
            {
                // Fienden besegrades
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Du besegrade fiende {i + 1}!");
            }
        }

        // Vann alla fiender
        if (heroHp > 0)
            Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Du vann mot alla fiender! Bra jobbat!");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nTryck Enter för att återgå till huvudmenyn");
        Console.ResetColor();
        Console.ReadLine();
    }

    // Frågar om giltigt heltal
    static int AskForNumber(string text, int min, int max)
    {
        int value;
        while (true)
        {
            Console.Clear();
            Console.WriteLine(text);
            if (!int.TryParse(Console.ReadLine(), out value))
                Console.WriteLine("Du måste skriva ett tal!");
            else if (value < min || value > max)
                Console.WriteLine($"Skriv ett tal mellan {min} och {max}.");
            else
                return value;
        }
    }

    // Visar hjälte och fiendestatus
    static void ShowStatus(int heroHp, int heroStamina, int enemyHp, int round, int enemyNumber)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("====================");
        Console.WriteLine($"Runda {round} mot fiende {enemyNumber}");
        Console.WriteLine($"HJÄLTE: HP [{heroHp}] STAMINA [{heroStamina}]");
        Console.WriteLine($"FIENDE {enemyNumber}: HP [{enemyHp}]");
        Console.WriteLine("Tryck Enter för att fortsätta");
    }

    // Hjältens attack mot fienden
    static void HeroAttack(ref int enemyHp, ref int heroStamina, int enemyNumber)
    {
        int damage = Random.Shared.Next(10, 20);
        int staminaCost = Random.Shared.Next(30, 45);
        enemyHp -= damage;
        heroStamina -= staminaCost;
        Console.WriteLine($"Du anfaller fiende {enemyNumber} och gör {damage} skada.");
        Console.WriteLine($"Det kostar {staminaCost} stamina.");
    }

    // Fiendens attack mot hjälten
    static void EnemyAttack(ref int heroHp, int enemyNumber)
    {
        int damage = Random.Shared.Next(10, 20);
        heroHp -= damage;
        Console.WriteLine($"Fiende {enemyNumber} anfaller och gör {damage} skada.");
    }
}