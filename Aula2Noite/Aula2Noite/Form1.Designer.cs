namespace Aula2Noite
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
            this.lblv1 = new System.Windows.Forms.Label();
            this.lblv2 = new System.Windows.Forms.Label();
            this.lblsoma = new System.Windows.Forms.Label();
            this.txtv2 = new System.Windows.Forms.TextBox();
            this.txtsoma = new System.Windows.Forms.TextBox();
            this.txtv1 = new System.Windows.Forms.TextBox();
            this.btcalcular = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblv1
            // 
            this.lblv1.AutoSize = true;
            this.lblv1.Location = new System.Drawing.Point(235, 57);
            this.lblv1.Name = "lblv1";
            this.lblv1.Size = new System.Drawing.Size(133, 24);
            this.lblv1.TabIndex = 0;
            this.lblv1.Text = "Digite o valor 1";
            // 
            // lblv2
            // 
            this.lblv2.AutoSize = true;
            this.lblv2.Location = new System.Drawing.Point(235, 151);
            this.lblv2.Name = "lblv2";
            this.lblv2.Size = new System.Drawing.Size(133, 24);
            this.lblv2.TabIndex = 1;
            this.lblv2.Text = "Digite o valor 2";
            // 
            // lblsoma
            // 
            this.lblsoma.AutoSize = true;
            this.lblsoma.Location = new System.Drawing.Point(462, 257);
            this.lblsoma.Name = "lblsoma";
            this.lblsoma.Size = new System.Drawing.Size(59, 24);
            this.lblsoma.TabIndex = 2;
            this.lblsoma.Text = "Soma";
            // 
            // txtv2
            // 
            this.txtv2.Location = new System.Drawing.Point(239, 205);
            this.txtv2.Name = "txtv2";
            this.txtv2.Size = new System.Drawing.Size(506, 29);
            this.txtv2.TabIndex = 3;
            // 
            // txtsoma
            // 
            this.txtsoma.BackColor = System.Drawing.Color.LightCyan;
            this.txtsoma.Location = new System.Drawing.Point(239, 295);
            this.txtsoma.Name = "txtsoma";
            this.txtsoma.Size = new System.Drawing.Size(506, 29);
            this.txtsoma.TabIndex = 4;
            this.txtsoma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtv1
            // 
            this.txtv1.Location = new System.Drawing.Point(239, 100);
            this.txtv1.Name = "txtv1";
            this.txtv1.Size = new System.Drawing.Size(506, 29);
            this.txtv1.TabIndex = 5;
            // 
            // btcalcular
            // 
            this.btcalcular.BackColor = System.Drawing.Color.LightGreen;
            this.btcalcular.ForeColor = System.Drawing.Color.Black;
            this.btcalcular.Location = new System.Drawing.Point(284, 414);
            this.btcalcular.Name = "btcalcular";
            this.btcalcular.Size = new System.Drawing.Size(161, 44);
            this.btcalcular.TabIndex = 6;
            this.btcalcular.Text = "Calcular";
            this.btcalcular.UseVisualStyleBackColor = false;
            this.btcalcular.Click += new System.EventHandler(this.Btcalcular_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.BackColor = System.Drawing.Color.Firebrick;
            this.btlimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btlimpar.Location = new System.Drawing.Point(549, 414);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(161, 44);
            this.btlimpar.TabIndex = 7;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = false;
            this.btlimpar.Click += new System.EventHandler(this.Btlimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btcalcular);
            this.Controls.Add(this.txtv1);
            this.Controls.Add(this.txtsoma);
            this.Controls.Add(this.txtv2);
            this.Controls.Add(this.lblsoma);
            this.Controls.Add(this.lblv2);
            this.Controls.Add(this.lblv1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblv1;
        private System.Windows.Forms.Label lblv2;
        private System.Windows.Forms.Label lblsoma;
        private System.Windows.Forms.TextBox txtv2;
        private System.Windows.Forms.TextBox txtsoma;
        private System.Windows.Forms.TextBox txtv1;
        private System.Windows.Forms.Button btcalcular;
        private System.Windows.Forms.Button btlimpar;
    }
}

