
namespace AulaClasse
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
            this.btquadrado = new System.Windows.Forms.Button();
            this.btcilindro = new System.Windows.Forms.Button();
            this.btfatorial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttriangulo = new System.Windows.Forms.Button();
            this.btret = new System.Windows.Forms.Button();
            this.btcasa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btquadrado
            // 
            this.btquadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btquadrado.Location = new System.Drawing.Point(32, 77);
            this.btquadrado.Name = "btquadrado";
            this.btquadrado.Size = new System.Drawing.Size(195, 71);
            this.btquadrado.TabIndex = 0;
            this.btquadrado.Text = "Quadrado";
            this.btquadrado.UseVisualStyleBackColor = true;
            this.btquadrado.Click += new System.EventHandler(this.btquadrado_Click);
            // 
            // btcilindro
            // 
            this.btcilindro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcilindro.Location = new System.Drawing.Point(299, 77);
            this.btcilindro.Name = "btcilindro";
            this.btcilindro.Size = new System.Drawing.Size(195, 71);
            this.btcilindro.TabIndex = 1;
            this.btcilindro.Text = "Cilindro";
            this.btcilindro.UseVisualStyleBackColor = true;
            this.btcilindro.Click += new System.EventHandler(this.btcilindro_Click);
            // 
            // btfatorial
            // 
            this.btfatorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfatorial.Location = new System.Drawing.Point(576, 77);
            this.btfatorial.Name = "btfatorial";
            this.btfatorial.Size = new System.Drawing.Size(195, 71);
            this.btfatorial.TabIndex = 2;
            this.btfatorial.Text = "Fatorial";
            this.btfatorial.UseVisualStyleBackColor = true;
            this.btfatorial.Click += new System.EventHandler(this.btfatorial_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // bttriangulo
            // 
            this.bttriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttriangulo.Location = new System.Drawing.Point(32, 187);
            this.bttriangulo.Name = "bttriangulo";
            this.bttriangulo.Size = new System.Drawing.Size(195, 71);
            this.bttriangulo.TabIndex = 4;
            this.bttriangulo.Text = "Triangulo";
            this.bttriangulo.UseVisualStyleBackColor = true;
            this.bttriangulo.Click += new System.EventHandler(this.bttriangulo_Click);
            // 
            // btret
            // 
            this.btret.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btret.Location = new System.Drawing.Point(299, 187);
            this.btret.Name = "btret";
            this.btret.Size = new System.Drawing.Size(195, 71);
            this.btret.TabIndex = 5;
            this.btret.Text = "Retangulo";
            this.btret.UseVisualStyleBackColor = true;
            this.btret.Click += new System.EventHandler(this.btret_Click);
            // 
            // btcasa
            // 
            this.btcasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcasa.Location = new System.Drawing.Point(576, 187);
            this.btcasa.Name = "btcasa";
            this.btcasa.Size = new System.Drawing.Size(195, 71);
            this.btcasa.TabIndex = 6;
            this.btcasa.Text = "Casa";
            this.btcasa.UseVisualStyleBackColor = true;
            this.btcasa.Click += new System.EventHandler(this.btcasa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btcasa);
            this.Controls.Add(this.btret);
            this.Controls.Add(this.bttriangulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btfatorial);
            this.Controls.Add(this.btcilindro);
            this.Controls.Add(this.btquadrado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btquadrado;
        private System.Windows.Forms.Button btcilindro;
        private System.Windows.Forms.Button btfatorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttriangulo;
        private System.Windows.Forms.Button btret;
        private System.Windows.Forms.Button btcasa;
    }
}

