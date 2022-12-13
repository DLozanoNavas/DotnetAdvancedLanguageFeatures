// Example file for LinkedIn Learning Course "Advanced C#: Language Features by Joe Marini"
// C# Pattern Matching programming challenge

// Code to calculate the trade commission
public class CommisionCalculator
{
    private static string CalculateTradeCommission(SecuritiesTrade trade)
    {
        return trade switch
        {
            // A Stock trade of 0 shares should be caught and flagged as invalid
            ( <= 0, _) => throw new ArgumentException("Invalid trade: 0 shares"),
            // A Stock trade that is less than $5,000 is a 0.1% commission
            StockTrade and (_, < 5_000, _) => "0.1%",
            // A Stock trade that is more or equal to $5,000 is a 0.05% commission
            StockTrade and var (_, price, _) when price >= 5_000 => "0.5%",
            // Any stock trade of 1,000 shares or more is a flat fee of $10
            StockTrade and var (quantity, _, _) when quantity >= 1_000 => "$10.0",
            // Any Stock trade of 1,000 shares or more with a value of $10,000 or more is a flat fee of $5
            StockTrade and var (quantity, price, _) when price >= 10_000 && quantity >= 1000 => "$5.0",
            // Any bond trade of 10 years duration is $12
            BondTrade and (_, _, 10, _) => "$12.0",
            // A Bond trade of 5 years duration is $20, or $15 if the total trade value is $10,000 or more
            BondTrade and (_,>= 10_000, 5, _) => "$15.0",
            // A Bond trade of 5 years duration is $20, or $15 if the total trade value is $10,000 or more
            BondTrade and (_, _, 5, _) => "$20.0",
            // A Bond trade of 20 years duration is $10, or $5 if the total value is $5,000 or more
            BondTrade and (_, < 5000, 20, _) => "$10.0",
            // A Bond trade of 20 years duration is $10, or $5 if the total value is $5,000 or more
            BondTrade and (_, >= 5000, 20, _) => "$5.0",
            // A Bond trade of any other duration should be caught and flagged as invalid
            _ => throw new ArgumentException("Invalid Security Trade")
        };

    }

    public static void PrintTradeCommission(SecuritiesTrade trade)
    {
        Console.WriteLine($"{trade} and commission is {CalculateTradeCommission(trade):P}");
    }
}
