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
    public class ProductRepository : GenericRepository<AplicacionDBContext,Product>, IProductRepository
    {
        public void RemoveProduct(int idProducto)                  //METODO "REMOVER" PRODUCTO
        {
            Product producto = Context.Product.Find(idProducto);
            producto.deleted = true;
        }

        public List<Product> GetSelling()                            //METODO GETSELLING
        {
            var result = Context.InvoiceDetail.GroupBy(o => o.productid)
                   .Select(g => new { productid = g.Key, total = g.Sum(i => i.Quantity) })
                   .OrderByDescending(u => u.total).Take(2);

            List<Product> productstop = new List<Product>();

            foreach (var group in result)
            {
                productstop.Add(Context.Product.Find(group.productid));
            }
            return productstop;
        }

        public Product Search(string username)                               //METODO SEARCH
        {
            Product product = Context.Product.FirstOrDefault(acc => acc.name == username);
            if (product == null)
            {
                return null;
            }

            if ((product.stock > 0) && (product.deleted == false))
            {
                return product;
            }
            else
            {
                return null;
            }
        }
    }
}
