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
    public partial class ProduitForm : Form
    {
        public ProduitForm()
        {
            InitializeComponent();
        }
        public BindingSource BS = new BindingSource();
        public void actualiser()
        {
            string req = string.Format("select * from produit ");
            BS.DataSource = Program.select_execute(req);

            lbl_nbrtotale.Text = Program.ScalarExecute("select count(*) from produit ").ToString();

        }
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            Program.update_execute(string.Format("update produit set descriptionp = '{0}',prixht={1} ,fournisseur= {2} from produit  where nump = {3} ", t_description.Text, t_prix.Text, comboBox_fournisseur.Text, t_num.Text));
            MessageBox.Show("modified with success");
            actualiser();
        }

        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            if (btn_nouveau.Text == "Nouveau")
            {
                t_num.Text = "";
                t_description.Text = "";
                t_prix.Text = "";
                comboBox_fournisseur.Text = "";
                
                btn_nouveau.Text = "Ajouter";

            }
            else
            {
                btn_nouveau.Text = "Ajouter";
                Program.update_execute(string.Format("insert into produit (nump,descriptionP,prixht,fournisseur) values({0},'{1}','{2}',{3} )", t_num.Text, t_description.Text, t_prix.Text, comboBox_fournisseur.Text));
                MessageBox.Show("added with success");
                actualiser();
                btn_nouveau.Text = "Nouveau";
            }
        }


        private void btn_ok_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Program.select_execute(string.Format("select * from produit  where nump = {0} ", t_find_num.Text));
            if (dt.Rows.Count != 0)
            {
                t_num.Text = dt.Rows[0][0].ToString();
                t_description.Text = dt.Rows[0][1].ToString();
                t_prix.Text = dt.Rows[0][2].ToString();
                comboBox_fournisseur.Text = dt.Rows[0][4].ToString();
            }
            else
            {
                MessageBox.Show("not found");
            }

        }

        private void btn_premier_Click(object sender, EventArgs e)
        {

            BS.MoveFirst();
            lbl_nbr.Text = (BS.Position + 1).ToString();
        }

        private void btn_prec_Click(object sender, EventArgs e)
        {
            BS.MovePrevious();
            lbl_nbr.Text = (BS.Position + 1).ToString();
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            BS.MoveNext();
            lbl_nbr.Text = (BS.Position + 1).ToString();
        }

        private void btn_derniere_Click(object sender, EventArgs e)
        {
            BS.MoveLast();
            lbl_nbr.Text = (BS.Position + 1).ToString();
        }

        private void ProduitForm_Load(object sender, EventArgs e)
        {
            actualiser();
            t_num.DataBindings.Add(new Binding("text", BS, "nump"));
            t_description.DataBindings.Add(new Binding("text", BS, "descriptionp"));
            t_prix.DataBindings.Add(new Binding("text", BS, "prixht"));
            comboBox_fournisseur.DataBindings.Add(new Binding("text", BS, "fournisseur"));
            comboBox_fournisseur.DisplayMember = "numf";
            comboBox_fournisseur.ValueMember = "numf";
            comboBox_fournisseur.DataSource = Program.select_execute(string.Format("select * from fournisseur "));
        }

        private void comboBox_fournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = Program.select_execute(string.Format(@"select * from fournisseur where numf = {0} ", comboBox_fournisseur.SelectedValue));
            lbl_ville.Text = dt.Rows[0][2].ToString();
            lbl_num.Text = dt.Rows[0][1].ToString();
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            Program.update_execute(string.Format("delete produit  where nump ={0} ", t_num.Text));
            MessageBox.Show("deleted with success");
            actualiser();
        }

        private void t_num_TextChanged(object sender, EventArgs e)
        {
            lbl_nbr.Text = t_num.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous Quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
