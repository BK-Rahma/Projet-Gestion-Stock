namespace Projet
{
    partial class AddAdminCategories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdminCategories));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel4 = new Panel();
            label2 = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label13 = new Label();
            panel1 = new Panel();
            close_btn = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            close = new Button();
            panel2 = new Panel();
            button5 = new Button();
            transaction_btn = new Button();
            product_btn = new Button();
            category_btn = new Button();
            dashboard_btn = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categorieBindingSource = new BindingSource(components);
            label3 = new Label();
            panel6 = new Panel();
            addCategories_removeBtn = new Button();
            addCategories_clearBtn = new Button();
            addCategories_updateBtn = new Button();
            addCategories_addBtn = new Button();
            addCategories_category = new Guna.UI2.WinForms.Guna2TextBox();
            Category = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categorieBindingSource).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(guna2CirclePictureBox1);
            panel4.Controls.Add(label13);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(199, 175);
            panel4.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(77, 122);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 6;
            label2.Text = "Admin";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(52, 23);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(94, 78);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 5;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(12, 122);
            label13.Name = "label13";
            label13.Size = new Size(69, 17);
            label13.TabIndex = 4;
            label13.Text = "Welcome,";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(close_btn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(199, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1104, 49);
            panel1.TabIndex = 6;
            // 
            // close_btn
            // 
            close_btn.BackColor = Color.Firebrick;
            close_btn.FlatAppearance.BorderColor = Color.Black;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.ForeColor = Color.White;
            close_btn.Location = new Point(1042, 3);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(59, 30);
            close_btn.TabIndex = 13;
            close_btn.Text = "X";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.box;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 26);
            label1.TabIndex = 3;
            label1.Text = "SwiftStock RS";
            // 
            // close
            // 
            close.BackColor = Color.Firebrick;
            close.FlatAppearance.BorderColor = Color.Black;
            close.FlatStyle = FlatStyle.Flat;
            close.ForeColor = Color.White;
            close.Location = new Point(1240, 5);
            close.Name = "close";
            close.Size = new Size(60, 30);
            close.TabIndex = 2;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 118, 120);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(transaction_btn);
            panel2.Controls.Add(product_btn);
            panel2.Controls.Add(category_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(199, 717);
            panel2.TabIndex = 7;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(119, 165, 166);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(26, 118, 120);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 118, 120);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Cambria", 10.2F, FontStyle.Bold | FontStyle.Italic);
            button5.ForeColor = Color.White;
            button5.Location = new Point(12, 667);
            button5.Name = "button5";
            button5.Size = new Size(176, 38);
            button5.TabIndex = 22;
            button5.Text = "Log Out";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // transaction_btn
            // 
            transaction_btn.FlatAppearance.BorderSize = 0;
            transaction_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(119, 165, 166);
            transaction_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(119, 165, 166);
            transaction_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(119, 165, 166);
            transaction_btn.FlatStyle = FlatStyle.Flat;
            transaction_btn.Font = new Font("Cambria", 10.2F, FontStyle.Bold | FontStyle.Italic);
            transaction_btn.ForeColor = Color.White;
            transaction_btn.Location = new Point(0, 443);
            transaction_btn.Name = "transaction_btn";
            transaction_btn.Size = new Size(196, 45);
            transaction_btn.TabIndex = 20;
            transaction_btn.Text = "Tansaction";
            transaction_btn.UseVisualStyleBackColor = false;
            // 
            // product_btn
            // 
            product_btn.FlatAppearance.BorderSize = 0;
            product_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(119, 165, 166);
            product_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(119, 165, 166);
            product_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(119, 165, 166);
            product_btn.FlatStyle = FlatStyle.Flat;
            product_btn.Font = new Font("Cambria", 10.2F, FontStyle.Bold | FontStyle.Italic);
            product_btn.ForeColor = Color.White;
            product_btn.Location = new Point(-1, 300);
            product_btn.Name = "product_btn";
            product_btn.Size = new Size(196, 45);
            product_btn.TabIndex = 18;
            product_btn.Text = "Product";
            product_btn.UseVisualStyleBackColor = false;
            product_btn.Click += product_btn_Click;
            // 
            // category_btn
            // 
            category_btn.FlatAppearance.BorderSize = 0;
            category_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(119, 165, 166);
            category_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(119, 165, 166);
            category_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(119, 165, 166);
            category_btn.FlatStyle = FlatStyle.Flat;
            category_btn.Font = new Font("Cambria", 10.2F, FontStyle.Bold | FontStyle.Italic);
            category_btn.ForeColor = Color.White;
            category_btn.Location = new Point(0, 371);
            category_btn.Name = "category_btn";
            category_btn.Size = new Size(196, 45);
            category_btn.TabIndex = 16;
            category_btn.Text = "Gategory";
            category_btn.UseVisualStyleBackColor = false;
            // 
            // dashboard_btn
            // 
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.FlatAppearance.CheckedBackColor = Color.FromArgb(119, 165, 166);
            dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(119, 165, 166);
            dashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(119, 165, 166);
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Cambria", 10.2F, FontStyle.Bold | FontStyle.Italic);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Location = new Point(0, 228);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(196, 45);
            dashboard_btn.TabIndex = 14;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1303, 717);
            panel3.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(648, 65);
            panel5.Name = "panel5";
            panel5.Size = new Size(643, 640);
            panel5.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, categoryNameDataGridViewTextBoxColumn });
            dataGridView1.DataSource = categorieBindingSource;
            dataGridView1.Location = new Point(14, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.PaleVioletRed;
            dataGridViewCellStyle1.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(610, 567);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // categorieBindingSource
            // 
            categorieBindingSource.DataSource = typeof(Data.Entities.Categorie);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 11);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 1;
            label3.Text = "All Categories";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(addCategories_removeBtn);
            panel6.Controls.Add(addCategories_clearBtn);
            panel6.Controls.Add(addCategories_updateBtn);
            panel6.Controls.Add(addCategories_addBtn);
            panel6.Controls.Add(addCategories_category);
            panel6.Controls.Add(Category);
            panel6.Location = new Point(216, 65);
            panel6.Name = "panel6";
            panel6.Size = new Size(409, 640);
            panel6.TabIndex = 9;
            // 
            // addCategories_removeBtn
            // 
            addCategories_removeBtn.BackColor = Color.PaleVioletRed;
            addCategories_removeBtn.FlatAppearance.BorderSize = 0;
            addCategories_removeBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(119, 165, 166);
            addCategories_removeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(119, 165, 166);
            addCategories_removeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(119, 165, 166);
            addCategories_removeBtn.FlatStyle = FlatStyle.Flat;
            addCategories_removeBtn.Font = new Font("Cambria", 10.2F, FontStyle.Bold | FontStyle.Italic);
            addCategories_removeBtn.ForeColor = Color.White;
            addCategories_removeBtn.Location = new Point(223, 319);
            addCategories_removeBtn.Name = "addCategories_removeBtn";
            addCategories_removeBtn.Size = new Size(162, 45);
            addCategories_removeBtn.TabIndex = 22;
            addCategories_removeBtn.Text = "Remove";
            addCategories_removeBtn.UseVisualStyleBackColor = false;
            addCategories_removeBtn.Click += addCategories_removeBtn_Click;
            // 
            // addCategories_clearBtn
            // 
            addCategories_clearBtn.BackColor = Color.PaleVioletRed;
            addCategories_clearBtn.FlatAppearance.BorderSize = 0;
            addCategories_clearBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(119, 165, 166);
            addCategories_clearBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(119, 165, 166);
            addCategories_clearBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(119, 165, 166);
            addCategories_clearBtn.FlatStyle = FlatStyle.Flat;
            addCategories_clearBtn.Font = new Font("Cambria", 10.2F, FontStyle.Bold | FontStyle.Italic);
            addCategories_clearBtn.ForeColor = Color.White;
            addCategories_clearBtn.Location = new Point(31, 319);
            addCategories_clearBtn.Name = "addCategories_clearBtn";
            addCategories_clearBtn.Size = new Size(162, 45);
            addCategories_clearBtn.TabIndex = 21;
            addCategories_clearBtn.Text = "Clear";
            addCategories_clearBtn.UseVisualStyleBackColor = false;
            addCategories_clearBtn.Click += addCategories_clearBtn_Click;
            // 
            // addCategories_updateBtn
            // 
            addCategories_updateBtn.BackColor = Color.PaleVioletRed;
            addCategories_updateBtn.FlatAppearance.BorderSize = 0;
            addCategories_updateBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(119, 165, 166);
            addCategories_updateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(119, 165, 166);
            addCategories_updateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(119, 165, 166);
            addCategories_updateBtn.FlatStyle = FlatStyle.Flat;
            addCategories_updateBtn.Font = new Font("Cambria", 10.2F, FontStyle.Bold | FontStyle.Italic);
            addCategories_updateBtn.ForeColor = Color.White;
            addCategories_updateBtn.Location = new Point(223, 230);
            addCategories_updateBtn.Name = "addCategories_updateBtn";
            addCategories_updateBtn.Size = new Size(162, 45);
            addCategories_updateBtn.TabIndex = 20;
            addCategories_updateBtn.Text = "Update";
            addCategories_updateBtn.UseVisualStyleBackColor = false;
            addCategories_updateBtn.Click += addCategories_updateBtn_Click;
            // 
            // addCategories_addBtn
            // 
            addCategories_addBtn.BackColor = Color.PaleVioletRed;
            addCategories_addBtn.FlatAppearance.BorderSize = 0;
            addCategories_addBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(119, 165, 166);
            addCategories_addBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(119, 165, 166);
            addCategories_addBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(119, 165, 166);
            addCategories_addBtn.FlatStyle = FlatStyle.Flat;
            addCategories_addBtn.Font = new Font("Cambria", 10.2F, FontStyle.Bold | FontStyle.Italic);
            addCategories_addBtn.ForeColor = Color.White;
            addCategories_addBtn.Location = new Point(31, 230);
            addCategories_addBtn.Name = "addCategories_addBtn";
            addCategories_addBtn.Size = new Size(162, 45);
            addCategories_addBtn.TabIndex = 19;
            addCategories_addBtn.Text = "Add";
            addCategories_addBtn.UseVisualStyleBackColor = false;
            addCategories_addBtn.Click += addCategories_addBtn_Click;
            // 
            // addCategories_category
            // 
            addCategories_category.CustomizableEdges = customizableEdges2;
            addCategories_category.DefaultText = "";
            addCategories_category.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            addCategories_category.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            addCategories_category.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            addCategories_category.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            addCategories_category.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            addCategories_category.Font = new Font("Segoe UI", 9F);
            addCategories_category.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            addCategories_category.Location = new Point(30, 129);
            addCategories_category.Margin = new Padding(3, 4, 3, 4);
            addCategories_category.Name = "addCategories_category";
            addCategories_category.PlaceholderText = "";
            addCategories_category.SelectedText = "";
            addCategories_category.ShadowDecoration.CustomizableEdges = customizableEdges3;
            addCategories_category.Size = new Size(354, 38);
            addCategories_category.TabIndex = 1;
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Category.Location = new Point(31, 87);
            Category.Name = "Category";
            Category.Size = new Size(76, 22);
            Category.TabIndex = 0;
            Category.Text = "Category";
            // 
            // AddAdminCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 717);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddAdminCategories";
            Text = "AddAdminCategories";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)categorieBindingSource).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label label13;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button close;
        private Panel panel2;
        private Button button5;
        private Button transaction_btn;
        private Button product_btn;
        private Button category_btn;
        private Button dashboard_btn;
        private Panel panel3;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Label label3;
        private Panel panel6;
        private Button addCategories_removeBtn;
        private Button addCategories_clearBtn;
        private Button addCategories_updateBtn;
        private Button addCategories_addBtn;
        private Guna.UI2.WinForms.Guna2TextBox addCategories_category;
        private Label Category;
        private Button close_btn;
        private BindingSource categorieBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
    }
}