namespace Expenser.Models.Expenses;

public class ExpenseEntry
{
    public decimal Amount { get; set; }
    public DateTimeOffset Moment { get; set; }
}