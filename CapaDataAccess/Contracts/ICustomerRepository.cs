using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDataAccess.Contracts
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        void RemoveCustomer(int idCliente);
    }
}
