namespace Condicao1
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
            this.lblresultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.btmostrar = new System.Windows.Forms.Button();
            this.btmostrar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(340, 301);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(30, 25);
            this.lblresultado.TabIndex = 0;
            this.lblresultado.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o número de um mês";
            // 
            // txtmes
            // 
            this.txtmes.Location = new System.Drawing.Point(334, 194);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(100, 20);
            this.txtmes.TabIndex = 2;
            // 
            // btmostrar
            // 
            this.btmostrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmostrar.Location = new System.Drawing.Point(299, 399);
            this.btmostrar.Name = "btmostrar";
            this.btmostrar.Size = new System.Drawing.Size(161, 33);
            this.btmostrar.TabIndex = 3;
            this.btmostrar.Text = "Mostrar";
            this.btmostrar.UseVisualStyleBackColor = false;
            this.btmostrar.Click += new System.EventHandler(this.Btmostrar_Click);
            // 
            // btmostrar2
            // 
            this.btmostrar2.BackColor = System.Drawing.Color.LightBlue;
            this.btmostrar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmostrar2.Location = new System.Drawing.Point(299, 457);
            this.btmostrar2.Name = "btmostrar2";
            this.btmostrar2.Size = new System.Drawing.Size(161, 31);
            this.btmostrar2.TabIndex = 4;
            this.btmostrar2.Text = "Mostrar 2";
            this.btmostrar2.UseVisualStyleBackColor = false;
            this.btmostrar2.Click += new System.EventHandler(this.Btmostrar2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 587);
            this.Controls.Add(this.btmostrar2);
            this.Controls.Add(this.btmostrar);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblresultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.Button btmostrar;
        private System.Windows.Forms.Button btmostrar2;
    }
}

