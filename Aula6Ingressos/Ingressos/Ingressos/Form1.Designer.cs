namespace Ingressos
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
            this.rdbfem = new System.Windows.Forms.RadioButton();
            this.rdbmasc = new System.Windows.Forms.RadioButton();
            this.rdbsolteiro = new System.Windows.Forms.RadioButton();
            this.rdbcasado = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btcalc = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbfem
            // 
            this.rdbfem.AutoSize = true;
            this.rdbfem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbfem.Location = new System.Drawing.Point(16, 19);
            this.rdbfem.Name = "rdbfem";
            this.rdbfem.Size = new System.Drawing.Size(116, 28);
            this.rdbfem.TabIndex = 0;
            this.rdbfem.TabStop = true;
            this.rdbfem.Text = "Feminino";
            this.rdbfem.UseVisualStyleBackColor = true;
            this.rdbfem.CheckedChanged += new System.EventHandler(this.Rdbfem_CheckedChanged);
            // 
            // rdbmasc
            // 
            this.rdbmasc.AutoSize = true;
            this.rdbmasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmasc.Location = new System.Drawing.Point(16, 53);
            this.rdbmasc.Name = "rdbmasc";
            this.rdbmasc.Size = new System.Drawing.Size(123, 28);
            this.rdbmasc.TabIndex = 1;
            this.rdbmasc.TabStop = true;
            this.rdbmasc.Text = "Masculino";
            this.rdbmasc.UseVisualStyleBackColor = true;
            this.rdbmasc.CheckedChanged += new System.EventHandler(this.Rdbmasc_CheckedChanged);
            // 
            // rdbsolteiro
            // 
            this.rdbsolteiro.AutoSize = true;
            this.rdbsolteiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbsolteiro.Location = new System.Drawing.Point(6, 64);
            this.rdbsolteiro.Name = "rdbsolteiro";
            this.rdbsolteiro.Size = new System.Drawing.Size(99, 28);
            this.rdbsolteiro.TabIndex = 2;
            this.rdbsolteiro.TabStop = true;
            this.rdbsolteiro.Text = "Solteiro";
            this.rdbsolteiro.UseVisualStyleBackColor = true;
            this.rdbsolteiro.CheckedChanged += new System.EventHandler(this.Rdbsolteiro_CheckedChanged);
            // 
            // rdbcasado
            // 
            this.rdbcasado.AutoSize = true;
            this.rdbcasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbcasado.Location = new System.Drawing.Point(6, 30);
            this.rdbcasado.Name = "rdbcasado";
            this.rdbcasado.Size = new System.Drawing.Size(98, 28);
            this.rdbcasado.TabIndex = 3;
            this.rdbcasado.TabStop = true;
            this.rdbcasado.Text = "Casado";
            this.rdbcasado.UseVisualStyleBackColor = true;
            this.rdbcasado.CheckedChanged += new System.EventHandler(this.Rdbcasado_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbfem);
            this.groupBox1.Controls.Add(this.rdbmasc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbcasado);
            this.groupBox2.Controls.Add(this.rdbsolteiro);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(338, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado civil:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor do ingresso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Desconto :";
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(291, 26);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(193, 29);
            this.txtvalor.TabIndex = 10;
            // 
            // txtdesconto
            // 
            this.txtdesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesconto.Location = new System.Drawing.Point(291, 82);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(103, 29);
            this.txtdesconto.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "%";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(339, 355);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(33, 25);
            this.lbltotal.TabIndex = 2;
            this.lbltotal.Text = "...";
            // 
            // btcalc
            // 
            this.btcalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcalc.Location = new System.Drawing.Point(68, 341);
            this.btcalc.Name = "btcalc";
            this.btcalc.Size = new System.Drawing.Size(154, 52);
            this.btcalc.TabIndex = 13;
            this.btcalc.Text = "Calcular";
            this.btcalc.UseVisualStyleBackColor = true;
            this.btcalc.Click += new System.EventHandler(this.Btcalc_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(462, 323);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 14;
            this.bt1.Text = "button1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.Bt1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btcalc);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdesconto);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbfem;
        private System.Windows.Forms.RadioButton rdbmasc;
        private System.Windows.Forms.RadioButton rdbsolteiro;
        private System.Windows.Forms.RadioButton rdbcasado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btcalc;
        private System.Windows.Forms.Button bt1;
    }
}

