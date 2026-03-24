static class HeroBattle
{
    public static void Run()
    {
        Console.Clear();

        int heroHp = 100;
        int heroStamina = 100;

        int numEnemies = AskForNumber("Hur många fiender vill du slåss mot? (1-10)", 1, 10);

        for (int i = 0; i < numEnemies; i++)
        {
            int enemyHp = 100;
            int round = 1;

            while (heroHp > 0 && enemyHp > 0)
            {
                ShowStatus(heroHp, heroStamina, enemyHp, round, i + 1);
                Console.ReadLine();

                if (heroStamina <= 0)
                {
                    Console.WriteLine("Du är för trött och vilar denna runda.");
                    heroStamina = 100;
                }
                else
                {
                    Console.Clear(); // ← fixat här
                    int attacks = AskForNumber("Hur många attacker vill du göra? (1-5)", 1, 5);

                    for (int j = 0; j < attacks; j++)
                    {
                        HeroAttack(ref enemyHp, ref heroStamina, i + 1);
                        if (heroStamina <= 0 || enemyHp <= 0) break;
                    }
                }

                Console.WriteLine("--------------------");
                EnemyAttack(ref heroHp, i + 1);

                heroHp      = Math.Max(heroHp, 0);
                heroStamina = Math.Max(heroStamina, 0);
                enemyHp     = Math.Max(enemyHp, 0);

                if (heroHp > 0 && enemyHp > 0)
                {
                    Console.WriteLine("Tryck Enter för nästa runda");
                    Console.ReadLine();
                }

                round++;
            }

            if (heroHp <= 0)
            {
                Console.WriteLine("Du dog! Spelet är slut!");
                break;
            }
            else
            {
                Console.WriteLine($"Du besegrade fiende {i + 1}!");
            }
        }

        if (heroHp > 0)
            Console.WriteLine("Du vann mot alla fiender! Bra jobbat!");

        Console.WriteLine("\nTryck Enter för att återgå till huvudmenyn");
        Console.ReadLine();
    }

    static int AskForNumber(string text, int min, int max)
    {
        int value;
        while (true)
        {
            Console.Clear(); // ← rensar även vid felaktig inmatning
            Console.WriteLine(text);
            if (!int.TryParse(Console.ReadLine(), out value))
                Console.WriteLine("Du måste skriva ett tal!");
            else if (value < min || value > max)
                Console.WriteLine($"Skriv ett tal mellan {min} och {max}.");
            else
                return value;
        }
    }

    static void ShowStatus(int heroHp, int heroStamina, int enemyHp, int round, int enemyNumber)
    {
        Console.Clear();
        Console.WriteLine("====================");
        Console.WriteLine($"Runda {round} mot fiende {enemyNumber}");
        Console.WriteLine($"HJÄLTE: HP [{heroHp}] STAMINA [{heroStamina}]");
        Console.WriteLine($"FIENDE {enemyNumber}: HP [{enemyHp}]");
        Console.WriteLine("Tryck Enter för att fortsätta");
    }

    static void HeroAttack(ref int enemyHp, ref int heroStamina, int enemyNumber)
    {
        int damage      = Random.Shared.Next(10, 20);
        int staminaCost = Random.Shared.Next(30, 45);
        enemyHp      -= damage;
        heroStamina  -= staminaCost;
        Console.WriteLine($"Du anfaller fiende {enemyNumber} och gör {damage} skada.");
        Console.WriteLine($"Det kostar {staminaCost} stamina.");
    }

    static void EnemyAttack(ref int heroHp, int enemyNumber)
    {
        int damage = Random.Shared.Next(10, 20);
        heroHp -= damage;
        Console.WriteLine($"Fiende {enemyNumber} anfaller och gör {damage} skada.");
    }
}