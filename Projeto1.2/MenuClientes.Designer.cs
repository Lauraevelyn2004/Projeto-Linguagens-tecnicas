namespace Projeto1._2
{
    partial class MenuClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuClientes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btficha = new Button();
            bteditar = new Button();
            btadd = new Button();
            dglista = new DataGridView();
            Cliente_ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Endereço = new DataGridViewTextBoxColumn();
            Senha = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            pesqend = new TextBox();
            pesqtel = new TextBox();
            pesqnome = new TextBox();
            pesqcod = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            lbltotallocalizado = new Label();
            lblaviso = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dglista).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btficha);
            groupBox1.Controls.Add(bteditar);
            groupBox1.Controls.Add(btadd);
            groupBox1.ForeColor = SystemColors.AppWorkspace;
            groupBox1.Location = new Point(21, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(203, 102);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ações";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btficha
            // 
            btficha.BackColor = Color.Transparent;
            btficha.BackgroundImage = (Image)resources.GetObject("btficha.BackgroundImage");
            btficha.Cursor = Cursors.Hand;
            btficha.Enabled = false;
            btficha.FlatAppearance.BorderSize = 0;
            btficha.FlatStyle = FlatStyle.Flat;
            btficha.Location = new Point(140, 32);
            btficha.Name = "btficha";
            btficha.Size = new Size(48, 48);
            btficha.TabIndex = 1;
            btficha.UseVisualStyleBackColor = false;
            // 
            // bteditar
            // 
            bteditar.BackColor = Color.Transparent;
            bteditar.BackgroundImage = (Image)resources.GetObject("bteditar.BackgroundImage");
            bteditar.Cursor = Cursors.Hand;
            bteditar.Enabled = false;
            bteditar.FlatAppearance.BorderSize = 0;
            bteditar.FlatStyle = FlatStyle.Flat;
            bteditar.Location = new Point(73, 32);
            bteditar.Name = "bteditar";
            bteditar.Size = new Size(48, 48);
            bteditar.TabIndex = 1;
            bteditar.UseVisualStyleBackColor = false;
            bteditar.Click += bteditar_Click;
            // 
            // btadd
            // 
            btadd.BackColor = Color.Transparent;
            btadd.BackgroundImage = Properties.Resources.icons8_adicionar_48;
            btadd.Cursor = Cursors.Hand;
            btadd.FlatAppearance.BorderSize = 0;
            btadd.FlatStyle = FlatStyle.Flat;
            btadd.Location = new Point(6, 32);
            btadd.Name = "btadd";
            btadd.Size = new Size(48, 48);
            btadd.TabIndex = 1;
            btadd.UseVisualStyleBackColor = false;
            btadd.Click += btadd_Click;
            // 
            // dglista
            // 
            dglista.AllowUserToAddRows = false;
            dglista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.AliceBlue;
            dglista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dglista.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dglista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dglista.ColumnHeadersHeight = 30;
            dglista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dglista.Columns.AddRange(new DataGridViewColumn[] { Cliente_ID, Nome, Email, Telefone, Endereço, Senha });
            dglista.EnableHeadersVisualStyles = false;
            dglista.GridColor = SystemColors.ButtonShadow;
            dglista.Location = new Point(21, 178);
            dglista.Name = "dglista";
            dglista.ReadOnly = true;
            dglista.RowHeadersWidth = 4;
            dglista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dglista.Size = new Size(1022, 400);
            dglista.TabIndex = 2;
            dglista.CellClick += dglista_CellClick;
            dglista.CellContentClick += dglista_CellContentClick;
            // 
            // Cliente_ID
            // 
            Cliente_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Cliente_ID.DataPropertyName = "Cliente_ID";
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.Padding = new Padding(10, 0, 0, 0);
            Cliente_ID.DefaultCellStyle = dataGridViewCellStyle3;
            Cliente_ID.HeaderText = "  Código";
            Cliente_ID.Name = "Cliente_ID";
            Cliente_ID.ReadOnly = true;
            Cliente_ID.Width = 106;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            dataGridViewCellStyle4.Font = new Font("Arial Narrow", 12F);
            dataGridViewCellStyle4.ForeColor = Color.Blue;
            dataGridViewCellStyle4.Padding = new Padding(10, 0, 0, 0);
            Nome.DefaultCellStyle = dataGridViewCellStyle4;
            Nome.HeaderText = "  Nome do Cliente";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 301;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            dataGridViewCellStyle5.Font = new Font("Arial Narrow", 12F);
            dataGridViewCellStyle5.ForeColor = Color.Blue;
            dataGridViewCellStyle5.Padding = new Padding(10, 0, 0, 0);
            Email.DefaultCellStyle = dataGridViewCellStyle5;
            Email.HeaderText = "  Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 280;
            // 
            // Telefone
            // 
            Telefone.DataPropertyName = "Telefone";
            dataGridViewCellStyle6.Font = new Font("Arial Narrow", 12F);
            dataGridViewCellStyle6.ForeColor = Color.Blue;
            dataGridViewCellStyle6.Padding = new Padding(10, 0, 0, 0);
            Telefone.DefaultCellStyle = dataGridViewCellStyle6;
            Telefone.HeaderText = "  Telefone";
            Telefone.Name = "Telefone";
            Telefone.ReadOnly = true;
            Telefone.Width = 173;
            // 
            // Endereço
            // 
            Endereço.DataPropertyName = "Endereco";
            dataGridViewCellStyle7.Font = new Font("Arial Narrow", 12F);
            dataGridViewCellStyle7.ForeColor = Color.Blue;
            dataGridViewCellStyle7.Padding = new Padding(10, 0, 0, 0);
            Endereço.DefaultCellStyle = dataGridViewCellStyle7;
            Endereço.HeaderText = "  Endereço";
            Endereço.Name = "Endereço";
            Endereço.ReadOnly = true;
            Endereço.Width = 170;
            // 
            // Senha
            // 
            Senha.DataPropertyName = "Senha";
            Senha.HeaderText = "  Senha";
            Senha.Name = "Senha";
            Senha.ReadOnly = true;
            Senha.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(pesqend);
            groupBox2.Controls.Add(pesqtel);
            groupBox2.Controls.Add(pesqnome);
            groupBox2.Controls.Add(pesqcod);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label3);
            groupBox2.ForeColor = SystemColors.AppWorkspace;
            groupBox2.Location = new Point(244, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(799, 102);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opções de consulta";
            // 
            // pesqend
            // 
            pesqend.Font = new Font("Calibri", 11.75F, FontStyle.Bold);
            pesqend.Location = new Point(555, 63);
            pesqend.Name = "pesqend";
            pesqend.Size = new Size(222, 27);
            pesqend.TabIndex = 3;
            pesqend.TextChanged += pesqcod_TextChanged;
            // 
            // pesqtel
            // 
            pesqtel.Font = new Font("Calibri", 11.75F, FontStyle.Bold);
            pesqtel.Location = new Point(332, 63);
            pesqtel.Name = "pesqtel";
            pesqtel.Size = new Size(192, 27);
            pesqtel.TabIndex = 3;
            pesqtel.TextChanged += pesqcod_TextChanged;
            // 
            // pesqnome
            // 
            pesqnome.Font = new Font("Calibri", 11.75F, FontStyle.Bold);
            pesqnome.Location = new Point(86, 63);
            pesqnome.Name = "pesqnome";
            pesqnome.Size = new Size(224, 27);
            pesqnome.TabIndex = 3;
            pesqnome.TextChanged += pesqcod_TextChanged;
            // 
            // pesqcod
            // 
            pesqcod.Font = new Font("Calibri", 11.75F, FontStyle.Bold);
            pesqcod.Location = new Point(5, 63);
            pesqcod.Name = "pesqcod";
            pesqcod.Size = new Size(57, 27);
            pesqcod.TabIndex = 3;
            pesqcod.TextChanged += pesqcod_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 11.75F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(555, 32);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 19);
            label4.TabIndex = 2;
            label4.Text = "Endereço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 11.75F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(332, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 2;
            label2.Text = "Telefone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 11.75F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(86, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 19);
            label1.TabIndex = 2;
            label1.Text = "Nome do Cliente /Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 11.75F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(5, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 2;
            label3.Text = "Código";
            // 
            // lbltotallocalizado
            // 
            lbltotallocalizado.AutoSize = true;
            lbltotallocalizado.BackColor = Color.Transparent;
            lbltotallocalizado.Font = new Font("Calibri", 11.75F, FontStyle.Bold);
            lbltotallocalizado.ForeColor = SystemColors.ControlText;
            lbltotallocalizado.Location = new Point(18, 600);
            lbltotallocalizado.Margin = new Padding(4, 0, 4, 0);
            lbltotallocalizado.Name = "lbltotallocalizado";
            lbltotallocalizado.Size = new Size(130, 19);
            lbltotallocalizado.TabIndex = 2;
            lbltotallocalizado.Text = "Total Localizado : ";
            // 
            // lblaviso
            // 
            lblaviso.Font = new Font("Calibri", 40.75F, FontStyle.Bold);
            lblaviso.ForeColor = Color.IndianRed;
            lblaviso.Image = (Image)resources.GetObject("lblaviso.Image");
            lblaviso.Location = new Point(21, 210);
            lblaviso.Name = "lblaviso";
            lblaviso.Size = new Size(1022, 362);
            lblaviso.TabIndex = 4;
            lblaviso.TextAlign = ContentAlignment.MiddleCenter;
            lblaviso.Visible = false;
            lblaviso.Click += label5_Click;
            // 
            // MenuClientes
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = Properties.Resources.degrade2;
            BackgroundImageLayout = ImageLayout.Stretch;
            CausesValidation = false;
            ClientSize = new Size(1064, 681);
            Controls.Add(lblaviso);
            Controls.Add(groupBox2);
            Controls.Add(dglista);
            Controls.Add(groupBox1);
            Controls.Add(lbltotallocalizado);
            DoubleBuffered = true;
            Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "MenuClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuClientes";
            TransparencyKey = Color.FromArgb(255, 192, 192);
            Load += MenuClientes_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dglista).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btadd;
        private Button btficha;
        private Button bteditar;
        private DataGridView dglista;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox pesqcod;
        private TextBox pesqnome;
        private Label label1;
        private TextBox pesqtel;
        private TextBox pesqend;
        private Label label4;
        private Label label2;
        private Label lbltotallocalizado;
        private Label lblaviso;
        private DataGridViewTextBoxColumn Cliente_ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Endereço;
        private DataGridViewTextBoxColumn Senha;
    }
}