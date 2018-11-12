using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBusiness.Implementations
{
    class CustomerPersistence
    {
        /*private AplicacionDBContext db = new AplicacionDBContext();

        public IQueryable<Customer> GetCustomer()
        {
            return db.Customer;
        }
        public Customer GetCustomer(int id)
        {
            Customer customer = db.Customer.Find(id);
            if (customer == null)
            {
                return null;
            }

            return customer;
        }

        public String PutCustomer(int id, Customer customer)
        {
            if (id != customer.customerid)
            {
                return "id no encontrado";
            }

            db.Entry(customer).State = EntityState.Modified;
            db.SaveChanges();
            return "modificacion Exitosa";
        }

        public void PostCustomer(Customer customer)
        {
            db.Customer.Add(customer);
            db.SaveChanges();
        }

        public Customer DeleteCustomer(int id)
        {
            Customer customer = db.Customer.Find(id);
            if (customer == null)
            {
                return null;
            }

            customer.deleted = true;
            db.Entry(customer).State = EntityState.Modified;
            //db.Customer.Remove(customer);
            db.SaveChanges();
            return customer;
        }

        private bool CustomerExists(int id)
        {
            return db.Customer.Count(e => e.customerid == id) > 0;
        }*/
    }
}
