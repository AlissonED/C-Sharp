namespace Aula2Trapezio
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
            this.lblbasemaior = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.btcalc = new System.Windows.Forms.Button();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtraio = new System.Windows.Forms.TextBox();
            this.lblvolume = new System.Windows.Forms.Label();
            this.btlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblbasemaior
            // 
            this.lblbasemaior.AutoSize = true;
            this.lblbasemaior.Location = new System.Drawing.Point(106, 56);
            this.lblbasemaior.Name = "lblbasemaior";
            this.lblbasemaior.Size = new System.Drawing.Size(141, 24);
            this.lblbasemaior.TabIndex = 0;
            this.lblbasemaior.Text = "Raio do cilindro";
            this.lblbasemaior.Click += new System.EventHandler(this.Lblbasemaior_Click);
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(106, 146);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(151, 24);
            this.lblaltura.TabIndex = 2;
            this.lblaltura.Text = "Altura do cilindro";
            // 
            // btcalc
            // 
            this.btcalc.Location = new System.Drawing.Point(152, 325);
            this.btcalc.Name = "btcalc";
            this.btcalc.Size = new System.Drawing.Size(155, 53);
            this.btcalc.TabIndex = 5;
            this.btcalc.Text = "Calcular volume";
            this.btcalc.UseVisualStyleBackColor = true;
            this.btcalc.Click += new System.EventHandler(this.Btcalc_Click);
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(110, 192);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(477, 29);
            this.txtaltura.TabIndex = 6;
            // 
            // txtraio
            // 
            this.txtraio.Location = new System.Drawing.Point(110, 99);
            this.txtraio.Name = "txtraio";
            this.txtraio.Size = new System.Drawing.Size(477, 29);
            this.txtraio.TabIndex = 9;
            // 
            // lblvolume
            // 
            this.lblvolume.AutoSize = true;
            this.lblvolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvolume.Location = new System.Drawing.Point(162, 269);
            this.lblvolume.Name = "lblvolume";
            this.lblvolume.Size = new System.Drawing.Size(41, 31);
            this.lblvolume.TabIndex = 10;
            this.lblvolume.Text = "...";
            // 
            // btlimpar
            // 
            this.btlimpar.Location = new System.Drawing.Point(417, 325);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(155, 53);
            this.btlimpar.TabIndex = 11;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.Btlimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 412);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.lblvolume);
            this.Controls.Add(this.txtraio);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.btcalc);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblbasemaior);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbasemaior;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Button btcalc;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtraio;
        private System.Windows.Forms.Label lblvolume;
        private System.Windows.Forms.Button btlimpar;
    }
}

