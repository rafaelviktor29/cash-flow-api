using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Repositories.Expenses;

public interface IExpensesReadOnlyRepository // To Do: terminar essa porra
{
    Task<List<Expense>> GetAll();
    Task<Expense?> GetById(long id);
}
