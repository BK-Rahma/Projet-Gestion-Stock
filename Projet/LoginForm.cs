using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet.Data.Repositories;

namespace Projet
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void register_label_Click(object sender, EventArgs e)
        {

            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            var repo = new UtilisateurRepository();
            bool ok = repo.SeConnecter(login_username.Text, login_password.Text);
            
            if (string.IsNullOrWhiteSpace(login_username.Text) || string.IsNullOrWhiteSpace(login_password.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            if (ok)
            {
                MessageBox.Show("Connexion réussie !");
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
            }
        }
    }
}
