using CapaDataAccess.Context;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDataAccess.Contracts
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        void RemoveProduct(int idProducto);
        List<Product> GetSelling();
        Product Search(string username);
    }
}
