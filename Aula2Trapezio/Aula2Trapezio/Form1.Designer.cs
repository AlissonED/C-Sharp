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
            this.lblbasemenor = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblarea = new System.Windows.Forms.Label();
            this.btcalc = new System.Windows.Forms.Button();
            this.txtbasemenor = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.txtbasemaior = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblbasemaior
            // 
            this.lblbasemaior.AutoSize = true;
            this.lblbasemaior.Location = new System.Drawing.Point(312, 98);
            this.lblbasemaior.Name = "lblbasemaior";
            this.lblbasemaior.Size = new System.Drawing.Size(202, 24);
            this.lblbasemaior.TabIndex = 0;
            this.lblbasemaior.Text = "Base maior do trápezio";
            // 
            // lblbasemenor
            // 
            this.lblbasemenor.AutoSize = true;
            this.lblbasemenor.Location = new System.Drawing.Point(312, 188);
            this.lblbasemenor.Name = "lblbasemenor";
            this.lblbasemenor.Size = new System.Drawing.Size(210, 24);
            this.lblbasemenor.TabIndex = 2;
            this.lblbasemenor.Text = "Base menor do trápezio";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(312, 278);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(156, 24);
            this.lblaltura.TabIndex = 3;
            this.lblaltura.Text = "Altura do trápezio";
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(312, 377);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(148, 24);
            this.lblarea.TabIndex = 4;
            this.lblarea.Text = "Área do trápezio";
            // 
            // btcalc
            // 
            this.btcalc.Location = new System.Drawing.Point(477, 514);
            this.btcalc.Name = "btcalc";
            this.btcalc.Size = new System.Drawing.Size(155, 53);
            this.btcalc.TabIndex = 5;
            this.btcalc.Text = "Calcular área";
            this.btcalc.UseVisualStyleBackColor = true;
            this.btcalc.Click += new System.EventHandler(this.Btcalc_Click);
            // 
            // txtbasemenor
            // 
            this.txtbasemenor.Location = new System.Drawing.Point(316, 234);
            this.txtbasemenor.Name = "txtbasemenor";
            this.txtbasemenor.Size = new System.Drawing.Size(477, 29);
            this.txtbasemenor.TabIndex = 6;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(316, 331);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(477, 29);
            this.txtaltura.TabIndex = 7;
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(316, 423);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(477, 29);
            this.txtarea.TabIndex = 8;
            // 
            // txtbasemaior
            // 
            this.txtbasemaior.Location = new System.Drawing.Point(316, 141);
            this.txtbasemaior.Name = "txtbasemaior";
            this.txtbasemaior.Size = new System.Drawing.Size(477, 29);
            this.txtbasemaior.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 617);
            this.Controls.Add(this.txtbasemaior);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtbasemenor);
            this.Controls.Add(this.btcalc);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblbasemenor);
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
        private System.Windows.Forms.Label lblbasemenor;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.Button btcalc;
        private System.Windows.Forms.TextBox txtbasemenor;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.TextBox txtbasemaior;
    }
}

