
namespace ProjetoQuiz
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
            this.grupo = new System.Windows.Forms.GroupBox();
            this.lblpergunta = new System.Windows.Forms.Label();
            this.resp1 = new System.Windows.Forms.RadioButton();
            this.resp2 = new System.Windows.Forms.RadioButton();
            this.resp3 = new System.Windows.Forms.RadioButton();
            this.resp4 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpontos = new System.Windows.Forms.Label();
            this.btprox = new System.Windows.Forms.Button();
            this.btiniciar = new System.Windows.Forms.Button();
            this.grupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupo
            // 
            this.grupo.Controls.Add(this.btprox);
            this.grupo.Controls.Add(this.resp4);
            this.grupo.Controls.Add(this.resp3);
            this.grupo.Controls.Add(this.resp2);
            this.grupo.Controls.Add(this.resp1);
            this.grupo.Controls.Add(this.lblpergunta);
            this.grupo.Location = new System.Drawing.Point(40, 56);
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(717, 307);
            this.grupo.TabIndex = 0;
            this.grupo.TabStop = false;
            this.grupo.Text = "groupBox1";
            // 
            // lblpergunta
            // 
            this.lblpergunta.AutoSize = true;
            this.lblpergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpergunta.Location = new System.Drawing.Point(21, 39);
            this.lblpergunta.Name = "lblpergunta";
            this.lblpergunta.Size = new System.Drawing.Size(51, 20);
            this.lblpergunta.TabIndex = 0;
            this.lblpergunta.Text = "label1";
            // 
            // resp1
            // 
            this.resp1.AutoSize = true;
            this.resp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resp1.Location = new System.Drawing.Point(103, 80);
            this.resp1.Name = "resp1";
            this.resp1.Size = new System.Drawing.Size(133, 28);
            this.resp1.TabIndex = 1;
            this.resp1.TabStop = true;
            this.resp1.Text = "radioButton1";
            this.resp1.UseVisualStyleBackColor = true;
            this.resp1.CheckedChanged += new System.EventHandler(this.resp1_CheckedChanged);
            // 
            // resp2
            // 
            this.resp2.AutoSize = true;
            this.resp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resp2.Location = new System.Drawing.Point(103, 119);
            this.resp2.Name = "resp2";
            this.resp2.Size = new System.Drawing.Size(133, 28);
            this.resp2.TabIndex = 2;
            this.resp2.TabStop = true;
            this.resp2.Text = "radioButton2";
            this.resp2.UseVisualStyleBackColor = true;
            this.resp2.CheckedChanged += new System.EventHandler(this.resp2_CheckedChanged);
            // 
            // resp3
            // 
            this.resp3.AutoSize = true;
            this.resp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resp3.Location = new System.Drawing.Point(103, 159);
            this.resp3.Name = "resp3";
            this.resp3.Size = new System.Drawing.Size(133, 28);
            this.resp3.TabIndex = 3;
            this.resp3.TabStop = true;
            this.resp3.Text = "radioButton3";
            this.resp3.UseVisualStyleBackColor = true;
            this.resp3.CheckedChanged += new System.EventHandler(this.resp3_CheckedChanged);
            // 
            // resp4
            // 
            this.resp4.AutoSize = true;
            this.resp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resp4.Location = new System.Drawing.Point(103, 200);
            this.resp4.Name = "resp4";
            this.resp4.Size = new System.Drawing.Size(133, 28);
            this.resp4.TabIndex = 4;
            this.resp4.TabStop = true;
            this.resp4.Text = "radioButton4";
            this.resp4.UseVisualStyleBackColor = true;
            this.resp4.CheckedChanged += new System.EventHandler(this.resp4_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(578, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pontos :";
            // 
            // lblpontos
            // 
            this.lblpontos.AutoSize = true;
            this.lblpontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpontos.Location = new System.Drawing.Point(672, 28);
            this.lblpontos.Name = "lblpontos";
            this.lblpontos.Size = new System.Drawing.Size(24, 25);
            this.lblpontos.TabIndex = 2;
            this.lblpontos.Text = "0";
            // 
            // btprox
            // 
            this.btprox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btprox.Location = new System.Drawing.Point(295, 262);
            this.btprox.Name = "btprox";
            this.btprox.Size = new System.Drawing.Size(132, 39);
            this.btprox.TabIndex = 5;
            this.btprox.Text = "Proxima";
            this.btprox.UseVisualStyleBackColor = true;
            this.btprox.Click += new System.EventHandler(this.btprox_Click);
            // 
            // btiniciar
            // 
            this.btiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btiniciar.Location = new System.Drawing.Point(353, 406);
            this.btiniciar.Name = "btiniciar";
            this.btiniciar.Size = new System.Drawing.Size(99, 32);
            this.btiniciar.TabIndex = 3;
            this.btiniciar.Text = "Iniciar";
            this.btiniciar.UseVisualStyleBackColor = true;
            this.btiniciar.Click += new System.EventHandler(this.btiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btiniciar);
            this.Controls.Add(this.lblpontos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grupo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grupo.ResumeLayout(false);
            this.grupo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grupo;
        private System.Windows.Forms.RadioButton resp4;
        private System.Windows.Forms.RadioButton resp3;
        private System.Windows.Forms.RadioButton resp2;
        private System.Windows.Forms.RadioButton resp1;
        private System.Windows.Forms.Label lblpergunta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblpontos;
        private System.Windows.Forms.Button btprox;
        private System.Windows.Forms.Button btiniciar;
    }
}

