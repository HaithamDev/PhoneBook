using ERP.Application.Common.Interfaces;
using ERP.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.Infrastructure.Services
{
    public class FinanceService : IFinanceService
    {
        private readonly IRepository<JournalEntry> _journalEntryRepository;
        private readonly IRepository<Account> _accountRepository;
        private readonly IUnitOfWork _unitOfWork;

        public FinanceService(
            IRepository<JournalEntry> journalEntryRepository,
            IRepository<Account> accountRepository,
            IUnitOfWork unitOfWork)
        {
            _journalEntryRepository = journalEntryRepository;
            _accountRepository = accountRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateJournalEntryAsync(JournalEntry entry)
        {
            await _journalEntryRepository.AddAsync(entry);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Account>> GetAccountsAsync()
        {
            return await _accountRepository.GetAllAsync();
        }
    }
}
