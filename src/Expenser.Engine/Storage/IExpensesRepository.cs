using Expenser.Models.Expenses;

namespace Expenser.Engine.Storage;

public interface IExpensesRepository
{
    List<ExpensesGroup> GetExpenses();
}