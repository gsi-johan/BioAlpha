using System.Linq;
using Biblio.Data.Repository;
namespace Biblio.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Document")]
    public partial class Document : IIdentifiable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Document()
        {
            Articulo = new HashSet<Articulo>();
            Libro = new HashSet<Libro>();
            Tesis = new HashSet<Tesis>();
            Autor = new HashSet<Autor>();
            Key_Words = new HashSet<Key_Words>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(255)]
        public string tittle { get; set; }

        public int year { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string url_pdf { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Articulo> Articulo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Libro> Libro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tesis> Tesis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autor> Autor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Key_Words> Key_Words { get; set; }

        public string TesisToString()
        {
            string result = "";
            foreach (var t in Tesis)
              result+=t.ToString();
            return result;
        }
    }
}
