namespace Projet
{
    partial class LoginForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            login_showPass = new CheckBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            register_label = new Label();
            label2 = new Label();
            login_btn = new Button();
            login_password = new Guna.UI2.WinForms.Guna2TextBox();
            login_username = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            close = new Button();
            guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel3
            // 
            guna2Panel3.BorderRadius = 40;
            guna2Panel3.Controls.Add(login_showPass);
            guna2Panel3.Controls.Add(pictureBox3);
            guna2Panel3.Controls.Add(pictureBox2);
            guna2Panel3.Controls.Add(pictureBox1);
            guna2Panel3.Controls.Add(register_label);
            guna2Panel3.Controls.Add(label2);
            guna2Panel3.Controls.Add(login_btn);
            guna2Panel3.Controls.Add(login_password);
            guna2Panel3.Controls.Add(login_username);
            guna2Panel3.Controls.Add(label1);
            guna2Panel3.CustomizableEdges = customizableEdges5;
            guna2Panel3.FillColor = Color.White;
            guna2Panel3.Location = new Point(64, 40);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel3.Size = new Size(656, 490);
            guna2Panel3.TabIndex = 12;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.BackColor = Color.White;
            login_showPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showPass.Location = new Point(375, 332);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(148, 27);
            login_showPass.TabIndex = 9;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = false;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.icons8_lock_50;
            pictureBox3.Location = new Point(125, 289);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.user__1_;
            pictureBox2.Location = new Point(125, 231);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.woman;
            pictureBox1.Location = new Point(247, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // register_label
            // 
            register_label.AutoSize = true;
            register_label.BackColor = Color.White;
            register_label.Cursor = Cursors.Hand;
            register_label.Font = new Font("Microsoft Sans Serif", 9F);
            register_label.ForeColor = Color.CornflowerBlue;
            register_label.Location = new Point(377, 441);
            register_label.Name = "register_label";
            register_label.Size = new Size(100, 18);
            register_label.TabIndex = 5;
            register_label.Text = "Register here ";
            register_label.Click += register_label_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.Location = new Point(216, 441);
            label2.Name = "label2";
            label2.Size = new Size(155, 18);
            label2.TabIndex = 4;
            label2.Text = "Have no account yet ?";
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.Pink;
            login_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(125, 365);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(398, 49);
            login_btn.TabIndex = 3;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // login_password
            // 
            login_password.CustomizableEdges = customizableEdges1;
            login_password.DefaultText = "";
            login_password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            login_password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            login_password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            login_password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            login_password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            login_password.Font = new Font("Segoe UI", 9F);
            login_password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            login_password.Location = new Point(193, 289);
            login_password.Margin = new Padding(3, 4, 3, 4);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.PlaceholderText = "";
            login_password.SelectedText = "";
            login_password.ShadowDecoration.CustomizableEdges = customizableEdges2;
            login_password.Size = new Size(330, 36);
            login_password.TabIndex = 2;
            // 
            // login_username
            // 
            login_username.CustomizableEdges = customizableEdges3;
            login_username.DefaultText = "";
            login_username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            login_username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            login_username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            login_username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            login_username.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            login_username.Font = new Font("Segoe UI", 9F);
            login_username.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            login_username.Location = new Point(193, 231);
            login_username.Margin = new Padding(3, 4, 3, 4);
            login_username.Name = "login_username";
            login_username.PlaceholderText = "";
            login_username.SelectedText = "";
            login_username.ShadowDecoration.CustomizableEdges = customizableEdges4;
            login_username.Size = new Size(330, 36);
            login_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 152);
            label1.Name = "label1";
            label1.Size = new Size(238, 34);
            label1.TabIndex = 0;
            label1.Text = "Login Account";
            // 
            // close
            // 
            close.BackColor = Color.Firebrick;
            close.FlatAppearance.BorderColor = Color.Black;
            close.FlatStyle = FlatStyle.Flat;
            close.ForeColor = Color.White;
            close.Location = new Point(718, 4);
            close.Name = "close";
            close.Size = new Size(59, 30);
            close.TabIndex = 11;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(783, 554);
            Controls.Add(guna2Panel3);
            Controls.Add(close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            guna2Panel3.ResumeLayout(false);
            guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private CheckBox login_showPass;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label register_label;
        private Label label2;
        private Button login_btn;
        private Guna.UI2.WinForms.Guna2TextBox login_password;
        private Guna.UI2.WinForms.Guna2TextBox login_username;
        private Label label1;
        private Button close;
    }
}