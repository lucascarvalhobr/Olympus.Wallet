using System;

namespace Olympus.Wallet.Expense
{
    public sealed class Expense
    {
        public string Description { get; set; }

        public ExpenseTypeEnums Type { get; set; }

        public double Value { get; set; }

        public DateTime Date { get; set; }

        public string Note { get; set; }
    }
}
