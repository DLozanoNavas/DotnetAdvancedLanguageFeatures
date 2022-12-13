// Example file for LinkedIn Learning Course Advanced C#: Language Features by Joe Marini
// Using class indexers

// Create a new sample data set
var stock1 = new StockRecord();

// Access a couple of the properties
Console.WriteLine($"Average: {stock1.Average:C}");
Console.WriteLine($"High: {stock1.High:C}");
Console.WriteLine($"Low: {stock1.Low:C}");

// Use the indexer method
Console.WriteLine($"Days: {stock1.Length}");

for (int i = 0; i < stock1.Length; i++)
{
    Console.WriteLine($"Day {i + 1}: {stock1[i]:C}");
}
Console.WriteLine();

// Index using a different value
Console.WriteLine($"Monday: {stock1["Monday"]:C}");
Console.WriteLine($"Tuesday: {stock1["Tuesday"]:C}");
Console.WriteLine($"Wednesday: {stock1["Wednesday"]:C}");
Console.WriteLine($"Thursday: {stock1["Thursday"]:C}");
Console.WriteLine($"Friday: {stock1["Friday"]:C}");
