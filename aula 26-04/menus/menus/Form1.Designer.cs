namespace menus
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosPorPreçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorPorProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amareloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rosaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.outrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.alpha = new System.Windows.Forms.NumericUpDown();
            this.verde = new System.Windows.Forms.NumericUpDown();
            this.azul = new System.Windows.Forms.NumericUpDown();
            this.vermelho = new System.Windows.Forms.NumericUpDown();
            this.btok = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.grupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.coresToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(943, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriasToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.CadastroToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.categoriasToolStripMenuItem.Text = "&Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.CategoriasToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("produtosToolStripMenuItem.Image")));
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.produtosToolStripMenuItem.Text = "Produtos ";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.ProdutosToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.FornecedoresToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.alterarToolStripMenuItem.Text = "alterar";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosPorPreçoToolStripMenuItem,
            this.fornecedorPorProdutoToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.consultaToolStripMenuItem.Text = "consulta";
            // 
            // produtosPorPreçoToolStripMenuItem
            // 
            this.produtosPorPreçoToolStripMenuItem.Name = "produtosPorPreçoToolStripMenuItem";
            this.produtosPorPreçoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.produtosPorPreçoToolStripMenuItem.Text = "produtos por preço";
            // 
            // fornecedorPorProdutoToolStripMenuItem
            // 
            this.fornecedorPorProdutoToolStripMenuItem.Name = "fornecedorPorProdutoToolStripMenuItem";
            this.fornecedorPorProdutoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.fornecedorPorProdutoToolStripMenuItem.Text = "fornecedor por produto";
            // 
            // coresToolStripMenuItem
            // 
            this.coresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fundoToolStripMenuItem,
            this.textoToolStripMenuItem});
            this.coresToolStripMenuItem.Name = "coresToolStripMenuItem";
            this.coresToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.coresToolStripMenuItem.Text = "cores";
            // 
            // fundoToolStripMenuItem
            // 
            this.fundoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amareloToolStripMenuItem,
            this.rosaToolStripMenuItem,
            this.verdeToolStripMenuItem,
            this.outrasToolStripMenuItem});
            this.fundoToolStripMenuItem.Name = "fundoToolStripMenuItem";
            this.fundoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fundoToolStripMenuItem.Text = "fundo";
            // 
            // amareloToolStripMenuItem
            // 
            this.amareloToolStripMenuItem.Name = "amareloToolStripMenuItem";
            this.amareloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.amareloToolStripMenuItem.Text = "amarelo";
            this.amareloToolStripMenuItem.Click += new System.EventHandler(this.AmareloToolStripMenuItem_Click);
            // 
            // rosaToolStripMenuItem
            // 
            this.rosaToolStripMenuItem.Name = "rosaToolStripMenuItem";
            this.rosaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rosaToolStripMenuItem.Text = "rosa";
            this.rosaToolStripMenuItem.Click += new System.EventHandler(this.RosaToolStripMenuItem_Click);
            // 
            // verdeToolStripMenuItem
            // 
            this.verdeToolStripMenuItem.Name = "verdeToolStripMenuItem";
            this.verdeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verdeToolStripMenuItem.Text = "verde";
            this.verdeToolStripMenuItem.Click += new System.EventHandler(this.VerdeToolStripMenuItem_Click);
            // 
            // textoToolStripMenuItem
            // 
            this.textoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretoToolStripMenuItem,
            this.brancoToolStripMenuItem});
            this.textoToolStripMenuItem.Name = "textoToolStripMenuItem";
            this.textoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.textoToolStripMenuItem.Text = "texto";
            // 
            // pretoToolStripMenuItem
            // 
            this.pretoToolStripMenuItem.Name = "pretoToolStripMenuItem";
            this.pretoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pretoToolStripMenuItem.Text = "preto";
            this.pretoToolStripMenuItem.Click += new System.EventHandler(this.PretoToolStripMenuItem_Click);
            // 
            // brancoToolStripMenuItem
            // 
            this.brancoToolStripMenuItem.Name = "brancoToolStripMenuItem";
            this.brancoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brancoToolStripMenuItem.Text = "branco";
            this.brancoToolStripMenuItem.Click += new System.EventHandler(this.BrancoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.sairToolStripMenuItem.Text = "sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mercado";
            // 
            // outrasToolStripMenuItem
            // 
            this.outrasToolStripMenuItem.Name = "outrasToolStripMenuItem";
            this.outrasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.outrasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.outrasToolStripMenuItem.Text = "Outras";
            this.outrasToolStripMenuItem.Click += new System.EventHandler(this.OutrasToolStripMenuItem_Click);
            // 
            // grupo
            // 
            this.grupo.Controls.Add(this.pic);
            this.grupo.Controls.Add(this.btok);
            this.grupo.Controls.Add(this.azul);
            this.grupo.Controls.Add(this.vermelho);
            this.grupo.Controls.Add(this.verde);
            this.grupo.Controls.Add(this.alpha);
            this.grupo.Controls.Add(this.label5);
            this.grupo.Controls.Add(this.label4);
            this.grupo.Controls.Add(this.label3);
            this.grupo.Controls.Add(this.label2);
            this.grupo.Location = new System.Drawing.Point(208, 378);
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(574, 211);
            this.grupo.TabIndex = 2;
            this.grupo.TabStop = false;
            this.grupo.Text = "Escolha a cor";
            this.grupo.Visible = false;
            this.grupo.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alpha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "VErde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vermelho";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Azul";
            // 
            // alpha
            // 
            this.alpha.Location = new System.Drawing.Point(96, 46);
            this.alpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.alpha.Name = "alpha";
            this.alpha.Size = new System.Drawing.Size(86, 31);
            this.alpha.TabIndex = 4;
            this.alpha.ValueChanged += new System.EventHandler(this.Alpha_ValueChanged);
            // 
            // verde
            // 
            this.verde.Location = new System.Drawing.Point(96, 142);
            this.verde.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.verde.Name = "verde";
            this.verde.Size = new System.Drawing.Size(86, 31);
            this.verde.TabIndex = 5;
            this.verde.ValueChanged += new System.EventHandler(this.Verde_ValueChanged);
            // 
            // azul
            // 
            this.azul.Location = new System.Drawing.Point(310, 142);
            this.azul.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.azul.Name = "azul";
            this.azul.Size = new System.Drawing.Size(86, 31);
            this.azul.TabIndex = 7;
            this.azul.ValueChanged += new System.EventHandler(this.Azul_ValueChanged);
            // 
            // vermelho
            // 
            this.vermelho.Location = new System.Drawing.Point(310, 46);
            this.vermelho.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.vermelho.Name = "vermelho";
            this.vermelho.Size = new System.Drawing.Size(86, 31);
            this.vermelho.TabIndex = 6;
            this.vermelho.ValueChanged += new System.EventHandler(this.Vermelho_ValueChanged);
            // 
            // btok
            // 
            this.btok.Location = new System.Drawing.Point(441, 148);
            this.btok.Name = "btok";
            this.btok.Size = new System.Drawing.Size(75, 33);
            this.btok.TabIndex = 3;
            this.btok.Text = "OK";
            this.btok.UseVisualStyleBackColor = true;
            this.btok.Click += new System.EventHandler(this.Btok_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(431, 61);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(100, 50);
            this.pic.TabIndex = 8;
            this.pic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 621);
            this.Controls.Add(this.grupo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grupo.ResumeLayout(false);
            this.grupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosPorPreçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorPorProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fundoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amareloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rosaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem outrasToolStripMenuItem;
        private System.Windows.Forms.GroupBox grupo;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btok;
        private System.Windows.Forms.NumericUpDown azul;
        private System.Windows.Forms.NumericUpDown vermelho;
        private System.Windows.Forms.NumericUpDown verde;
        private System.Windows.Forms.NumericUpDown alpha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

