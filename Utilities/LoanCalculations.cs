using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLoanManagementSystemByHulom.Utilities
{
    internal interface LoanCalculations
    {
        double InterestedAmount(double loanAmount, double interest);
        double ReceivableAmount(double loanAmount, double interestedAmount);

        double TotalPayable(double loanAmount, double interestedAmount, double deduction);

        (DateTime Start, DateTime Due) GetDueDate(int numberOfPayments,PaymentTerm frequency);
    }
}
