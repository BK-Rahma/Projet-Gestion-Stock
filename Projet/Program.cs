using Projet.Data;
using Projet.Data.Repositories;

namespace Projet
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Initialisation de la base
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();
                context.Seed();
            }

            Application.Run(new LoginForm());
        }
    }
}