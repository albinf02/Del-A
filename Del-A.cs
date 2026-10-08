//innehåller namn och listor
List<string> names = new List<string>();
List<int> prices = new List<int>();

while (true)
{
    int total = 0;

    for (int i = 0; i < names.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {names[i]} - {prices[i]} kr");
        total += prices[i];
    }

    Console.WriteLine($"Totalt: {total} kr");


    Console.Write("Skriv en vara eller numret på en vara att ta bort: ");
    string input = Console.ReadLine()!;
    if (int.TryParse(input, out int number))
    {
        int index = number - 1;

        if (index >= 0 && index < names.Count)
        {
            names.RemoveAt(index);
            prices.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Det numret finns inte i listan.");
        }
        continue;


    }

    Console.Write("Skriv priset: ");
    string priceInput = Console.ReadLine()!;

    // priset är ett heltal
    if (int.TryParse(priceInput, out int price))
    {
        names.Add(input);
        prices.Add(price);

    }
    else
    {
        Console.WriteLine("Priset måste vara ett heltal");
    }


}
