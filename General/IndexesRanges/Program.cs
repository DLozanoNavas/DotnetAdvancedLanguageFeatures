// Example file for LinkedIn Learning Course Advanced C#: Language Features by Joe Marini
// Indexes and Ranges example

// Define a sample array 
string[] words = new string[]
{
    "Zero","One","Two","Three","Four", "Five","Six","Seven","Eight","Nine"
};

// The index operator provides access to array elements
Console.WriteLine(words[1]);

// The index-from-end operator indexes from the end of a sequence
// (Note that the end is not zero-based, ^1 is the last item)
Console.WriteLine(words[^1]); 

// The range operator (..) defines a range
string[] range = words[2..5];
Console.WriteLine(string.Join(",", range));

// Indexes and ranges can be variables too
Index idx = ^4;
Console.WriteLine(words[idx]);

Range rng = 1..^4;
Console.WriteLine(string.Join(",", words[rng]));