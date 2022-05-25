using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace gestion_des_commandes
{
    class Client
    {
        private int num;
        private string nom;

        private string ville;

        public int Num { get => num; set => num = value; }
        public string Nom { get => nom; set => nom = value; }

        public string Ville { get => ville; set => ville = value; }


        public Client()
        {

        }

        public Client(int num, string nom, string ville)
        {
            this.num = num;
            this.nom = nom;

            this.ville = ville;

        }
        public Client(int num)
        {
            this.num = num;
        }

        public static DataTable listeClient()
        {
            return Program.select_execute(string.Format("select * from client"));


        }
        public static DataTable CommandesClient(int numclient)
        {
            return Program.select_execute(string.Format("select numfac ,date_facture from facture where client ={0}", numclient));


        }
        public decimal CA_client()
        {
            return Convert.ToDecimal(Program.ScalarExecute(string.Format("select sum(prixht*quantite) from produit p join contenu cn on cn.produit=p.nump join facture f on cn.facture=f.numfac where f.client={0}", this.num)));


        }
        public static Client RechercherClient(int num)
        {
            Client c = null;
            DataTable dt = Program.select_execute(string.Format("select * from client where numc={0}", num));
            if (dt.Rows.Count != 0)
            {
                c = new Client((int)dt.Rows[0][0], dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
            }
            return c;

        }

    }
}
