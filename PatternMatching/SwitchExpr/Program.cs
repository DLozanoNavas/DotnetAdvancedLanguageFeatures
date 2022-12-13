// Example file for LinkedIn Learning Course "Advanced C#: Language Features by Joe Marini"
// C# Pattern Matching using enhanced switch expressions

// switch statements are very common in C#:
string NumToString(int num)
{
    return num switch
    {
        1 => "One",
        2 => "Two",
        3 => "Three",
        _ => "Unknown"
    };
}
Console.WriteLine(NumToString(2));
Console.WriteLine(NumToString(4));

// TODO: Beginning with C# 7 and enhanced in C# 8, switch statements 
// can now operate on just about any type
string ShapeToString(object shape)
{
    switch (shape)
    {
        case Circle: 
            return "Circle";
        case Rectangle: return "Rectangle";
        case Triangle: return "Triangle";
        default:
            return "Unknown";
    }

};


Console.WriteLine(ShapeToString(new Circle { Radius = 10 }));
Console.WriteLine(ShapeToString(new Triangle { Base = 10, Height = 5 }));
Console.WriteLine(ShapeToString(new Rectangle { Length = 10, Width = 10 }));

// This can be made a little more concise with the switch expression, starting in C# 8
string ShapeToString2(object shape) => shape switch
{
    Circle {Radius:> 10} => "Big Circle",
    Circle {Radius:<= 10} => "Small Circle",
    Rectangle {Length: var l , Width: var w} when l == w => "Rectangle",
    Triangle => "Triangle",
    _ => "Unknown"
};

Console.WriteLine(ShapeToString2(new Circle { Radius = 20 }));
Console.WriteLine(ShapeToString2(new Circle { Radius = 10 }));
Console.WriteLine(ShapeToString2(new Rectangle { Length = 10, Width = 10 }));
Console.WriteLine(ShapeToString2(new Rectangle { Length = 5, Width = 10 }));
