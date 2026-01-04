using ERP.Domain.Common;
using System;
using System.Collections.Generic;

namespace ERP.Domain.Entities
{
    public class Account : BaseEntity
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty; // Asset, Liability, Equity, Revenue, Expense
    }

    public class JournalEntry : BaseEntity
    {
        public DateTime EntryDate { get; set; }
        public string Description { get; set; } = string.Empty;
        public string ReferenceNumber { get; set; } = string.Empty;
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }

    public class Transaction : BaseEntity
    {
        public int JournalEntryId { get; set; }
        public JournalEntry JournalEntry { get; set; } = null!;
        public int AccountId { get; set; }
        public Account Account { get; set; } = null!;
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
    }
}
