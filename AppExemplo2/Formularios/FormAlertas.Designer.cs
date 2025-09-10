namespace AppExemplo2.Formularios
{
    partial class FormAlertas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btInformacao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btAtencao = new System.Windows.Forms.Button();
            this.btErro = new System.Windows.Forms.Button();
            this.btPergunta = new System.Windows.Forms.Button();
            this.btExemplo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btInformacao
            // 
            this.btInformacao.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInformacao.Location = new System.Drawing.Point(250, 66);
            this.btInformacao.Name = "btInformacao";
            this.btInformacao.Size = new System.Drawing.Size(296, 40);
            this.btInformacao.TabIndex = 0;
            this.btInformacao.Text = "INFORMAÇÃO";
            this.btInformacao.UseVisualStyleBackColor = false;
            this.btInformacao.Click += new System.EventHandler(this.btInformacao_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(767, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALERTAS DE INTERAÇÃO COM  USUÁRIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAtencao
            // 
            this.btAtencao.BackColor = System.Drawing.Color.Orange;
            this.btAtencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtencao.Location = new System.Drawing.Point(250, 144);
            this.btAtencao.Name = "btAtencao";
            this.btAtencao.Size = new System.Drawing.Size(296, 40);
            this.btAtencao.TabIndex = 2;
            this.btAtencao.Text = "ATENÇÃO";
            this.btAtencao.UseVisualStyleBackColor = false;
            this.btAtencao.Click += new System.EventHandler(this.btAtencao_Click);
            // 
            // btErro
            // 
            this.btErro.BackColor = System.Drawing.Color.OrangeRed;
            this.btErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btErro.Location = new System.Drawing.Point(250, 221);
            this.btErro.Name = "btErro";
            this.btErro.Size = new System.Drawing.Size(296, 40);
            this.btErro.TabIndex = 3;
            this.btErro.Text = "ERRO";
            this.btErro.UseVisualStyleBackColor = false;
            this.btErro.Click += new System.EventHandler(this.btErro_Click);
            // 
            // btPergunta
            // 
            this.btPergunta.BackColor = System.Drawing.Color.YellowGreen;
            this.btPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPergunta.Location = new System.Drawing.Point(250, 297);
            this.btPergunta.Name = "btPergunta";
            this.btPergunta.Size = new System.Drawing.Size(296, 40);
            this.btPergunta.TabIndex = 4;
            this.btPergunta.Text = "PERGUNTA";
            this.btPergunta.UseVisualStyleBackColor = false;
            this.btPergunta.Click += new System.EventHandler(this.btPergunta_Click);
            // 
            // btExemplo
            // 
            this.btExemplo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExemplo.Location = new System.Drawing.Point(250, 385);
            this.btExemplo.Name = "btExemplo";
            this.btExemplo.Size = new System.Drawing.Size(296, 40);
            this.btExemplo.TabIndex = 5;
            this.btExemplo.Text = "EXEMPLO";
            this.btExemplo.UseVisualStyleBackColor = true;
            this.btExemplo.Click += new System.EventHandler(this.btExemplo_Click);
            // 
            // FormAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExemplo);
            this.Controls.Add(this.btPergunta);
            this.Controls.Add(this.btErro);
            this.Controls.Add(this.btAtencao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btInformacao);
            this.Name = "FormAlertas";
            this.Text = "FormAlertas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btInformacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAtencao;
        private System.Windows.Forms.Button btErro;
        private System.Windows.Forms.Button btPergunta;
        private System.Windows.Forms.Button btExemplo;
    }
}