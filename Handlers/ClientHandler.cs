using ClientLoanManagementSystemByHulom.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace ClientLoanManagementSystemByHulom.Handlers
{
    [Author]
    [Serializable]
    internal class ClientHandler : IDisposable
    {
        [Required]
        private readonly hulomdbEntities _context;
        private readonly BindingSource _bindingSource;
        private readonly int _op;

        public ClientHandler(BindingSource _bindingSource, int _op = 0)
        {
            _context = new hulomdbEntities();
            this._bindingSource = _bindingSource;
            this._op = _op;
            RefreshBindingSource = _op;
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
                Birthdate = date
            };

            _ = _context.Clients.Add(addClient);
            _context.SaveChanges();

            RefreshBindingSource = _op;
        }

        public void UpdateClient(int _id, int colIndex, object newVal)
        {
            Client selectedClient = _context.Clients.FirstOrDefault(_ => _.ID == _id);

            switch (colIndex)
            {
                case 0:
                    selectedClient.Firstname = (string)newVal;
                    break;
                case 1:
                    selectedClient.Lastname = (string)newVal;
                    break;
                case 2:
                    selectedClient.Residency = (string)newVal;
                    break;
                case 3:
                    selectedClient.Birthdate = (DateTime)newVal;
                    break;
                default:
                    break;
            }

            _context.SaveChanges();
            RefreshBindingSource = _op;
        }

        public void DeleteClient(int _id)
        {
            Client itemToDelete = _context.Clients.FirstOrDefault(_ => _.ID == _id);

            _ = _context.Clients.Remove(itemToDelete);

            _context.SaveChanges();
            RefreshBindingSource = _op;
        }

        public void SearchClient(string text)
        {
            try
            {
                bool isId = int.TryParse(text, out int id);
                bool isBirthDate = DateTime.TryParse(text, out DateTime birthDate);

                var result = Con.Clients
                    .Where(c => (isId && c.ID == id) ||
                                c.Firstname.Contains(text) ||
                                c.Lastname.Contains(text) ||
                                c.Residency.Contains(text) ||
                                (isBirthDate && c.Birthdate == birthDate))
                    .Select(_ => new
                    {
                        _.ID,
                        _.Firstname,
                        _.Lastname,
                        _.Residency,
                        _.Birthdate
                    })
                    .ToList();

                _bindingSource.DataSource = result;
            }
            catch (Exception) { }
        }

        private int RefreshBindingSource
        {
            set
            {
                switch (value)
                {
                    case 1:
                        _bindingSource.DataSource = _context.Clients.OrderBy(_ => _.Firstname).ToList();
                        break;
                    case 2:
                        int[] ids = GetClientIdsSortedByLoanAmount();

                        List<Client> clients = _context.Clients
                            .Where(client => ids.Contains(client.ID))
                            .ToList()
                            .OrderBy(client => Array.IndexOf(ids, client.ID))
                            .ToList();

                        _bindingSource.DataSource = clients;
                        break;
                    default:
                        _bindingSource.DataSource = _context.Clients.ToList();
                        break;
                }
            }
        }

        private int[] GetClientIdsSortedByLoanAmount()
        {
            using (hulomdbEntities _con = new hulomdbEntities())
            {
                IQueryable<int> clientIds = _con.Clients
                    .GroupJoin(_con.Loans,
                        client => client.ID,
                        loan => loan.ClientID,
                        (client, loans) => new
                        {
                            ClientID = client.ID,
                            TotalLoanAmount = loans.Sum(l => (int?)l.LoanAmount)
                        })
                    .OrderByDescending(_ => _.TotalLoanAmount)
                    .Select(_ => _.ClientID);

                return clientIds.ToArray();
            }
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
