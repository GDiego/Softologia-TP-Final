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
    public class InvoiceRepository : GenericRepository<AplicacionDBContext,Invoice>,IInvoiceRepository
    {

    }
}
