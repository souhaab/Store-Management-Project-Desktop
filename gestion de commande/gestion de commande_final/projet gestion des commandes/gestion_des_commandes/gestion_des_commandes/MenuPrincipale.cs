using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_des_commandes
{
    public partial class MenuPrincipale : Form
    {
        public MenuPrincipale()
        {
            InitializeComponent();
        }

        private void MenuPrincipale_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous Quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Form f_client = new clientForm();
            f_client.Show();

        }

        private void buttonFourniseur_Click(object sender, EventArgs e)
        {
            Form f_fourn = new FournisseurForm();
            f_fourn.Show();
        }

        private void buttonProduit_Click(object sender, EventArgs e)
        {
            Form f_prod = new ProduitForm();
            f_prod.Show();
        }

        private void btnGestionCommande_Click(object sender, EventArgs e)
        {
            Form f_cmds = new commandes();
            f_cmds.Show();
        }

        private void btn_consultation_Click(object sender, EventArgs e)
        {
            Form f_cons = new ConsultationCom();
            f_cons.Show();


        }
    }
}
