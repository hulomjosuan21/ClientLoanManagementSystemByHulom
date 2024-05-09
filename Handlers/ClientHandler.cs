using ClientLoanManagementSystemByHulom.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLoanManagementSystemByHulom.Handlers
{
    internal class ClientHandler
    {
        private readonly hulomdbEntities _context;
        private readonly BindingSource _bindingSource;
        public ClientHandler(BindingSource _bindingSource)
        {
            _context = new hulomdbEntities();
            this._bindingSource = _bindingSource;

            _bindingSource.DataSource = _context.Clients.ToList();
        }
    }
}
