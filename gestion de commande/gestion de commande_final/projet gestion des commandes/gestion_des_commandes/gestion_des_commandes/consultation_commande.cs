using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace gestion_des_commandes
{
    class consultation_commande
    {
        int numero, client;
        DateTime date;



        //les propriétés
        public int Numero { get => numero; set => numero = value; }
        public int Client { get => client; set => client = value; }
        public DateTime Date { get => date; set => date = value; }



        //les constructeurs



        public consultation_commande()
        {
        }



        public consultation_commande(int numero, int client, DateTime date)
        {
            this.numero = numero;
            this.client = client;
            this.date = date;
        }



        public consultation_commande(int numero)
        {
            this.numero = numero;
        }



        public static DataTable CommandesClient(int numClient)
        {
            DataTable dt = new DataTable();
            string req = string.Format(@"select numfac, date_facture from  facture where client={0}", numClient);
            dt = Program.select_execute(req);
            return dt;
        }




        public void supprimerCommnade()
        {
            string req = string.Format(@"delete from facture where numfac={0}", this.numero);
            Program.update_execute(req);



        }



        public Decimal Total()
        {
            string req = string.Format(@"select sum((prixht*quantite)*1.2) from produit p join contenu cn on cn.produit=p.nump where cn.facture={0}", this.numero);
            return Convert.ToDecimal(Program.ScalarExecute(req));
            
        }




        public Decimal TTC()
        {
            string req = string.Format(@"select sum(prixht*quantite) from produit p join contenu cn on p.nump=cn.produit where cn.facture={0}", this.numero);
            return Convert.ToDecimal(Program.ScalarExecute(req));
            
        }



        public Decimal TVA()
        {
            string req= string.Format(@"select sum((prixht*quantite)*0.2)from produit p join contenu cn on p.nump=cn.produit where cn.produit={0}", this.numero);
            return Convert.ToDecimal(Program.ScalarExecute(req));
        }



        public DataTable Detail_commande()
        {
            string req = string.Format(@"select * from contenu where facture={0}", this.numero);
            return Program.select_execute(req); 
        }
    }
}
