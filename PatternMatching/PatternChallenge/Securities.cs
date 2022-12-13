// Example file for LinkedIn Learning Course "Advanced C#: Language Features by Joe Marini"
// C# Pattern Matching programming challenge

public class SecuritiesTrade {
    public int Quantity;
    public decimal Price;

    public void Deconstruct(out int quantity, out decimal price) {
        quantity = Quantity;
        price = Price;
    }

    
}

public class StockTrade : SecuritiesTrade {
    public string? Symbol;
    public override string ToString()
    {
        return $"{Symbol} is a stock trade and it's price is {Price} for {Quantity} shares";
    }

    public void Deconstruct(out int quantity, out decimal price, out string? symbol) 
    {
        price = Price;
        symbol = Symbol;
        quantity = Quantity;
    }
}

public class BondTrade : SecuritiesTrade {
    public string? Name;
    public int Duration;
    public override string ToString()
    {
        return $"{Name} is a bond trade, it's price is {Price} for {Quantity} and duration is {Duration} years";
    }
    public void Deconstruct(out int quantity, out decimal price, out int duration, out string name) 
    {
        name = Name;
        price = Price;
        quantity = Quantity;
        duration = Duration;
    }

}
