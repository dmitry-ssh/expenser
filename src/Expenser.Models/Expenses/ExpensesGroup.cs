namespace Expenser.Models.Expenses
{
    public class ExpensesGroup
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
        public string Name { get; set; } = "---";
        public List<ExpenseEntry> Expenses { get; set; } = new List<ExpenseEntry>();
    }
}
