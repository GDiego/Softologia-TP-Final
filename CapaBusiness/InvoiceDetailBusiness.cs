using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaBusiness
{
    public class InvoiceDetailBusiness
    {
        public bool validarQuantity(InvoiceDetail invoiceDetail)
        {
            if(invoiceDetail.Quantity>0)
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
