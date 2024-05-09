using ClientLoanManagementSystemByHulom.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        public static hulomdbEntities Con
        {
            get => new hulomdbEntities();
        }

        public void AddClient(string firstname, string lastname, string residency, DateTime date)
        {
            Client addClient = new Client
            {
                Firstname = firstname,
                Lastname = lastname,
                Residency = residency,
                Birthday = date
            };

            _ = _context.Clients.Add(addClient);
            _context.SaveChanges();

            _bindingSource.DataSource = Con.Clients.ToList();
        }
    }
}
