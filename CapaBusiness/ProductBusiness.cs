using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBusiness
{
    public class ProductBusiness
    {
        public bool validarPrecioyStock(Product product)
        {
            if((product.price>0)&&(product.stock>0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
