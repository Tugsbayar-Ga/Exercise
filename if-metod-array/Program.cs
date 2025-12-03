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
//     Console.Write("Skriv ett tal: ");
//     int tal = int.Parse(Console.ReadLine());

//     if (tal > 5)
//         Console.WriteLine("högre än 5!");
// } -------for- kontrolerar om det det talet jag skriver är högre än 5-------

// int i = 0;
// while (i < 5)
// {
//     Console.Write("Skriv ett tal: ");
//     string input = Console.ReadLine();
//     int tal = int.Parse(input);
//     if (tal > 5)
//         Console.WriteLine("      högre än 5!"); 
//     else
//         Console.WriteLine(); 
//     i++;
// } samma/=/=//
// while (i < 5)
// {
//     Console.Write("Skriv ett tal: ");
//     int cursorX = Console.CursorLeft;
//     int cursorY = Console.CursorTop;
//     string input = Console.ReadLine();

//     // Testar om det är ett tal
//     if (!int.TryParse(input, out int tal))
//     {
//         Console.WriteLine("  Du måste skriva ett tal!");
//         continue; // hoppa över resten av loopen och börja om
//     }
//     // Flytta tillbaka markören efter det användaren skrev
//     Console.SetCursorPosition(cursorX + input.Length, cursorY);
//     if (tal > 5)
//     Console.Write("   högre än 5!");
//     Console.WriteLine();
//     i++;
// }         ---------------------sjätte--------------------------------------------

// string input;
// while (true){
// Console.Write("Skriv ett heltal: ");
// input = Console.ReadLine(); // Läs in texten från användaren

// // Försök konvertera texten till ett tal
// if (int.TryParse(input, out int number)){
// Console.WriteLine($"Du skrev ett giltigt tal: {number}  hej då!!!!");
// Thread.Sleep(500);
// break; 
// }
// else{
// Console.WriteLine("   Ogiltigt!   Skriv ett heltal.");
// Thread.Sleep(300);
// }}

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
// }} ---------------sjunde----------------------------------------------------------

Random random = new Random();
int taletAttGissa = random.Next(1, 101);
int gissning = 0; //fråga den!!!

Console.WriteLine("Välkommen till 'Gissa siffran'!");
Console.WriteLine("Jag har valt ett tal mellan 1 och 100. Kan du gissa vilket?");

while (gissning != taletAttGissa)
{
    Console.Write("Skriv din gissning: ");
    string input = Console.ReadLine();
    
    if (!int.TryParse(input, out gissning)){
    Console.WriteLine("Det där var inte ett giltigt tal. Försök igen.");
    continue;
    }

if (gissning < taletAttGissa){
    Console.WriteLine("För lågt! Försök igen.");
    }
else if (gissning > taletAttGissa){
    Console.WriteLine("För högt! Försök igen.");
    }
else{
Console.WriteLine("Grattis! Du gissade rätt!");
    }}