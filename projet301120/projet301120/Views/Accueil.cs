using projet301120.Models;
using projet301120.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet301120
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Hide();
            btnCreer.Hide();
            btnModifier.Hide();
            btnSupprimer.Hide();
            DGVAcheter.Hide();

            cboId.Refresh();

            foreach (Client unClient in Client.collClasseClient)
            {
                cboId.Items.Add(unClient.Id);
            }
            
        }

        private void cboId_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Client unClient in Client.collClasseClient)
            {
                if (unClient.Id == cboId.SelectedIndex + 1)
                {
                    txtNom.Text = unClient.GetNom();                   
                }
            }

            this.DGVCommande(this.GetClient(txtNom.Text));

            label4.Show();
            btnSupprimer.Show();
            btnModifier.Show();
            btnCreer.Show();
            DGVAcheter.Show();
        }
        public Client GetClient(string param)
        {
            Client lescommandes = null;

            foreach (Client unClient in Client.collClasseClient)
            {
                if (unClient.Nom == param)
                {
                    lescommandes = unClient;                   
                }
            }
            return lescommandes;
        }

        private void DGVCommande(Client param)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Date", typeof(string));


            foreach (Commande uneCommande in param.LesCommandes)
            {
                dt.Rows.Add(uneCommande.Id, uneCommande.Date);
            }

            DGVAcheter.DataSource = dt;
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            CommandeView from1 = new CommandeView();
            from1.Show();
            this.Hide();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            ClientCreerViews from1 = new ClientCreerViews();
            from1.Show();
            this.Hide();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            foreach (Client unClient in Client.collClasseClient)
            {
                if (unClient.Id.ToString() == cboId.Text)
                {
                       unClient.Nom = txtNom.Text;
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(Client.ClientAvecId(int.Parse(cboId.Text)).LesCommandes.Count()==0)
            {
                Client.SupprimerClient(int.Parse(cboId.Text));

                cboId.Items.Clear();
                cboId.Text = "";
                txtNom.Clear();
                txtNom.Text = "";
                cboId.Refresh();
                txtNom.Refresh();

                if (cboId.Text == "") txtNom.ResetText();
                foreach (Client client in Client.collClasseClient) cboId.Items.Add(client.Id);


            }
            
          
                  
        }
    }
}
