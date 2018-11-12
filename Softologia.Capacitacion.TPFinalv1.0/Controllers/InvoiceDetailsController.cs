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
    public class InvoiceDetailsController : ApiController
    {
        /*private AplicacionDBContext db = new AplicacionDBContext();

        // GET: api/InvoiceDetails
        public IQueryable<InvoiceDetail> GetInvoiceDetail()
        {
            return db.InvoiceDetail;
        }

        // GET: api/InvoiceDetails/5
        [ResponseType(typeof(InvoiceDetail))]
        public IHttpActionResult GetInvoiceDetail(int id)
        {
            InvoiceDetail invoiceDetail = db.InvoiceDetail.Find(id);
            if (invoiceDetail == null)
            {
                return NotFound();
            }

            return Ok(invoiceDetail);
        }

        // PUT: api/InvoiceDetails/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutInvoiceDetail(int id, InvoiceDetail invoiceDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != invoiceDetail.invoiceid)
            {
                return BadRequest();
            }

            db.Entry(invoiceDetail).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoiceDetailExists(id))
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

        // POST: api/InvoiceDetails
        [ResponseType(typeof(InvoiceDetail))]
        public IHttpActionResult PostInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InvoiceDetail.Add(invoiceDetail);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (InvoiceDetailExists(invoiceDetail.invoiceid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = invoiceDetail.invoiceid }, invoiceDetail);
        }

        // DELETE: api/InvoiceDetails/5
        [ResponseType(typeof(InvoiceDetail))]
        public IHttpActionResult DeleteInvoiceDetail(int id)
        {
            InvoiceDetail invoiceDetail = db.InvoiceDetail.Find(id);
            if (invoiceDetail == null)
            {
                return NotFound();
            }

            db.InvoiceDetail.Remove(invoiceDetail);
            db.SaveChanges();

            return Ok(invoiceDetail);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InvoiceDetailExists(int id)
        {
            return db.InvoiceDetail.Count(e => e.invoiceid == id) > 0;
        }*/
    }
}