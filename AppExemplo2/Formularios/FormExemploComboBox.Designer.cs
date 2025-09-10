namespace AppExemplo2.Formularios
{
    partial class FormExemploComboBox
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
            this.clientecb = new System.Windows.Forms.ComboBox();
            this.calcularbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.valortxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descontotxt = new System.Windows.Forms.TextBox();
            this.resultadotxt = new System.Windows.Forms.TextBox();
            this.percentuallb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.novobtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 37);
            this.label4.TabIndex = 25;
            this.label4.Text = "SISTEMA DE DESCONTOS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientecb
            // 
            this.clientecb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.clientecb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.clientecb.FormattingEnabled = true;
            this.clientecb.Items.AddRange(new object[] {
            "Cliente Diamante: 25%",
            "Cliente Ouro: 20%",
            "Cliente VIP: 15%",
            "Cliente Comum: 10%",
            "Cliente Aleatório: (Percentual Livre)"});
            this.clientecb.Location = new System.Drawing.Point(103, 99);
            this.clientecb.Name = "clientecb";
            this.clientecb.Size = new System.Drawing.Size(121, 21);
            this.clientecb.TabIndex = 26;
            this.clientecb.SelectedIndexChanged += new System.EventHandler(this.clientecb_SelectedIndexChanged);
            // 
            // calcularbtn
            // 
            this.calcularbtn.Location = new System.Drawing.Point(45, 309);
            this.calcularbtn.Name = "calcularbtn";
            this.calcularbtn.Size = new System.Drawing.Size(75, 23);
            this.calcularbtn.TabIndex = 27;
            this.calcularbtn.Text = "CALCULAR";
            this.calcularbtn.UseVisualStyleBackColor = true;
            this.calcularbtn.Click += new System.EventHandler(this.calcularbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "SELECIONE O TIPO DE CLIENTE";
            // 
            // valortxt
            // 
            this.valortxt.Location = new System.Drawing.Point(103, 184);
            this.valortxt.Name = "valortxt";
            this.valortxt.Size = new System.Drawing.Size(121, 20);
            this.valortxt.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "VALOR DA COMPRA";
            // 
            // descontotxt
            // 
            this.descontotxt.Location = new System.Drawing.Point(103, 240);
            this.descontotxt.Name = "descontotxt";
            this.descontotxt.Size = new System.Drawing.Size(121, 20);
            this.descontotxt.TabIndex = 31;
            this.descontotxt.TextChanged += new System.EventHandler(this.descontotxt_TextChanged);
            // 
            // resultadotxt
            // 
            this.resultadotxt.Location = new System.Drawing.Point(103, 371);
            this.resultadotxt.Name = "resultadotxt";
            this.resultadotxt.Size = new System.Drawing.Size(121, 20);
            this.resultadotxt.TabIndex = 32;
            // 
            // percentuallb
            // 
            this.percentuallb.AutoSize = true;
            this.percentuallb.Location = new System.Drawing.Point(100, 224);
            this.percentuallb.Name = "percentuallb";
            this.percentuallb.Size = new System.Drawing.Size(96, 13);
            this.percentuallb.TabIndex = 33;
            this.percentuallb.Text = "% DE DESCONTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "VALOR COM DESCONTO";
            // 
            // novobtn
            // 
            this.novobtn.Location = new System.Drawing.Point(197, 309);
            this.novobtn.Name = "novobtn";
            this.novobtn.Size = new System.Drawing.Size(75, 23);
            this.novobtn.TabIndex = 35;
            this.novobtn.Text = "NOVO";
            this.novobtn.UseVisualStyleBackColor = true;
            // 
            // FormExemploComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 479);
            this.Controls.Add(this.novobtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.percentuallb);
            this.Controls.Add(this.resultadotxt);
            this.Controls.Add(this.descontotxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valortxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcularbtn);
            this.Controls.Add(this.clientecb);
            this.Controls.Add(this.label4);
            this.Name = "FormExemploComboBox";
            this.Text = "FormExemploComboBox";
            this.Load += new System.EventHandler(this.FormExemploComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox clientecb;
        private System.Windows.Forms.Button calcularbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valortxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descontotxt;
        private System.Windows.Forms.TextBox resultadotxt;
        private System.Windows.Forms.Label percentuallb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button novobtn;
    }
}