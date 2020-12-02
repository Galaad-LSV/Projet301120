using projet301120.Models;
using projet301120.Utilistaires;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet301120.Views
{
    public partial class ClientCreerViews : Form
    {
        public ClientCreerViews()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ajouter un nouveau client
        /// Ajout automatique de l'id et recupère le texte dans texteBox Nom
        /// </summary>

 
        private void btnAjout_Click(object sender, EventArgs e)
        {       
            try
            {
                if(txtNom.Text == "")
                {
                    MessageBox.Show("Il faut écrire un nom");
                }
                else
                {
                    new Client(GestionId.GetNouvelIndexBox(), txtNom.Text);
                    MessageBox.Show("Le client a été créé");
                    this.Close();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
                
            }
            catch
            {
                MessageBox.Show("Erreur");
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Form1 from1 = new Form1();
            from1.Show();
            this.Hide();
        }

        private void ClientCreerViews_Load(object sender, EventArgs e)
        {

        }
    }
}
