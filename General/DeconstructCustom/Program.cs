// Example file for LinkedIn Learning Course "Advanced C#: Language Features by Joe Marini"
// Using Deconstruction on a custom defined type

// Create some classes with data
var earth = new Planet("Earth", 6371, 1, 150_980_000);
var venus = new Planet("Venus", 6052, 0, 108_930_000);

// Use Deconstruction to get the name and moon count
var (name, moons) = earth;
Console.WriteLine($"{name} has {moons} moons");

// Use Deconstruction to get the name, moon count, and radius
var (name2, moons2, radius2) = venus;
Console.WriteLine($"{name2} has {moons2} moons and a radius of {radius2} km");
