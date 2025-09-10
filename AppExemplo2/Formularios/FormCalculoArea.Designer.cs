namespace AppExemplo2.Formularios
{
    partial class FormCalculoArea
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
            this.label5 = new System.Windows.Forms.Label();
            this.arealb = new System.Windows.Forms.Label();
            this.hipotenusalb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.areatxt = new System.Windows.Forms.TextBox();
            this.hipotenusatxt = new System.Windows.Forms.TextBox();
            this.ladobtxt = new System.Windows.Forms.TextBox();
            this.ladoatxt = new System.Windows.Forms.TextBox();
            this.novobtn = new System.Windows.Forms.Button();
            this.tipocalculocb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(440, 37);
            this.label4.TabIndex = 36;
            this.label4.Text = "CÁLCULO TRIÂNGULO RETÂNGULO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcularbtn
            // 
            this.calcularbtn.Location = new System.Drawing.Point(129, 410);
            this.calcularbtn.Name = "calcularbtn";
            this.calcularbtn.Size = new System.Drawing.Size(75, 23);
            this.calcularbtn.TabIndex = 49;
            this.calcularbtn.Text = "CALCULAR";
            this.calcularbtn.UseVisualStyleBackColor = true;
            this.calcularbtn.Click += new System.EventHandler(this.calcularbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "LADO A (CATETO)";
            // 
            // arealb
            // 
            this.arealb.AutoSize = true;
            this.arealb.Location = new System.Drawing.Point(118, 316);
            this.arealb.Name = "arealb";
            this.arealb.Size = new System.Drawing.Size(60, 13);
            this.arealb.TabIndex = 46;
            this.arealb.Text = "AREA (M2)";
            // 
            // hipotenusalb
            // 
            this.hipotenusalb.AutoSize = true;
            this.hipotenusalb.Location = new System.Drawing.Point(118, 260);
            this.hipotenusalb.Name = "hipotenusalb";
            this.hipotenusalb.Size = new System.Drawing.Size(125, 13);
            this.hipotenusalb.TabIndex = 45;
            this.hipotenusalb.Text = "LADO C (HIPOTENUSA)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "LADO B (CATETO)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "SELECIONE O TIPO DE CALCULO";
            // 
            // areatxt
            // 
            this.areatxt.Location = new System.Drawing.Point(121, 332);
            this.areatxt.Name = "areatxt";
            this.areatxt.Size = new System.Drawing.Size(195, 20);
            this.areatxt.TabIndex = 42;
            // 
            // hipotenusatxt
            // 
            this.hipotenusatxt.Location = new System.Drawing.Point(121, 276);
            this.hipotenusatxt.Name = "hipotenusatxt";
            this.hipotenusatxt.Size = new System.Drawing.Size(195, 20);
            this.hipotenusatxt.TabIndex = 41;
            this.hipotenusatxt.TextChanged += new System.EventHandler(this.hipotenusatxt_TextChanged);
            this.hipotenusatxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.hipotenusatxt_KeyUp);
            this.hipotenusatxt.Leave += new System.EventHandler(this.hipotenusatxt_leave);
            // 
            // ladobtxt
            // 
            this.ladobtxt.Location = new System.Drawing.Point(121, 229);
            this.ladobtxt.Name = "ladobtxt";
            this.ladobtxt.Size = new System.Drawing.Size(195, 20);
            this.ladobtxt.TabIndex = 40;
            this.ladobtxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ladobtxt_keyup);
            this.ladobtxt.Leave += new System.EventHandler(this.ladobtxt_leave);
            // 
            // ladoatxt
            // 
            this.ladoatxt.Location = new System.Drawing.Point(121, 181);
            this.ladoatxt.Name = "ladoatxt";
            this.ladoatxt.Size = new System.Drawing.Size(195, 20);
            this.ladoatxt.TabIndex = 39;
            this.ladoatxt.TextChanged += new System.EventHandler(this.ladoatxt_TextChanged);
            this.ladoatxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ladoatxt_keyup);
            this.ladoatxt.Leave += new System.EventHandler(this.ladoatxt_leave);
            // 
            // novobtn
            // 
            this.novobtn.Location = new System.Drawing.Point(254, 410);
            this.novobtn.Name = "novobtn";
            this.novobtn.Size = new System.Drawing.Size(75, 23);
            this.novobtn.TabIndex = 38;
            this.novobtn.Text = "NOVO";
            this.novobtn.UseVisualStyleBackColor = true;
            this.novobtn.Click += new System.EventHandler(this.novobtn_Click);
            // 
            // tipocalculocb
            // 
            this.tipocalculocb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tipocalculocb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tipocalculocb.FormattingEnabled = true;
            this.tipocalculocb.Items.AddRange(new object[] {
            "CALCULAR AREA",
            "DESCOBRIR LADO A",
            "DESCOBRIR LADO B ",
            "DESCOBRIR LADO C"});
            this.tipocalculocb.Location = new System.Drawing.Point(121, 142);
            this.tipocalculocb.Name = "tipocalculocb";
            this.tipocalculocb.Size = new System.Drawing.Size(195, 21);
            this.tipocalculocb.TabIndex = 37;
            this.tipocalculocb.SelectedIndexChanged += new System.EventHandler(this.tipocalculocb_SelectedIndexChanged);
            // 
            // FormCalculoArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 520);
            this.Controls.Add(this.calcularbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.arealb);
            this.Controls.Add(this.hipotenusalb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.areatxt);
            this.Controls.Add(this.hipotenusatxt);
            this.Controls.Add(this.ladobtxt);
            this.Controls.Add(this.ladoatxt);
            this.Controls.Add(this.novobtn);
            this.Controls.Add(this.tipocalculocb);
            this.Controls.Add(this.label4);
            this.Name = "FormCalculoArea";
            this.Text = "FormCalculoArea";
            this.Load += new System.EventHandler(this.FormCalculoArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calcularbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label arealb;
        private System.Windows.Forms.Label hipotenusalb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox areatxt;
        private System.Windows.Forms.TextBox hipotenusatxt;
        private System.Windows.Forms.TextBox ladobtxt;
        private System.Windows.Forms.TextBox ladoatxt;
        private System.Windows.Forms.Button novobtn;
        private System.Windows.Forms.ComboBox tipocalculocb;
    }
}