namespace Condicao2
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
            this.button2 = new System.Windows.Forms.Button();
            this.btcalc = new System.Windows.Forms.Button();
            this.txthorastrab = new System.Windows.Forms.TextBox();
            this.txtsalhora = new System.Windows.Forms.TextBox();
            this.txtinss = new System.Windows.Forms.TextBox();
            this.txtsalbruto = new System.Windows.Forms.TextBox();
            this.txtsalliq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(340, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 42);
            this.button2.TabIndex = 23;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btcalc
            // 
            this.btcalc.BackColor = System.Drawing.Color.PaleGreen;
            this.btcalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcalc.Location = new System.Drawing.Point(84, 358);
            this.btcalc.Name = "btcalc";
            this.btcalc.Size = new System.Drawing.Size(118, 42);
            this.btcalc.TabIndex = 22;
            this.btcalc.Text = "Calcular";
            this.btcalc.UseVisualStyleBackColor = false;
            this.btcalc.Click += new System.EventHandler(this.Btcalc_Click);
            // 
            // txthorastrab
            // 
            this.txthorastrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorastrab.Location = new System.Drawing.Point(271, 52);
            this.txthorastrab.Name = "txthorastrab";
            this.txthorastrab.Size = new System.Drawing.Size(211, 22);
            this.txthorastrab.TabIndex = 21;
            // 
            // txtsalhora
            // 
            this.txtsalhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalhora.Location = new System.Drawing.Point(271, 102);
            this.txtsalhora.Name = "txtsalhora";
            this.txtsalhora.Size = new System.Drawing.Size(211, 22);
            this.txtsalhora.TabIndex = 20;
            // 
            // txtinss
            // 
            this.txtinss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinss.Location = new System.Drawing.Point(271, 215);
            this.txtinss.Name = "txtinss";
            this.txtinss.Size = new System.Drawing.Size(211, 22);
            this.txtinss.TabIndex = 19;
            // 
            // txtsalbruto
            // 
            this.txtsalbruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalbruto.Location = new System.Drawing.Point(271, 160);
            this.txtsalbruto.Name = "txtsalbruto";
            this.txtsalbruto.Size = new System.Drawing.Size(211, 22);
            this.txtsalbruto.TabIndex = 18;
            // 
            // txtsalliq
            // 
            this.txtsalliq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalliq.Location = new System.Drawing.Point(271, 272);
            this.txtsalliq.Name = "txtsalliq";
            this.txtsalliq.Size = new System.Drawing.Size(211, 22);
            this.txtsalliq.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Salário líquido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "INSS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Salário bruto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Salário hora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Horas trabalhadas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btcalc);
            this.Controls.Add(this.txthorastrab);
            this.Controls.Add(this.txtsalhora);
            this.Controls.Add(this.txtinss);
            this.Controls.Add(this.txtsalbruto);
            this.Controls.Add(this.txtsalliq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btcalc;
        private System.Windows.Forms.TextBox txthorastrab;
        private System.Windows.Forms.TextBox txtsalhora;
        private System.Windows.Forms.TextBox txtinss;
        private System.Windows.Forms.TextBox txtsalbruto;
        private System.Windows.Forms.TextBox txtsalliq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

