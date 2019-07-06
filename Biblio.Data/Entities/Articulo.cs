using Biblio.Data.Repository;

namespace Biblio.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Articulo")]
    public partial class Articulo:IIdentifiable
    {
        private long _id;
        public long id { get; set; }

        [Column("abstract")]
      
        [StringLength(2147483647)]
        public string _abstract { get; set; }

        [Required]
        [StringLength(255)]
        public string Literatura { get; set; }

        [StringLength(255)]
        public string event_localitation { get; set; }

        public long Documentid { get; set; }

        public virtual Document Document { get; set; }

    }
}
