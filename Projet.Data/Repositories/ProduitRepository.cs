using Microsoft.EntityFrameworkCore;
using Projet.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Projet.Data.Repositories
{
    public class ProduitRepository
    {
        private readonly AppDbContext _context;

        public ProduitRepository()
        {
            _context = new AppDbContext();
        }

        public List<Produit> GetAll()
        {
            return _context.Produits.Include(p => p.Categorie).ToList();
        }

        public Produit GetById(int id)
        {
            return _context.Produits.Include(p => p.Categorie).FirstOrDefault(p => p.ProdID == id);
        }

        public void Add(Produit produit)
        {
            _context.Produits.Add(produit);
            _context.SaveChanges();
        }

        public void Update(Produit produit)
        {
            _context.Produits.Update(produit);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var prod = _context.Produits.Find(id);
            if (prod != null)
            {
                _context.Produits.Remove(prod);
                _context.SaveChanges();
            }
        }

        // Exemples de méthodes utiles
        public List<Produit> GetLowStockProducts(int threshold)
        {
            return _context.Produits.Where(p => p.Stock < threshold).ToList();
        }

        public List<Produit> GetByCategory(int categoryId)
        {
            return _context.Produits.Where(p => p.CategorieId == categoryId).ToList();
        }
    }
}
