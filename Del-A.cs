List<string> names = new List<string>();
List<int> prices = new List<int>();
//innehåller namn och listor

names.Add("Ost");
prices.Add(89);

int total = 0;

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"{i + 1}. {names[i]} - {prices[i]} kr");
    total += prices[i];
}

Console.WriteLine($"Totalt: {total} kr");


// frågar användaren att plocka en vara
Console.Write("Skriv en vara: " );
string name = Console.ReadLine()!;

