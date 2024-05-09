using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLoanManagementSystemByHulom.Utilities
{
    public enum LoanStatus
    {
        Pending, //wla pa ge allow sa lender
        Approved, // na allow na sa lender
        Rejected, // ge declined sa lender.
        Active, // na hatag sa borrower
        Repayment, // nag sugod nag bayad ang borrower
        Paid, // nabayadan na sa borrower ang tanan
        Defaulted, // wala pa na baydan na ni lapas nag due date or any nga agreed terms
        Closed // nahutdan nag bayad
    }
}
