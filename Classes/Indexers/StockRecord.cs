// Example file for LinkedIn Learning Course Advanced C#: Language Features by Joe Marini

// StockRecord is a sample class that returns information about
// a week's worth of stock information - closing prices, etc.
public class StockRecord {
    public string Symbol {
        get => "ABCD";
    }

    private decimal[] prices = new decimal[] {
        105.1m, 103.12m, 106.93m, 104.5m, 103.7m
    };

    // Define some public properties
    public decimal Average {
        get => prices.Sum() / prices.Length;
    }
    public decimal High {
        get => prices.Max();
    }
    public decimal Low {
        get => prices.Min();
    }

    // implement Length property 
    public int Length  => prices.Length;

    // implement this[] to enable indexing
    public decimal this[int index]
    {
        get => prices[index];
    }

    // You can overload the indexer to provide another way to access
    public decimal this[string day]
    {
        get
        {
            return day switch
            {
                "Monday" => prices[0],
                "Tuesday" => prices[1],
                "Wednesday" => prices[2],
                "Thursday" => prices[3],
                "Friday" => prices[4],
                _ => throw new ArgumentException("Invalid day")
            };
        }
    }
}
