using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Softologia.Capacitacion.TPFinalv1._0.Models;

namespace Softologia.Capacitacion.TPFinalv1._0.Models
{
    public class InvoicesController : ApiController
    {
        /*private AplicacionDBContext db = new AplicacionDBContext();

        // GET: api/Invoices
        public IQueryable<Invoice> GetInvoice()
        {
            return db.Invoice;
        }

        // GET: api/Invoices/5
        [ResponseType(typeof(Invoice))]
        public IHttpActionResult GetInvoice(int id)
        {
            Invoice invoice = db.Invoice.Find(id);
            if (invoice == null)
            {
                return NotFound();
            }

            return Ok(invoice);
        }

        // PUT: api/Invoices/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutInvoice(int id, Invoice invoice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != invoice.Invoiceid)
            {
                return BadRequest();
            }

            db.Entry(invoice).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoiceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Invoices
        [ResponseType(typeof(Invoice))]
        public IHttpActionResult PostInvoice(Invoice invoice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Invoice.Add(invoice);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (InvoiceExists(invoice.Invoiceid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = invoice.Invoiceid }, invoice);
        }

        // DELETE: api/Invoices/5
        [ResponseType(typeof(Invoice))]
        public IHttpActionResult DeleteInvoice(int id)
        {
            Invoice invoice = db.Invoice.Find(id);
            if (invoice == null)
            {
                return NotFound();
            }

            db.Invoice.Remove(invoice);
            db.SaveChanges();

            return Ok(invoice);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InvoiceExists(int id)
        {
            return db.Invoice.Count(e => e.Invoiceid == id) > 0;
        }*/
    }
}