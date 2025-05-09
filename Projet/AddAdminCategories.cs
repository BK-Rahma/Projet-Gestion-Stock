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

    public partial class AddAdminCategories : Form
    {

        private int? selectedCategoryId = null;

        public AddAdminCategories()
        {
            InitializeComponent();
            this.Load += AddAdminCategories_Load;

        }

        private readonly CategorieRepository _categorieRepo = new CategorieRepository();

        private void AddAdminCategories_Load(object sender, EventArgs e)
        {
            var categories = _categorieRepo.GetAll();
            dataGridView1.DataSource = categories;
            this.dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                selectedCategoryId = Convert.ToInt32(row.Cells[0].Value); // ou row.Cells[0] si tu veux par index
                addCategories_category.Text = row.Cells[1].Value.ToString();
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            MainForm dashmain = new MainForm();
            dashmain.Show();
            this.Hide();
        }

        private void product_btn_Click(object sender, EventArgs e)
        {
            AddAdminProduct addprod = new AddAdminProduct();
            addprod.Show();
            this.Hide();
        }

        private void addCategories_addBtn_Click(object sender, EventArgs e)
        {
            string name = addCategories_category.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Le nom de la catégorie est requis.");
                return;
            }

            var categorie = new Projet.Data.Entities.Categorie
            {
                CategoryName = name
            };

            _categorieRepo.Add(categorie);
            MessageBox.Show("Catégorie ajoutée avec succès.");
            RefreshGrid();
            ClearFields();
        }

        private void addCategories_updateBtn_Click(object sender, EventArgs e)
        {

            if (selectedCategoryId == null)
            {
                MessageBox.Show("Veuillez d'abord sélectionner une catégorie à modifier.");
                return;
            }

            string name = addCategories_category.Text.Trim();
            var cat = _categorieRepo.GetById(selectedCategoryId.Value);

            if (cat != null)
            {
                cat.CategoryName = name;
                _categorieRepo.Update(cat);
                MessageBox.Show("Catégorie mise à jour.");
                RefreshGrid();
                ClearFields();
            }

        }

        private void addCategories_clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();

        }

        private void addCategories_removeBtn_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId == null)
            {
                MessageBox.Show("Veuillez sélectionner une catégorie à supprimer.");
                return;
            }

            if (MessageBox.Show("Supprimer cette catégorie ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _categorieRepo.Delete(selectedCategoryId.Value);
                MessageBox.Show("Catégorie supprimée.");
                RefreshGrid();
                ClearFields();
            }

        }
        private void ClearFields()
        {
            selectedCategoryId = null;
            addCategories_category.Text = "";
        }
        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _categorieRepo.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // On stocke l'ID dans la variable
                addCategories_category.Text = row.Cells["CategoryName"].Value.ToString();
            }
        }
    }
}
