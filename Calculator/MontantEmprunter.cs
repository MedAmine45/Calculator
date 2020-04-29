using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MontantEmprunter : Form
    {
        public MontantEmprunter()
        {
            InitializeComponent();
            return;
        }

       

        private void btnMontantEmprunter_Click(object sender, EventArgs e)
        {

        }

        private void txtMontAchat_TextChanged(object sender, EventArgs e)
        {
            float montantAchat = string.IsNullOrEmpty(txtMontAchat.Text) ? 0 : float.Parse(txtMontAchat.Text);
            txtFraisAchat.Text = (montantAchat * 0.1).ToString();
        }
    }
}
