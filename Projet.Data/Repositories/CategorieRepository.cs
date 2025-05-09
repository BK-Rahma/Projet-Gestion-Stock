using Projet.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Projet.Data.Repositories
{
    public class CategorieRepository
    {
        private readonly AppDbContext _context;

        public CategorieRepository()
        {
            _context = new AppDbContext();
        }

        public List<Categorie> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Categorie GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        public void Add(Categorie categorie)
        {
            _context.Categories.Add(categorie);
            _context.SaveChanges();
        }

        public void Update(Categorie categorie)
        {
            _context.Categories.Update(categorie);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var cat = _context.Categories.Find(id);
            if (cat != null)
            {
                _context.Categories.Remove(cat);
                _context.SaveChanges();
            }
        }
    }
}
