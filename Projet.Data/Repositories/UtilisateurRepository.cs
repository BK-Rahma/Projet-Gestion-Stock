using System.Linq;
using Projet.Data.Entities;

namespace Projet.Data.Repositories
{
    public class UtilisateurRepository
    {
        private readonly AppDbContext _context;

        public UtilisateurRepository()
        {
            _context = new AppDbContext();
        }

        public bool Inscrire(string username, string password)
        {
            if (_context.Utilisateurs.Any(u => u.Username == username))
                return false;

            var user = new Utilisateur { Username = username, Password = password };
            _context.Utilisateurs.Add(user);
            _context.SaveChanges();
            return true;
        }

        public bool SeConnecter(string username, string password)
        {
            return _context.Utilisateurs.Any(u => u.Username == username && u.Password == password);
        }
        /*
        public void Seed()
        {
            if (!_context.Utilisateurs.Any())
            {
                _context.Utilisateurs.AddRange(
                    new Utilisateur { Username = "admin", Password = "admin123" },
                    new Utilisateur { Username = "demo", Password = "demo123" }
                );
                _context.SaveChanges();
            }
        }*/


    }
}
