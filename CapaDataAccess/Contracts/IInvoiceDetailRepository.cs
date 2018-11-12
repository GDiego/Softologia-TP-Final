using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDataAccess.Contracts
{
    public interface IInvoiceDetailRepository : IGenericRepository<InvoiceDetail>
    {
        List<InvoiceDetail> findInvoiceDetails(int idInvoice);
    }
}
