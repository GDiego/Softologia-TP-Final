using CapaDataAccess.Context;
using CapaDataAccess.Contracts;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDataAccess.Implementations
{
    public class CustomerRepository : GenericRepository<AplicacionDBContext, Customer>, ICustomerRepository
    {
        public void RemoveCustomer(int idCliente)                       //punto 3
        {
            Customer cliente = Context.Customer.Find(idCliente);
            cliente.deleted = true;
        }
    }
}
