using Biblio.Data.Repository;
namespace Biblio.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Libro")]
    public partial class Libro : IIdentifiable
    {
        public long id { get; set; }

        public long Documentid { get; set; }

        public virtual Document Document { get; set; }

        [Required]
        [StringLength(255)]
        public string Literatura { get; set; }
    }
}
