// Example file for LinkedIn Learning Course Advanced C#: Language Features by Joe Marini
// The null coalescing operator

// A common scenario is to test a value for null and assign one if it is
void OldSchoolLogString(string theString)
{
    switch (theString)
    {
        case null:
            Console.WriteLine("No string given!");
            break;
        default:
            Console.WriteLine(theString);
            break;
    }
}

OldSchoolLogString("Test String");
OldSchoolLogString(null);

// The ?? operator returns the left-hand value if not null, or the right one if it is null
void LogString(string? theString)
{
    Console.WriteLine(theString ?? "No string given!");
}
LogString("Test String");
LogString(null);

// The ??= assigns a value if the left-hand value is null
void AssignableLogString(string? theString)
{
    theString ??= "No string given!";
    Console.WriteLine(theString);
}
AssignableLogString("Test String");
AssignableLogString(null);


// It's also allowable to throw an exception as part of the right-hand expression
void ThrowableLogString(string? theString)
{
    Console.WriteLine(theString ?? throw new ArgumentNullException(nameof(theString)));
}
ThrowableLogString("Test String");
ThrowableLogString(null);