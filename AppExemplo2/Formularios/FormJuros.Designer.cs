namespace AppExemplo2.Formularios
{
    partial class FormJuros
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
            this.calcularbtn = new System.Windows.Forms.Button();
            this.escolhacb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.montantetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.capitaltxt = new System.Windows.Forms.TextBox();
            this.taxatxt = new System.Windows.Forms.TextBox();
            this.tempotxt = new System.Windows.Forms.TextBox();
            this.jurostxt = new System.Windows.Forms.TextBox();
            this.novobtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcularbtn
            // 
            this.calcularbtn.Location = new System.Drawing.Point(71, 397);
            this.calcularbtn.Name = "calcularbtn";
            this.calcularbtn.Size = new System.Drawing.Size(75, 23);
            this.calcularbtn.TabIndex = 0;
            this.calcularbtn.Text = "CALCULAR";
            this.calcularbtn.UseVisualStyleBackColor = true;
            this.calcularbtn.Click += new System.EventHandler(this.calcularbtn_Click);
            // 
            // escolhacb
            // 
            this.escolhacb.FormattingEnabled = true;
            this.escolhacb.Items.AddRange(new object[] {
            "Calcular o montante simples:",
            "Calcular o capital:",
            "Calcular a taxa:",
            "Calcular o tempo:"});
            this.escolhacb.Location = new System.Drawing.Point(108, 85);
            this.escolhacb.Name = "escolhacb";
            this.escolhacb.Size = new System.Drawing.Size(252, 21);
            this.escolhacb.TabIndex = 1;
            this.escolhacb.SelectedIndexChanged += new System.EventHandler(this.escolhacb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CALCULO DE JUROS";
            // 
            // montantetxt
            // 
            this.montantetxt.Location = new System.Drawing.Point(205, 155);
            this.montantetxt.Name = "montantetxt";
            this.montantetxt.Size = new System.Drawing.Size(100, 20);
            this.montantetxt.TabIndex = 3;
            this.montantetxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.montantetxt_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MONTANTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CAPITAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TAXA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "TEMPO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "JUROS";
            // 
            // capitaltxt
            // 
            this.capitaltxt.Location = new System.Drawing.Point(205, 193);
            this.capitaltxt.Name = "capitaltxt";
            this.capitaltxt.Size = new System.Drawing.Size(100, 20);
            this.capitaltxt.TabIndex = 9;
            this.capitaltxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.capitaltxt_KeyUp);
            // 
            // taxatxt
            // 
            this.taxatxt.Location = new System.Drawing.Point(205, 231);
            this.taxatxt.Name = "taxatxt";
            this.taxatxt.Size = new System.Drawing.Size(100, 20);
            this.taxatxt.TabIndex = 10;
            this.taxatxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.taxatxt_KeyUp);
            // 
            // tempotxt
            // 
            this.tempotxt.Location = new System.Drawing.Point(205, 277);
            this.tempotxt.Name = "tempotxt";
            this.tempotxt.Size = new System.Drawing.Size(100, 20);
            this.tempotxt.TabIndex = 11;
            this.tempotxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tempotxt_KeyUp);
            // 
            // jurostxt
            // 
            this.jurostxt.Location = new System.Drawing.Point(205, 316);
            this.jurostxt.Name = "jurostxt";
            this.jurostxt.Size = new System.Drawing.Size(100, 20);
            this.jurostxt.TabIndex = 12;
            // 
            // novobtn
            // 
            this.novobtn.Location = new System.Drawing.Point(297, 397);
            this.novobtn.Name = "novobtn";
            this.novobtn.Size = new System.Drawing.Size(75, 23);
            this.novobtn.TabIndex = 13;
            this.novobtn.Text = "NOVO";
            this.novobtn.UseVisualStyleBackColor = true;
            this.novobtn.Click += new System.EventHandler(this.novobtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "SELECIONE QUAL VOCE QUER CALCULAR";
            // 
            // FormJuros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.novobtn);
            this.Controls.Add(this.jurostxt);
            this.Controls.Add(this.tempotxt);
            this.Controls.Add(this.taxatxt);
            this.Controls.Add(this.capitaltxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.montantetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.escolhacb);
            this.Controls.Add(this.calcularbtn);
            this.Name = "FormJuros";
            this.Text = "FormJuros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcularbtn;
        private System.Windows.Forms.ComboBox escolhacb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox montantetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox capitaltxt;
        private System.Windows.Forms.TextBox taxatxt;
        private System.Windows.Forms.TextBox tempotxt;
        private System.Windows.Forms.TextBox jurostxt;
        private System.Windows.Forms.Button novobtn;
        private System.Windows.Forms.Label label7;
    }
}