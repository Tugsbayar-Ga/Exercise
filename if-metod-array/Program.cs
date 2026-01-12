// if( 6>=3){
//     Console.WriteLine("Hello, World!");
// }  ---------Första---------------------------------------------------------------------

// string username = Console.ReadLine();
// if (username == "kalleanka")
// Console.WriteLine("Welcome!");
// ---------Andra-------------------------------------------------------------------

// string username = Console.ReadLine();
// string password = Console.ReadLine();
// if (username == "kalleanka" && password == "12345")
//     Console.WriteLine("Welcome!");
// else
//     Console.WriteLine("Wrong username or password");
// -----------tredje--------------------------------------------------------------------

// for (int i = 0; i < 32; i++)
// {
//     Console.WriteLine("Hello, World!");
// } -------------fjärde--------------------------------------------------------------

// string password = "";
// while (password != "12345"){
//     password = Console.ReadLine();
//     Console.Clear();
//     if (password != "12345"){
//         Console.WriteLine("Wrong try again");
//         Console.ReadKey();
//         Console.Clear();
//     }}
// Console.WriteLine("Welcome!");
// Console.ReadLine();
// ----------femte--------------------------------------------------------------------------

// int i = 0;
// while (i != 5)
// {
//     i++;
//     Console.WriteLine(i);
// }
// Console.WriteLine("högre en 5");  ------while-ränkar up till mer än 5--------

// for (int i = 0; i <= 5; i++)
// {
//     Console.WriteLine(i);
// }
// Console.WriteLine("högre en 5");
// Console.ReadLine();  -------for-ränkar up till mer än 5------

// for (int i = 0; i < 5; i++)
// {
// //     Console.Write("Skriv ett tal: ");
// //     int tal = int.Parse(Console.ReadLine());

// //     if (tal > 5)
// //         Console.WriteLine("högre än 5!");
// // } -------for- kontrolerar om det det talet jag skriver är högre än 5-------

// // int i = 0;
// // while (i < 5)
// // {
// //     Console.Write("Skriv ett tal: ");
// //     string input = Console.ReadLine();
// //     int tal = int.Parse(input);
// //     if (tal > 5)
// //         Console.WriteLine("      högre än 5!"); 
// //     else
// //         Console.WriteLine(); 
// //     i++;
// // } samma/=/=//
// // while (i < 5)
// // {
// //     Console.Write("Skriv ett tal: ");
// //     int cursorX = Console.CursorLeft;
// //     int cursorY = Console.CursorTop;
// //     string input = Console.ReadLine();

// //     // Testar om det är ett tal
// //     if (!int.TryParse(input, out int tal))
// //     {
// //         Console.WriteLine("  Du måste skriva ett tal!");
// //         continue; // hoppa över resten av loopen och börja om
// //     }
// //     // Flytta tillbaka markören efter det användaren skrev
// //     Console.SetCursorPosition(cursorX + input.Length, cursorY);
// //     if (tal > 5)
// //     Console.Write("   högre än 5!");
// //     Console.WriteLine();
// //     i++;
// // }  ----------------------------------sjätte--------------------------------------------

// // string input;
// // while (true){
// // Console.Write("Skriv ett heltal: ");
// // input = Console.ReadLine(); // Läs in texten från användaren

// // // Försök konvertera texten till ett tal
// // if (int.TryParse(input, out int number)){
// // Console.WriteLine($"Du skrev ett giltigt tal: {number}  hej då!!!!");
// // Thread.Sleep(500);
// // break; 
// // }
// // else{
// // Console.WriteLine("   Ogiltigt!   Skriv ett heltal.");
// // Thread.Sleep(300);
// // }}

// string input;
// while (true){
// Console.Write("Skriv ett heltal: ");
// input = Console.ReadLine();

// // Kolla om alla tecken är siffror
// if (!string.IsNullOrEmpty(input) && input.All(char.IsDigit)){
//     Console.WriteLine($"Bra! Du skrev ett giltigt tal: {input}");
//     break;
// }
// else{
//     Console.WriteLine("Ogiltigt! Skriv endast siffror."); 
//     Thread.Sleep(1000);
//     Console.Clear();
// }}Console.ReadLine();// ------sjunde------------------------------------------------------

// Random random = new Random();
// int taletAttGissa = random.Next(1, 101);
// int gissning = 0; //fråga den!!!

// Console.WriteLine("Välkommen till 'Gissa siffran'!");
// Console.WriteLine("Jag har valt ett tal mellan 1 och 100. Kan du gissa vilket?");

// while (gissning != taletAttGissa)
// {
//     Console.Write("Skriv din gissning: ");
//     string input = Console.ReadLine();

//     if (!int.TryParse(input, out gissning)){
//     Console.WriteLine("Det där var inte ett giltigt tal. Försök igen.");
//     continue;
//     }

// if (gissning < taletAttGissa){
//     Console.WriteLine("För lågt! Försök igen.");
//     }
// else if (gissning > taletAttGissa){
//     Console.WriteLine("För högt! Försök igen.");
//     }
// else{
// Console.WriteLine("Grattis! Du gissade rätt!");
//     }}------------------------------åtta------------------------------------------------

// ButikUppgift(); // Kör funktionen
// static void ButikUppgift()
// {
//     // 1. Skapa listor med föremålens namn och vikter
//     List<string> namn = ["Äpple", "Limpa", "Mjölk", "Ost", "Kött"];
//     List<int> vikt = [];

//     // 2. Fyll viktlistan med slumpade vikter
//     for (int i = 0; i < 5; i++)
//     { vikt.Add(Random.Shared.Next(1, 101)); }
//     3. Skriv ut rubrik
//     Console.ForegroundColor = ConsoleColor.Yellow;
//     Console.WriteLine("Föremål i butik:");
//     Console.ResetColor();

//     // Skriv ut föremålen
//     for (int i = 0; i < namn.Count; i++)
//     {
//         Console.WriteLine($"{namn[i]} väger {vikt[i]}");
//     }

//     // 4. Användarens maxvikt
//     int maxVikt;
//     while (true)
//     {
//         Console.Write("\nHur mycket kan din karaktär bära? ");
//         string input = Console.ReadLine();

//         if (int.TryParse(input, out maxVikt))
//             break;

//         Console.WriteLine("Du måste skriva ett heltal!");
//     }

//     // 5. Skriv vad användaren kan bära
//     Console.WriteLine("\nDu kan bära:");
//     for (int i = 0; i < namn.Count; i++)
//     {
//         if (vikt[i] <= maxVikt)
//         {
//             Console.WriteLine($"{namn[i]} (vikt {vikt[i]})");
//         }
//     }
//     // 6. Skriv vad som är för tungt på ett separat ställe (OM det finns något)
//     bool Tunga = false;
    
//     // Kontrollera först om det finns några tunga föremål
//     for (int i = 0; i < namn.Count; i++)
//     {
//         if (vikt[i] > maxVikt)
//         {
//             Tunga = true;
//             break;
//         }
//     }
    
//     // Skriv bara "För tungt:" om det faktiskt finns tunga föremål
//     if (Tunga)
//     {
//         Console.WriteLine("\nFör tungt:");
//         for (int i = 0; i < namn.Count; i++)
//         {
//             if (vikt[i] > maxVikt)
//             {
//                 Console.WriteLine($"{namn[i]} (vikt {vikt[i]}) för tungt");
//             }
//         }
//     }
//     // 7. Paus 
//     Console.WriteLine("\nTryck valfri tangent för att avsluta...");
//     Console.ReadKey();
// } ------------------------------------------Prov------------------------------------------------

// List<string> xxxx = new List<string> {"alla är gay","Chineska muren","kineser", "kisiska vapen", "Tuge"};
// // -----------------------------------1-------------------------------------------------------------

// for (int i = 0; i < xxxx.Count; i++)
// {
//     Console.WriteLine(xxxx[i]);
// } ------------------------------------2--------------------------------------------------------------

// string[] klasskamrater = { "Allah", "Sara", "ErikPixon", "Annabellamuhhamed", "MohamedProfeted" };
// -------------------------------------3----------------------------------------------------------------

// int[] tal = { 2, 5, 7, 9, 10 };
// List<int> tal = new List<int> { 2, 5, 7, 9, 10 };
// -------------------------------------4----------------------------------------------------------------

// string[] klasskamrater = { "Pelle", "Sara", "Ali", "Emma", "Noah" };
// string[] leksaker = { "Barbie", "Bil", "Lego", "Docka", "Boll" };
// int[] betyg = { 5, 8, 7, 6, 9 };
// for (int i = 0; i < klasskamrater.Length; i++)
// { Console.WriteLine($"{klasskamrater[i]} ger {leksaker[i]} betyget {betyg[i]}"); } 
// Console.ReadKey(); -----------------5-----------------------------------------------------------------

// List<string> cities = new List<string>();
// ---------------------------------------6--------------------------------------------------------------

// List<string> cities = new List<string>();
// while (true)  
// {Console.Write("Skriv en stad eller ''exit'' för att avsluta): ");
//     string input = Console.ReadLine();
//     if (input == "exit")
//     {break;}
//     cities.Add(input); }
// ---------------------------------------7------------------------------------------------------------

// Console.WriteLine("\nStäder som du skrev in:");
//     foreach (string city in cities)
//     {
//     Console.WriteLine(city);
//     } Console.ReadKey();
// -----------------------------------------8------------------------------------------------------------