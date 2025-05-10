namespace Dialogos
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
            this.btabrir = new System.Windows.Forms.Button();
            this.btmais = new System.Windows.Forms.Button();
            this.btmenos = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.btfonte = new System.Windows.Forms.Button();
            this.btcores = new System.Windows.Forms.Button();
            this.lbltexto = new System.Windows.Forms.Label();
            this.figura = new System.Windows.Forms.PictureBox();
            this.cores = new System.Windows.Forms.ColorDialog();
            this.fonte = new System.Windows.Forms.FontDialog();
            this.abrir = new System.Windows.Forms.OpenFileDialog();
            this.salvar = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.figura)).BeginInit();
            this.SuspendLayout();
            // 
            // btabrir
            // 
            this.btabrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btabrir.Location = new System.Drawing.Point(180, 67);
            this.btabrir.Name = "btabrir";
            this.btabrir.Size = new System.Drawing.Size(106, 31);
            this.btabrir.TabIndex = 0;
            this.btabrir.Text = "Abrir";
            this.btabrir.UseVisualStyleBackColor = true;
            this.btabrir.Click += new System.EventHandler(this.Btabrir_Click);
            // 
            // btmais
            // 
            this.btmais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmais.Location = new System.Drawing.Point(341, 58);
            this.btmais.Name = "btmais";
            this.btmais.Size = new System.Drawing.Size(53, 48);
            this.btmais.TabIndex = 1;
            this.btmais.Text = "+";
            this.btmais.UseVisualStyleBackColor = true;
            this.btmais.Click += new System.EventHandler(this.Btmais_Click);
            // 
            // btmenos
            // 
            this.btmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmenos.Location = new System.Drawing.Point(418, 58);
            this.btmenos.Name = "btmenos";
            this.btmenos.Size = new System.Drawing.Size(53, 48);
            this.btmenos.TabIndex = 2;
            this.btmenos.Text = "_";
            this.btmenos.UseVisualStyleBackColor = true;
            this.btmenos.Click += new System.EventHandler(this.Btmenos_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalvar.Location = new System.Drawing.Point(524, 67);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(106, 31);
            this.btsalvar.TabIndex = 3;
            this.btsalvar.Text = "Salvar";
            this.btsalvar.UseVisualStyleBackColor = true;
            this.btsalvar.Click += new System.EventHandler(this.Btsalvar_Click);
            // 
            // btfonte
            // 
            this.btfonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfonte.Location = new System.Drawing.Point(678, 67);
            this.btfonte.Name = "btfonte";
            this.btfonte.Size = new System.Drawing.Size(106, 31);
            this.btfonte.TabIndex = 4;
            this.btfonte.Text = "Fonte";
            this.btfonte.UseVisualStyleBackColor = true;
            this.btfonte.Click += new System.EventHandler(this.Btfonte_Click);
            // 
            // btcores
            // 
            this.btcores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcores.Location = new System.Drawing.Point(837, 67);
            this.btcores.Name = "btcores";
            this.btcores.Size = new System.Drawing.Size(106, 31);
            this.btcores.TabIndex = 5;
            this.btcores.Text = "Cores";
            this.btcores.UseVisualStyleBackColor = true;
            this.btcores.Click += new System.EventHandler(this.Btcores_Click);
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltexto.Location = new System.Drawing.Point(401, 153);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(30, 25);
            this.lbltexto.TabIndex = 6;
            this.lbltexto.Tag = "";
            this.lbltexto.Text = "...";
            // 
            // figura
            // 
            this.figura.Location = new System.Drawing.Point(342, 206);
            this.figura.Name = "figura";
            this.figura.Size = new System.Drawing.Size(389, 383);
            this.figura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.figura.TabIndex = 7;
            this.figura.TabStop = false;
            // 
            // fonte
            // 
            this.fonte.Apply += new System.EventHandler(this.Fonte_Apply);
            // 
            // abrir
            // 
            this.abrir.FileName = "openFileDialog1";
            this.abrir.Filter = "Todas as imagens|*.bmp;.jpeg;*.png|bitmap|*.bmp|ArquivoJPEG|*.jpg|Fireworks|*.png" +
    "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 612);
            this.Controls.Add(this.figura);
            this.Controls.Add(this.lbltexto);
            this.Controls.Add(this.btcores);
            this.Controls.Add(this.btfonte);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.btmenos);
            this.Controls.Add(this.btmais);
            this.Controls.Add(this.btabrir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.figura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btabrir;
        private System.Windows.Forms.Button btmais;
        private System.Windows.Forms.Button btmenos;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.Button btfonte;
        private System.Windows.Forms.Button btcores;
        private System.Windows.Forms.Label lbltexto;
        private System.Windows.Forms.PictureBox figura;
        private System.Windows.Forms.ColorDialog cores;
        private System.Windows.Forms.FontDialog fonte;
        private System.Windows.Forms.OpenFileDialog abrir;
        private System.Windows.Forms.SaveFileDialog salvar;
    }
}

