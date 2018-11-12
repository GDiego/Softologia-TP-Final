using CapaDataAccess.Context;
using CapaDataAccess.Contracts;
using CapaDataAccess.Implementations;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBusiness
{
    public class InvoiceBusiness //: IInvoiceDetailRepository
    {
        public bool stockDisponible(Product product, InvoiceDetail invoiceDetail)
        {
            if (invoiceDetail.Quantity <= product.stock)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool productoDisponible(Product product)       //FALTA  VERIFICAR
        {
            if (!product.deleted)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool clienteDisponible(Customer customer)
        {
            if(!customer.deleted)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal calcularTotal(int idfactura)
        {
            InvoiceDetailRepository invoiceDetailRepository = new InvoiceDetailRepository();
            IInvoiceDetailRepository prueba = new InvoiceDetailRepository();
            decimal total=0;
            foreach (InvoiceDetail group in prueba.findInvoiceDetails(idfactura))
            {
                total = total +  calcularSubtotal(group);
            }
            return total;
        }

        public decimal calcularSubtotal(InvoiceDetail detalle)
        {
            IGenericRepository<Product> genericRepository = new GenericRepository<AplicacionDBContext, Product>();
            decimal precio = genericRepository.Get(detalle.productid).price;
            decimal subtotal = detalle.Quantity * precio;
            return subtotal;
        }
    }
}
