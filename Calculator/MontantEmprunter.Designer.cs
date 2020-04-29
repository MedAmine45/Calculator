namespace Calculator
{
    partial class MontantEmprunter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontAchat = new System.Windows.Forms.TextBox();
            this.txtFondPropres = new System.Windows.Forms.TextBox();
            this.txtFraisHypotheques = new System.Windows.Forms.TextBox();
            this.txtFraisAchat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontEmprunter = new System.Windows.Forms.TextBox();
            this.btnMontantEmprunter = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Montant de l\'achat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(295, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frais d\'achat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Frais d\'hypothèque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fonds propres";
            // 
            // txtMontAchat
            // 
            this.txtMontAchat.Location = new System.Drawing.Point(147, 15);
            this.txtMontAchat.Name = "txtMontAchat";
            this.txtMontAchat.Size = new System.Drawing.Size(100, 20);
            this.txtMontAchat.TabIndex = 4;
            this.txtMontAchat.TextChanged += new System.EventHandler(this.txtMontAchat_TextChanged);
            // 
            // txtFondPropres
            // 
            this.txtFondPropres.Location = new System.Drawing.Point(147, 59);
            this.txtFondPropres.Name = "txtFondPropres";
            this.txtFondPropres.Size = new System.Drawing.Size(100, 20);
            this.txtFondPropres.TabIndex = 5;
            // 
            // txtFraisHypotheques
            // 
            this.txtFraisHypotheques.Location = new System.Drawing.Point(452, 59);
            this.txtFraisHypotheques.Name = "txtFraisHypotheques";
            this.txtFraisHypotheques.Size = new System.Drawing.Size(100, 20);
            this.txtFraisHypotheques.TabIndex = 6;
            // 
            // txtFraisAchat
            // 
            this.txtFraisAchat.Location = new System.Drawing.Point(452, 15);
            this.txtFraisAchat.Name = "txtFraisAchat";
            this.txtFraisAchat.ReadOnly = true;
            this.txtFraisAchat.Size = new System.Drawing.Size(100, 20);
            this.txtFraisAchat.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(13, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Montant à emprunter";
            // 
            // txtMontEmprunter
            // 
            this.txtMontEmprunter.Location = new System.Drawing.Point(147, 102);
            this.txtMontEmprunter.Name = "txtMontEmprunter";
            this.txtMontEmprunter.ReadOnly = true;
            this.txtMontEmprunter.Size = new System.Drawing.Size(100, 20);
            this.txtMontEmprunter.TabIndex = 9;
            // 
            // btnMontantEmprunter
            // 
            this.btnMontantEmprunter.Location = new System.Drawing.Point(298, 100);
            this.btnMontantEmprunter.Name = "btnMontantEmprunter";
            this.btnMontantEmprunter.Size = new System.Drawing.Size(75, 23);
            this.btnMontantEmprunter.TabIndex = 10;
            this.btnMontantEmprunter.Text = "Calculer";
            this.btnMontantEmprunter.UseVisualStyleBackColor = true;
            this.btnMontantEmprunter.Click += new System.EventHandler(this.btnMontantEmprunter_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 159);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(145, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Modifier les frais d\'achat?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(16, 197);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(183, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Modifier le montant à emprunter ?";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Montant de l\'achat";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 250);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Frais d\'hypothèque";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(452, 250);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(574, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Calculer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(13, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Taux d\'intérêt mensuel";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 297);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(295, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mensualité";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(452, 301);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 22;
            // 
            // MontantEmprunter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 375);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnMontantEmprunter);
            this.Controls.Add(this.txtMontEmprunter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFraisAchat);
            this.Controls.Add(this.txtFraisHypotheques);
            this.Controls.Add(this.txtFondPropres);
            this.Controls.Add(this.txtMontAchat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MontantEmprunter";
            this.Text = "MontantEmprunter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontAchat;
        private System.Windows.Forms.TextBox txtFondPropres;
        private System.Windows.Forms.TextBox txtFraisHypotheques;
        private System.Windows.Forms.TextBox txtFraisAchat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMontEmprunter;
        private System.Windows.Forms.Button btnMontantEmprunter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
    }
}