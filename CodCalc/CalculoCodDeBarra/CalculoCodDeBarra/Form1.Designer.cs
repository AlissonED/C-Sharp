namespace CalculoCodDeBarra
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbldigito = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.btcalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de barras:";
            // 
            // lbldigito
            // 
            this.lbldigito.AutoSize = true;
            this.lbldigito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldigito.Location = new System.Drawing.Point(279, 298);
            this.lbldigito.Name = "lbldigito";
            this.lbldigito.Size = new System.Drawing.Size(25, 24);
            this.lbldigito.TabIndex = 1;
            this.lbldigito.Text = "...";
            this.lbldigito.Click += new System.EventHandler(this.Lbldigito_Click);
            // 
            // txtcod
            // 
            this.txtcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.Location = new System.Drawing.Point(299, 143);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(272, 31);
            this.txtcod.TabIndex = 2;
            this.txtcod.Text = "789742408138";
            this.txtcod.TextChanged += new System.EventHandler(this.Txtcod_TextChanged);
            // 
            // btcalc
            // 
            this.btcalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcalc.Location = new System.Drawing.Point(203, 428);
            this.btcalc.Name = "btcalc";
            this.btcalc.Size = new System.Drawing.Size(179, 61);
            this.btcalc.TabIndex = 3;
            this.btcalc.Text = "Calcular";
            this.btcalc.UseVisualStyleBackColor = true;
            this.btcalc.Click += new System.EventHandler(this.Btcalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 608);
            this.Controls.Add(this.btcalc);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.lbldigito);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldigito;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Button btcalc;
    }
}

