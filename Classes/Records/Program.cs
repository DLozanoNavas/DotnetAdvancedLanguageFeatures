// Example file for LinkedIn Learning Course Advanced C#: Language Features by Joe Marini
// Using records 

// Instantiate some records
var dt1 = new DayTemperature(29.6m, 20.2m);
var dt2 = new DayTemperature(30m, 18.2m);
var dt3 = new DayTemperature(30m, 18.2m);

// Records get built-in formatting for output
Console.WriteLine(dt1);

// Records have built-in value equality testing
Console.WriteLine($"{dt1 == dt2}");
Console.WriteLine($"{dt2 == dt3}");

// Like with classes, you can add other methods and properties
Console.WriteLine($"{dt1.Average}");

// Records are immutable by default - you can make them mutable but they are 
// really intended for immutable data types
//dt1.High = 32.0m;

// We can use the "with" statment for non-destructive mutation
var dt4 = dt1 with { High = 32.0m };
Console.WriteLine(dt4);

// Records can be defined very simply
public record DayTemperature(decimal High, decimal Low)
{
    public decimal Average => (High + Low) / 2;
}