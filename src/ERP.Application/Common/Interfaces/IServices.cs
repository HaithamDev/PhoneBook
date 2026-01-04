using System.Collections.Generic;
using System.Threading.Tasks;
using ERP.Domain.Entities;

namespace ERP.Application.Common.Interfaces
{
    public interface IAuthenticationService
    {
        Task<string> AuthenticateAsync(string username, string password);
    }

    public interface IEncryptionService
    {
        string Encrypt(string plainText);
        string Decrypt(string cipherText);
    }
    
    public interface ICurrentUserService
    {
        string? UserId { get; }
    }

    public interface IEmployeeService
    {
        Task<IReadOnlyList<Employee>> GetAllAsync();
        Task<Employee?> GetByIdAsync(int id);
        Task<Employee> CreateAsync(Employee employee);
        Task UpdateAsync(Employee employee);
        Task DeleteAsync(int id);
    }

    public interface IFinanceService
    {
        Task CreateJournalEntryAsync(JournalEntry entry);
        Task<IReadOnlyList<Account>> GetAccountsAsync();
    }
}
