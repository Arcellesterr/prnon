public class TaxCalculator
{
    public double CalculateProgressiveTax(double income)
    {
        // Example calculation
        double progressiveTax = income * 0.2;  // Replace with actual tax calculation logic

        return progressiveTax;
    }
}

// Example usage
class Program
{
    static void Main()
    {
        TaxCalculator calculator = new TaxCalculator();
        double income = 50000;
        double taxToPay = calculator.CalculateProgressiveTax(income);
        Console.WriteLine($"Progressive tax for income ${income} is ${taxToPay:F2}");
    }
}
