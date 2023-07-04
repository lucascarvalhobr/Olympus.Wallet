using System.Threading.Tasks;

namespace Olympus.Wallet.Expense.Interfaces
{
    public interface IExpenseRepository
    {
        Task<bool> AddAsync();

        Task<bool> DeleteAsync();

        Task<bool> UpdateAsync();

        Task<bool> GetAsync();
    }
}
