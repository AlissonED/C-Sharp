namespace Aula4Media
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txttrabalho = new System.Windows.Forms.TextBox();
            this.txtp2 = new System.Windows.Forms.TextBox();
            this.txtp1 = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btcalc = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.lblaprovado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmedia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(283, 23);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(119, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Nota de P1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(283, 112);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(119, 25);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Nota de P2";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(283, 220);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(178, 25);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Nota de Trabalho";
            this.lbl3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // txttrabalho
            // 
            this.txttrabalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttrabalho.Location = new System.Drawing.Point(288, 278);
            this.txttrabalho.Name = "txttrabalho";
            this.txttrabalho.Size = new System.Drawing.Size(396, 26);
            this.txttrabalho.TabIndex = 3;
            this.txttrabalho.TextChanged += new System.EventHandler(this.Txttrabalho_TextChanged);
            // 
            // txtp2
            // 
            this.txtp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp2.Location = new System.Drawing.Point(288, 167);
            this.txtp2.Name = "txtp2";
            this.txtp2.Size = new System.Drawing.Size(396, 26);
            this.txtp2.TabIndex = 4;
            // 
            // txtp1
            // 
            this.txtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp1.Location = new System.Drawing.Point(288, 51);
            this.txtp1.Name = "txtp1";
            this.txtp1.Size = new System.Drawing.Size(396, 26);
            this.txtp1.TabIndex = 5;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(333, 392);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(44, 37);
            this.lblresultado.TabIndex = 6;
            this.lblresultado.Text = "...";
            // 
            // btcalc
            // 
            this.btcalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcalc.Location = new System.Drawing.Point(200, 496);
            this.btcalc.Name = "btcalc";
            this.btcalc.Size = new System.Drawing.Size(131, 41);
            this.btcalc.TabIndex = 7;
            this.btcalc.Text = "CALCULAR";
            this.btcalc.UseVisualStyleBackColor = true;
            this.btcalc.Click += new System.EventHandler(this.Btcalc_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpar.Location = new System.Drawing.Point(577, 496);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(131, 41);
            this.btlimpar.TabIndex = 8;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.Btlimpar_Click);
            // 
            // lblaprovado
            // 
            this.lblaprovado.AutoSize = true;
            this.lblaprovado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaprovado.Location = new System.Drawing.Point(333, 429);
            this.lblaprovado.Name = "lblaprovado";
            this.lblaprovado.Size = new System.Drawing.Size(44, 37);
            this.lblaprovado.TabIndex = 9;
            this.lblaprovado.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "media";
            // 
            // txtmedia
            // 
            this.txtmedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmedia.Location = new System.Drawing.Point(288, 363);
            this.txtmedia.Name = "txtmedia";
            this.txtmedia.Size = new System.Drawing.Size(396, 26);
            this.txtmedia.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 572);
            this.Controls.Add(this.txtmedia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblaprovado);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btcalc);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtp1);
            this.Controls.Add(this.txtp2);
            this.Controls.Add(this.txttrabalho);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txttrabalho;
        private System.Windows.Forms.TextBox txtp2;
        private System.Windows.Forms.TextBox txtp1;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btcalc;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Label lblaprovado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmedia;
    }
}

