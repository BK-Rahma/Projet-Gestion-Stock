using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet.Data.Entities;
using Projet.Data;
using static System.Windows.Forms.DataFormats;
using Projet.Data.Repositories;

namespace Projet
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }

        private void login_label_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string username = register_username.Text.Trim();
            string password = register_password.Text;
            string confirmPassword = register_cPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.");
                return;
            }

            var utilisateurRepo = new UtilisateurRepository();

            bool success = utilisateurRepo.Inscrire(username, password);

            if (!success)
            {
                MessageBox.Show("Nom d'utilisateur déjà utilisé.");
                return;
            }

            MessageBox.Show("Inscription réussie !");
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
