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
                Birthdate = date
            };

            _ = _context.Clients.Add(addClient);
            _context.SaveChanges();

            _bindingSource.DataSource = Con.Clients.ToList();
        }

        public void UpdateClient(int _id, int colIndex, object newVal)
        {
            Client selectedClient = _context.Clients.FirstOrDefault(q => q.ID == _id);

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
            _bindingSource.DataSource = Con.Clients.ToList();
        }

        public void DeleteClient(int _id)
        {
            Client itemToDelete = _context.Clients.Where(q => q.ID == _id).FirstOrDefault();

            _ = _context.Clients.Remove(itemToDelete);

            _context.SaveChanges();
            _bindingSource.DataSource = Con.Clients.ToList();
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
                    .Select(c => new
                    {
                        c.ID,
                        c.Firstname,
                        c.Lastname,
                        c.Residency,
                        c.Birthdate
                    })
                    .ToList();

                _bindingSource.DataSource = result;
            }
            catch (Exception) { }
        }
    }
}
