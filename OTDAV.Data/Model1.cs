namespace OTDAV.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<artwork> artworks { get; set; }
        public virtual DbSet<artworkpoint> artworkpoints { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<declaration> declarations { get; set; }
        public virtual DbSet<disponibility> disponibilities { get; set; }
        public virtual DbSet<exploitation> exploitations { get; set; }
        public virtual DbSet<fee> fees { get; set; }
        public virtual DbSet<file> files { get; set; }
        public virtual DbSet<forum> fora { get; set; }
        public virtual DbSet<meeting> meetings { get; set; }
        public virtual DbSet<membership> memberships { get; set; }
        public virtual DbSet<programme> programmes { get; set; }
        public virtual DbSet<reclamation> reclamations { get; set; }
        public virtual DbSet<subcategory> subcategories { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<declaration_artwork> declaration_artwork { get; set; }
        public virtual DbSet<membership_file> membership_file { get; set; }
        public virtual DbSet<subcategory_artwork> subcategory_artwork { get; set; }
        public virtual DbSet<subcategory_membership> subcategory_membership { get; set; }
        public virtual DbSet<user_artwork> user_artwork { get; set; }
        public virtual DbSet<user_declaration> user_declaration { get; set; }
        public virtual DbSet<user_meeting> user_meeting { get; set; }
        public virtual DbSet<user_membership> user_membership { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<artwork>()
                .Property(e => e.author)
                .IsUnicode(false);

            modelBuilder.Entity<artwork>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<artwork>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .Property(e => e.icon)
                .IsUnicode(false);

            modelBuilder.Entity<disponibility>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<disponibility>()
                .Property(e => e.etat)
                .IsUnicode(false);

            modelBuilder.Entity<disponibility>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<disponibility>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<exploitation>()
                .Property(e => e.artworkNom)
                .IsUnicode(false);

            modelBuilder.Entity<fee>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<file>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<forum>()
                .Property(e => e.commentaire)
                .IsUnicode(false);

            modelBuilder.Entity<meeting>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<meeting>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<meeting>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<meeting>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<membership>()
                .Property(e => e.rejectedFor)
                .IsUnicode(false);

            modelBuilder.Entity<membership>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<reclamation>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<subcategory>()
                .Property(e => e.subcategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.adress)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.stageName)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.username)
                .IsUnicode(false);
        }
    }
}
