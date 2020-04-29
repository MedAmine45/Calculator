using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace Calculator
{
    public partial class MontantEmprunter : Form
    {
        private int myLimitMontAchat=50000;
        public MontantEmprunter()
        {
            InitializeComponent();
            dataGridAmortissement.Visible = false;
            return;
        }

        private void btnMontantEmprunter_Click(object sender, EventArgs e)
        {

            try
            {
                decimal montantEmprunter = CalculeMontantEmprunter();
                txtMontEmprunter.Text = montantEmprunter.ToString();
            }
            catch (Exception ex)
            {
                txtFraisAchat.Text = string.Empty;
            }
        }
        private void txtMontAchat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtFraisAchat.Text = CalculeFraisAchat();
              
            }
            catch (Exception ex)
            {
                txtFraisAchat.Text = string.Empty;
            }
          
        }

        private void txtMontAchat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                if (!this.Text.Contains('.'))
                    e.Handled = true;
           else 
                    e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void btnCalculMensualit_Click(object sender, EventArgs e)
        {
            try
            {
                #region calcule Taux d'intérêt mensuel
                decimal tauxInteret = string.IsNullOrEmpty(txtTauxInteret.Text) ? 0 : decimal.Parse(txtTauxInteret.Text) / 100;
                double nbrTauxPow1 = double.Parse((1 + tauxInteret).ToString());
                double nbrTauxPow2 = double.Parse((1.0 / 12.0).ToString());
                double resultInteretPow = Math.Pow(nbrTauxPow1, nbrTauxPow2) - 1;
                decimal tauxInteretMensuel = Math.Round(decimal.Parse(resultInteretPow.ToString()) * 100, 3);
                txtTauxInteretMensuel.Text = string.Concat(tauxInteretMensuel, "%");
                #endregion

                #region calcule Mensualité
                decimal montantEmprunter = string.IsNullOrEmpty(txtMontEmprunter.Text) ? 0 : decimal.Parse(txtMontEmprunter.Text);
                decimal nouveautauxInteretMensuel = 1 + (tauxInteretMensuel/100);
                double doubleNouveauxIntertMensuel = Convert.ToDouble(nouveautauxInteretMensuel);
                double nbrEmprunterPow2 = string.IsNullOrEmpty(txtDuree.Text) ? 0.0 : double.Parse(txtDuree.Text);
                double nbrtaux = Math.Pow(doubleNouveauxIntertMensuel, nbrEmprunterPow2);
                decimal nbdecimal = Convert.ToDecimal(nbrtaux);
                double nbrEmprunterDiv1Pow1 = double.Parse((montantEmprunter * (tauxInteretMensuel/100) * nbdecimal).ToString());
                //double nbrEmprunterPow2 = string.IsNullOrEmpty(txtDuree.Text) ? 0.0 : double.Parse(txtDuree.Text);
                //decimal resultEmprunterPow1 = decimal.Parse((Math.Pow(nbrEmprunterDiv1Pow1, nbrEmprunterPow2)).ToString());
                decimal resultEmprunterPow1 = Convert.ToDecimal(nbrEmprunterDiv1Pow1);


                //double nbrEmprunterDiv2Pow1 = double.Parse((1 + tauxInteretMensuel).ToString());
                //double nbrEmprunterDiv2Pow1 = 
                double res = Math.Pow(doubleNouveauxIntertMensuel, nbrEmprunterPow2) - 1;
                decimal resultEmprunterPow2 = decimal.Parse(res.ToString());

                decimal resultMensualit = Math.Round(resultEmprunterPow1 / resultEmprunterPow2, 2);
                txtMensualite.Text = resultMensualit.ToString();



                //decimal resultMensualit = decimal.Parse("598,48 ");
                //txtMensualite.Text = resultMensualit.ToString();
                #endregion

                #region Load Table Amortissemnt
                LoadAmortissemnt(tauxInteretMensuel, resultMensualit , montantEmprunter);
                #endregion
            }
            catch (Exception ex)
            {

            }
        

           

        }

        private void LoadAmortissemnt(decimal tauxInteretMensuel, decimal mensualite, decimal montantEmprunter)
        {
            List<ItemAmortissemnt> listAmortissemnts = new List<ItemAmortissemnt>();
             double duree = string.IsNullOrEmpty(txtDuree.Text) ? 0.0 : double.Parse(txtDuree.Text);
             decimal endBalance = 0;
             for (var i = 1; i <= duree; i++)
             {
                 ItemAmortissemnt amortissemnt = new ItemAmortissemnt();
                 amortissemnt.Periode = i;
                 amortissemnt.SoldeDebut = i == 1 ? montantEmprunter : endBalance;
                 amortissemnt.Mensualite = mensualite;
                 amortissemnt.Interet = Math.Round(amortissemnt.SoldeDebut * (tauxInteretMensuel / 100), 2);
                 amortissemnt.CapitalRembourse = Math.Round((mensualite - amortissemnt.Interet), 2);
                 endBalance = Math.Round((amortissemnt.SoldeDebut - amortissemnt.CapitalRembourse), 2);
                 amortissemnt.SoldeFin = endBalance;
                 listAmortissemnts.Add(amortissemnt);
             }
             dataGridAmortissement.DataSource = listAmortissemnts;
             dataGridAmortissement.Visible = true;
            

        }
 
        private void ckEditFraisAchats_CheckedChanged(object sender, EventArgs e)
        {
            if(ckEditFraisAchats.Checked)
            {
                txtFraisAchat.ReadOnly = false;
            }
            else
            {
                txtFraisAchat.ReadOnly = true;
                txtFraisAchat.Text=CalculeFraisAchat();
                decimal montantEmprunter = CalculeMontantEmprunter();
                txtMontEmprunter.Text = montantEmprunter.ToString();
            }
        }

        private void txtFraisAchat_TextChanged(object sender, EventArgs e)
        {
            if(ckEditFraisAchats.Checked)
            {
                decimal montantEmprunter = CalculeMontantEmprunter();
                txtMontEmprunter.Text = montantEmprunter.ToString();
            }
        }

        private string CalculeFraisAchat()
        {
            string fraisAchat = string.Empty;
            decimal montantAchat = string.IsNullOrEmpty(txtMontAchat.Text) ? 0 : decimal.Parse(txtMontAchat.Text);
            if (montantAchat > myLimitMontAchat)
                fraisAchat = ((montantAchat * 10) / 100).ToString();

            return fraisAchat;
        }

        private decimal CalculeMontantEmprunter()
        {
            decimal montantAchat = string.IsNullOrEmpty(txtMontAchat.Text) ? 0 : decimal.Parse(txtMontAchat.Text);
            decimal fraisAchat = string.IsNullOrEmpty(txtFraisAchat.Text) ? 0 : decimal.Parse(txtFraisAchat.Text);
            decimal fondPropres = string.IsNullOrEmpty(txtFondPropres.Text) ? 0 : decimal.Parse(txtFondPropres.Text);
            decimal fraisHypotheques = string.IsNullOrEmpty(txtFraisHypotheques.Text) ? 0 : decimal.Parse(txtFraisHypotheques.Text);
            decimal montantEmprunter = montantAchat + fraisAchat - fondPropres + fraisHypotheques;
            return montantEmprunter;
        }

        private void ckEditMontantEmprunter_CheckedChanged(object sender, EventArgs e)
        {
            if(ckEditMontantEmprunter.Checked)
            {
                txtMontEmprunter.ReadOnly = false;
                btnCalculFondPropre.Visible = true;
            }
            else
            {
                txtMontEmprunter.ReadOnly = true;
                btnCalculFondPropre.Visible = false;
                decimal montantEmprunter = CalculeMontantEmprunter();
                txtMontEmprunter.Text = montantEmprunter.ToString();
            }
        }

        private void btnCalculFondPropre_Click(object sender, EventArgs e)
        {
            if(ckEditMontantEmprunter.Checked)
            {
                decimal montantAchat = string.IsNullOrEmpty(txtMontAchat.Text) ? 0 : decimal.Parse(txtMontAchat.Text);
                decimal fraisAchat = string.IsNullOrEmpty(txtFraisAchat.Text) ? 0 : decimal.Parse(txtFraisAchat.Text);
                decimal montEmprunter = string.IsNullOrEmpty(txtMontEmprunter.Text) ? 0 : decimal.Parse(txtMontEmprunter.Text);
                decimal fraisHypotheques = string.IsNullOrEmpty(txtFraisHypotheques.Text) ? 0 : decimal.Parse(txtFraisHypotheques.Text);
                decimal fondPropres = montantAchat + fraisAchat + fraisHypotheques - montEmprunter;
                txtFondPropres.Text = fondPropres.ToString();
            }
        }

        private void MontantEmprunter_Load(object sender, EventArgs e)
        {

        }
    }
}
