namespace Projeto1._2
{
    partial class FrmCadCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadCliente));
            label1 = new Label();
            txtnome = new TextBox();
            txtcod = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            txtsenha = new TextBox();
            txtemail = new TextBox();
            txttel = new MaskedTextBox();
            btnnovo = new Button();
            btncadastro = new Button();
            txtfalse = new Button();
            txtend = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(53, 99);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 26);
            label1.TabIndex = 0;
            label1.Text = "Código";
            label1.Click += label1_Click;
            // 
            // txtnome
            // 
            txtnome.Location = new Point(53, 217);
            txtnome.Margin = new Padding(4, 6, 4, 6);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(614, 33);
            txtnome.TabIndex = 0;
            txtnome.TextChanged += txtnome_TextChanged;
            // 
            // txtcod
            // 
            txtcod.Location = new Point(53, 131);
            txtcod.Margin = new Padding(4, 6, 4, 6);
            txtcod.Name = "txtcod";
            txtcod.ReadOnly = true;
            txtcod.Size = new Size(65, 33);
            txtcod.TabIndex = 7;
            txtcod.TextAlign = HorizontalAlignment.Center;
            txtcod.TextChanged += textBox4_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(53, 185);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(158, 26);
            label3.TabIndex = 0;
            label3.Text = "Nome do Cliente";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(53, 282);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 26);
            label4.TabIndex = 0;
            label4.Text = "Email";
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(492, 285);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 26);
            label5.TabIndex = 0;
            label5.Text = "Telefone";
            label5.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(53, 463);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(65, 26);
            label6.TabIndex = 0;
            label6.Text = "Senha";
            label6.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(53, 374);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(93, 26);
            label8.TabIndex = 0;
            label8.Text = "Endereço";
            label8.Click += label1_Click;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(53, 495);
            txtsenha.Margin = new Padding(4, 6, 4, 6);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(256, 33);
            txtsenha.TabIndex = 5;
            txtsenha.TextChanged += txtsenha_TextChanged;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(53, 314);
            txtemail.Margin = new Padding(4, 6, 4, 6);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(432, 33);
            txtemail.TabIndex = 1;
            txtemail.TextChanged += textBox7_TextChanged;
            // 
            // txttel
            // 
            txttel.BeepOnError = true;
            txttel.Location = new Point(492, 314);
            txttel.Mask = "(##) #####-####";
            txttel.Name = "txttel";
            txttel.Size = new Size(175, 33);
            txttel.TabIndex = 2;
            // 
            // btnnovo
            // 
            btnnovo.BackColor = Color.LavenderBlush;
            btnnovo.ForeColor = SystemColors.ActiveCaptionText;
            btnnovo.Image = Properties.Resources.icons8_vassoura_24;
            btnnovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnnovo.Location = new Point(196, 566);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(113, 36);
            btnnovo.TabIndex = 9;
            btnnovo.Text = "      Limpar";
            btnnovo.UseVisualStyleBackColor = false;
            btnnovo.Click += button1_Click;
            // 
            // btncadastro
            // 
            btncadastro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btncadastro.BackgroundImage = Properties.Resources.icons8_cadastro_24;
            btncadastro.BackgroundImageLayout = ImageLayout.None;
            btncadastro.Location = new Point(541, 566);
            btncadastro.Name = "btncadastro";
            btncadastro.Size = new Size(126, 36);
            btncadastro.TabIndex = 10;
            btncadastro.Tag = "2";
            btncadastro.Text = "     Cadastrar";
            btncadastro.UseVisualStyleBackColor = true;
            btncadastro.Click += button5_Click;
            // 
            // txtfalse
            // 
            txtfalse.AutoSize = true;
            txtfalse.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtfalse.BackgroundImage = Properties.Resources.icons8_fechar_janela_241;
            txtfalse.BackgroundImageLayout = ImageLayout.None;
            txtfalse.ImageAlign = ContentAlignment.MiddleLeft;
            txtfalse.Location = new Point(53, 566);
            txtfalse.Name = "txtfalse";
            txtfalse.Size = new Size(105, 36);
            txtfalse.TabIndex = 11;
            txtfalse.Text = "     Fechar";
            txtfalse.UseVisualStyleBackColor = true;
            txtfalse.Click += button1_Click_1;
            // 
            // txtend
            // 
            txtend.Location = new Point(53, 403);
            txtend.Name = "txtend";
            txtend.Size = new Size(432, 33);
            txtend.TabIndex = 12;
            txtend.TextChanged += textBox1_TextChanged;
            // 
            // FrmCadCliente
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(734, 661);
            Controls.Add(txtend);
            Controls.Add(txtfalse);
            Controls.Add(btncadastro);
            Controls.Add(btnnovo);
            Controls.Add(txttel);
            Controls.Add(txtcod);
            Controls.Add(txtemail);
            Controls.Add(txtsenha);
            Controls.Add(txtnome);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de clientes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnome;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox txtsenha;
        private TextBox txtemail;
        private MaskedTextBox txttel;
        private Button btnnovo;
        private Button btncadastro;
        private Button txtfalse;
        private TextBox txtend;
        public TextBox txtcod;
    }
}
