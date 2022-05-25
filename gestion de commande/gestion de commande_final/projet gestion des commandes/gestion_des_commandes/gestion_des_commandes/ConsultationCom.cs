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
    public partial class ConsultationCom : Form
    {
        public ConsultationCom()
        {
            InitializeComponent();
        }
        public void Actualiser()
        {
            Client c = new Client(int.Parse(combo_client.Text));
            tb_ca.Text = c.CA_client().ToString();

        }
        private void ConsultationCom_Load(object sender, EventArgs e)
        {
            combo_client.DisplayMember = "numc";
            combo_client.ValueMember = "nomc";
            combo_client.DataSource = Client.listeClient();

        }

        private void combo_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client c = Client.RechercherClient(int.Parse(combo_client.Text));
            tb_nom.Text = c.Nom;
            tb_ville.Text = c.Ville;
            dgv_cmd.DataSource = Client.CommandesClient(int.Parse(combo_client.Text));
            Actualiser();
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            consultation_commande com = new consultation_commande(int.Parse(dgv_cmd.CurrentCell.Value.ToString()));
            com.supprimerCommnade();
            Actualiser();
        }

        private void dgv_cmd_Click(object sender, EventArgs e)
        {

            consultation_commande com = new consultation_commande(int.Parse(dgv_cmd.CurrentCell.Value.ToString()));
            tb_total.Text = com.Total().ToString();

            tb_tva.Text = com.TVA().ToString();

            tb_pht.Text = com.TTC().ToString();

            dgv_detailcmd.DataSource = com.Detail_commande();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous Quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
