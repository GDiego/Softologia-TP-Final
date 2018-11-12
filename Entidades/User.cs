namespace Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int userid { get; set; }

        [Required]
        [StringLength(64)]
        public string username { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        [StringLength(16)]
        public string rol { get; set; }
    }
}
