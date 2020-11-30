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


            DataTable dt = new DataTable();
            dt.Columns.Add("Pizza", typeof(string));            
            DGVAcheter.Refresh();
            
            

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
    }
}
