namespace AppExemplo2
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
            this.btAlerta = new System.Windows.Forms.Button();
            this.btExemploAlerta = new System.Windows.Forms.Button();
            this.btAlteracaoRotulo = new System.Windows.Forms.Button();
            this.btComboBox = new System.Windows.Forms.Button();
            this.btCalculoDeArea = new System.Windows.Forms.Button();
            this.jurosbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU DE OPÇÕES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAlerta
            // 
            this.btAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlerta.Location = new System.Drawing.Point(87, 91);
            this.btAlerta.Name = "btAlerta";
            this.btAlerta.Size = new System.Drawing.Size(405, 35);
            this.btAlerta.TabIndex = 1;
            this.btAlerta.Text = "ALERTAS";
            this.btAlerta.UseVisualStyleBackColor = false;
            this.btAlerta.Click += new System.EventHandler(this.btAlerta_Click);
            // 
            // btExemploAlerta
            // 
            this.btExemploAlerta.BackColor = System.Drawing.Color.Salmon;
            this.btExemploAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExemploAlerta.Location = new System.Drawing.Point(87, 158);
            this.btExemploAlerta.Name = "btExemploAlerta";
            this.btExemploAlerta.Size = new System.Drawing.Size(405, 35);
            this.btExemploAlerta.TabIndex = 2;
            this.btExemploAlerta.Text = "EXEMPLO COM ALERTA";
            this.btExemploAlerta.UseVisualStyleBackColor = false;
            this.btExemploAlerta.Click += new System.EventHandler(this.btExemploAlerta_Click);
            // 
            // btAlteracaoRotulo
            // 
            this.btAlteracaoRotulo.BackColor = System.Drawing.Color.YellowGreen;
            this.btAlteracaoRotulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlteracaoRotulo.Location = new System.Drawing.Point(87, 237);
            this.btAlteracaoRotulo.Name = "btAlteracaoRotulo";
            this.btAlteracaoRotulo.Size = new System.Drawing.Size(405, 35);
            this.btAlteracaoRotulo.TabIndex = 3;
            this.btAlteracaoRotulo.Text = "EXEMPLO ALTERAÇÃO DE RÓTULO";
            this.btAlteracaoRotulo.UseVisualStyleBackColor = false;
            this.btAlteracaoRotulo.Click += new System.EventHandler(this.btAlteracaoRotulo_Click);
            // 
            // btComboBox
            // 
            this.btComboBox.BackColor = System.Drawing.Color.SteelBlue;
            this.btComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComboBox.Location = new System.Drawing.Point(87, 319);
            this.btComboBox.Name = "btComboBox";
            this.btComboBox.Size = new System.Drawing.Size(405, 35);
            this.btComboBox.TabIndex = 4;
            this.btComboBox.Text = "EXEMPLO COM COMBOBOX";
            this.btComboBox.UseVisualStyleBackColor = false;
            this.btComboBox.Click += new System.EventHandler(this.btComboBox_Click);
            // 
            // btCalculoDeArea
            // 
            this.btCalculoDeArea.BackColor = System.Drawing.Color.DarkOrange;
            this.btCalculoDeArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalculoDeArea.Location = new System.Drawing.Point(87, 400);
            this.btCalculoDeArea.Name = "btCalculoDeArea";
            this.btCalculoDeArea.Size = new System.Drawing.Size(405, 35);
            this.btCalculoDeArea.TabIndex = 5;
            this.btCalculoDeArea.Text = "EXEMPLO CÁLCULO DE ÁREA";
            this.btCalculoDeArea.UseVisualStyleBackColor = false;
            this.btCalculoDeArea.Click += new System.EventHandler(this.btCalculoDeArea_Click);
            // 
            // jurosbtn
            // 
            this.jurosbtn.Location = new System.Drawing.Point(87, 469);
            this.jurosbtn.Name = "jurosbtn";
            this.jurosbtn.Size = new System.Drawing.Size(405, 23);
            this.jurosbtn.TabIndex = 7;
            this.jurosbtn.Text = "CALCULO DE JUROS";
            this.jurosbtn.UseVisualStyleBackColor = true;
            this.jurosbtn.Click += new System.EventHandler(this.jurosbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 548);
            this.Controls.Add(this.jurosbtn);
            this.Controls.Add(this.btCalculoDeArea);
            this.Controls.Add(this.btComboBox);
            this.Controls.Add(this.btAlteracaoRotulo);
            this.Controls.Add(this.btExemploAlerta);
            this.Controls.Add(this.btAlerta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAlerta;
        private System.Windows.Forms.Button btExemploAlerta;
        private System.Windows.Forms.Button btAlteracaoRotulo;
        private System.Windows.Forms.Button btComboBox;
        private System.Windows.Forms.Button btCalculoDeArea;
        private System.Windows.Forms.Button jurosbtn;
    }
}

