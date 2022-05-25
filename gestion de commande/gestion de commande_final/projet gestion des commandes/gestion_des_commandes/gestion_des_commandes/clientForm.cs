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
    public partial class clientForm : Form
    {
        public clientForm()
        {
            InitializeComponent();
        }
        public void refresh()
        {
            dgv_clients.DataSource = Program.select_execute("select * from client");
            var nbr_clt = Program.ScalarExecute("select count(*) from client");
            label_nbrcl.Text = nbr_clt.ToString();

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            T_num.Text = "";
            T_nom.Text = "";
            T_adresse.Text = "";
            T_find_num.Text = "";
            T_ville.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string req = string.Format(@"insert into client values('{0}', '{1}', '{2}','{3}')", T_num.Text, T_nom.Text, T_adresse.Text, T_ville.Text);
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
                string req = string.Format(@"delete from client where numc=" + T_num.Text);
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
                string req = string.Format(@"update client set nomc = '{0}' , adresse = '{1}' , ville = '{2}' where numc = {3}", T_nom.Text, T_adresse.Text, T_ville.Text, T_num.Text);
                Program.update_execute(req);
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clientForm_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            try
            {
                string req = string.Format(@"select * from client where numc={0}", T_find_num.Text);
                DataTable dt = new DataTable();
                dt = Program.select_execute(req);
                if (dt.Rows.Count > 0)
                {
                    T_num.Text = T_find_num.Text;
                    T_nom.Text = dt.Rows[0][1].ToString();
                    T_adresse.Text = dt.Rows[0][2].ToString();
                    T_ville.Text = dt.Rows[0][3].ToString();
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



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous Quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
                this.Close(); ;
        }
    }
}
