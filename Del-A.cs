//innehåller namn och listor
List<string> names = new List<string>();
List<int> prices = new List<int>();


// frågar användaren att plocka en vara och skriva pris
Console.Write("Skriv en vara: " );
string name = Console.ReadLine()!;

Console.Write ("Skriv priset: ");
string priceInput = Console.ReadLine()!;

// priset är ett heltal
if (int.TryParse(priceInput, out int price))
{
    names.Add(name);
    prices.Add(price);

}
else
{
    Console.WriteLine("Priset måste vara ett heltal");
}

int total = 0;

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"{i + 1}. {names[i]} - {prices[i]} kr");
    total += prices[i];
}

Console.WriteLine($"Totalt: {total} kr");
