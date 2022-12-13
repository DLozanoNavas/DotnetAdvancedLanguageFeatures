// Example file for LinkedIn Learning Course "Advanced C#: Language Features by Joe Marini"
// Using Positional and Tuple Patterns in Pattern Matching

decimal GetGroupTicketPriceDiscount(int groupSize, DateTime visitDate)
    => (groupSize, visitDate.DayOfWeek) switch
{
    // use the position of each value as an individual pattern expression
    (_ , DayOfWeek.Saturday or DayOfWeek.Sunday) => 0.0m,
    (>= 5 and < 10, DayOfWeek.Monday) => 0.1m,
    (>= 5 and < 10, DayOfWeek.Tuesday) => 0.2m,
    (>= 5 and < 10, DayOfWeek.Wednesday) => 0.3m,
    (>= 5 and < 10, DayOfWeek.Thursday) => 0.4m,
    (>= 5 and < 10, DayOfWeek.Friday) => 0.5m,
    (>= 10, DayOfWeek.Monday) => 0.2m,
    (>= 10, DayOfWeek.Tuesday) => 0.3m,
    (>= 10, DayOfWeek.Wednesday) => 0.4m,
    (>= 10, DayOfWeek.Thursday) => 0.5m,
    (>= 10, DayOfWeek.Friday) => 0.6m,
    (<= 0 , _ ) => throw new ArgumentException("Group size must be greater than zero"),
    _ => 0.0m,
};

// Declare some test data to use with the example
(int, DateTime)[] TestDiscountData = new[] {
    (4, new DateTime(2022, 9, 3)),
    (7, new DateTime(2023, 2, 6)),
    (20, new DateTime(2023, 4, 17)),
    (15, new DateTime(2023, 8, 8)),
    (9, new DateTime(2023, 8, 9)),
};

// Iterate over each of the test data items and evaluate the discount
foreach (var (groupSize, visitDate) in TestDiscountData)
{
        Console.WriteLine($"Discount for group of {groupSize} at {visitDate:ddd MM d}: ${GetGroupTicketPriceDiscount(groupSize, visitDate):0.00}");
}

// TODO: Use the implicit Deconstruct call to switch on the different values of a class
string Classify(Point point) => point switch
{
    (>0, >0) => "Upper Right Cuadrant",
    (<0, >0) => "Upper Left Cuadrant",
    (<0, <0) => "Lower Left Cuadrant",
    (>0, <0) => "Lower Right Cuadrant",
};
// Declare some test data to use with the point example
Point[] TestPointData = new[] {
    new Point(5, 8),
    new Point(-2, 7),
    new Point(1, -1),
    new Point(-2, -2),
};

foreach (Point p in TestPointData)
{
    Console.WriteLine($"Point is {Classify(p)}");
}

// Define a type that implements the Deconstruct method to return a tuple
public readonly struct Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y) => (X, Y) = (x, y);

    public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
}
