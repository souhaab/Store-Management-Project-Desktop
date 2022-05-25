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
    public partial class commandes : Form
    {
        public commandes()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //ajouter l'article dans dgv
            decimal montant = decimal.Parse(T_prix_prod.Text) * decimal.Parse(t_qtte_c.Text);
            dgv_commande.Rows.Add(T_code_prod.Text, combodesc.Text, t_qtte_c.Text, T_prix_prod.Text, montant);
            t_totale_p.Text = prixTotale().ToString();

        }

        private void btn_supp_article_Click(object sender, EventArgs e)
        {
            int rowIndex = dgv_commande.CurrentCell.RowIndex;
            dgv_commande.Rows.RemoveAt(rowIndex);
            t_totale_p.Text = prixTotale().ToString();
        }
        public decimal prixTotale()
        {
            decimal total_price = 0;
            for (int i = 0; i < dgv_commande.Rows.Count; i++)
            {
                total_price += decimal.Parse(dgv_commande.Rows[i].Cells["montant"].Value.ToString());

            }



            return total_price;

        }
        private void combodesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //afficher les infos des produits selectionner
            string req = string.Format(@"select * from produit");
            DataTable dt = new DataTable();
            dt = Program.select_execute(req);
            T_code_prod.Text = dt.Rows[combodesc.SelectedIndex][0].ToString();
            T_prix_prod.Text = dt.Rows[combodesc.SelectedIndex][2].ToString();
        }

        private void commandes_Load(object sender, EventArgs e)
        {
            //charger le combo_nul_cl par les numéro
            combo_num_cl.DataSource = Program.select_execute("select * from client ");
            combo_num_cl.DisplayMember = "numc";



            //charger combo_article par les désignation
            combodesc.DataSource = Program.select_execute("select * from produit order by nump desc");
            combodesc.DisplayMember = "descriptionp";




            dgv_commande.Columns.Add("num_prod", "numéro");
            dgv_commande.Columns.Add("desc_prod", "description");
            dgv_commande.Columns.Add("qtte_prod", "quantité produit");
            dgv_commande.Columns.Add("prix_prod", "prix unitaire");
            dgv_commande.Columns.Add("montant", "Montant");

            //par default quantité =1
            t_qtte_c.Text = 1.ToString();
        }

        private void combo_num_cl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //afficher les infos des client selectionner
            string req = string.Format(@"select * from client");
            DataTable dt = new DataTable();
            dt = Program.select_execute(req);
            T_nom_cl.Text = dt.Rows[combo_num_cl.SelectedIndex][1].ToString();
            T_ville_cl.Text = dt.Rows[combo_num_cl.SelectedIndex][3].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime DateValue = Convert.ToDateTime(date_comd.Text);
            int client = int.Parse(combo_num_cl.Text);
            int num = int.Parse(t_num_cmd.Text);
            int resultat;
            resultat = Program.ps_insert_cmd(num, DateValue, client);
            if (resultat == 1)
                MessageBox.Show("order number exists already");
            else
                for (int i = 0; i < dgv_commande.Rows.Count; i++)
                {
                    int nump = int.Parse(dgv_commande.Rows[i].Cells["nump"].Value.ToString());
                    int qtte = int.Parse(dgv_commande.Rows[i].Cells["qtte"].Value.ToString());
                    string req = string.Format("insert into contenue values( {0},{1},{2})", num, nump, qtte);
                    Program.update_execute(req);
                    MessageBox.Show("order added with success");
                }
            //empty the dgv and the textboxes
            dgv_commande.Rows.Clear();
            t_num_cmd.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous Quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
