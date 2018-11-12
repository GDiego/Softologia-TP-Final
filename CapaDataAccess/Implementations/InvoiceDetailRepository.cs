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
    public class InvoiceDetailRepository : GenericRepository<AplicacionDBContext, InvoiceDetail>, IInvoiceDetailRepository
    {
        public List<InvoiceDetail> findInvoiceDetails(int idInvoice)
        {
            List<InvoiceDetail> detailsOneProduct = new List<InvoiceDetail>(); ;
            foreach (var group in Context.InvoiceDetail)
            {
                if (idInvoice==group.invoiceid)
                {
                    detailsOneProduct.Add(group);
                }
            }
            return detailsOneProduct;
        }
    }
}