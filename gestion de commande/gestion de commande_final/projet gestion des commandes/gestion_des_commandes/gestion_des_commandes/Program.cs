using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace gestion_des_commandes
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuPrincipale());
        }

        public static SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-SGMND3D\SQLEXPRESS;Initial Catalog=gestion_des_commandes1;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand("", cnx);

        public static DataTable select_execute(string requete)
        {
            try
            {

                DataTable dt = new DataTable();
                cmd.CommandText = requete;
                cnx.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                cnx.Close();
                return dt;
            }
            catch
            {
                throw;
            }
            finally
            {
                cnx.Close();
            }
        }



        public static object ScalarExecute(string requete)
        {

            cmd.CommandText = requete;
            cnx.Open();
            var resultat = cmd.ExecuteScalar();
            cnx.Close();
            return resultat;

        }

        public static void update_execute(string requete)
        {
            try
            {
                cmd.CommandText = requete;
                cnx.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                cnx.Close();
            }
        }


        public static int ps_insert_cmd(int num, DateTime datec, int client)
        {
            cnx.Open(); cmd.CommandText = "dbo.ps_add_cmd";
            cmd.CommandType = CommandType.StoredProcedure;
            //nom de psc
            cmd.Parameters.Clear();
            // ajouter les parametres
            cmd.Parameters.Add(new SqlParameter("@numf", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@datef", SqlDbType.DateTime));
            cmd.Parameters.Add(new SqlParameter("@client", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@resultat", SqlDbType.Int));
            cmd.Parameters[0].Value = num; //@numf=num
            cmd.Parameters[1].Value = datec;//@datef=datec
            cmd.Parameters[2].Value = client;//@client=client
            cmd.Parameters[3].Direction = ParameterDirection.ReturnValue;

            cmd.ExecuteNonQuery();
            int retour = (int)cmd.Parameters["@resultat"].Value;
            cnx.Close();
            cmd.CommandType = CommandType.Text;
            return retour;




        }
    }
}
