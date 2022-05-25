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
    public partial class FournisseurForm : Form
    {
        public FournisseurForm()
        {
            InitializeComponent();
        }

        public void refresh()
        {
            dgv_f.DataSource = Program.select_execute("select * from fournisseur");
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            T_numF.Text = "";
            T_nomF.Text = "";
            T_find_numF.Text = "";
            T_villeF.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string req = string.Format(@"insert into fournisseur values('{0}', '{1}', '{2}')", T_numF.Text, T_nomF.Text, T_villeF.Text);
                Program.update_execute(req);
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string req = string.Format(@"delete from fournisseur where numf=" + T_numF.Text);
                Program.update_execute(req);
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            try
            {
                string req = string.Format(@"update fournisseur set nomf = '{0}' , ville = '{1}' where numf = {2}", T_nomF.Text, T_villeF.Text, T_numF.Text);
                Program.update_execute(req);
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            try
            {
                string req = string.Format(@"select * from fournisseur where numf={0}", T_find_numF.Text);
                DataTable dt = new DataTable();
                dt = Program.select_execute(req);
                if (dt.Rows.Count > 0)
                {
                    T_numF.Text = T_find_numF.Text;
                    T_nomF.Text = dt.Rows[0][1].ToString();
                    T_villeF.Text = dt.Rows[0][2].ToString();
                }
                else
                {
                    MessageBox.Show("introuvable");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FournisseurForm_Load(object sender, EventArgs e)
        {
            var nbr_f = Program.ScalarExecute("select count(*) from fournisseur");
            label_nbrf.Text = nbr_f.ToString();
            refresh();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous Quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
