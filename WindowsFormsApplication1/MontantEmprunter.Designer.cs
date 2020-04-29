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
            this.ckEditFraisAchats = new System.Windows.Forms.CheckBox();
            this.ckEditMontantEmprunter = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTauxInteret = new System.Windows.Forms.TextBox();
            this.btnCalculMensualit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTauxInteretMensuel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMensualite = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridAmortissement = new System.Windows.Forms.DataGridView();
            this.btnCalculFondPropre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAmortissement)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Montant de l\'achat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(295, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frais d\'achat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Frais d\'hypothèque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fonds propres";
            // 
            // txtMontAchat
            // 
            this.txtMontAchat.Location = new System.Drawing.Point(147, 10);
            this.txtMontAchat.Name = "txtMontAchat";
            this.txtMontAchat.Size = new System.Drawing.Size(100, 20);
            this.txtMontAchat.TabIndex = 4;
            this.txtMontAchat.TextChanged += new System.EventHandler(this.txtMontAchat_TextChanged);
            this.txtMontAchat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontAchat_KeyPress);
            // 
            // txtFondPropres
            // 
            this.txtFondPropres.Location = new System.Drawing.Point(147, 54);
            this.txtFondPropres.Name = "txtFondPropres";
            this.txtFondPropres.Size = new System.Drawing.Size(100, 20);
            this.txtFondPropres.TabIndex = 5;
            // 
            // txtFraisHypotheques
            // 
            this.txtFraisHypotheques.Location = new System.Drawing.Point(452, 54);
            this.txtFraisHypotheques.Name = "txtFraisHypotheques";
            this.txtFraisHypotheques.Size = new System.Drawing.Size(100, 20);
            this.txtFraisHypotheques.TabIndex = 6;
            // 
            // txtFraisAchat
            // 
            this.txtFraisAchat.Location = new System.Drawing.Point(452, 10);
            this.txtFraisAchat.Name = "txtFraisAchat";
            this.txtFraisAchat.ReadOnly = true;
            this.txtFraisAchat.Size = new System.Drawing.Size(100, 20);
            this.txtFraisAchat.TabIndex = 7;
            this.txtFraisAchat.TextChanged += new System.EventHandler(this.txtFraisAchat_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(13, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Montant à emprunter";
            // 
            // txtMontEmprunter
            // 
            this.txtMontEmprunter.Location = new System.Drawing.Point(147, 97);
            this.txtMontEmprunter.Name = "txtMontEmprunter";
            this.txtMontEmprunter.ReadOnly = true;
            this.txtMontEmprunter.Size = new System.Drawing.Size(100, 20);
            this.txtMontEmprunter.TabIndex = 9;
            // 
            // btnMontantEmprunter
            // 
            this.btnMontantEmprunter.Location = new System.Drawing.Point(307, 97);
            this.btnMontantEmprunter.Name = "btnMontantEmprunter";
            this.btnMontantEmprunter.Size = new System.Drawing.Size(75, 23);
            this.btnMontantEmprunter.TabIndex = 10;
            this.btnMontantEmprunter.Text = "Calculer";
            this.btnMontantEmprunter.UseVisualStyleBackColor = true;
            this.btnMontantEmprunter.Click += new System.EventHandler(this.btnMontantEmprunter_Click);
            // 
            // ckEditFraisAchats
            // 
            this.ckEditFraisAchats.AutoSize = true;
            this.ckEditFraisAchats.Location = new System.Drawing.Point(16, 154);
            this.ckEditFraisAchats.Name = "ckEditFraisAchats";
            this.ckEditFraisAchats.Size = new System.Drawing.Size(145, 17);
            this.ckEditFraisAchats.TabIndex = 11;
            this.ckEditFraisAchats.Text = "Modifier les frais d\'achat?";
            this.ckEditFraisAchats.UseVisualStyleBackColor = true;
            this.ckEditFraisAchats.CheckedChanged += new System.EventHandler(this.ckEditFraisAchats_CheckedChanged);
            // 
            // ckEditMontantEmprunter
            // 
            this.ckEditMontantEmprunter.AutoSize = true;
            this.ckEditMontantEmprunter.Location = new System.Drawing.Point(16, 192);
            this.ckEditMontantEmprunter.Name = "ckEditMontantEmprunter";
            this.ckEditMontantEmprunter.Size = new System.Drawing.Size(183, 17);
            this.ckEditMontantEmprunter.TabIndex = 12;
            this.ckEditMontantEmprunter.Text = "Modifier le montant à emprunter ?";
            this.ckEditMontantEmprunter.UseVisualStyleBackColor = true;
            this.ckEditMontantEmprunter.CheckedChanged += new System.EventHandler(this.ckEditMontantEmprunter_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Durée";
            // 
            // txtDuree
            // 
            this.txtDuree.Location = new System.Drawing.Point(147, 245);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(100, 20);
            this.txtDuree.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Taux d\'intérêt annuel(%)";
            // 
            // txtTauxInteret
            // 
            this.txtTauxInteret.Location = new System.Drawing.Point(452, 245);
            this.txtTauxInteret.Name = "txtTauxInteret";
            this.txtTauxInteret.Size = new System.Drawing.Size(100, 20);
            this.txtTauxInteret.TabIndex = 16;
            // 
            // btnCalculMensualit
            // 
            this.btnCalculMensualit.Location = new System.Drawing.Point(574, 296);
            this.btnCalculMensualit.Name = "btnCalculMensualit";
            this.btnCalculMensualit.Size = new System.Drawing.Size(75, 23);
            this.btnCalculMensualit.TabIndex = 18;
            this.btnCalculMensualit.Text = "Calculer";
            this.btnCalculMensualit.UseVisualStyleBackColor = true;
            this.btnCalculMensualit.Click += new System.EventHandler(this.btnCalculMensualit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(13, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Taux d\'intérêt mensuel(%)";
            // 
            // txtTauxInteretMensuel
            // 
            this.txtTauxInteretMensuel.Location = new System.Drawing.Point(147, 292);
            this.txtTauxInteretMensuel.Name = "txtTauxInteretMensuel";
            this.txtTauxInteretMensuel.ReadOnly = true;
            this.txtTauxInteretMensuel.Size = new System.Drawing.Size(100, 20);
            this.txtTauxInteretMensuel.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(295, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mensualité";
            // 
            // txtMensualite
            // 
            this.txtMensualite.Location = new System.Drawing.Point(452, 296);
            this.txtMensualite.Name = "txtMensualite";
            this.txtMensualite.ReadOnly = true;
            this.txtMensualite.Size = new System.Drawing.Size(100, 20);
            this.txtMensualite.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(2, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tableau amortissement";
            // 
            // dataGridAmortissement
            // 
            this.dataGridAmortissement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAmortissement.Location = new System.Drawing.Point(12, 364);
            this.dataGridAmortissement.Name = "dataGridAmortissement";
            this.dataGridAmortissement.Size = new System.Drawing.Size(664, 332);
            this.dataGridAmortissement.TabIndex = 24;
            // 
            // btnCalculFondPropre
            // 
            this.btnCalculFondPropre.Location = new System.Drawing.Point(227, 188);
            this.btnCalculFondPropre.Name = "btnCalculFondPropre";
            this.btnCalculFondPropre.Size = new System.Drawing.Size(164, 23);
            this.btnCalculFondPropre.TabIndex = 25;
            this.btnCalculFondPropre.Text = "Calculer Fond Propre";
            this.btnCalculFondPropre.UseVisualStyleBackColor = true;
            this.btnCalculFondPropre.Visible = false;
            this.btnCalculFondPropre.Click += new System.EventHandler(this.btnCalculFondPropre_Click);
            // 
            // MontantEmprunter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 746);
            this.Controls.Add(this.btnCalculFondPropre);
            this.Controls.Add(this.dataGridAmortissement);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMensualite);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTauxInteretMensuel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCalculMensualit);
            this.Controls.Add(this.txtTauxInteret);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ckEditMontantEmprunter);
            this.Controls.Add(this.ckEditFraisAchats);
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
            this.Load += new System.EventHandler(this.MontantEmprunter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAmortissement)).EndInit();
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
        private System.Windows.Forms.CheckBox ckEditFraisAchats;
        private System.Windows.Forms.CheckBox ckEditMontantEmprunter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTauxInteret;
        private System.Windows.Forms.Button btnCalculMensualit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTauxInteretMensuel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMensualite;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridAmortissement;
        private System.Windows.Forms.Button btnCalculFondPropre;
    }
}