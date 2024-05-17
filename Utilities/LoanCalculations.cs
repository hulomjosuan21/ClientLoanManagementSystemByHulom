using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLoanManagementSystemByHulom.Utilities
{
    internal interface LoanCalculations
    {
        decimal InterestedAmount(decimal loanAmount, decimal interest);
        decimal ReceivableAmount(decimal loanAmount, decimal interestedAmount);
        decimal TotalPayable(decimal loanAmount, decimal interestedAmount, decimal deduction);
        (DateTime Start, DateTime Due) GetDueDate(int numberOfPayments,PaymentTerm frequency);
    }
}
