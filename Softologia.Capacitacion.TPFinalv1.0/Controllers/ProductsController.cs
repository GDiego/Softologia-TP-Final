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
    public class ProductsController : ApiController
    {
        /*private AplicacionDBContext db = new AplicacionDBContext();

        // GET: api/Products
        public IQueryable<Product> GetProduct()
        {
            return db.Product;
        }

        // GET: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProduct(int id)
        {
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // GET: api/Products/nombre de producto                     METODO SEARCH
        [HttpGet]
        [Route("api/prueba/hola/{username}")]
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProduct(string username)
        //public string GetProduct(string username)
        {
            Product product = db.Product.FirstOrDefault(acc => acc.name == username);
            if (product == null)
            {
                return NotFound();
                //return "producto nulo";
            }

            if ((product.stock > 0) && (product.deleted == false))
            {
                return Ok(product);
                //return "producto  encontrado";
            }
            else
            {
                return NotFound();
                //return "producto mayor  a 0 o borrado en true";
            }
        }

        // GET: api/Products                                      METODO GETSELLING
        public List<Product> GetSelling()
        {
            var result = db.InvoiceDetail.GroupBy(o => o.productid)
                   .Select(g => new { productid = g.Key, total = g.Sum(i => i.Quantity) })
                   .OrderByDescending(u => u.total).Take(2);

            //var top = result.OrderByDescending(u => u.total).Take(2);
            //result.ToList<>;
            List<Product> productstop = new List<Product>();
            //var products;
            foreach (var group in result top)
            {
                productstop.Add(db.Product.Find(group.productid)); 
                //Console.WriteLine("producto = {0} vendidos={1}", group.productid, group.total);
            }
            return productstop;
            
            {
                return null;
            }
            //var total = result.ToList();
            //return total;
            //return db.Product.OrderByDescending(u => u.Vendidos.Count).Take(2);
            //var metarializedItems = items.ToList();
            //return (items.ToList());
            //return metarializedItems;
        }

        // PUT: api/Products/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProduct(int id, Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product.productid)
            {
                return BadRequest();
            }

            db.Entry(product).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
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

        // POST: api/Products
        [ResponseType(typeof(Product))]
        public IHttpActionResult PostProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Product.Add(product);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ProductExists(product.productid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = product.productid }, product);
        }

        // DELETE: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult DeleteProduct(int id)
        {
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            product.deleted = true;
            db.Entry(product).State = EntityState.Modified;
            //db.Product.Remove(product);
            db.SaveChanges();

            return Ok(product);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductExists(int id)
        {
            return db.Product.Count(e => e.productid == id) > 0;
        }*/
    }
}