namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int productid { get; set; }

        [Required]
        public string name { get; set; }

        public decimal price { get; set; }

        public int stock { get; set; }

        public bool deleted { get; set; }

        //public ICollection<InvoiceDetail> Vendidos;// = new List<InvoiceDetail>(); 
    }
}
