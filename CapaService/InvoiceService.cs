using CapaBusiness;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaService
{
    public class InvoiceService
    {
        InvoiceBusiness invoiceBusiness = new InvoiceBusiness();
        public void facturacion(Product product,Customer customer, InvoiceDetail invoiceDetail, int idFactura)
        {
            if (invoiceBusiness.stockDisponible(product, invoiceDetail))
            {
                if(invoiceBusiness.productoDisponible(product))
                {
                    if(invoiceBusiness.clienteDisponible(customer))
                    {
                        decimal total = invoiceBusiness.calcularTotal(idFactura);
                    }
                    else
                    {
                        //cliente no disponible
                    }
                }
                else
                {
                    //producto no disponible
                }
            }
            else
            {
                //stock no disponible
            }
        }
    }
}
