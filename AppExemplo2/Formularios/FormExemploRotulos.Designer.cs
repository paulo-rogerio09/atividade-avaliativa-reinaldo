namespace AppExemplo2.Formularios
{
    partial class FormExemploRotulos
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
            this.label4 = new System.Windows.Forms.Label();
            this.calcularbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.salarioatualtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reajustetxt = new System.Windows.Forms.TextBox();
            this.novobtn = new System.Windows.Forms.Button();
            this.respostalb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 37);
            this.label4.TabIndex = 24;
            this.label4.Text = "REAJUSTE SALARIAL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcularbtn
            // 
            this.calcularbtn.Location = new System.Drawing.Point(104, 290);
            this.calcularbtn.Name = "calcularbtn";
            this.calcularbtn.Size = new System.Drawing.Size(75, 23);
            this.calcularbtn.TabIndex = 25;
            this.calcularbtn.Text = "CALCULAR";
            this.calcularbtn.UseVisualStyleBackColor = true;
            this.calcularbtn.Click += new System.EventHandler(this.calcularbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "SALARIO ATUAL";
            // 
            // salarioatualtxt
            // 
            this.salarioatualtxt.Location = new System.Drawing.Point(104, 110);
            this.salarioatualtxt.Name = "salarioatualtxt";
            this.salarioatualtxt.Size = new System.Drawing.Size(174, 20);
            this.salarioatualtxt.TabIndex = 27;
            this.salarioatualtxt.TextChanged += new System.EventHandler(this.salarioatualtxt_TextChanged);
            this.salarioatualtxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.salarioatualtxt_KeyUp);
            this.salarioatualtxt.Leave += new System.EventHandler(this.salarioatualtxt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "% DE REAJUSTE";
            // 
            // reajustetxt
            // 
            this.reajustetxt.Location = new System.Drawing.Point(104, 208);
            this.reajustetxt.Name = "reajustetxt";
            this.reajustetxt.Size = new System.Drawing.Size(174, 20);
            this.reajustetxt.TabIndex = 29;
            this.reajustetxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.reajustetxt_KeyUp);
            this.reajustetxt.Leave += new System.EventHandler(this.reajustetxt_Leave);
            // 
            // novobtn
            // 
            this.novobtn.Location = new System.Drawing.Point(203, 290);
            this.novobtn.Name = "novobtn";
            this.novobtn.Size = new System.Drawing.Size(75, 23);
            this.novobtn.TabIndex = 30;
            this.novobtn.Text = "NOVO";
            this.novobtn.UseVisualStyleBackColor = true;
            this.novobtn.Click += new System.EventHandler(this.novobtn_Click);
            // 
            // respostalb
            // 
            this.respostalb.AutoSize = true;
            this.respostalb.Location = new System.Drawing.Point(113, 343);
            this.respostalb.Name = "respostalb";
            this.respostalb.Size = new System.Drawing.Size(128, 13);
            this.respostalb.TabIndex = 31;
            this.respostalb.Text = "SALARIO REAJUSTADO";
            // 
            // FormExemploRotulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 378);
            this.Controls.Add(this.respostalb);
            this.Controls.Add(this.novobtn);
            this.Controls.Add(this.reajustetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salarioatualtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcularbtn);
            this.Controls.Add(this.label4);
            this.Name = "FormExemploRotulos";
            this.Text = "FormExemploRotulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calcularbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salarioatualtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reajustetxt;
        private System.Windows.Forms.Button novobtn;
        private System.Windows.Forms.Label respostalb;
    }
}