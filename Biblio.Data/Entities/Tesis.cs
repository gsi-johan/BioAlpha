using Biblio.Data.Repository;
namespace Biblio.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tesis : IIdentifiable
    {
        public long id { get; set; }

        [Column("abstract")]
        [StringLength(2147483647)]
        public string _Abstract { get; set; }

        [Required]
        [StringLength(20)]
        public string Category { get; set; }

        [Required]
        [StringLength(2147483647,MinimumLength = 4)]
        public string Description { get; set; }

        public long Documentid { get; set; }

        public virtual Document Document { get; set; }

        public override string ToString()
        {
            return Category;
        }
    }
}
