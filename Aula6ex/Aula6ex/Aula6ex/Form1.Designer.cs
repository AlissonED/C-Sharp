namespace Aula6ex
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
            this.txtvel = new System.Windows.Forms.TextBox();
            this.txtdiametro = new System.Windows.Forms.TextBox();
            this.txtviscosidade = new System.Windows.Forms.TextBox();
            this.txtdensidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtreynolds = new System.Windows.Forms.TextBox();
            this.btcalc = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtvel
            // 
            this.txtvel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvel.Location = new System.Drawing.Point(451, 81);
            this.txtvel.Name = "txtvel";
            this.txtvel.Size = new System.Drawing.Size(217, 29);
            this.txtvel.TabIndex = 0;
            // 
            // txtdiametro
            // 
            this.txtdiametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiametro.Location = new System.Drawing.Point(451, 165);
            this.txtdiametro.Name = "txtdiametro";
            this.txtdiametro.Size = new System.Drawing.Size(217, 29);
            this.txtdiametro.TabIndex = 1;
            // 
            // txtviscosidade
            // 
            this.txtviscosidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtviscosidade.Location = new System.Drawing.Point(451, 204);
            this.txtviscosidade.Name = "txtviscosidade";
            this.txtviscosidade.Size = new System.Drawing.Size(217, 29);
            this.txtviscosidade.TabIndex = 2;
            // 
            // txtdensidade
            // 
            this.txtdensidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdensidade.Location = new System.Drawing.Point(451, 128);
            this.txtdensidade.Name = "txtdensidade";
            this.txtdensidade.Size = new System.Drawing.Size(217, 29);
            this.txtdensidade.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Velocidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Densidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Diâmetro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Viscosidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(149, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "N° de Reynolds";
            // 
            // txtreynolds
            // 
            this.txtreynolds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreynolds.Location = new System.Drawing.Point(451, 244);
            this.txtreynolds.Name = "txtreynolds";
            this.txtreynolds.Size = new System.Drawing.Size(217, 29);
            this.txtreynolds.TabIndex = 9;
            // 
            // btcalc
            // 
            this.btcalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcalc.Location = new System.Drawing.Point(241, 352);
            this.btcalc.Name = "btcalc";
            this.btcalc.Size = new System.Drawing.Size(134, 54);
            this.btcalc.TabIndex = 10;
            this.btcalc.Text = "Calcular";
            this.btcalc.UseVisualStyleBackColor = true;
            this.btcalc.Click += new System.EventHandler(this.Btcalc_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpar.Location = new System.Drawing.Point(441, 352);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(134, 54);
            this.btlimpar.TabIndex = 11;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.Btlimpar_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(396, 311);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(30, 25);
            this.lblresultado.TabIndex = 12;
            this.lblresultado.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btcalc);
            this.Controls.Add(this.txtreynolds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdensidade);
            this.Controls.Add(this.txtviscosidade);
            this.Controls.Add(this.txtdiametro);
            this.Controls.Add(this.txtvel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvel;
        private System.Windows.Forms.TextBox txtdiametro;
        private System.Windows.Forms.TextBox txtviscosidade;
        private System.Windows.Forms.TextBox txtdensidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtreynolds;
        private System.Windows.Forms.Button btcalc;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Label lblresultado;
    }
}

