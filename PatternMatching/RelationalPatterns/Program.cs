// Example file for LinkedIn Learning Course "Advanced C#: Language Features by Joe Marini"
// Using Relational Patterns in Pattern Matching

// Relational patterns can be used to compare constant values using logical comparison
// operators such as <, >, <=, and >=

// Example: Given a Date, determine which quarter it occurs in 
string GetQuarterFromDate(DateTime date) => date.Month switch
{
    // Categorize the date into a quarter
    >=1 and <= 3 => "Q1",
    >=4 and <= 6 => "Q2",
    >=7 and <= 9 => "Q3",
    >=10 and <= 12 => "Q4",
    _ => throw new ArgumentOutOfRangeException(nameof(date), $"Unexpected month given: {date.Month}."),
};

Console.WriteLine(GetQuarterFromDate(new DateTime(2022, 2, 14)));
Console.WriteLine(GetQuarterFromDate(new DateTime(2022, 7, 19)));
Console.WriteLine(GetQuarterFromDate(new DateTime(2022, 12, 25)));
Console.WriteLine(GetQuarterFromDate(new DateTime(2022, 4, 1)));

void FirstOrSecondHalf(object dt)
{
    switch (dt)
    {
        // Categorize the date into a half
        case DateTime { Month: >= 1 and <= 6 }:
            Console.WriteLine("First half of the year");
            break;
        case DateTime { Month: >= 7 and <= 12 }:
            Console.WriteLine("Second half of the year");
            break;
        default:
            Console.WriteLine("Not a date");
            break;
    }
}

FirstOrSecondHalf(new DateTime(2022, 7, 28));
FirstOrSecondHalf(new DateTime(2022, 4, 1));

// This also works with the regular "is" statement
void FirstOrSecondHalf2(object dt)
{
    if (dt is DateTime { Month: >= 1 and <= 6 })
        Console.WriteLine("First half of the year");
    else if (dt is DateTime { Month: >= 7 and <= 12 })
        Console.WriteLine("Second half of the year");
    else
        Console.WriteLine("Not a date");
}


FirstOrSecondHalf2(new DateTime(2022, 7, 28));
FirstOrSecondHalf2(new DateTime(2022, 4, 1));
