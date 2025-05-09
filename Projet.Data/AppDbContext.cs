using Microsoft.EntityFrameworkCore;
using Projet.Data.Entities;

namespace Projet.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }

        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlite("Data Source=stock.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relation Produit ↔ Categorie
            modelBuilder.Entity<Produit>()
                .HasOne(p => p.Categorie)
                .WithMany(c => c.Produits)
                .HasForeignKey(p => p.CategorieId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuration produit
            modelBuilder.Entity<Produit>()
                .Property(p => p.ProdName)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Produit>()
                .Property(p => p.Status)
                .HasMaxLength(50);

            modelBuilder.Entity<Produit>()
                .Property(p => p.ImagePath)
                .HasMaxLength(255);

            modelBuilder.Entity<Categorie>()
                .Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Utilisateur>()
                .Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Utilisateur>()
                .Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(100);
        }
        public void Seed()
        {
            // Initialisation des catégories si elles n'existent pas
            if (!Categories.Any())
            {
                Categories.AddRange(
                    new Categorie { CategoryName = "Informatique" },
                    new Categorie { CategoryName = "Bureau" },
                    new Categorie { CategoryName = "Accessoires" }
                );
                SaveChanges();
            }

            // Initialisation des utilisateurs si ils n'existent pas
            if (!Utilisateurs.Any())
            {
                Utilisateurs.Add(new Utilisateur { Username = "admin", Password = "admin" });
                SaveChanges();
            }

            // Initialisation des produits si ils n'existent pas
            if (!Produits.Any())
            {
                // Ajouter quelques produits d'exemple
                Produits.AddRange(
                    new Produit
                    {
                        ProdName = "Ordinateur Portable",
                        CategorieId = Categories.First(c => c.CategoryName == "Informatique").Id,
                        Price = 1000.00m,
                        Stock = 10,
                        ImagePath = @"Assets\ordinateur_portable.jpg",
                        Status = "Disponible",
                        Date = DateTime.Now
                    },
                    new Produit
                    {
                        ProdName = "Chaise de Bureau",
                        CategorieId = Categories.First(c => c.CategoryName == "Bureau").Id,
                        Price = 150.00m,
                        Stock = 25,
                        ImagePath = @"Assets\chaise_bureau.jpg",
                        Status = "Disponible",
                        Date = DateTime.Now
                    },
                    new Produit
                    {
                        ProdName = "Souris Sans Fil",
                        CategorieId = Categories.First(c => c.CategoryName == "Accessoires").Id,
                        Price = 20.00m,
                        Stock = 50,
                        ImagePath = @"Assets\souris_sans_fil.jpg",
                        Status = "Disponible",
                        Date = DateTime.Now
                    }
                );
                SaveChanges();
            }
        }


    }

}
