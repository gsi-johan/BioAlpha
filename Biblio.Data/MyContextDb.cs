namespace Biblio.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyContextDb : DbContext
    {
        public MyContextDb()
            : base("name=biblio_db_extend")
        {
        }

        public virtual DbSet<Articulo> Articulo { get; set; }
        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<Key_Words> Key_Words { get; set; }
        public virtual DbSet<Libro> Libro { get; set; }
        public virtual DbSet<Tesis> Tesis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulo>()
                .Property(e => e.event_localitation)
                .IsUnicode(false);

            modelBuilder.Entity<Autor>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Autor>()
                .Property(e => e.apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Autor>()
                .HasMany(e => e.Document)
                .WithMany(e => e.Autor)
                .Map(m => m.ToTable("Document_Autor").MapLeftKey("Autorid").MapRightKey("Documentid"));

            modelBuilder.Entity<Document>()
                .Property(e => e.tittle)
                .IsUnicode(false);

            modelBuilder.Entity<Document>()
                .HasMany(e => e.Articulo)
                .WithRequired(e => e.Document)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Document>()
                .HasMany(e => e.Libro)
                .WithRequired(e => e.Document)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Document>()
                .HasMany(e => e.Tesis)
                .WithRequired(e => e.Document)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Key_Words>()
                .Property(e => e.key_word)
                .IsUnicode(false);

            modelBuilder.Entity<Key_Words>()
                .HasMany(e => e.Document)
                .WithMany(e => e.Key_Words)
                .Map(m => m.ToTable("Document_Key_Words").MapLeftKey("Key_Wordsid").MapRightKey("Documentid"));

            modelBuilder.Entity<Tesis>()
                .Property(e => e.Category)
                .IsUnicode(false);
        }
    }
}
