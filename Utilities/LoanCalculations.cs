using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLoanManagementSystemByHulom.Utilities
{
    internal interface LoanCalculations
    {
        double InterestedAmount(double LoanAmount, double Interest);
        double ReceivableAmount(double LoanAmount, double Interest);

        double TotalPayable(double LoanAmount, double InterestedAmount, double Deduction);

        (DateTime Start, DateTime Due) GetDueDate(int numberOfPayments, DateTime loanStartDate, PaymentTerm frequency);
    }
}
