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
using Projet.Data.Repositories;

namespace Projet
{
    public partial class AddAdminProduct : Form
    {
        private readonly ProduitRepository _produitRepo = new ProduitRepository();
        private int? selectedProduitId = null;
        private readonly CategorieRepository _categorieRepo = new CategorieRepository();

        private void AddAdminProduct_Load(object sender, EventArgs e)
        {
            // S'assurer que les produits sont chargés
            var produits = _produitRepo.GetAll();
            dataGridView1.DataSource = produits;
            dataGridView1.AutoResizeColumns(); // Ajuste automatiquement les colonnes

            // S'assurer que l'événement de double-clic fonctionne
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;

            // Charger les catégories dans le ComboBox
            addProducts_category.DataSource = _categorieRepo.GetAll();
            addProducts_category.DisplayMember = "CategoryName";
            addProducts_category.ValueMember = "Id";
            addProducts_category.SelectedIndex = -1;

            // Charger les statuts
            addProducts_status.Items.Clear();
            addProducts_status.Items.Add("Disponible");
            addProducts_status.Items.Add("Indisponible");
            addProducts_status.SelectedIndex = -1;

            CheckStockAlerts();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                selectedProduitId = Convert.ToInt32(row.Cells[0].Value);
                addProducts_prodName.Text = row.Cells[1].Value.ToString();
                addProducts_price.Text = row.Cells[3].Value.ToString();
                addProducts_stock.Text = row.Cells[4].Value.ToString();

                // Pour le ComboBox Status
                string statusValue = row.Cells[6].Value?.ToString();
                if (!string.IsNullOrEmpty(statusValue))
                {
                    addProducts_status.SelectedItem = statusValue;
                }

                // Pour l'image (supposé qu’il y a un champ texte pour le chemin)
                string imagePath = row.Cells[5].Value?.ToString();
                if (!string.IsNullOrEmpty(imagePath))
                {
                    addProducts_imageView.ImageLocation = imagePath; // Charger l'image à partir du chemin enregistré
                }
                else
                {
                    addProducts_imageView.Image = null; // Si pas d'image, réinitialiser le PictureBox
                }

                // Pour le ComboBox catégorie
                addProducts_category.SelectedValue = Convert.ToInt32(row.Cells[2].Value);
            }
        }

        private void CheckStockAlerts()
        {
            var ruptures = _produitRepo.GetAll().Where(p => p.Stock == 0).ToList();

            if (ruptures.Any())
            {
                string message = "Attention : les produits suivants sont en rupture de stock :\n\n";
                message += string.Join("\n", ruptures.Select(p => $"- {p.ProdName}"));

                MessageBox.Show(message, "Alerte Rupture de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public AddAdminProduct()
        {
            InitializeComponent();
            this.Load += AddAdminProduct_Load;  // Associer l'événement Load

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
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

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            MainForm dashmain = new MainForm();
            dashmain.Show();
            this.Hide();
        }

        private void category_btn_Click(object sender, EventArgs e)
        {
            AddAdminCategories addcat = new AddAdminCategories();
            addcat.Show();
            this.Hide();
        }

        private void addProducts_addBtn_Click(object sender, EventArgs e)
        {
            var produit = new Produit
            {
                ProdName = addProducts_prodName.Text.Trim(),
                Price = decimal.Parse(addProducts_price.Text),
                Stock = int.Parse(addProducts_stock.Text),
                Status = addProducts_status.Text,
                ImagePath = addProducts_imageView.ImageLocation,
                Date = DateTime.Now,
                CategorieId = (int)addProducts_category.SelectedValue
            };

            _produitRepo.Add(produit);
            RefreshGrid();
            ClearFields();
            MessageBox.Show("Produit ajouté.");
        }

        private void addProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (selectedProduitId == null)
            {
                MessageBox.Show("Sélectionnez un produit à modifier.");
                return;
            }

            var produit = _produitRepo.GetById(selectedProduitId.Value);
            if (produit != null)
            {
                produit.ProdName = addProducts_prodName.Text.Trim();
                produit.Price = decimal.Parse(addProducts_price.Text);
                produit.Stock = int.Parse(addProducts_stock.Text);
                produit.Status = addProducts_status.Text;
                produit.ImagePath = addProducts_imageView.ImageLocation;
                produit.CategorieId = (int)addProducts_category.SelectedValue;

                _produitRepo.Update(produit);
                RefreshGrid();
                ClearFields();
                MessageBox.Show("Produit modifié.");
            }
        }

        private void addProducts_removeBtn_Click(object sender, EventArgs e)
        {
            if (selectedProduitId == null)
            {
                MessageBox.Show("Sélectionnez un produit à supprimer.");
                return;
            }

            if (MessageBox.Show("Voulez-vous vraiment supprimer ce produit ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _produitRepo.Delete(selectedProduitId.Value);
                RefreshGrid();
                ClearFields();
                MessageBox.Show("Produit supprimé.");
            }

        }

        private void addProducts_clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            addProducts_prodName.Clear();
            addProducts_price.Clear();
            addProducts_stock.Clear();
            addProducts_status.SelectedIndex = -1;
            addProducts_imageView.Image = null;
            addProducts_category.SelectedIndex = -1;
            selectedProduitId = null;
        }
        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _produitRepo.GetAll();
        }

        private void addProducts_importBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Choisir une image";
                openFileDialog.Filter = "Fichiers image (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Afficher l'image dans un PictureBox
                    addProducts_imageView.ImageLocation = openFileDialog.FileName;
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtenez la ligne sélectionnée
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Récupérer l'ID du produit sélectionné
                selectedProduitId = Convert.ToInt32(row.Cells[0].Value);

                // Remplir les champs avec les informations du produit
                addProducts_prodName.Text = row.Cells[1].Value?.ToString();
                addProducts_price.Text = row.Cells[2].Value?.ToString();
                addProducts_stock.Text = row.Cells[3].Value?.ToString();
                addProducts_status.SelectedItem = row.Cells[4].Value?.ToString();

                // Afficher l'image si elle existe
                string imagePath = row.Cells[5].Value?.ToString();
                if (!string.IsNullOrEmpty(imagePath))
                {
                    addProducts_imageView.ImageLocation = imagePath;
                }
                else
                {
                    addProducts_imageView.Image = null; // Si l'image est vide, réinitialiser l'image
                }

                // Sélectionner la catégorie dans le ComboBox
                addProducts_category.SelectedValue = row.Cells[6].Value;
            }
        }
    }
}
