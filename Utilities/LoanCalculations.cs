using System;

namespace ClientLoanManagementSystemByHulom.Utilities
{
    [Author]
    internal interface LoanCalculations
    {
        decimal InterestedAmount(decimal loanAmount, decimal interest);
        decimal ReceivableAmount(decimal loanAmount, decimal interestedAmount);
        decimal TotalPayable(decimal loanAmount, decimal interestedAmount, decimal deduction);
        (DateTime Start, DateTime Due) GetDueDate(int numberOfPayments,PaymentTerm frequency);
    }
}
