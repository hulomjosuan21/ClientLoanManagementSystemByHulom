using ClientLoanManagementSystemByHulom.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLoanManagementSystemByHulom.Handlers
{
    internal class RecordHandler
    {
        public static (int _Clients, int _Loans) GetTotal()
        {
            using (hulomdbEntities _context = new hulomdbEntities())
            {
                return (_Clients: _context.Clients.Count(),_Loans: _context.Loans.Count());
            }
        }
    }
}
