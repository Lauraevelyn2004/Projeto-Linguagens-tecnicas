namespace Projeto1._2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtlogin = new TextBox();
            TxtSenha = new TextBox();
            button1 = new Button();
            label4 = new Label();
            btsair = new Label();
            btversenha = new PictureBox();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            tabControl1 = new TabControl();
            ((System.ComponentModel.ISupportInitialize)btversenha).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 64);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(47, 285);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 37);
            label2.TabIndex = 1;
            label2.Text = "        Usuário:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(47, 363);
            label3.Name = "label3";
            label3.Size = new Size(114, 37);
            label3.TabIndex = 2;
            label3.Text = "       Senha:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtlogin
            // 
            txtlogin.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            txtlogin.Location = new Point(47, 329);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(299, 31);
            txtlogin.TabIndex = 3;
            txtlogin.TextChanged += textBox1_TextChanged;
            // 
            // TxtSenha
            // 
            TxtSenha.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            TxtSenha.Location = new Point(47, 403);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(261, 31);
            TxtSenha.TabIndex = 4;
            TxtSenha.UseSystemPasswordChar = true;
            TxtSenha.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            button1.Location = new Point(47, 455);
            button1.Name = "button1";
            button1.Size = new Size(172, 39);
            button1.TabIndex = 5;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label4.Location = new Point(371, 411);
            label4.Name = "label4";
            label4.Size = new Size(159, 23);
            label4.TabIndex = 2;
            label4.Text = "Esqueci a senha";
            // 
            // btsair
            // 
            btsair.AutoSize = true;
            btsair.BackColor = Color.Transparent;
            btsair.Cursor = Cursors.Hand;
            btsair.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btsair.Location = new Point(486, 463);
            btsair.Name = "btsair";
            btsair.Size = new Size(44, 23);
            btsair.TabIndex = 2;
            btsair.Text = "Sair";
            btsair.Click += btsair_Click;
            // 
            // btversenha
            // 
            btversenha.Cursor = Cursors.Hand;
            btversenha.Image = Properties.Resources.invisível;
            btversenha.Location = new Point(314, 411);
            btversenha.Name = "btversenha";
            btversenha.Size = new Size(16, 16);
            btversenha.SizeMode = PictureBoxSizeMode.AutoSize;
            btversenha.TabIndex = 6;
            btversenha.TabStop = false;
            btversenha.CursorChanged += hand;
            btversenha.Click += btversenha_Click;
            btversenha.MouseDown += btversenha_MouseDown;
            btversenha.MouseUp += btversenha_MouseUp;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 66);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(192, 66);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(9, 525);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(200, 100);
            tabControl1.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Designer__12_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(579, 526);
            Controls.Add(tabControl1);
            Controls.Add(btversenha);
            Controls.Add(button1);
            Controls.Add(TxtSenha);
            Controls.Add(txtlogin);
            Controls.Add(btsair);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)btversenha).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtlogin;
        private TextBox TxtSenha;
        private Button button1;
        private Label label4;
        private Label btsair;
        private PictureBox btversenha;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabControl tabControl1;
    }
}